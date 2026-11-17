using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VetKlinik.Models;

namespace VetKlinik.Controllers
{
 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Hizmetler
            {
                KlinikAd = "Kamerleno Veteriner Kliniği",
                KlinikAdres = "123 tunceli sok. karakoyun mah.",
                CalismaSaatleri = "Pazartesi-Cuma 09:00-18:00",
                Hizmetlerimiz = new List<Hizmetler>
                {
                    new Hizmetler { }


                }
            };

            return View(model);//Modeli viewe göndermek için
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
