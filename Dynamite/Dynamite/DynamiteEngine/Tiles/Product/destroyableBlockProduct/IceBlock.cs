using Dynamite.DynamiteEngine.Tiles.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.Product.destroyableBlockProduct
{
    class IceBlock : DestroyableBlock
    {
        private Sprite2D IceImg;

        public IceBlock(int i, int j)
        {
            IceImg = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Ice", "/Blocks/PNG/Tiles/platformPack_tile017");
        }
        public override void Destroy(Sprite2D IceImg)
        {
            IceImg.DestroySelf();
            Console.WriteLine(this.GetType().Name + " Destroyed ");
        }
    }
}
