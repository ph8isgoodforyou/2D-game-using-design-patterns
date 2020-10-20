using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using Dynamite.DynamiteEngine.Tiles.Client;

namespace Dynamite.DynamiteEngine.Map.Product
{
    /// <summary>

    /// The 'Product' class

    /// </summary>
    class MapProduct
    {
        private string MapType;
        private Blocks[,] blocks = new Blocks[10,12];

        // Constructor

        public MapProduct(string mapType)
        {
            this.MapType = mapType;
        }
        public Blocks this[int i, int j]
        {
            get { return blocks[i, j]; }
            set { blocks[i, j] = value; }
        }

        public void PrintMap()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(string.Format("{0} ", blocks[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
