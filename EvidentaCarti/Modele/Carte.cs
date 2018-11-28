using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaCarti.Modele
{
    class Carte
    {
        public int Id { get; private set; }
        public string Titlu { get; private set; }
        public string Autor { get; private set; }
        public string Editura { get; private set; }
        public int Termen { get; private set; } 
        public DateTime DataImprumut { get; private set; }
        public string Domeniu { get; private set; }
        public Locatie Locatie { get; private set; }
        public StareCarte Stare { get; private set; }



        public Carte( int id, string titlu, string autor, string editura, int termen, DateTime dataImprumut, string domeniu, Locatie locatie, StareCarte stare)
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

        public void Imprumuta( int id)
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
