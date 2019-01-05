using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Evenimente
{
    class ProcesatorImprumutareCarte:ProcesatorEveniment
    {
        public override void Proceseaza(Eveniment e)
        {
            string titlu = e.Detalii;
            Carte c = ReadRepository.CautaCarte(titlu);
            c.DataImprumut = DateTime.Now;
            c.Stare = StareCarte.Imprumutata;
            MagistralaEvenimente.CartiUser.Add(c);
        }
    }
}
