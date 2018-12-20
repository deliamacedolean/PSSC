using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Modele.Carti;

namespace Biblioteca
{
    public class ReadRepository
    {
        public bool CautaCarte(string idRadacina)
        {
            return true;

        }

        public bool ActualizareCarte(string idRadacina)
        {
          
            return true;

        }

        public List<Carte> CitesteCarti()
        {
            //citire din fisier
            List<Carte> lista = new List<Carte>();
            return lista;
        }
    }
}
