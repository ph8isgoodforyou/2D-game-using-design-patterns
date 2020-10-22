using Dynamite.DynamiteEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Dynamite.DynamiteEngine.Tiles.AbstractFactory;
using Dynamite.DynamiteEngine.Tiles.ConcreteFactory;
using Dynamite.DynamiteEngine.Map.Director;
using Dynamite.DynamiteEngine.Map.Builder;
using Dynamite.DynamiteEngine.Map.ConcreteBuilder;
using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Players.Creator;
using Dynamite.DynamiteEngine.Players.Product;
using Dynamite.DynamiteEngine.Players.ConcreteCreator;
using Dynamite.DynamiteEngine.Weapons;

namespace Dynamite
{
    class DemoGame : DynamiteEngine.DynamiteEngine
    {
        bool left, right, up, down, enter;
        bool a, d, w, s, space;

        Player player1;
        Player player2;

        Block_AbstractFactory blockFactory;
        MapDirector mapDirector = new MapDirector();
        MapBuilder mapBuilder;
        MapProduct map;

        CharacterCreator[] creators = new CharacterCreator[2];

        Weapon_AbstractFactory weaponFactory1 = new Player_Weapon_Factory();
        Weapon_AbstractFactory weaponFactory2 = new Player_Weapon_Factory();

        public DemoGame() : base(new Vector2(677, 590), "Dynamite Demo") { }

        /// <summary>
        /// Used for uploading everything for the game before rendering starts
        /// </summary>
        public override void OnLoad()
        {
            BackgroundColor = Color.BurlyWood;

            Console.WriteLine("Choose game mode: \n 1. Ice Map \n 2. Lava Map \n Enter number according to the chosen map:");
            int GameMode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose game character: \n 1. Female \n " +
                "2. Male \n 3. Robot \n 4. Zombie \n Enter number " +
                "according to the chosen character:");
            int Player1Character = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Player Name: ");
            string Player1Name = Console.ReadLine();

            Console.WriteLine("Choose game character: \n 1. Female \n " +
                "2. Male \n 3. Robot \n 4. Zombie \n Enter number " +
                "according to the chosen character:");
            int Player2Character = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Player Name: ");
            string Player2Name = Console.ReadLine();

            if (GameMode == 1)
            {
                blockFactory = new IceMapFactory();
                mapBuilder = new IceMapBuilder();
            }
            else if (GameMode == 2)
            {
                blockFactory = new LavaMapFactory();
                mapBuilder = new LavaMapBuilder();
            }
            mapDirector.Construct(mapBuilder, blockFactory);
            map = mapBuilder.GetMap();

            Random rnd = new Random();
            int PlacementOfPlayers = rnd.Next(1, 100);

            CharacterCreator[] creators = new CharacterCreator[2];

            if (Player1Character == 1)
            {
                creators[0] = new HumanFemaleCharacterCreator();
            }
            else if (Player1Character == 2)
            {
                creators[0] = new HumanMaleCharacterCreator();
            }
            else if (Player1Character == 3)
            {
                creators[0] = new RobotCharacterCreator();
            }
            else if (Player1Character == 4)
            {
                creators[0] = new ZombieCharacterCreator();
            }

            if (Player2Character == 1)
            {
                creators[1] = new HumanFemaleCharacterCreator();
            }
            else if (Player2Character == 2)
            {
                creators[1] = new HumanMaleCharacterCreator();
            }
            else if (Player2Character == 3)
            {
                creators[1] = new RobotCharacterCreator();
            }
            else if (Player2Character == 4)
            {
                creators[1] = new ZombieCharacterCreator();
            }

            if (Player1Name != "")
            {
                if (PlacementOfPlayers % 7 == 0)
                {
                    //top
                    player1 = creators[0].CreatePlayer(Player1Name, map, -4, -10);
                }
                else if (PlacementOfPlayers % 9 == 0)
                {
                    //left
                    player1 = creators[0].CreatePlayer(Player1Name, map, -4, -10);
                }
                else if (PlacementOfPlayers % 2 == 0)
                {
                    //right
                    player1 = creators[0].CreatePlayer(Player1Name, map, 610, -10);
                }
                else
                {
                    //bottom
                    player1 = creators[0].CreatePlayer(Player1Name, map, 0, 480);
                }
            }
            else
            {
                if (PlacementOfPlayers % 7 == 0)
                {
                    //top
                    player1 = creators[0].CreateAnonymousPlayer(map, -4, -10);
                }
                else if (PlacementOfPlayers % 9 == 0)
                {
                    //left
                    player1 = creators[0].CreateAnonymousPlayer(map, -4, -10);
                }
                else if (PlacementOfPlayers % 2 == 0)
                {
                    //right
                    player1 = creators[0].CreateAnonymousPlayer(map, 610, -10);
                }
                else
                {
                    //bottom
                    player1 = creators[0].CreateAnonymousPlayer(map, 0, 480);
                }
            }

            if (Player2Name != "")
            {
                if (PlacementOfPlayers % 7 == 0)
                {
                    //top
                    player2 = creators[1].CreatePlayer(Player2Name, map, 610, -10);
                }
                else if (PlacementOfPlayers % 9 == 0)
                {
                    //left
                    player2 = creators[1].CreatePlayer(Player2Name, map, -4, 480);
                }
                else if (PlacementOfPlayers % 2 == 0)
                {
                    //right
                    player2 = creators[1].CreatePlayer(Player2Name, map, 610, 480);
                }
                else
                {
                    //bottom
                    player2 = creators[1].CreatePlayer(Player2Name, map, 610, 480);
                }
            }
            else
            {
                if (PlacementOfPlayers % 7 == 0)
                {
                    //top
                    player2 = creators[1].CreateAnonymousPlayer(map, 610, -10);
                }
                else if (PlacementOfPlayers % 9 == 0)
                {
                    //left
                    player2 = creators[1].CreateAnonymousPlayer(map, -4, 480);
                }
                else if (PlacementOfPlayers % 2 == 0)
                {
                    //right
                    player2 = creators[1].CreateAnonymousPlayer(map, 610, 480);
                }
                else
                {
                    //bottom
                    player2 = creators[1].CreateAnonymousPlayer(map, 610, 480);
                }
            }
        }
        public override void OnDraw()
        {
            
        }

        public override void OnUpdate()
        {
            //CameraPosition.x -= .1f;
            //CameraAngle += .1f;

            if (up)
            {
                player1.DecreasePlayersPositionY(1f);
            }
            if (down)
            {
                player1.IncreasePlayersPositionY(1f);
            }
            if (left)
            {
                player1.DecreasePlayersPositionX(1f);
            }
            if (right)
            {
                player1.IncreasePlayersPositionX(1f);
            }
            if (enter)
            {
                Vector2 currentPlayer1Position = player1.GetPlayersPosition();
                player1.DropBomb(weaponFactory1, "Bomb", "drop_bomb", 
                    Convert.ToInt32(currentPlayer1Position.x), 
                    Convert.ToInt32(currentPlayer1Position.y));
            }

            if (w)
            {
                player2.DecreasePlayersPositionY(1f);
            }
            if (s)
            {
                player2.IncreasePlayersPositionY(1f);
            }
            if (a)
            {
                player2.DecreasePlayersPositionX(1f);
            }
            if (d)
            {
                player2.IncreasePlayersPositionX(1f);
            }
            if (space)
            {
                Vector2 currentPlayer2Position = player2.GetPlayersPosition();
                player2.DropBomb(weaponFactory1, "Bomb", "drop_bomb",
                    Convert.ToInt32(currentPlayer2Position.x),
                    Convert.ToInt32(currentPlayer2Position.y));
            }
            //if(player.IsColliding(player, player2))
            //{
            //    Log.Info("Colliding");
            //}
        }

        public override void GetKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }

        }

        public override void GetKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }

        }
    }
}
