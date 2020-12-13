using Dynamite.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite
{
    public class Bonus : GameObject
    {

        public BonusType Type = BonusType.None;
        public GameMediator Mediator;

        public Bonus(int x, int y, int frameNumber, int frameWidth, int frameHeight, BonusType type, GameMediator med)
            : base(x, y, frameNumber, frameWidth, frameHeight)
        {
            this.Type = type;
            this.Mediator = med;
            Mediator.Notify("spawn", this);
        }

        public void CheckCasePosition(int TileWidth, int TileHeight)
        {
            this.CasePosition[0] = this.Source.Y / TileWidth; //Ligne
            this.CasePosition[1] = this.Source.X / TileWidth; //Colonne
        }

    }

    public enum BonusType
    {
        None,
        PowerBomb,
        SpeedBoost,
        Desamorce,
        Armor

    }
}
