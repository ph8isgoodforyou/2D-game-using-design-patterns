using Dynamite.DynamiteEngine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Players.Product
{
    abstract class Player
    {
        public abstract Vector2 DropBombAsync(Weapon_AbstractFactory factory, string weaponType, string weaponName, int i, int j);
        public abstract Vector2 PlantMine(Weapon_AbstractFactory factory, string weaponType, string weaponName, int i, int j);
        public abstract Vector2 GetPlayersPosition();
        public abstract Vector2 IncreasePlayersPositionX(float push);
        public abstract Vector2 DecreasePlayersPositionX(float push);
        public abstract Vector2 IncreasePlayersPositionY(float push);
        public abstract Vector2 DecreasePlayersPositionY(float push);
        public abstract void SetPlayersPosition(int PositionX, int PositionY);
        public abstract int Damage(int damageTaken);
        public abstract void Die(Sprite2D CharacterImg);
        public abstract void Win(Sprite2D CharacterImg);
    }
}
