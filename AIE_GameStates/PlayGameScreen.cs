using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
namespace AIE_GameStates
{
    class PlayGameScreen : GameState
    {

        int buttonPressedCount = 0;

        public PlayGameScreen(Program program) : base(program)
        {

        }
        public override void Update()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                buttonPressedCount += 1;
            }
        }

        public override void Draw()
        {
            Raylib.DrawText("Play Game Screen", 10, 10, 20, Color.PINK);
            Raylib.DrawText($"Press Count: { buttonPressedCount}", 10, 30, 20, Color.PINK);
        }
    }
}
