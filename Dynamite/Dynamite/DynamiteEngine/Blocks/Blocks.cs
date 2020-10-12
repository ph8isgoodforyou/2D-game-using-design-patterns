using Dynamite.DynamiteEngine.Blocks.AbstractFactory;
using Dynamite.DynamiteEngine.Blocks.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Blocks
{
    class Blocks
    {
        private DestroyableBlock _D_Block;
        private UndestroyableBlock _U_Block;

        // Constructor

        public Blocks(Block_AbstractFactory factory)
        {
            _D_Block = factory.CreateDestroyableBlock();
            _U_Block = factory.CreateUndestroyableBlock();
        }

        public void DestroyBlock()
        {
            _D_Block.Destroy();
        }
    }
}
