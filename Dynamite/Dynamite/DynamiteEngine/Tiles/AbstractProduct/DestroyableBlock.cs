using Dynamite.DynamiteEngine.Tiles.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Tiles.AbstractProduct
{
    abstract class DestroyableBlock
    {
        public abstract void Destroy(Sprite2D block);
    }
}
