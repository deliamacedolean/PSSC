using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PSSC.Models;
using Biblioteca.Comenzi;
using Biblioteca;
using Biblioteca.Modele.Carti;
using Biblioteca.Evenimente;

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
            var carte = (Carte)MagistralaComenzi.Executa("cauta", model.Titlu);

            var modelConvertit = new CarteMVC(carte.Id, carte.Titlu, carte.Autor, carte.Editura, carte.Termen, carte.DataImprumut, carte.Domeniu, carte.Locatie, carte.Stare);

            return View(modelConvertit);

        }

        public ActionResult AfisareCartiUser()
        {
            var cartiUser = MagistralaEvenimente.CartiUser;
            var cartiConvertite = new List<CarteMVC>();
            foreach(var carte in cartiUser)
            {
                cartiConvertite.Add(new CarteMVC(carte.Id, carte.Titlu, carte.Autor, carte.Editura, carte.Termen, carte.DataImprumut, carte.Domeniu, carte.Locatie, carte.Stare));
            }
            return View(cartiConvertite);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult Login(User model)
        {

            if (ModelState.IsValid)
            {
                if (model.IsValid())
                {
                    ReadRepository.CitesteCarti();
                    MagistralaEvenimente.Process();
                    return RedirectToAction("PaginaPrincipala");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(model);
        }

        private void Process()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult ImprumutaCarte(ImprumutaCartePost model)
        {
            MagistralaComenzi.Executa("imprumutare", model.Titlu);

            return RedirectToAction("AfisareCartiUser");
        }

        [HttpPost]
        public ActionResult RezervareCarte(RezervaCartePost model)
        {
            MagistralaComenzi.Executa("rezervare", model.Titlu);

            return RedirectToAction("AfisareCartiUser");
        }

        [HttpPost]
        public ActionResult PrelungireCarte(PrelungireCartePost model)
        {
            MagistralaComenzi.Executa("prelungire", model.Titlu);

            return RedirectToAction("AfisareCartiUser");
        }


        [HttpPost]
        public ActionResult RestituieCarte(RestituieCartePost model)
        {
            MagistralaComenzi.Executa("restituire", model.Titlu);

            return RedirectToAction("AfisareCartiUser");
        }
    }
}
