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
        public static StreamReader sr = new StreamReader("C:\\Users\\Cosmina\\Desktop\\PSSC-master\\Biblioteca\\evenimente.txt");
        public static List<Eveniment> events = new List<Eveniment>();

        public static void Citeste()
        {
            string line = null;
            while((line = sr.ReadLine())!=null)
            {
                string[] s = line.Split(';');
                string idRadacina = s[0];
                TipEveniment t;
                
                if (s[1] == "ImprumutareCarte")
                    t = TipEveniment.ImprumutareCarte;
                else if (s[1] == "PrelungireTermen")
                    t = TipEveniment.PrelungireTermen;
                else if (s[1] == "RestituireCarte")
                    t = TipEveniment.RestituireCarte;
                else
                    t = TipEveniment.RezervareCarte;

                string detalii = s[2];

                Eveniment e = new Eveniment(idRadacina, t, detalii);
                events.Add(e);
            }
            sr.Close();
        }
    }
}
