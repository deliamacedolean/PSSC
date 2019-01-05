using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Evenimente
{
    class ProcesatorRezervareCarte : ProcesatorEveniment
    {
        public override void Proceseaza(Eveniment e)
        {
            string titlu = e.Detalii;

            for(int i=0; i<MagistralaEvenimente.CartiUser.Count;i++)
            {
                Carte c = ReadRepository.CautaCarte(titlu);
                c.Stare = StareCarte.Rezervata;
                MagistralaEvenimente.CartiUser.Add(c);
            }
        }
    }
}
