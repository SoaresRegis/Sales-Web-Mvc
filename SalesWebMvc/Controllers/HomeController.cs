using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers {
    public class HomeController : Controller {
       public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Sales Web MVC App from C#";
            ViewData["Director"] = "Regis Soares";
            return View();
        }
           
        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}