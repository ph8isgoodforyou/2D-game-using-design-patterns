using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class Weapons
    {
        private Bomb _bomb;
        private Mine _mine;

        // Constructor

        public Weapons(Weapon_AbstractFactory factory, int BombIndex, int MineIndex)
        {
            _bomb = factory.CreateBomb(BombIndex);
            _mine = factory.CreateMine(MineIndex);
        }

        public void DetonateBomb()
        {
            _bomb.Explode();
        }
        public void DetonateMine()
        {
            _mine.Explode();
        }
    }
}
