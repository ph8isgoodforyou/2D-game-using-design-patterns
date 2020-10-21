using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class pipe_bomb : Bomb
    {
        private Sprite2D pipe_bomb_Img;
        private int Damage = 600;
        public pipe_bomb(int i, int j)
        {
            pipe_bomb_Img = new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Pipe Bomb", "/Weapons/png/pipe_bomb");
        }
        public override void Explode()
        {
            Console.WriteLine(this.GetType().Name + " Explodes ");
            Console.WriteLine("Damage: {0}", Damage);
        }
    }
}
