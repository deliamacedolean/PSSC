using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Comenzi
{
    public class MagistralaComenzi
    {
        public static object Executa(string tip, string titlu) // TODO DELIA void -> object
        {
            ProcesatorComanda pc = null; // TODO DELIA am pus pe null
            Comanda c = null;


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
            else if (tip == "restituire")
            {
                c = new ComandaRestituieCarte();
                pc = new ProcesatorRestituireCarte();
            }


            if (pc != null)             // TODO DELIA return
            {
                c.Titlu = titlu;
                return pc.Proceseaza(c); 
            }
            return null;
        }
    }
}
