using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class land_mine : Mine
    {
        private Sprite2D land_mine_Img;
        private int Damage = 1000;
        public land_mine(int i, int j)
        {
            land_mine_Img = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Land Mine", "/Weapons/png/land_mine");
        }
        public override void Explode()
        {
            Console.WriteLine(this.GetType().Name + " Explodes ");
            Console.WriteLine("Damage: {0}", Damage);
        }
    }
}
