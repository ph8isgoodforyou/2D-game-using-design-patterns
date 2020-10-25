﻿using Dynamite.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamite
{
    [Serializable]
    public class Player : GameObject
    {
        byte PlayerNumero;
        public string Name = "Player";
        private byte _Speed = 5;
        private bool _Dead = false;
        private byte _BombNumb = 2;
        private byte _Lifes = 1;
        public World world;
        public Player otherPlayer;
        public Game game;

        public List<CommandClass> _commands = new List<CommandClass>();
        int _current = 0;

        internal void DrawSelf()
        {
            if (!Dead)
            {
                switch (Orientation)
                {
                    case Player.MovementDirection.UP:
                        LoadSprite(Properties.Resources.AT_UP);
                        break;
                    case Player.MovementDirection.DOWN:
                        LoadSprite(Properties.Resources.AT_DOWN);
                        break;
                    case Player.MovementDirection.LEFT:
                        LoadSprite(Properties.Resources.AT_LEFT);
                        break;
                    case Player.MovementDirection.RIGHT:
                        LoadSprite(Properties.Resources.AT_RIGHT);
                        break;
                    case Player.MovementDirection.NONE:
                        break;
                    default:
                        break;
                }
            }
            else
                LoadSprite(Properties.Resources.Blood);
        }

        //Player can have 2 bonus at the same time
        public BonusType[] BonusSlot = new BonusType[2];
        public short[] BonusTimer = new short[2];

        public MovementDirection Orientation = MovementDirection.NONE;





        public int Wait = 500;

        public enum MovementDirection
        {
            UP,
            DOWN,
            LEFT,
            RIGHT,
            NONE
        }



        #region Accessors



        public byte Lifes
        {
            get { return _Lifes; }
            set
            {
                _Lifes = value;
            }
        }


        public byte BombNumb
        {
            get { return _BombNumb; }
            set { _BombNumb = value; }
        }

        public byte Speed
        {
            get { return _Speed; }
            set
            {
                if (value > 0)
                    _Speed = value;
                else _Speed = 2;
            }

        }






        public bool Dead
        {
            get { return _Dead; }
            set
            {

                _Dead = value;

            }

        }

        #endregion




        public Player(byte lifes, int totalFrames, int frameWidth, int frameHeight, int caseligne, int casecolonne, int TileWidth, int TileHeight, int frameTime, byte playerNumero)
            : base(casecolonne * TileWidth, caseligne * TileHeight, totalFrames, frameWidth, frameHeight, frameTime)
        {
            CasePosition = new int[2] { caseligne, casecolonne };
            Lifes = lifes;
            Wait = 0;
            PlayerNumero = playerNumero;


        }

        #region Deplacements


        //Check the player's location
        public void LocationCheck(int tileWidth, int tileHeight)
        {
            //Player is considerate to be on a case when at least half of his sprite is on it
            //Hauteur
            this.CasePosition[0] = (this.Source.Y + this.Source.Height / 2) / tileHeight; //Ligne
            this.CasePosition[1] = (this.Source.X + this.Source.Width / 2) / tileWidth; //Colonne


        }

        public void Move()
        {
            switch (this.Orientation)
            {
                case MovementDirection.UP:
                    MoveUp();
                    break;
                case MovementDirection.DOWN:
                    MoveDown();
                    break;
                case MovementDirection.LEFT:
                    MoveLeft();
                    break;
                case MovementDirection.RIGHT:
                    MoveRight();
                    break;
                default:
                    this.frameindex = 0;
                    break;
            }

        }

        public void Operation(char operation)
        {
            switch (operation)
            {
                case 'U':
                    this.Orientation = Player.MovementDirection.UP;
                    break;
                case 'D':
                    this.Orientation = Player.MovementDirection.DOWN;
                    break;
                case 'L':
                    this.Orientation = Player.MovementDirection.LEFT;
                    break;
                case 'R':
                    this.Orientation = Player.MovementDirection.RIGHT;
                    break;
                case 'S':
                    this.DropBomb(world.MapGrid, game.BombsOnTheMap, otherPlayer);
                    break;
                case 'C':
                    this.Deactivate(this.world.MapGrid, game.BombsOnTheMap, otherPlayer);
                    break;
                case 'E':
                    game.Pause();
                    break;
            }
        }
        public void MoveUp()
        {
            base.Move(0, -Speed);
        }

        public void MoveDown()
        {
            base.Move(0, Speed);
        }

        public void MoveLeft()
        {
            base.Move(-Speed, 0);
        }

        public void MoveRight()
        {
            base.Move(Speed, 0);
        }

        public void NO()
        {
            base.Move(-Speed / 2, 0);
            base.Move(0, Speed / 2);
        }
        public void NE()
        {

            base.Move(Speed / 2, 0);
            base.Move(0, Speed / 2);
        }
        public void SO()
        {

            base.Move(-Speed / 2, 0);
            base.Move(0, -Speed / 2);
        }
        public void SE()
        {

            base.Move(Speed / 2, 0);
            base.Move(0, -Speed / 2);
        }




        #endregion

        #region Actions

        public void DropBomb(Tile[,] MapGrid, List<Weapon> BombsOnTheMap, Player otherplayer)
        {
            if (this.BombNumb > 0) //If player still has bombs
            {
                if (!MapGrid[this.CasePosition[0], this.CasePosition[1]].Occupied)
                {
                    BombsOnTheMap.Add(new Weapon(this.CasePosition[0], this.CasePosition[1], 8, 48, 48, 2000, 48, 48, this.PlayerNumero));
                    //Case obtain a reference to the bomb dropped on
                    MapGrid[this.CasePosition[0], this.CasePosition[1]].bomb = BombsOnTheMap[BombsOnTheMap.Count - 1];
                    MapGrid[this.CasePosition[0], this.CasePosition[1]].Occupied = true;
                    this.BombNumb--;
                }
            }
        }

        public void DrawPosition(Graphics g)
        {

            g.DrawString(CasePosition[0].ToString() + ":" + CasePosition[1].ToString(), new Font("Arial", 16), new SolidBrush(Color.Pink), this.Source.X, this.Source.Y);

        }
        public new void Draw(Graphics gr)
        {
            if (this.Sprite != null)
            {
                if (this.Dead)
                {
                    gr.DrawImage(this.Sprite, Source, 0, 0, Source.Width, Source.Height, GraphicsUnit.Pixel);
                    gr.DrawString("DEAD", new Font("Arial", 16), new SolidBrush(Color.Red), this.Source.X + Source.Width / 2, this.Source.Y - Source.Height / 2);
                    return;
                }

                for (int i = 0; i < 2; i++)
                {
                    switch (this.BonusSlot[i])
                    {
                        case BonusType.PowerBomb:
                            gr.DrawImage(Properties.Resources.SuperBomb, this.Source);
                            break;
                        case BonusType.SpeedBoost:
                            gr.DrawLine(new Pen(Color.Yellow, 6), this.Source.X, this.Source.Y + this.Source.Height, this.Source.X + this.Source.Width, this.Source.Y + this.Source.Height);
                            break;
                        case BonusType.Desamorce:
                            break;
                        case BonusType.Armor:
                            gr.DrawEllipse(new Pen(Color.Blue, 5), this.Source);
                            break;
                        case BonusType.None:
                            break;
                        default:
                            break;
                    }

                    gr.DrawImage(this.Sprite, Source, frameindex * Source.Width, 0, Source.Width, Source.Height, GraphicsUnit.Pixel);
                    gr.DrawRectangle(Pens.Red, this.Source);
                    gr.DrawString(this.Name, new Font(new Font("Arial", 10), FontStyle.Bold), Brushes.MediumVioletRed, this.Source.X, this.Source.Y - this.Source.Height / 2);


                }

            }
        }


        public void Respawn(Player p, Tile[,] MapGrid, int TileWidth, int TileHeight)
        {
            if (this.Wait > 2)
            {
                if (this.Lifes > 0)
                {
                    if ((1 - this.CasePosition[0]) < p.CasePosition[0] - this.CasePosition[0] &&
                       ((1 - this.CasePosition[1]) < p.CasePosition[1] - this.CasePosition[0]))
                    {
                        this.CasePosition[0] = 1;
                        this.CasePosition[1] = 1;


                    }
                    else
                    {
                        this.CasePosition[0] = ((MapGrid.GetLength(0) - 1) - 1);
                        this.CasePosition[1] = ((MapGrid.GetLength(0) - 1) - 1);

                    }
                    this._Source.X = this.CasePosition[0] * TileWidth;
                    this._Source.Y = this.CasePosition[1] * TileHeight;

                    this.Dead = false;
                }
            }
        }

        public void Deactivate(Tile[,] MapGrid, List<Weapon> bombsOnTheMap, Player otherPlayer)
        {
            Weapon toDesamorce = null;

            //Check if player has the bonus
            if (this.BonusSlot[0] != BonusType.Desamorce && this.BonusSlot[1] != BonusType.Desamorce)
            {
                return;
            }

            if (MapGrid[this.CasePosition[0], this.CasePosition[1]].bomb != null)
            {
                toDesamorce = MapGrid[this.CasePosition[0], this.CasePosition[1]].bomb;

                if (toDesamorce.Proprietary == this.PlayerNumero)
                {
                    this.BombNumb++;
                }
                else
                {
                    otherPlayer.BombNumb++;
                }

                bombsOnTheMap.Remove(toDesamorce);
                toDesamorce.Dispose();
                toDesamorce = null;

                MapGrid[this.CasePosition[0], this.CasePosition[1]].bomb = null;
                MapGrid[this.CasePosition[0], this.CasePosition[1]].Occupied = false;
            }
            else
            {
                for (int i = -1; i < 2; i += 2)
                {
                    if (MapGrid[this.CasePosition[0] + i, this.CasePosition[1]].bomb != null)
                    {
                        toDesamorce = MapGrid[this.CasePosition[0] + i, this.CasePosition[1]].bomb;

                        if (toDesamorce.Proprietary == this.PlayerNumero)
                        {
                            this.BombNumb++;
                        }
                        else
                        {
                            otherPlayer.BombNumb++;
                        }

                        bombsOnTheMap.Remove(toDesamorce);
                        toDesamorce.Dispose();
                        toDesamorce = null;

                        MapGrid[this.CasePosition[0] + i, this.CasePosition[1]].bomb = null;
                        MapGrid[this.CasePosition[0] + i, this.CasePosition[1]].Occupied = false;


                    }
                    if (MapGrid[this.CasePosition[0], this.CasePosition[1] + i].bomb != null)
                    {
                        toDesamorce = MapGrid[this.CasePosition[0], this.CasePosition[1] + i].bomb;

                        if (toDesamorce.Proprietary == this.PlayerNumero)
                        {
                            this.BombNumb++;
                        }
                        else
                        {
                            otherPlayer.BombNumb++;
                        }

                        bombsOnTheMap.Remove(toDesamorce);
                        toDesamorce.Dispose();

                        toDesamorce = null;

                        MapGrid[this.CasePosition[0], this.CasePosition[1] + i].bomb = null;

                        MapGrid[this.CasePosition[0], this.CasePosition[1] + i].Occupied = false;
                    }
                }


            }




        }

        internal void Command(Keys key)
        {
            CommandClass command = new PlayerCommand(
        this, key);
            command.Execute();

            // Add command to undo list

            _commands.Add(command);
            _current++;
        }


        #endregion

    }
}
