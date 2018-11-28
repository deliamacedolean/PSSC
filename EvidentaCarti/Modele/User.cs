﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaCarti.Modele
{
    class User
    {
        public string CNP { get; private set; }

        public string Nume { get; private set; }
        public int NrCartiImprumutate { get; private set; }
        public string Parola { get; set; }

        public List<Carte>  ListaCartiImprumutate { get; set; }

        public User( string cnp, string nume, string parola )
        {
            CNP = cnp;
            Nume = nume;
            NrCartiImprumutate = 0;
            Parola = parola;
            ListaCartiImprumutate = null;

        }

        public void AdaugareCarte(Carte carte)
        {
            ListaCartiImprumutate.Add(carte);
            NrCartiImprumutate++;
        }

    }
}