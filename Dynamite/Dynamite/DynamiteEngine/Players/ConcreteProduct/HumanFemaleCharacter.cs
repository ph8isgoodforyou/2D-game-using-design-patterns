using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Players.Product;
using Dynamite.DynamiteEngine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Players.ConcreteProduct
{
    class HumanFemaleCharacter : Player
    {
        private string PlayerName = "Anonymous Player";
        private Vector2 Position = null;
        private Sprite2D CharacterImg;
        private int Health = 2000;
        MapProduct map;

        public HumanFemaleCharacter(MapProduct _map, int positionX, int positionY)
        {
            this.map = _map;
            this.Position = new Vector2(positionX, positionY);
            CharacterImg = new Sprite2D(new Vector2(positionX, positionY), new Vector2(48, 64),
                PlayerName, "/Characters/Female person/PNG/Poses/character_femalePerson_walk1");
        }

        public HumanFemaleCharacter(string playerName, MapProduct _map, int positionX, int positionY)
        {
            this.PlayerName = playerName;
            this.map = _map;
            this.Position = new Vector2(positionX, positionY);
            CharacterImg = new Sprite2D(new Vector2(positionX, positionY), new Vector2(48, 64), 
                playerName, "/Characters/Female person/PNG/Poses/character_femalePerson_walk1");
        }

        public override Vector2 DropBombAsync(Weapon_AbstractFactory factory, string weaponType, string weaponName, int i, int j)
        {
            Weapon Bomb = new Weapon(factory, weaponType, weaponName, i, j);
            //TimeSpan interval1 = new TimeSpan(0, 0, 10);
            //TimeSpan interval2 = new TimeSpan(0, 0, 5);

            //Thread t = new Thread(delegate ()
            //{
            //    Bomb.DetonateWeapon("Bomb");
            //});
            //Thread.Sleep(interval1);
            //t.Start();
            //Thread.Sleep(interval2);
            //t.Abort();
            Bomb.DetonateWeapon("Bomb");
            return Position;
        }
        public override Vector2 PlantMine(Weapon_AbstractFactory factory, string weaponType, string weaponName, int i, int j)
        {
            Weapon Mine = new Weapon(factory, weaponType, weaponName, i, j);
            //TimeSpan interval1 = new TimeSpan(0, 0, 10);
            //TimeSpan interval2 = new TimeSpan(0, 0, 5);
            //Thread t = new Thread(delegate ()
            //{
            //    Mine.DetonateWeapon("Mine");
            //});
            //Thread.Sleep(interval1);
            //t.Start();
            //Thread.Sleep(interval2);
            //t.Abort();
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
