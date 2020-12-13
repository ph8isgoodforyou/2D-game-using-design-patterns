using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Chain_of_resp
{
    public class IceHandler : Handler
    {
        public override void HandleRequest(BombType request)
        {
            if (request == BombType.Ice)
                Console.WriteLine("You're cool. Forever. Wow, not a good way to go, eh?");
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }
}
