using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Biblioteca.Modele;
namespace Biblioteca.Evenimente
{

    public class Eveniment
    {
        public Guid Id { get; private set; }
        public string IdRadacina { get; private set; }
        public TipEveniment Tip;
        public string Detalii { get; private set; }

        public string ToString()
        {
            return IdRadacina + ";" + Tip.ToString() + ";" + Detalii;
        }

        public Eveniment(string idRadacina, TipEveniment tipEveniment, string detalii)
        {
            Tip = tipEveniment;
            IdRadacina = idRadacina;
            Detalii = detalii;
            Id = Guid.NewGuid();
        }

    }

}
