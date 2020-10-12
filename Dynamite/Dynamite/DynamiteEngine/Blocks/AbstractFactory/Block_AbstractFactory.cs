using Dynamite.DynamiteEngine.Blocks.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Blocks.AbstractFactory
{
    abstract class Block_AbstractFactory
    {
        public abstract DestroyableBlock CreateDestroyableBlock();
        public abstract UndestroyableBlock CreateUndestroyableBlock();
    }
}
