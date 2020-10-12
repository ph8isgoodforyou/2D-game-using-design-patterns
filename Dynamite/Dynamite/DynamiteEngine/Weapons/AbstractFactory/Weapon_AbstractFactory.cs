using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Weapons
{
    abstract class Weapon_AbstractFactory
    {
        public abstract Bomb CreateBomb(int index);
        public abstract Mine CreateMine(int index);
    }
}
