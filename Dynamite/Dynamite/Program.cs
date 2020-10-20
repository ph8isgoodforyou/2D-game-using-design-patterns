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
            //DemoGame game = new DemoGame();

            Block_AbstractFactory blockFactory = new IceMapFactory();

            MapDirector mapDirector = new MapDirector();
            MapBuilder mapBuilder = new IceMapBuilder();
            mapDirector.Construct(mapBuilder, blockFactory);
            MapProduct map = mapBuilder.GetMap();


            Console.ReadKey();
        }
    }
}
