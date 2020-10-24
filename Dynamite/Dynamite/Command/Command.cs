using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Command
{
    public abstract class CommandClass
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
