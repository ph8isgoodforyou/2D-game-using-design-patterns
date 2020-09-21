using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dynamite.DynamiteEngine
{
    public class Sprite2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public string Tag = "";
        public string Directory = "";
        public Bitmap Sprite = null;

        public Sprite2D(Vector2 Position, Vector2 Scale, string Tag, string Directory)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Tag = Tag;
            this.Directory = Directory;

            Image tmp = Image.FromFile($"Assets/Sprites/{Directory}.png");
            Bitmap sprite = new Bitmap(tmp, (int)this.Scale.x, (int)this.Scale.y);
            Sprite = sprite;

            
            Log.Info($"[SPRITE2D]({Tag}) - Has been registered!");
            DynamiteEngine.RegisterSprite(this);
        }

        public bool IsColliding(Sprite2D a, Sprite2D b)
        {
            if (a.Position.x < b.Position.x + b.Scale.x && 
                a.Position.x + a.Scale.x > b.Position.x && 
                a.Position.y < b.Position.y + b.Scale.y && 
                a.Position.y + a.Scale.y > b.Position.y)
            {
                return true;
            }
            return false;
        }

        public void DestroySelf()
        {
            DynamiteEngine.UnRegisterSprite(this);
        }
    }
}
