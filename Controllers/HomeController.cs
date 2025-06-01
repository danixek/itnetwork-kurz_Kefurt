using Microsoft.AspNetCore.Mvc;

namespace PojistakNET.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController

        // Hlavní stránka
        public ActionResult Index()
        {
            return View();
        }

        // Články
        public IActionResult Articles()
        {
            return View();
        }

        // O aplikaci
        public IActionResult About()
        {
            return View();
        }

        // Kontakt - Kde je View pro kontakt?
        public IActionResult Contact()
        {
            return View();
        }

        // Under Development
        public IActionResult UnderDevelopment()
        {
            return View();
        }

        // 404 Not Found -- neimplementováno


    }
}
