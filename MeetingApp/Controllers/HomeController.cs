using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            // ViewBag.Adana = "Adana";
            // ViewBag.Sayi = 25 * 5;
            // birden fazla viewbag veya viewdata tanımlanabilir, bu viewbaglere tıpkı tanımlandıkları gibi kullanarak view sayfalarında erişilebilir

            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewData["Username"] = "Mami";

            return View(ViewData["Selamlama"]);
            // bir key-value degiskeninini model olarak view sayfasına yollamak icin return View(ViewData["Selamlama"]);
        }
    }
}