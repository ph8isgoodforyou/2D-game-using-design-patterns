using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Map.Builder
{
    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>
    abstract class MapBuilder
    {
        protected MapProduct map;

        // Gets map instance
        public MapProduct MapProduct
        { 
            get { return map; } 
        }

        // Abstract build methods
        public abstract string[,] GenerateNewMap();
        //public abstract void BuildEmptyPath(string[,] Map, Block_AbstractFactory factory);
        public abstract void BuildUndestroyableBlocks(string[,] Map, Block_AbstractFactory factory);
        public abstract void BuildDestroyableBlocks(string[,] Map, Block_AbstractFactory factory);
        public abstract MapProduct GetMap();
    }
}
