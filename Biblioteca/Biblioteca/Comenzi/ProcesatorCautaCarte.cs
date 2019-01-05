using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Comenzi
{
    public class ProcesatorCautaCarte : ProcesatorComandaGeneric<ComandaCautaCarte>
    {
        public override Carte Proceseaza(ComandaCautaCarte comanda)
        {
            Carte c = null;
            for(int i =0;i < ReadRepository.lista.Count; i++)
            {
                if (ReadRepository.lista[i].Titlu == comanda.Titlu)
                    c = ReadRepository.lista[i];
            }
            return c;
        }
    }
}
