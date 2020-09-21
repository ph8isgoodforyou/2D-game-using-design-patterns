using Dynamite.DynamiteEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dynamite
{
    class DemoGame : DynamiteEngine.DynamiteEngine
    {
        bool left, right, up, down;

        //Shape2D player;
        Sprite2D player;
        Sprite2D player2;

        string[,] Map =
        {
            {"b","b","b","b","b","b","b","b","b","b","b","b"},
            {"b",".",".","g","b","g","g","b","g",".",".","b"},
            {"b",".","b","g","g","g","g","g","g","b",".","b"},
            {"b","g","g","g","b","b","b","b","g","g","g","b"},
            {"b","g","b","g","g","g","g","g","g","b","g","b"},
            {"b","g","g","b","g","g","g","g","b","g","g","b"},
            {"b","g","g","g","g","b","b","g","g","g","g","b"},
            {"b",".","b","g","g","g","g","g","g","b",".","b"},
            {"b",".",".","g","b","g","g","b","g",".",".","b"},
            {"b","b","b","b","b","b","b","b","b","b","b","b"},
        };

        public DemoGame() : base(new Vector2(677, 590), "Dynamite Demo") { }

        /// <summary>
        /// Used for uploading everything for the game before rendering starts
        /// </summary>
        public override void OnLoad()
        {
            BackgroundColor = Color.BurlyWood;
            //CameraPosition.x = 100;
            //player = new Shape2D(new Vector2(10, 10), new Vector2(10, 10), "Test");

            for (int i = 0; i < Map.GetLength(1); i++)
            {
                for (int j = 0; j < Map.GetLength(0); j++)
                {
                    if (Map[j, i] == "b")
                    {
                        new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Titanium", "/Blocks/PNG/Tiles/platformPack_tile041");
                    }
                    if (Map[j, i] == "g")
                    {
                        new Sprite2D(new Vector2(i * 55, j * 55), new Vector2(55, 55), "Ground", "/Blocks/PNG/Tiles/platformPack_tile004");
                    }
                }
            }

            player = new Sprite2D(new Vector2(60, 43), new Vector2(48, 64), "Player1", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");
            player2 = new Sprite2D(new Vector2(550, 428), new Vector2(48, 64), "Player2", "/Characters/Zombie/PNG/Poses/character_zombie_walk1");


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
                player.Position.y -= 1f;
            }
            if (down)
            {
                player.Position.y += 1f;
            }
            if (left)
            {
                player.Position.x -= 1f;
            }
            if (right)
            {
                player.Position.x += 1f;
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
