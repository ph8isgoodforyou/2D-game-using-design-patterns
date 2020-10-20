using Dynamite.DynamiteEngine.Tiles.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.Product.undestroyableBlockProduct
{
    class LavaBlock : UndestroyableBlock
    {
        private Sprite2D LavaImg;
        public LavaBlock(int i, int j)
        {
            LavaImg = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Lava", "/Blocks/PNG/Tiles/platformPack_tile018");
        }
    }
}
