using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Evenimente;
using Newtonsoft.Json;

namespace Biblioteca
{
    public class WriteRepository
    {

        public bool UpdateCarte(string idRadacina)
        {
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
