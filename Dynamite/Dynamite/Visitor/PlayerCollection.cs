using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamite.Visitor
{
    public class PlayerCollection
    {
        List<Player> Players;
        public PlayerCollection()
        {
            Players = new List<Player>();
        }
        public void Attach(Player pl)
        {
            Players.Add(pl);
        }
        public void Dettach(Player pl)
        {
            Players.Remove(pl);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (Player pl in Players)
            {
                pl.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
