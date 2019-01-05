using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;
using Biblioteca.Evenimente;

namespace Biblioteca.Comenzi
{
    class ProcesatorRestituireCarte : ProcesatorComandaGeneric<ComandaImprumutaCarte>
    {
        public override Carte Proceseaza(ComandaImprumutaCarte comanda)
        {
            for(int i=0; i<MagistralaEvenimente.CartiUser.Count; i++)
            {
                if (MagistralaEvenimente.CartiUser[i].Titlu == comanda.Titlu)
                    MagistralaEvenimente.CartiUser.RemoveAt(i);
            }

            return null;
        }
    }
}
