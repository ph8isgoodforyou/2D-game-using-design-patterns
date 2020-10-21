using Dynamite.DynamiteEngine.Map.Builder;
using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using Dynamite.DynamiteEngine.Tiles.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Map.ConcreteBuilder
{
    class LavaMapBuilder : MapBuilder
    {
        public LavaMapBuilder()
        {
            map = new MapProduct("Lava Map");
        }
        public override string[,] GenerateNewMap()
        {
            Random rnd = new Random();
            string[,] Map = new string[12, 10];

            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    //Making sure all 4 corners have 3 empty blocks
                    if (i == 0 && j == 0 || i == 0 && j == 1 || i == 1 && j == 0 ||
                        i == 0 && j == 9 || i == 1 && j == 9 || i == 0 && j == 8 ||
                        i == 10 && j == 0 || i == 11 && j == 0 || i == 11 && j == 1 ||
                        i == 10 && j == 9 || i == 11 && j == 9 || i == 11 && j == 8)
                    {
                        Map[i, j] = "E";
                    }
                    else if ((rnd.Next(1, 100)) % 2 != 0)
                    {
                        if (i > 0 && Map[i - 1, j] != "U")
                        {
                            if (j == 0)
                            {
                                Map[i, j] = "U";
                            }
                            if (j > 1 && Map[i, j - 1] != "U" && Map[i, j - 2] != "U")
                            {
                                Map[i, j] = "U";
                            }
                        }
                    }
                    else
                    {
                        Map[i, j] = "D";
                    }
                    //Console.WriteLine(Map[i,j]);
                }
            }
            //PrintMap(Map);
            return Map;
        }
        public void PrintMap(string[,] Map)
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", Map[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
        //public override void BuildEmptyPath(string[,] Map, Block_AbstractFactory factory)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int j = 0; j < 12; j++)
        //        {
        //            if (Map[i,j] == "E")
        //            {
        //                map[i, j] = new Blocks(factory, "EmptyBlock", i, j);
        //            }
        //        }
        //    }
        //}
        public override void BuildUndestroyableBlocks(string[,] Map, Block_AbstractFactory factory)
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (Map[i, j] == "U")
                    {
                        map[i, j] = new Blocks(factory, "UndestroyableBlock", i, j);
                    }
                }
            }
        }
        public override void BuildDestroyableBlocks(string[,] Map, Block_AbstractFactory factory)
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (Map[i, j] == "D")
                    {
                        map[i, j] = new Blocks(factory, "DestroyableBlock", i, j);
                    }

                }
            }
        }
        public override MapProduct GetMap()
        {
            return map;
        }
    }
}
