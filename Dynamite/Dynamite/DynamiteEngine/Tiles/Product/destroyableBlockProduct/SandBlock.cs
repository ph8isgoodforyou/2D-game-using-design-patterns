using Dynamite.DynamiteEngine.Tiles.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.Product.destroyableBlockProduct
{
    class SandBlock : DestroyableBlock
    {
        private Sprite2D SandImg;
        public SandBlock(int i, int j)
        {
            SandImg = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Sand", "/Blocks/PNG/Tiles/platformPack_tile008");
        }
        public override void Destroy(Sprite2D SandImg)
        {
            SandImg.DestroySelf();
            Console.WriteLine(this.GetType().Name + " Destroyed ");
        }
    }
}
