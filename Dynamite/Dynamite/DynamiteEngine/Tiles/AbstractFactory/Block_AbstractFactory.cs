using Dynamite.DynamiteEngine.Tiles.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.AbstractFactory
{
    abstract class Block_AbstractFactory
    {
        //public abstract EmptyBlock CreateEmptyBlock(int i, int j);
        public abstract DestroyableBlock CreateDestroyableBlock(int i, int j);
        public abstract UndestroyableBlock CreateUndestroyableBlock(int i, int j);
    }
}
