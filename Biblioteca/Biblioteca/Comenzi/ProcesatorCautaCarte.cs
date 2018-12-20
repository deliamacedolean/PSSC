using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Comenzi
{
    public class ProcesatorCautaCarte : ProcesatorComandaGeneric<ComandaCautaCarte>
    {
        public override void Proceseaza(ComandaCautaCarte comanda)
        {

            var read = new ReadRepository();

            var gasit = read.CautaProdus("18");   /////!!!!


        }
    }
}
