using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamite.Facade
{
    public class FacadeClass
    {
        Player player1;
        Player player2;
        Graphics gr;
        World world;
        PictureBox pbGame;
        Game game;
        public FacadeClass(Player p1, Player p2, Graphics gr, World world, PictureBox pbGame)
        {
            player1 = p1;
            player2 = p2;
            this.world = world;
            this.pbGame = pbGame;
        }
        public FacadeClass(Player p1, Player p2, Game game, World world)
        {
            player1 = p1;
            player2 = p2;
            this.game = game;
            this.world = world;
        }

        public void DrawStuff()
        {
            player1.DrawSelf();
            player2.DrawSelf();

            gr.Clear(pbGame.BackColor);

            world.Draw(gr);

            player1.Draw(gr);
            player1.DrawPosition(gr);

            player2.Draw(gr);
            player2.DrawPosition(gr);
        }

        internal void PlayerLogic()
        {
            player1.LocationCheck(48, 48);
            player2.LocationCheck(48, 48);

            game.BonusLogic(player1);
            game.BonusLogic(player2);

            if (player1.Orientation != Player.MovementDirection.NONE)
            {
                if (game.CheckCollisionPlayer(player1, player2, world.MapGrid, player1.Orientation))
                {
                    player1.Move();

                }
                player1.UpdateFrame((int)game.LogicTimer.Interval);
            }
            else
                player1.frameindex = 1;

            if (player2.Orientation != Player.MovementDirection.NONE)
            {
                if (game.CheckCollisionPlayer(player2, player1, world.MapGrid, player2.Orientation))
                {
                    player2.Move();
                }
                player2.UpdateFrame((int)game.LogicTimer.Interval);
            }
            else
                player2.frameindex = 1;
        }
    }
}
