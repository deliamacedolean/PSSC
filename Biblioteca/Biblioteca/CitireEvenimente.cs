using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca.Evenimente;

namespace Biblioteca
{
    class CitireEvenimente
    {
        public StreamReader sr = new StreamReader("C:\\Users\\Cosmina\\Desktop\\Biblioteca\\evenimente.txt");
        public static List<Eveniment> events = new List<Eveniment>();

        public List<Eveniment> Citeste()
        {
            string line = null;
            while((line = sr.ReadLine())!=null)
            {
                string[] s = line.Split(';');
                Guid id = Guid.Parse(s[0]);
                string idRadacina = s[1];
                TipEveniment t;
                
                if (s[2] == "ImprumutareCarte")
                    t = TipEveniment.ImprumutareCarte;
                else if (s[2] == "PrelungireTermen")
                    t = TipEveniment.PrelungireTermen;
                else if (s[2] == "RestituireCarte")
                    t = TipEveniment.RestituireCarte;
                else
                    t = TipEveniment.RezervareCarte;

                string detalii = s[3];

                Eveniment e = new Eveniment(idRadacina, t, detalii);
                events.Add(e);
            }
            return events;
        }
    }
}
