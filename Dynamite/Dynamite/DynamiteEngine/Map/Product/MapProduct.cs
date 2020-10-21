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
        private Blocks[,] blocks = new Blocks[12,10];
        public int rowLength;
        public int colLength;

        // Constructor

        public MapProduct(string mapType)
        {
            this.MapType = mapType;
            this.rowLength = blocks.GetLength(0);
            this.colLength = blocks.GetLength(1);
        }
        public Blocks this[int i, int j]
        {
            get { return blocks[i, j]; }
            set { blocks[i, j] = value; }
        }

        public void PrintMap()
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", blocks[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
