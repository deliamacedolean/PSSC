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
        public static StreamWriter sw;
        public static StreamReader sr;

        public static async void Write(Eveniment e)
        {
            sr = new StreamReader("C:\\Users\\Cosmina\\Desktop\\PSSC-master\\Biblioteca\\evenimente.txt");
            string s;
            s = sr.ReadToEnd();
            sr.Close();
            sw = new StreamWriter("C:\\Users\\Cosmina\\Desktop\\PSSC-master\\Biblioteca\\evenimente.txt");
            sw.Write(s);
            sw.WriteLine(e.ToString());
            sw.Close();
        }
    }
}
