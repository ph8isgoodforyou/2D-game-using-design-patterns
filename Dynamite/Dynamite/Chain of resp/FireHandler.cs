using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Chain_of_resp
{
    public class FireHandler : Handler
    {
        public override void HandleRequest(BombType request)
        {
            if(request == BombType.Fire)
            {
                Console.WriteLine("You've been smoked friendo!");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
