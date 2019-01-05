using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PSSC.Models;

namespace PSSC.Controllers
{
    public class HomeController : Controller
    {

        List<CarteMVC> carteMVC = new List<CarteMVC>();
        public IActionResult Index()
        {
            return View("Login");
            //return View("PaginaPrincipala");
        }

        public HomeController()
        {
            
        }

        
        public ActionResult PaginaPrincipala()
        {
            return View();
        }

        public ActionResult CautaCarte()
        {
            return View("CautaCarte");
        }


        [HttpPost]
        public ActionResult CautaCarte(CautareCartePost model)
        {

            return RedirectToAction("GasireCarte");
        }



        [HttpPost]
        public ActionResult GasireCarte(CautareCartePost model)
        {
            return View();

        }

        public ActionResult AfisareCartiUser()
        {
            return View("AfisareCartiUser");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult Login(User model)
        {

            if(ModelState.IsValid)
            {
                if(model.IsValid())
                {
                    return RedirectToAction("PaginaPrincipala");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(model);
        }


       


    }
}
