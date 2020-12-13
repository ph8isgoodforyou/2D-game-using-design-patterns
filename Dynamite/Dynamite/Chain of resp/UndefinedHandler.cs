using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Chain_of_resp
{
    public class UndefinedHandler : Handler
    {
        public override void HandleRequest(BombType request)
        {
            if (request != BombType.Fire || request != BombType.Ice || request != BombType.Psychic)
                Console.WriteLine("No idea what happened");
            else if (successor != null)
                successor.HandleRequest(request);
        }
    }
}
