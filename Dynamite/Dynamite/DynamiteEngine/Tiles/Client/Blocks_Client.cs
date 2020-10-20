using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using Dynamite.DynamiteEngine.Tiles.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.Client
{
    class Blocks
    {
        //private EmptyBlock _E_Block;
        private DestroyableBlock _D_Block;
        private UndestroyableBlock _U_Block;

        // Constructor

        public Blocks(Block_AbstractFactory factory, string BlockType, int i, int j)
        {
            //if (BlockType == "EmptyBlock")
            //{
            //    _E_Block = factory.CreateEmptyBlock(i, j);
            //}
            if (BlockType == "DestroyableBlock")
            {
                _D_Block = factory.CreateDestroyableBlock(i, j);
            }
            else if (BlockType == "UndestroyableBlock")
            {
                _U_Block = factory.CreateUndestroyableBlock(i, j);
            }
        }

        public void DestroyBlock(Sprite2D block)
        {
            _D_Block.Destroy(block);
        }
    }
}
