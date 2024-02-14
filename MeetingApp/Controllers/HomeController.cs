using MeetingApp.Models;
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

            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };
            // MeetingInfodan gelen modelin değerlerini girme

            return View(meetingInfo);
            // bir key-value degiskeninini model olarak view sayfasına yollamak icin return View(ViewData["Selamlama"]);
        }
    }
}