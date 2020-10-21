using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class Player_Weapon_Factory : Weapon_AbstractFactory
    {
        public override Bomb CreateBomb(string weaponName, int i, int j)
        {
            if (weaponName == "drop_bomb")
            {
                return new drop_bomb(i, j);
            }
            else if (weaponName == "hand_bomb")
            {
                return new hand_bomb(i, j);
            }
            else if (weaponName == "pipe_bomb")
            {
                return new pipe_bomb(i, j);
            }
            return new drop_bomb(i, j);
        }
        public override Mine CreateMine(string weaponName, int i, int j)
        {
            if(weaponName == "land_mine")
            {
                return new land_mine(i, j);
            }
            else if (weaponName == "floating_mine")
            {
                return new floating_mine(i, j);
            }
            return new land_mine(i, j);
        }
    }
}
