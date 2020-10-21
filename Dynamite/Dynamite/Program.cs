using Dynamite.DynamiteEngine.Map.Builder;
using Dynamite.DynamiteEngine.Map.ConcreteBuilder;
using Dynamite.DynamiteEngine.Map.Director;
using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using Dynamite.DynamiteEngine.Tiles.ConcreteFactory;
using Dynamite.DynamiteEngine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoGame game = new DemoGame();

            //Generating map and adding blocks
            //----------------------------------------------------------
            //Console.WriteLine("Choose game mode: \n 1. Ice Map \n 2. Lava Map \n Enter number according to the chosen map:");
            //int GameMode = Convert.ToInt32(Console.ReadLine());

            //Block_AbstractFactory blockFactory;
            //MapDirector mapDirector = new MapDirector();
            //MapBuilder mapBuilder;
            //MapProduct map;
            //if (GameMode == 1)
            //{
            //    blockFactory = new IceMapFactory();
            //    mapBuilder = new IceMapBuilder();
            //    mapDirector.Construct(mapBuilder, blockFactory);
            //    map = mapBuilder.GetMap();

            //    map.PrintMap();
            //}
            //else if(GameMode == 2)
            //{
            //    blockFactory = new LavaMapFactory();
            //    mapBuilder = new LavaMapBuilder();
            //    mapDirector.Construct(mapBuilder, blockFactory);
            //    map = mapBuilder.GetMap();

            //    map.PrintMap();
            //}

            //---------------------------------------------------------


            Console.ReadKey();
        }
    }
}
