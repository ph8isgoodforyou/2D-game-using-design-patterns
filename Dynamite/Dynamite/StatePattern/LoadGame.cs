using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamite.StatePattern
{
    class LoadGame : State
    {
        public override void Handle(Game game, string fileName)
        {
            SaveGameData save;

            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            System.IO.FileStream filestream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try
            {
                save = (SaveGameData)formatter.Deserialize(filestream);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured : " + ex.Message);
                return;
            }
            game.BombsOnTheMap = save.bombsOnTheMap;
            game.world.MapGrid = save.MapGrid;
            game.player1 = save.player1;
            game.player2 = save.player2;

            game.Paused = true;
            game.LogicTimer.Stop();

            if (game.Over)
            {
                game.Over = false;
                game.Winner = 0;
            }
        }
    }
}
