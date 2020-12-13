using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Mediator
{
    public class GameMediator
    {
        public List<GameObject> gobs;
        public GameMediator()
        {
            gobs = new List<GameObject>();
        }
        public void Notify(string msg, GameObject obj)
        {
            if(msg == "blow")
            {
                foreach (var o in gobs)
                    if (o is Player)
                    {
                        Player pl = o as Player;
                        pl.NoteExplosion((Weapon)obj);
                    }
            }
        }

        internal void Attach(GameObject player)
        {
            gobs.Add(player);
        }
    }
}
