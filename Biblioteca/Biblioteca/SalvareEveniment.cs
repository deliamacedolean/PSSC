using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca.Evenimente;

namespace Biblioteca
{
    class SalvareEveniment
    {
        public StreamWriter sw = new StreamWriter("C:\\Users\\Cosmina\\Desktop\\Biblioteca\\evenimente.txt");

        public void Write(Eveniment e)
        {
            sw.WriteLine(e.ToString());
        }
    }
}
