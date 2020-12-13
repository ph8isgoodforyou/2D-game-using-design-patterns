using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Chain_of_resp
{
    public class PsychicHandler : Handler
    {
        public override void HandleRequest(BombType request)
        {
            if (request == BombType.Psychic)
                Console.WriteLine("Mind is a wonderful thing. Yours blew up. Neat");
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }
}
