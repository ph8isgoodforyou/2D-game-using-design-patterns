using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Visitor
{
    class SpeedVisitor:IVisitor
    {
        public void Visit(Player element)
        {
            if(element.Speed < 8)
            element.Speed += 1;
        }
    }
}
