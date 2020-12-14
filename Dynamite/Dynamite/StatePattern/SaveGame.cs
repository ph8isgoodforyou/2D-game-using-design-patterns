using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamite.StatePattern
{
    class SaveGame : State
    {
        public override void Handle(Game game, string fileName)
        {
            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            System.IO.FileStream filestream = new System.IO.FileStream(fileName, System.IO.FileMode.Create);
            try
            {
                formatter.Serialize(filestream, new SaveGameData(game.BombsOnTheMap, game.world.MapGrid, game.player1, game.player2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured : " + ex.Message);
                return;
            }
            MessageBox.Show("File " + fileName + " saved successfuly !");
        }
    }
}
