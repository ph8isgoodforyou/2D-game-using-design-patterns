﻿using Dynamite.DynamiteEngine.Map.Product;
using Dynamite.DynamiteEngine.Players.ConcreteProduct;
using Dynamite.DynamiteEngine.Players.Creator;
using Dynamite.DynamiteEngine.Players.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.DynamiteEngine.Players.ConcreteCreator
{
    class RobotCharacterCreator : CharacterCreator
    {
        public override Player CreateAnonymousPlayer(MapProduct _map, int PositionX, int PositionY)
        {
            return new RobotCharacter(_map, PositionX, PositionY);
        }
        public override Player CreatePlayer(string playerName, MapProduct _map, int PositionX, int PositionY)
        {
            return new RobotCharacter(playerName, _map, PositionX, PositionY);
        }
    }
}
