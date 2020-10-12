using Dynamite.DynamiteEngine.Blocks.AbstractFactory;
using Dynamite.DynamiteEngine.Blocks.AbstractProduct;
using Dynamite.DynamiteEngine.Blocks.Product.destroyableBlockProduct;
using Dynamite.DynamiteEngine.Blocks.Product.undestroyableBlockProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Blocks.Factory
{
    class Map_Factory : Block_AbstractFactory
    {
        public override DestroyableBlock CreateDestroyableBlock()
        {
            return new IceBlock();
        }
        public override UndestroyableBlock CreateUndestroyableBlock()
        {
            return new TitaniumBlock();
        }
    }
}
