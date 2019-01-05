using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Comenzi
{
    public class MagistralaComenzi
    {
        public static void Executa(string tip, string titlu)
        {
            ProcesatorComanda pc;
            Comanda c;

            if (tip == "cauta")
            {
                pc = new ProcesatorCautaCarte();
                c = new ComandaCautaCarte();
            }
            else if (tip == "imprumutare")
            {
                c = new ComandaImprumutaCarte();
                pc = new ProcesatorImprumutareCarte();
            }
            else if (tip == "prelungire")
            {
                c = new ComandaPrelungireTermen();
                pc = new ProcesatorPrelungireTermen();
            }
            else if (tip == "rezervare")
            {
                c = new ComandaRezervaCarte();
                pc = new ProcesatorRezervareCarte();
            }
            else
            {
                c = new ComandaRestituieCarte();
                pc = new ProcesatorRestituireCarte();
            }

            c.Titlu = titlu;
            pc.Proceseaza(c);
        }
    }
}
