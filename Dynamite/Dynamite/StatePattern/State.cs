﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.StatePattern
{
    public abstract class State
    {
        public abstract void Handle(Game game, string fileName);
    }
}
