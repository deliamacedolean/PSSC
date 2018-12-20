using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PSSC.Models
{
    public class User
    {

        [Required]
        [Display(Name = "CNP")]
        public string CNP { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        public bool IsValid(string _cnp, string _password)
        {
            //return true;

            using (StreamReader sr = new StreamReader("user.txt"))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    var splitLine = line.Split(' ');

                    var cnp = splitLine[0];
                    var password = splitLine[1];
                    if (_cnp.Equals(cnp) && _password.Equals(password))
                    {
                        return true;
                    }



                }
            }
            return false;
        }
    }
}
