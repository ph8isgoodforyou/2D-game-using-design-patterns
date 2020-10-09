using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite
{
    [Serializable]
    public struct SaveGameData
    {
        public List<Weapon> bombsOnTheMap;
        public Tile[,] MapGrid;
        public Player player1, player2;


        public SaveGameData(List<Weapon> bombsOnTheMap_, Tile[,] MapGrid_, Player player1_, Player player2_)
        {
            this.bombsOnTheMap = bombsOnTheMap_;
            this.MapGrid = MapGrid_;
            this.player1 = player1_;
            this.player2 = player2_;
        }


    }
}
