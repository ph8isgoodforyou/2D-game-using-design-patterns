using Dynamite.DynamiteEngine.Blocks.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Blocks.Product.destroyableBlockProduct
{
    class IceBlock : DestroyableBlock
    {
        public override void Destroy()
        {
            Console.WriteLine(this.GetType().Name + " Destroyed ");
        }
    }
}
