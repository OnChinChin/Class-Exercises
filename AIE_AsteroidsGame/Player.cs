using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace AIE_AsteroidsGame
{
    class Player
    {

        Program program;

        public Vector2 pos = new Vector2();
        public Vector2 size = new Vector2(64, 64);

        public float rotation = 0.0f;
        public float rotationSpeed = 5.0f;

        public float accelerationSpeed = 0.1f;
        public Vector2 Velocity = new Vector2();

        public Player(Program program, Vector2 pos, Vector2 size)
        {
            this.program = program;
            this.pos = pos;
            this.size = size;
        }

        public void Update()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                rotation -= rotationSpeed;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                rotation += rotationSpeed;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                var dir = GetFacingDirection();
                Velocity += dir * accelerationSpeed;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                var dir = GetFacingDirection();
                Velocity -= dir * accelerationSpeed;
            }

            //add velocity to position
            pos += Velocity;
            
            //wrap player around screan 
            if (pos.X < 0) pos.X = program.WindowWidth;
            if (pos.X > program.WindowWidth) pos.X = 0;
            if (pos.Y < 0) pos.Y = program.WindowHeight;
            if (pos.Y > program.WindowHeight) pos.Y = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                program.SpawnBullet(pos, GetFacingDirection());
            }

        }

        public Vector2 GetFacingDirection()
        {
            return new Vector2(
                MathF.Cos((MathF.PI / 180) * rotation),
                MathF.Sin((MathF.PI / 180) * rotation)
                );
        }

        public void Draw()
        {
            var texture = Assets.shipTexture;

            Raylib.DrawTexturePro(
                texture,
                new Rectangle(0, 0, texture.width, texture.height),
                new Rectangle(pos.X, pos.Y, size.X, size.Y),
                new Vector2(0.5f * size.X, 0.5f * size.Y),
                rotation,
                Color.WHITE);

        }

    }
}
 