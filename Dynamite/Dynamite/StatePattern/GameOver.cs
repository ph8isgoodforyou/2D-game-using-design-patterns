using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.StatePattern
{
    class GameOver : State
    {
        public override void Handle(Game game, string fileName)
        {
            if (game.player1.Dead || game.player2.Dead)
            {
                game.Over = true;
                game.Paused = true;
                if (game.player1.Dead && game.player2.Dead)
                    game.Winner = 0;
                else if (game.player2.Dead)
                    game.Winner = 2;
                else if (game.player1.Dead)
                    game.Winner = 1;
            }
        }
    }
}
