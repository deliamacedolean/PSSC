using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Comenzi
{
    public static class MagistralaComenziEx
    {
        public static void InregistreazaProcesatoareStandard(this MagistralaComenzi magistrala)
        {
            magistrala.InregistreazaProcesator(new ProcesatorImprumutareCarte());
            magistrala.InregistreazaProcesator(new ProcesatorCautaCarte());
            magistrala.InregistreazaProcesator(new ProcesatorPrelungireTermen());
            magistrala.InregistreazaProcesator(new ProcesatorRestituireCarte());
            magistrala.InregistreazaProcesator(new ProcesatorRezervareCarte());
        }
    }
}
