using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvidentaCarti.Modele;

namespace PSSC.Models
{
    public class CarteMVC
    {

        public int Id { get; private set; }
        public string Titlu { get; private set; }
        public string Autor { get; private set; }
        public string Editura { get; private set; }
        public int Termen { get; private set; }
        public DateTime DataImprumut { get; private set; }
        public string Domeniu { get; private set; }
        public Locatie Locatie { get;  set; }
        public StareCarte Stare { get; set; }



        public CarteMVC(int id, string titlu, string autor, string editura, int termen, DateTime dataImprumut, string domeniu, Locatie locatie, StareCarte stare)
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



    }
}

