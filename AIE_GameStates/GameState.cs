using System;
using System.Collections.Generic;
using System.Text;


namespace AIE_GameStates
{
    class GameState
    {
        protected Program program;

        public GameState(Program program)
        {
            this.program = program;
        }
        public virtual void Update()
        {

        }

        public virtual void Draw()
        {

        }
        
    }
}
