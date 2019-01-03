using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Comenzi
{
    class ProcesatorRezervareCarte : ProcesatorComandaGeneric<ComandaRezervaCarte>
    {
        public override void Proceseaza(ComandaRezervaCarte comanda)
        {
            int id = comanda.ID;
            ReadRepository read = new ReadRepository();
            WriteRepository write = new WriteRepository();
            Carte c = read.CautaCarte(id);
            if (c != null)
            {
                c.Stare = StareCarte.Rezervata;
                write.UpdateCarte(c);
            }
        }
    }
}
