using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace AIE_AsteroidsGame
{
    class Bullet
    {
        Program program;

        public Vector2 pos = new Vector2();
        public Vector2 dir = new Vector2();
        public float speed = 10;

        public Bullet(Program program, Vector2 pos, Vector2 dir)
        {
            this.program = program;
            this.pos = pos;
            this.dir = dir;
        }

        public void Update()
        {
            pos += dir * speed;

            //wrap bullets around screan 
            if (pos.X < 0) pos.X = program.WindowWidth;
            if (pos.X > program.WindowWidth) pos.X = 0;
            if (pos.Y < 0) pos.Y = program.WindowHeight;
            if (pos.Y > program.WindowHeight) pos.Y = 0;
        }
        public void Draw()
        {
            Raylib.DrawLine((int)pos.X, (int)pos.Y, (int)(pos.X - dir.X * speed), (int)(pos.Y - dir.Y * speed), Color.WHITE);
             
        }

    }
}
