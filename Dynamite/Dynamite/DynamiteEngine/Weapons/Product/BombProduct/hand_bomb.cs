using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class hand_bomb : Bomb
    {
        private Sprite2D hand_bomb_Img;
        private int Damage = 200;
        public hand_bomb(int i, int j)
        {
            hand_bomb_Img = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Hand Bomb", "/Weapons/png/hand_bomb");
        }
        public override void Explode()
        {
            Console.WriteLine(this.GetType().Name + " Explodes ");
            Console.WriteLine("Damage: {0}", Damage);
        }
    }
}
