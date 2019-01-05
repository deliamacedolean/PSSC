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
            return Id + ";" + IdRadacina + ";" + Tip.ToString() + ";" + Detalii;
        }

        public Eveniment(string idRadacina, TipEveniment tipEveniment, string detalii)
        {
            Tip = tipEveniment;
            IdRadacina = idRadacina;
            Detalii = detalii;
            Id = Guid.NewGuid();
        }

        /*public EvenimentGeneric<T> ToGeneric<T>()
        {
            EvenimentGeneric<T> eveniment = null;
            if (Detalii is T)
            {
                eveniment = new EvenimentGeneric<T>(this.IdRadacina, this.Tip, (T)Detalii);
            }
            else if (Detalii is JObject)
            {
                var detalii = ((JObject)this.Detalii).ToObject<T>();
                eveniment = new EvenimentGeneric<T>(this.IdRadacina, this.Tip, detalii);
            }
            else
            {
                throw new InvalidCastException();
            }
            return eveniment;
        }
    }

    public class EvenimentGeneric<T> : Eveniment
    {
        public EvenimentGeneric(string idRadacina, TipEveniment tipEveniment, T detalii)
            : base(idRadacina, tipEveniment, detalii)
        {
        }
        */
    }

}
