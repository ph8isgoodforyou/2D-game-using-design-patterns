using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Visitor
{
    class LifeGainVisitor : IVisitor
    {
        public void Visit(Player element)
        {
            if (element.Lifes < 3)
                element.Lifes++;
        }
    }
}
