using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Players.Product;
using Dynamite.DynamiteEngine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Players.ConcreteProduct
{
    class RobotCharacter : Player
    {
        private string PlayerName = "Anonymous Player";
        private Vector2 Position = null;
        private Sprite2D CharacterImg;
        private int Health = 2000;
        MapProduct map;

        public RobotCharacter(MapProduct _map, int positionX, int positionY)
        {
            this.map = _map;
            this.Position = new Vector2(positionX, positionY);
            CharacterImg = new Sprite2D(new Vector2(positionX, positionY), new Vector2(48, 64),
                PlayerName, "/Characters/Robot/PNG/Poses/character_robot_walk1");
        }

        public RobotCharacter(string playerName, MapProduct _map, int positionX, int positionY)
        {
            this.PlayerName = playerName;
            this.map = _map;
            this.Position = new Vector2(positionX, positionY);
            CharacterImg = new Sprite2D(new Vector2(positionX, positionY), new Vector2(48, 64),
                playerName, "/Characters/Robot/PNG/Poses/character_robot_walk1");
        }

        public override Vector2 DropBomb(Weapon_AbstractFactory factory, string weaponType, string weaponName, int i, int j)
        {
            Weapon Bomb = new Weapon(factory, weaponType, weaponName, i, j);

            Bomb.DetonateWeapon("Bomb");
            return Position;
        }
        public override Vector2 PlantMine(Weapon_AbstractFactory factory, string weaponType, string weaponName, int i, int j)
        {
            Weapon Mine = new Weapon(factory, weaponType, weaponName, i, j);

            Mine.DetonateWeapon("Mine");
            return Position;
        }

        public override Vector2 GetPlayersPosition()
        {
            return Position;
        }

        public override Vector2 IncreasePlayersPositionX(float push)
        {
            Position.x += push;
            return Position;
        }
        public override Vector2 DecreasePlayersPositionX(float push)
        {
            Position.x -= push;
            return Position;
        }
        public override Vector2 IncreasePlayersPositionY(float push)
        {
            Position.y += push;
            return Position;
        }
        public override Vector2 DecreasePlayersPositionY(float push)
        {
            Position.y -= push;
            return Position;
        }

        public override void SetPlayersPosition(int positionX, int positionY)
        {
            Position = new Vector2(positionX, positionY);
        }

        public override int Damage(int damageTaken)
        {
            Health -= damageTaken;
            return Health;
        }

        public override void Die(Sprite2D CharacterImg)
        {
            CharacterImg.DestroySelf();
            Console.WriteLine(this.PlayerName + " Died ");
        }

        public override void Win(Sprite2D CharacterImg)
        {
            Console.WriteLine(this.PlayerName + "Won The Game");
        }
    }
}
