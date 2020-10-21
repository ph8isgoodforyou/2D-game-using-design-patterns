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

namespace Dynamite
{
    class DemoGame : DynamiteEngine.DynamiteEngine
    {
        bool left, right, up, down;

        //Shape2D player;
        Sprite2D player1;
        Sprite2D player2;

        Block_AbstractFactory blockFactory;
        MapDirector mapDirector = new MapDirector();
        MapBuilder mapBuilder;
        MapProduct map;

        //string[,] Map =
        //{
        //    {"b","b","b","b","b","b","b","b","b","b","b","b"},
        //    {"b",".",".","g","b","g","g","b","g",".",".","b"},
        //    {"b",".","b","g","g","g","g","g","g","b",".","b"},
        //    {"b","g","g","g","b","b","b","b","g","g","g","b"},
        //    {"b","g","b","g","g","g","g","g","g","b","g","b"},
        //    {"b","g","g","b","g","g","g","g","b","g","g","b"},
        //    {"b","g","g","g","g","b","b","g","g","g","g","b"},
        //    {"b",".","b","g","g","g","g","g","g","b",".","b"},
        //    {"b",".",".","g","b","g","g","b","g",".",".","b"},
        //    {"b","b","b","b","b","b","b","b","b","b","b","b"},
        //};

        public DemoGame() : base(new Vector2(677, 590), "Dynamite Demo") { }

        /// <summary>
        /// Used for uploading everything for the game before rendering starts
        /// </summary>
        public override void OnLoad()
        {
            BackgroundColor = Color.BurlyWood;

            Console.WriteLine("Choose game mode: \n 1. Ice Map \n 2. Lava Map \n Enter number according to the chosen map:");
            int GameMode = Convert.ToInt32(Console.ReadLine());

            if (GameMode == 1)
            {
                blockFactory = new IceMapFactory();
                mapBuilder = new IceMapBuilder();
                mapDirector.Construct(mapBuilder, blockFactory);
                //map = mapBuilder.GetMap();
                //map.PrintMap();
            }
            else if (GameMode == 2)
            {
                blockFactory = new LavaMapFactory();
                mapBuilder = new LavaMapBuilder();
                mapDirector.Construct(mapBuilder, blockFactory);
                //map = mapBuilder.GetMap();
                //map.PrintMap();
            }

            //for (int i = 0; i < Map.GetLength(1); i++)
            //{
            //    for (int j = 0; j < Map.GetLength(0); j++)
            //    {
            //        if (Map[j, i] == "b")
            //        {
            //            new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Titanium", "/Blocks/PNG/Tiles/platformPack_tile041");
            //        }
            //        if (Map[j, i] == "g")
            //        {
            //            new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Ground", "/Blocks/PNG/Tiles/platformPack_tile004");
            //        }
            //    }
            //}

            Random rnd = new Random();
            int PlacementOfPlayers = rnd.Next(1, 100);

            if (PlacementOfPlayers % 7 == 0)
            {
                // \
                player1 = new Sprite2D(new Vector2(-4, -10), new Vector2(48, 64), "Player1", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
                player2 = new Sprite2D(new Vector2(610, -10), new Vector2(48, 64), "Player2", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
            }
            else if (PlacementOfPlayers % 9 == 0)
            {
                // _
                player1 = new Sprite2D(new Vector2(-4, -10), new Vector2(48, 64), "Player1", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
                player2 = new Sprite2D(new Vector2(-4, 480), new Vector2(48, 64), "Player2", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
            }
            else if (PlacementOfPlayers % 2 == 0)
            {
                // |
                player1 = new Sprite2D(new Vector2(-4, 480), new Vector2(48, 64), "Player1", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
                player2 = new Sprite2D(new Vector2(610, 480), new Vector2(48, 64), "Player2", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
            }
            else
            {
                // --
                player1 = new Sprite2D(new Vector2(-4, -10), new Vector2(48, 64), "Player1", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
                player2 = new Sprite2D(new Vector2(610, 480), new Vector2(48, 64), "Player2", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
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
                player1.Position.y -= 1f;
            }
            if (down)
            {
                player1.Position.y += 1f;
            }
            if (left)
            {
                player1.Position.x -= 1f;
            }
            if (right)
            {
                player1.Position.x += 1f;
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
