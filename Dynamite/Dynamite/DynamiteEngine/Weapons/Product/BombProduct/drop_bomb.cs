using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class drop_bomb : Bomb
    {
        private Sprite2D drop_bomb_Img;
        private int Damage = 1000;

        public drop_bomb(int i, int j)
        {
            drop_bomb_Img = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Drop Bomb", "/Weapons/png/drop_bomb");
        }
        public override void Explode()
        {
            drop_bomb_Img.DestroySelf();
            Console.WriteLine(this.GetType().Name + " Explodes ");
            Console.WriteLine("Damage: {0}", Damage);
        }
    }
}
