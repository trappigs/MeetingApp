using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(string Name, string Phone, string Email, bool WillAttend)
        {
            System.Diagnostics.Debug.WriteLine(Name+"ahahahasad");
            System.Diagnostics.Debug.WriteLine(Phone);

            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }
}
