using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modele.Carti
{
    public class Locatie
    {
        public int Etaj { get; set; }
        public int Raft { get; set; }


        public Locatie(int etaj, int raft)
        {
            Etaj = etaj;
            Raft = raft;
        }

        public void SchimbaLocatia(int etaj, int raft)
        {
            Etaj = etaj;
            Raft = raft;
        }
    }
}
