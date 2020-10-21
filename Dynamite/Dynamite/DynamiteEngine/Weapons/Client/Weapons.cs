using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    class Weapon
    {
        private Bomb _bomb;
        private Mine _mine;

        // Constructor

        public Weapon(Weapon_AbstractFactory factory, string weapontType, string weaponName, int i, int j)
        {
            if (weapontType == "Bomb")
            {
                _bomb = factory.CreateBomb(weaponName, i, j);
            }
            else if (weapontType == "Mine")
            {
                _mine = factory.CreateMine(weaponName, i, j);
            }
        }

        public void DetonateWeapon(string weapontType)
        {
            if (weapontType == "Bomb")
            {
                _bomb.Explode();
            }
            else if (weapontType == "Mine")
            {
                _mine.Explode();
            }
        }
    }
}
