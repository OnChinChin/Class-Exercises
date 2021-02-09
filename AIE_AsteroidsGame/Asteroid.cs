using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace AIE_AsteroidsGame
{
    class Asteroid
    {
        Program program;
        public Vector2 pos;
        public Vector2 dir;
        public float radius;

        public Asteroid(Program program, Vector2 pos, Vector2 dir)
        {
            this.program = program;
            this.pos = pos;
            this.dir = dir;
        }

        public void Update()
        {
            pos += dir;
        }
        public void Draw()
        {
            Raylib.DrawCircle((int)pos.X, (int)pos.Y, radius, Color.PINK);
        }

    }
}
