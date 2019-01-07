using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Evenimente;
using Newtonsoft.Json;
using Biblioteca.Modele.Carti;
using Biblioteca;
using System.IO;

namespace Biblioteca
{
    public class WriteRepository
    {

        public bool UpdateCarte(Carte c)
        {
            string linie = "";
            linie = linie + c.Id + ";" + c.Titlu + ";" + c.Autor + ";" + c.Editura + ";" + c.Termen + ";" + c.DataImprumut + ";" + c.Locatie.Etaj + "," + c.Locatie.Raft + ";" + c.Stare + ";";
            StreamReader sr = new StreamReader("C:\\Users\\Cosmina\\Desktop\\PSSC-master\\Biblioteca\\carti.txt");
            List<string> str = new List<string>();
            string l;
            while((l=sr.ReadLine())!=null)
            {
                string[] s = l.Split(';');
                if (s[0] == c.Id.ToString())
                    str.Add(linie);
                else
                    str.Add(l);
            }
            sr.Close();  // TODO DELIA
            StreamWriter sw = new StreamWriter("C:\\Users\\Cosmina\\Desktop\\PSSC-master\\Biblioteca\\carti.txt");
            for(int i=0;i<str.Count;i++)
            {
                sw.WriteLine(str[i]);
            }
            sw.Close(); // TODO DELIA
            return true;
        }

        public void SalvareEvenimente(Eveniment evenimenteNoi)
        {

            string detalii = JsonConvert.SerializeObject(evenimenteNoi.Detalii);
            var tipEveniment = evenimenteNoi.Tip;
            var idEveniment = evenimenteNoi.Id.ToString();
            var idRadacina = evenimenteNoi.IdRadacina.ToString();

        }
    }
}
