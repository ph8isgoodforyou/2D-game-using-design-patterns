using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using Dynamite.DynamiteEngine.Tiles.AbstractProduct;
using Dynamite.DynamiteEngine.Tiles.Product.destroyableBlockProduct;
using Dynamite.DynamiteEngine.Tiles.Product.emptyBlockProduct;
using Dynamite.DynamiteEngine.Tiles.Product.undestroyableBlockProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.ConcreteFactory
{
    class IceMapFactory : Block_AbstractFactory
    {
        //public override EmptyBlock CreateEmptyBlock(int i, int j)
        //{
        //    return new NullBlock(i, j);
        //}
        public override DestroyableBlock CreateDestroyableBlock(int i, int j)
        {
            return new IceBlock(i, j);
        }
        public override UndestroyableBlock CreateUndestroyableBlock(int i, int j)
        {
            return new TitaniumBlock(i, j);
        }
    }
}
