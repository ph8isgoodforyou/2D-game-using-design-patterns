using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Visitor
{
    class SlowVisitor : IVisitor
    {
        public void Visit(Player element)
        {
            if(element.Speed > 1)
            element.Speed -= 1;
        }
    }
}
