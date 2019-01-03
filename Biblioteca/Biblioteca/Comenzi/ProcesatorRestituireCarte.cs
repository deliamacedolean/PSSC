using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Comenzi
{
    class ProcesatorRestituireCarte : ProcesatorComandaGeneric<ComandaImprumutaCarte>
    {
        public override void Proceseaza(ComandaImprumutaCarte comanda)
        {
            int id = comanda.ID;
            ReadRepository read = new ReadRepository();
            WriteRepository write = new WriteRepository();
            Carte c = read.CautaCarte(id);
            if (c != null)
            {
                c.Stare = StareCarte.Neimprumutata;
                write.UpdateCarte(c);
            }
        }
    }
}
