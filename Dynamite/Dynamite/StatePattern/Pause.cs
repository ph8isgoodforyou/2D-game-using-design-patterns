using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.StatePattern
{
    class Pause : State
    {
        public override void Handle(Game game, string fileName)
        {
            //If the game is already over, no need for pause
            if (!game.Over)
            {
                if (game.Paused)
                {
                    game.LogicTimer.Start();
                    game.Paused = false;
                }
                else
                {
                    game.LogicTimer.Stop();
                    game.Paused = true;
                }
            }
        }
    }
}
