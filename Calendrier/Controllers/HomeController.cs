using Calendrier.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Calendrier.Controllers
{
    public class HomeController : Controller
    {
        private BaseDeDonnees BD { get; set; }

        public HomeController(BaseDeDonnees pDonnees)
        {
            BD = pDonnees;
        }

        public IActionResult Index()
        {
            
            
            return View(BD.Jours.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
