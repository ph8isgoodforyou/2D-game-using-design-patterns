using Dynamite.DynamiteEngine.Map.Builder;
using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using Dynamite.DynamiteEngine.Tiles.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Map.Director
{
    /// <summary>

    /// The 'Director' class

    /// </summary>
    class MapDirector
    {
        // Builder uses a complex series of steps

        public void Construct(MapBuilder mapBuilder, Block_AbstractFactory factory)
        {
            string[,] Map = mapBuilder.GenerateNewMap();
            //mapBuilder.BuildEmptyPath(Map, factory);
            mapBuilder.BuildUndestroyableBlocks(Map, factory);
            mapBuilder.BuildDestroyableBlocks(Map, factory);
        }
    }
}
