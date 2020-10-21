using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class floating_mine : Mine
    {
        private Sprite2D floating_mine_Img;
        private int Damage = 400;
        public floating_mine(int i, int j)
        {
            floating_mine_Img = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Floating Mine", "/Weapons/png/floating_mine");
        }
        public override void Explode()
        {
            Console.WriteLine(this.GetType().Name + " Explodes ");
            Console.WriteLine("Damage: {0}", Damage);
        }
    }
}
