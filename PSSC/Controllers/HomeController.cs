﻿using System;
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
        public IActionResult Index()
        {
           return View("Login");
            // return View("PaginaPrincipala");
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
