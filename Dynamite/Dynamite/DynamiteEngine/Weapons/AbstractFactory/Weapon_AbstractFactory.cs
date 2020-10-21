using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    abstract class Weapon_AbstractFactory
    {
        public abstract Bomb CreateBomb(string weaponName, int i, int j);
        public abstract Mine CreateMine(string weaponName, int i, int j);
    }
}
