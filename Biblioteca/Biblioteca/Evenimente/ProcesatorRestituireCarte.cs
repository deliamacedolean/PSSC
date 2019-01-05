using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Evenimente
{
    class ProcesatorRestituireCarte : ProcesatorEveniment
    {
        public override void Proceseaza(Eveniment e)
        {
            string titlu = e.Detalii;

            for(int i=0;i< MagistralaEvenimente.CartiUser.Count; i++)
            {
                if (MagistralaEvenimente.CartiUser[i].Titlu == titlu)
                    MagistralaEvenimente.CartiUser.RemoveAt(i);
            }
        }
    }
}
