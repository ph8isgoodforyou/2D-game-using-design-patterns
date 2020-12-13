using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite
{
    [Serializable]
    public abstract class GameObject
    {
        //Rectangle used to make this
        protected Rectangle _Source;

        [NonSerialized]
        protected Image Sprite;

        //Current frame
        protected int _frameindex;

        //Frame duration
        protected float _frameTime = 125;


        protected int _totalElapsedTime = 0;


        //Number of animation frames
        protected int _totalFrames;

        //Object position at box level
        protected int[] _CasePosition;

        #region Accessors


        public int[] CasePosition
        {
            get { return _CasePosition; }
            set
            {
                if (!(value[0] < 0 || value[1] < 0))
                {
                    _CasePosition = value;

                }
            }

        }
        public Rectangle Source
        {
            get { return _Source; }
            set { _Source = value; }
        }
        public float frameSpeed
        {
            get { return this._frameTime; }
            set
            {
                if (value <= 0) this._frameTime = 1; //Time can't be negative
                else this._frameTime = value;
            }
        }

        public int totalFrames
        {
            get { return _totalFrames; }
        }
        public int frameindex
        {
            get { return _frameindex; }
            set { _frameindex = value; }
        }


        #endregion

        //Contructor
        public GameObject()
        { }

        public GameObject(int x, int y, int totalFrames, int frameWidth, int frameHeight)

        {
            _totalFrames = totalFrames;
            CasePosition = new int[2] { 0, 0 };
            _Source = new Rectangle(x, y, frameWidth, frameHeight);

        }

        public GameObject(int x, int y, int totalFrames, int frameWidth, int frameHeight, int frameTime)

        {
            _totalFrames = totalFrames;
            CasePosition = new int[2] { 0, 0 };
            _Source = new Rectangle(x, y, frameWidth, frameHeight);
            _frameTime = frameTime;


        }

        public void ChangeLocation(int x, int y)
        {
            this._Source.X = x;
            this._Source.Y = y;
        }


        public void LoadSprite(Image sprite)
        {

            this.Sprite = sprite;

        }
        public void UnloadSprite()
        {

            this.Sprite = null;

        }



        public void Draw(Graphics gr)
        {
            if (this.Sprite != null)
            {
                gr.DrawImage(this.Sprite, Source, frameindex * Source.Width, 0, Source.Width, Source.Height, GraphicsUnit.Pixel);
                gr.DrawRectangle(Pens.Red, this.Source);
            }
        }




        public void UpdateFrame(int elsapedTime)
        {

            _totalElapsedTime += elsapedTime;

            if (_totalElapsedTime > this.frameSpeed)
            {
                frameindex += 1;

                _totalElapsedTime = 0;

                if (frameindex > _totalFrames)
                {
                    frameindex = 0; // loop around

                }
            }


        }



        public void Move(int deplX, int deplY)
        {
            _Source.X += deplX;
            _Source.Y += deplY;
        }
    }
}
