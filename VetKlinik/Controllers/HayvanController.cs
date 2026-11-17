using Microsoft.AspNetCore.Mvc;

namespace VetKlinik.Controllers
{
    public class HayvanController: Controller
    {
        public IActionResult Bilgi(string ad, int yas)
        {
            ViewBag.Ad= ad;
            ViewBag.Yas= yas;

            return View();
        }
    }
}
