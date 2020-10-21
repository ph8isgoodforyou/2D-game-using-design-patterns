using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Players.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Players.Creator
{
    abstract class CharacterCreator
    {
        public abstract Player CreateAnonymousPlayer(MapProduct _map, int PositionX, int PositionY);
        public abstract Player CreatePlayer(string playerName, MapProduct _map, int PositionX, int PositionY);
    }
}
