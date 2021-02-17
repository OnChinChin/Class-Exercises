using System;
using System.Numerics;
using Raylib_cs;

namespace AIE_AsteroidsGame
{
    class Program
    {
        public int WindowWidth = 800;
        public int WindowHeight = 450;
        public string WindowTitle = "Asteroids Game";

        Player player;
        Bullet[] bullets = new Bullet[100];
        Asteroid[] asteroids = new Asteroid[100];

        float asteroidSpawnCoolDown = 4.0f;
        float asteroidSpawnCoolDownReset = 4.0f;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunGame();

        }

        void RunGame()
        {
            Raylib.InitWindow(WindowWidth, WindowHeight, WindowTitle);
            Raylib.SetTargetFPS(60);

            loadGame();

            while(!Raylib.WindowShouldClose())
            {
                Update();
                Draw();
            }
            Raylib.CloseWindow();
        }
      

        void loadGame()
        {
            Assets.LoadAssets();

            player = new Player(
                this,
                new Vector2(WindowWidth/2, WindowHeight/2),
                new Vector2(64, 64)
                );

            //initialise bullets null
            for(int i=0; i<bullets.Length; i++)
            {
                bullets[i] = null;
            }
            
            //initialise asteroids to null
            for(int i=0; i<asteroids.Length; i++)
            {
                asteroids[i] = null;
            }

        }

        void Update()
        {
            asteroidSpawnCoolDown -= Raylib.GetFrameTime();
            if(asteroidSpawnCoolDown < 0.0f)
            {
                SpawnNewAsteroid();
                asteroidSpawnCoolDown = asteroidSpawnCoolDownReset;

            }


            player.Update();

            // update all bullets
            for(int i=0; i<bullets.Length; i++)
            {
                if (bullets[i] != null)
                {
                    bullets[i].Update();
                }
                
            }

            // updates asteroids
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] != null)
                {
                     asteroids[i].Update();
                }
            }

            // cheack all bullets against all asteriods
            foreach(var bullet in bullets)
            {
                foreach(var asteroid in asteroids)
                {
                    DoBulletAsteroidCollision(bullet, asteroid);
                }
            }
        }

        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DARKGRAY);

            player.Draw();

            // darw all bullets
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] != null)
                {
                    bullets[i].Draw();
                }
            }

            // update all bullets
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] != null)
                {
                    asteroids[i].Draw();
                }
            }

            Raylib.EndDrawing();
        }

        public void SpawnBullet(Vector2 pos, Vector2 dir)
        {

            Bullet bullet = new Bullet(this, pos, dir);
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == null)
                {
                    bullets[i] = bullet;
                    break;
                }
            }

        }

        void SpawnNewAsteroid()
        {
            Random rand = new Random();
            int side = rand.Next(0, 4);

            float rot = (float)rand.NextDouble() * MathF.PI * 2.0f;
            Vector2 dir = new Vector2(MathF.Cos(rot), MathF.Sin(rot));

            float radius = 40;

            //left wall spawn
            if (side == 0) SpawnAsteroid(new Vector2(0, rand.Next(0, WindowHeight)), dir, radius);

            //top wall spawn
            if (side == 1) SpawnAsteroid(new Vector2(rand.Next(0, WindowWidth), 0), dir, radius);

            // right wall spawn
            if (side == 2) SpawnAsteroid(new Vector2(WindowWidth, rand.Next(0, WindowHeight)), dir, radius);

            // bottom wall sapwn
            if (side == 3) SpawnAsteroid(new Vector2(rand.Next(0, WindowWidth), WindowHeight), dir, radius);
        }
        public void SpawnAsteroid(Vector2 pos, Vector2 dir, float radius)
        {
            Asteroid asteroid = new Asteroid(this, pos, dir);
            asteroid.radius = radius;
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] == null)
                {
                    asteroids[i] = asteroid;
                    break;
                }
            }
        }

        void DoBulletAsteroidCollision(Bullet bullet, Asteroid asteroid)
        {
            if (bullet == null || asteroid == null)
                return;

            float distance = (bullet.pos - asteroid.pos).Length();
            if (distance < asteroid.radius)
            {
                if(asteroid.radius > 10)
                {
                    SpawnAsteroid(asteroid.pos, asteroid.dir, asteroid.radius / 2);
                    SpawnAsteroid(asteroid.pos, -asteroid.dir, asteroid.radius / 2);
                }
                

                //find the bullet in the array
                for (int i=0; i<bullets.Length; i++)
                {
                    if (bullets[i] == bullet)
                    {
                        bullets[i] = null;
                        break;
                    }
                }
                //find the asteroid in the array
                for (int i = 0; i < asteroids.Length; i++)
                {
                    if (asteroids[i] == asteroid)
                    {
                        asteroids[i] = null;
                        break;
                    }
                }
            }

        }
    }
}
