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
            int UndestroyableBlockCount = 0;
            Random rnd = new Random();
            string[,] Map = new string[10, 12];

            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    //Making sure all 4 corners have 3 empty blocks
                    if (i == 0 && j == 0 || i == 0 && j == 1 || i == 1 && j == 0 ||
                        i == 9 && j == 0 || i == 9 && j == 1 || i == 8 && j == 0 ||
                        i == 0 && j == 10 || i == 0 && j == 11 || i == 1 && j == 11 ||
                        i == 9 && j == 10 || i == 9 && j == 11 || i == 8 && j == 11)
                    {
                        Map[i, j] = "E";
                    }
                    else if (UndestroyableBlockCount < 15 && (rnd.Next(1, 100)) % 3 == 0)
                    {
                        UndestroyableBlockCount += 1;
                        Map[i, j] = "U";
                    }
                    else if ((rnd.Next(1, 100)) % 2 == 0)
                    {
                        Map[i, j] = "D";
                    }
                    else if ((rnd.Next(1, 100)) % 2 != 0)
                    {
                        Map[i, j] = "E";
                    }
                }
            }
            PrintMap(Map);
            return Map;
        }
        public void PrintMap(string[,] Map)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
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
