using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;

namespace Biblioteca.Modele.Carti
{
    public class Carte
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        public int Termen { get; set; }
        public DateTime DataImprumut { get; set; }
        public string Domeniu { get; set; }
        public Locatie Locatie { get; set; }
        public StareCarte Stare { get; set; }



        public Carte(int id, string titlu, string autor, string editura, int termen, DateTime dataImprumut, string domeniu, Locatie locatie, StareCarte stare)
        {
            Id = id;
            Autor = autor;
            Titlu = titlu;
            Editura = editura;
            Termen = termen;
            DataImprumut = dataImprumut;
            Domeniu = domeniu;
            Locatie = locatie;
            Stare = stare;

        }

        public void Imprumuta(int id)
        {
            DataImprumut = DateTime.Now;
            Stare = StareCarte.Imprumutata;

        }
        public void Restituie(int id)
        {
            DataImprumut = DateTime.Now;
            Stare = StareCarte.Neimprumutata;

        }
        public void Rezerva(int id)
        {
            DataImprumut = DateTime.Now;
            Stare = StareCarte.Rezervata;

        }
    }
}
