using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;
using System.IO;

namespace Biblioteca
{
    public class ReadRepository
    {
        public Carte CautaCarte(int idRadacina)
        {
            List<Carte> lista = new List<Carte>();
            lista = CitesteCarti();
            for (int i = 0; i < lista.Count; i++)
                if (lista[i].Id == idRadacina && lista[i].Stare==StareCarte.Neimprumutata)
                    return lista[i];
            return null;
        }

        public List<Carte> CitesteCarti()
        {
            //citire din fisier
            List<Carte> lista = new List<Carte>();
            StreamReader sr =new StreamReader("C:\\Users\\Cosmina\\Desktop\\Biblioteca\\carti.txt");
            string linie;
            char separator1 = ';';
            char separator2 = ',';
            while ((linie = sr.ReadLine())!=null)
            {
                string[] s = linie.Split(separator1);
                int id = int.Parse(s[0]);
                string titlu = s[1];
                string autor = s[2];
                string editura = s[3];
                int termen = int.Parse(s[4]);
                DateTime data = new DateTime();
                if (s[5] == "0")
                    data = Convert.ToDateTime("01-01-1900");
                string domeniu = s[6];
                string[] s1 = s[7].Split(separator2);
                int etaj = int.Parse(s1[0]);
                int raft = int.Parse(s1[1]);
                Locatie l = new Locatie(etaj, raft);
                StareCarte stare = new StareCarte();
                if (s[8].Equals("Neimprumutata"))
                    stare = StareCarte.Neimprumutata;
                else if (s[8].Equals("Imprumutata"))
                    stare = StareCarte.Imprumutata;
                else
                    stare = StareCarte.Rezervata;
                Carte c = new Carte(id, titlu, autor, editura, termen, data, domeniu, l, stare);
                lista.Add(c);
            }
            return lista;
        }
    }
}
