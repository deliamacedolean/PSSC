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


        public bool IsValid()
        {

            using (StreamReader sr = new StreamReader("user.txt"))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    var splitLine = line.Split(' ');

                    var cnp = splitLine[0];
                    var password = splitLine[1];
                    if (CNP.Equals(cnp) && Password.Equals(password))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        
    }
}
