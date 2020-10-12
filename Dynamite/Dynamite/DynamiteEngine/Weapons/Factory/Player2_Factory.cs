using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class Player2_Factory : Weapon_AbstractFactory
    {
        public override Bomb CreateBomb(int index)
        {
            if (index == 1)
            {
                return new drop_bomb();
            }
            else if (index == 2)
            {
                return new hand_bomb();
            }
            else if (index == 3)
            {
                return new pipe_bomb();
            }
            return new hand_bomb();
        }
        public override Mine CreateMine(int index)
        {
            if (index == 1)
            {
                return new land_mine();
            }
            else if (index == 2)
            {
                return new floating_mine();
            }
            return new land_mine();
        }
    }
}
