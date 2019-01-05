using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PSSC.Controllers
{
    public class UserController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult HomePage()
        {
            return View("PaginaPrincipala");
        }


    }
}
