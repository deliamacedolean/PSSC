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
        public override Carte Proceseaza(ComandaRezervaCarte comanda)
        {
            string titlu = comanda.Titlu;
            WriteRepository write = new WriteRepository();
            Carte c = ReadRepository.CautaCarte(titlu);
            if (c != null)
            {
                c.Stare = StareCarte.Rezervata;
                write.UpdateCarte(c);
            }
            return null;
        }
    }
}
