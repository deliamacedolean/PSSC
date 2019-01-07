using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;
using Biblioteca.Evenimente;
using Biblioteca;

namespace Biblioteca.Comenzi
{
    class ProcesatorImprumutareCarte : ProcesatorComandaGeneric<ComandaImprumutaCarte>
    {
        public override Carte Proceseaza(ComandaImprumutaCarte comanda)
        {
            Carte c = null;
            ProcesatorCautaCarte p = new ProcesatorCautaCarte();
            ComandaCautaCarte cmd = new ComandaCautaCarte();
            cmd.Titlu = comanda.Titlu;
            c = p.Proceseaza(cmd);
            c.Stare = StareCarte.Imprumutata;
            c.DataImprumut = DateTime.Now;

            MagistralaEvenimente.CartiUser.Add(c);
            Eveniment e = new Eveniment(c.Id.ToString(), TipEveniment.ImprumutareCarte, c.Titlu);
            SalvareEveniment.Write(e);
            return null;                            // trebuie verificat daca cartea e deja imprumutata
        }
    }
}
