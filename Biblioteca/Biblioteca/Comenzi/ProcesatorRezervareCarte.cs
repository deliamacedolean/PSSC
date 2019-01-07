using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Evenimente;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Comenzi
{
    class ProcesatorRezervareCarte : ProcesatorComandaGeneric<ComandaRezervaCarte>
    {
        public override Carte Proceseaza(ComandaRezervaCarte comanda)
        {
            Carte c = null;
            ProcesatorCautaCarte p = new ProcesatorCautaCarte();
            ComandaCautaCarte cmd = new ComandaCautaCarte();
            cmd.Titlu = comanda.Titlu;
            c = p.Proceseaza(cmd);
            c.Stare = StareCarte.Rezervata;
           
            MagistralaEvenimente.CartiUser.Add(c);
            
            Eveniment e = new Eveniment(c.Id.ToString(), TipEveniment.RezervareCarte, c.Titlu);
            SalvareEveniment.Write(e);
            return null;
        }
    }
}
