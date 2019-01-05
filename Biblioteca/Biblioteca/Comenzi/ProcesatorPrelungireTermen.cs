using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;
using Biblioteca.Evenimente;

namespace Biblioteca.Comenzi
{
    class ProcesatorPrelungireTermen : ProcesatorComandaGeneric<ComandaPrelungireTermen>
    {
        public override Carte Proceseaza(ComandaPrelungireTermen comanda)
        {
            Carte c = null;
            ProcesatorCautaCarte p = new ProcesatorCautaCarte();
            ComandaCautaCarte cmd = new ComandaCautaCarte();
            cmd.Titlu = comanda.Titlu;
            c = p.Proceseaza(cmd);
            c.Termen = c.Termen + 2;
            
            for( int i=0;i<MagistralaEvenimente.CartiUser.Count;i++)
            {
                if (MagistralaEvenimente.CartiUser[i].Titlu == comanda.Titlu)
                    MagistralaEvenimente.CartiUser[i] = c;
            }
            return null;
        }
    }
}
