using Dynamite.DynamiteEngine.Blocks;
using Dynamite.DynamiteEngine.Blocks.AbstractFactory;
using Dynamite.DynamiteEngine.Blocks.Factory;
using Dynamite.DynamiteEngine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoGame game = new DemoGame();

            Weapon_AbstractFactory p1 = new Player1_Factory();
            int BombIndex = 3;
            int MineIndex = 2;
            Weapons w1 = new Weapons(p1, BombIndex, MineIndex);
            w1.DetonateBomb();
            w1.DetonateMine();

            Block_AbstractFactory m = new Map_Factory();
            Blocks b = new Blocks(m);
            b.DestroyBlock();



            Console.ReadKey();
        }
    }
}
