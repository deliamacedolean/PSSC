using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;
using Biblioteca.Evenimente;

namespace Biblioteca.Comenzi
{
    class ProcesatorRestituireCarte : ProcesatorComandaGeneric<ComandaRestituieCarte>
    {
        public override Carte Proceseaza(ComandaRestituieCarte comanda)
        {
            for(int i=0; i<MagistralaEvenimente.CartiUser.Count; i++)
            {
                if (MagistralaEvenimente.CartiUser[i].Titlu == comanda.Titlu)
                    MagistralaEvenimente.CartiUser.RemoveAt(i);
            }
            
            Eveniment e = new Eveniment("0", TipEveniment.RestituireCarte, comanda.Titlu);
            SalvareEveniment.Write(e);
            return null;
        }
    }
}
