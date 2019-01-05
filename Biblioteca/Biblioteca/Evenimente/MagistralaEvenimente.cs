using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Evenimente
{
    public class MagistralaEvenimente
    {
        public static List<Carte> CartiUser = new List<Carte>();

        static void Process()
        {
            for(int i=0;i<CitireEvenimente.events.Count;i++)
            {
                Eveniment e = CitireEvenimente.events[i];
                ProcesatorEveniment p;
                if (e.Tip == TipEveniment.ImprumutareCarte)
                    p = new ProcesatorImprumutareCarte();
                else if (e.Tip == TipEveniment.PrelungireTermen)
                    p = new ProcesatorPrelungireTermen();
                else if (e.Tip == TipEveniment.RestituireCarte)
                    p = new ProcesatorRestituireCarte();
                else
                    p = new ProcesatorRezervareCarte();

                p.Proceseaza(e);

            }
        }
    }
}
