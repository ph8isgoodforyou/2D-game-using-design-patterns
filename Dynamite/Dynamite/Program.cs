using Dynamite.DynamiteEngine;
using Dynamite.DynamiteEngine.Map.Builder;
using Dynamite.DynamiteEngine.Map.ConcreteBuilder;
using Dynamite.DynamiteEngine.Map.Director;
using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Players.ConcreteCreator;
using Dynamite.DynamiteEngine.Players.Creator;
using Dynamite.DynamiteEngine.Players.Product;
using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using Dynamite.DynamiteEngine.Tiles.ConcreteFactory;
using Dynamite.DynamiteEngine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoGame game = new DemoGame();

            //Generating map and adding blocks
            //----------------------------------------------------------
            //Console.WriteLine("Choose game mode: \n 1. Ice Map \n 2. Lava Map \n Enter number according to the chosen map:");
            //int GameMode = Convert.ToInt32(Console.ReadLine());

            //Block_AbstractFactory blockFactory;
            //MapDirector mapDirector = new MapDirector();
            //MapBuilder mapBuilder;
            //MapProduct map;
            //Weapon_AbstractFactory weaponFactory1;
            //Weapon_AbstractFactory weaponFactory2;
            //if (GameMode == 1)
            //{
            //    blockFactory = new IceMapFactory();
            //    mapBuilder = new IceMapBuilder();
            //    mapDirector.Construct(mapBuilder, blockFactory);
            //    map = mapBuilder.GetMap();

            //    //map.PrintMap();

            //    //Creating new player
            //    CharacterCreator[] creators = new CharacterCreator[2];

            //    creators[0] = new HumanFemaleCharacterCreator();
            //    creators[1] = new HumanFemaleCharacterCreator();


            //    Player player1 = creators[0].CreatePlayer("John", map, -4, -10);
            //    Player player2 = creators[1].CreateAnonymousPlayer(map, 610, 480);

            //    weaponFactory1 = new Player_Weapon_Factory();
            //    Vector2 currentPlayer1Position = player1.GetPlayersPosition();
            //    player1.DropBomb(weaponFactory1,"Bomb", "drop_bomb", Convert.ToInt32(currentPlayer1Position.x), Convert.ToInt32(currentPlayer1Position.y));


            //    weaponFactory2 = new Player_Weapon_Factory();
            //    Vector2 currentPlayer2Position = player2.GetPlayersPosition();
            //    player2.PlantMine(weaponFactory2,"Mine", "land_mine", Convert.ToInt32(currentPlayer2Position.x), Convert.ToInt32(currentPlayer2Position.y));
            //}
            //else if (GameMode == 2)
            //{
            //    blockFactory = new LavaMapFactory();
            //    mapBuilder = new LavaMapBuilder();
            //    mapDirector.Construct(mapBuilder, blockFactory);
            //    map = mapBuilder.GetMap();

            //    //map.PrintMap();

            //    //Creating new player
            //    CharacterCreator[] creators = new CharacterCreator[2];

            //    creators[0] = new ZombieCharacterCreator();
            //    creators[1] = new RobotCharacterCreator();

            //    Random rnd = new Random();
            //    int PlacementOfPlayers = rnd.Next(1, 100);

            //    if (PlacementOfPlayers % 7 == 0)
            //    {
            //        // \
            //        Player player1 = creators[0].CreatePlayer("John", map, -4, -10);
            //        Player player2 = creators[1].CreateAnonymousPlayer(map, 610, -10);

            //        weaponFactory1 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer1Position = player1.GetPlayersPosition();
            //        player1.DropBomb(weaponFactory1, "Bomb", "drop_bomb", Convert.ToInt32(currentPlayer1Position.x), Convert.ToInt32(currentPlayer1Position.y));


            //        weaponFactory2 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer2Position = player2.GetPlayersPosition();
            //        player2.PlantMine(weaponFactory2, "Mine", "land_mine", Convert.ToInt32(currentPlayer2Position.x), Convert.ToInt32(currentPlayer2Position.y));
            //    }
            //    else if (PlacementOfPlayers % 9 == 0)
            //    {
            //        // _
            //        Player player1 = creators[0].CreatePlayer("John", map, -4, -10);
            //        Player player2 = creators[1].CreateAnonymousPlayer(map, -4, 480);

            //        weaponFactory1 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer1Position = player1.GetPlayersPosition();
            //        player1.DropBomb(weaponFactory1, "Bomb", "drop_bomb", Convert.ToInt32(currentPlayer1Position.x), Convert.ToInt32(currentPlayer1Position.y));


            //        weaponFactory2 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer2Position = player2.GetPlayersPosition();
            //        player2.PlantMine(weaponFactory2, "Mine", "land_mine", Convert.ToInt32(currentPlayer2Position.x), Convert.ToInt32(currentPlayer2Position.y));
            //    }
            //    else if (PlacementOfPlayers % 2 == 0)
            //    {
            //        // |
            //        Player player1 = creators[0].CreatePlayer("John", map, -4, -480);
            //        Player player2 = creators[1].CreateAnonymousPlayer(map, -610, 480);

            //        weaponFactory1 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer1Position = player1.GetPlayersPosition();
            //        player1.DropBomb(weaponFactory1, "Bomb", "drop_bomb", Convert.ToInt32(currentPlayer1Position.x), Convert.ToInt32(currentPlayer1Position.y));


            //        weaponFactory2 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer2Position = player2.GetPlayersPosition();
            //        player2.PlantMine(weaponFactory2, "Mine", "land_mine", Convert.ToInt32(currentPlayer2Position.x), Convert.ToInt32(currentPlayer2Position.y));
            //    }
            //    else
            //    {
            //        // --
            //        Player player1 = creators[0].CreatePlayer("John", map, -4, -10);
            //        Player player2 = creators[1].CreateAnonymousPlayer(map, 610, 480);

            //        weaponFactory1 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer1Position = player1.GetPlayersPosition();
            //        player1.DropBomb(weaponFactory1, "Bomb", "drop_bomb", Convert.ToInt32(currentPlayer1Position.x), Convert.ToInt32(currentPlayer1Position.y));


            //        weaponFactory2 = new Player_Weapon_Factory();
            //        Vector2 currentPlayer2Position = player2.GetPlayersPosition();
            //        player2.PlantMine(weaponFactory2, "Mine", "land_mine", Convert.ToInt32(currentPlayer2Position.x), Convert.ToInt32(currentPlayer2Position.y));
            //    }
            //}

            //---------------------------------------------------------

            Console.ReadKey();
        }
    }
}
