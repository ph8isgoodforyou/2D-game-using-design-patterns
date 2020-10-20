using Dynamite.DynamiteEngine.Tiles.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.Product.undestroyableBlockProduct
{
    class TitaniumBlock : UndestroyableBlock
    {
        private Sprite2D TitaniumImg;
        public TitaniumBlock(int i, int j)
        {
            TitaniumImg = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Titanium", "/Blocks/PNG/Tiles/platformPack_tile041");
        }
    }
}
