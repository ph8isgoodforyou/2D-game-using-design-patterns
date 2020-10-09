using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite
{
    [Serializable]
    public class World
    {
        public Tile[,] MapGrid;
        [NonSerialized]
        private Image Background_;


        public Image Background
        {
            get
            {
                return Background_;
            }

            set
            {
                Background_ = value;
            }
        }


        public void Draw(Graphics gr)
        {
            if (Background != null)
            {
                gr.DrawImage(Background, gr.VisibleClipBounds.X, gr.VisibleClipBounds.Y, gr.VisibleClipBounds.Width, gr.VisibleClipBounds.Height);
            }

            for (int i = 0; i < MapGrid.GetLength(0); i++) //Line
            {
                for (int j = 0; j < MapGrid.GetLength(1); j++) //Collumns
                {
                    MapGrid[i, j].Draw(gr);
                }
            }

        }

        public void loadBackground(Image background)
        {
            this.Background = background;
        }

        public void loadSpriteTile(Image spriteDestroyableTile, Image spriteUndestroyableTile)
        {
            for (int i = 0; i < MapGrid.GetLength(0); i++) //Lines
            {
                for (int j = 0; j < MapGrid.GetLength(1); j++) //Collumns
                {
                    if (MapGrid[i, j].Destroyable)
                    {
                        MapGrid[i, j].LoadSprite(spriteDestroyableTile);
                    }
                    else if (!MapGrid[i, j].Walkable && !MapGrid[i, j].Destroyable)
                    {
                        MapGrid[i, j].LoadSprite(spriteUndestroyableTile);
                    }
                }
            }

        }

        public void refreshTileSprites()
        {
            for (int i = 0; i < MapGrid.GetLength(0); i++) //Lines
            {
                for (int j = 0; j < MapGrid.GetLength(1); j++) //Collumns
                {
                    if (MapGrid[i, j].Walkable && !MapGrid[i, j].Destroyable)
                    {
                        MapGrid[i, j].UnloadSprite();
                    }
                    if (MapGrid[i, j].Fire)
                    {
                        MapGrid[i, j].LoadSprite(Properties.Resources.Fire);
                    }
                    else if (MapGrid[i, j].Walkable && !MapGrid[i, j].Fire)
                    {
                        MapGrid[i, j].UnloadSprite();
                    }

                }
            }

        }


        public World(int Width, int Height, int TILE_WIDTH, int TILE_HEIGHT, int totalFrameTile)
        {
            CreateWorldGrid(Width, Height, TILE_WIDTH, TILE_HEIGHT, totalFrameTile);
        }

        public World(int Width, int Height, Tile[,] map)
        {
            this.MapGrid = map;
        }

        public World()
        {

        }

        public void CreateWorldGrid(int Width, int Height, int TILE_WIDTH, int TILE_HEIGHT, int totalFrameTile)
        {
            Random r = new Random();
            int rand = 0;
            //Terrain generation
            MapGrid = new Tile[Width / TILE_WIDTH, Height / TILE_HEIGHT];

            for (int i = 0; i < MapGrid.GetLength(0); i++) //Line
            {
                for (int j = 0; j < MapGrid.GetLength(1); j++) //Collumn
                {

                    rand = r.Next(0, 10);

                    if (j == 0 || j == (MapGrid.GetLength(0) - 1) || i == 0 || i == (MapGrid.GetLength(1) - 1))
                        MapGrid[i, j] = new Tile(j * TILE_WIDTH, i * TILE_HEIGHT, totalFrameTile, TILE_WIDTH, TILE_HEIGHT, false, false);
                    else
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                            MapGrid[i, j] = new Tile(j * TILE_WIDTH, i * TILE_HEIGHT, totalFrameTile, TILE_WIDTH, TILE_HEIGHT, false, false);
                        else
                        {
                            if (((i == 1 && (j == 1 || j == 2)) || (i == 2 && j == 1)
                                || (i == (MapGrid.GetLength(0) - 1) - 2 && j == (MapGrid.GetLength(0) - 1) - 1) || (i == (MapGrid.GetLength(0) - 1) - 1 && (j == (MapGrid.GetLength(0) - 1) - 1 || j == (MapGrid.GetLength(0) - 1) - 2)))) // les cases adjacentes au point de spawn du joueurs sont exemptes de blocks destructibles
                                MapGrid[i, j] = new Tile(j * TILE_WIDTH, i * TILE_HEIGHT, totalFrameTile, TILE_WIDTH, TILE_HEIGHT, true, false);
                            else if (rand >= 1) 
                                MapGrid[i, j] = new Tile(j * TILE_WIDTH, i * TILE_HEIGHT, totalFrameTile, TILE_WIDTH, TILE_HEIGHT, false, true);
                            else  
                                MapGrid[i, j] = new Tile(j * TILE_WIDTH, i * TILE_HEIGHT, totalFrameTile, TILE_WIDTH, TILE_HEIGHT, true, false);

                        }


                    }


                }
            }
        }






    }
}
