using MeetingApp.Models;
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


        // view sayfasından post metoduyla formdan gelen bilgileri alıp işleyecek olan metod budur.
        // dikkat edilmesi gereken şey, view sayfasındaki değişkenlerin "name" özelliklerinin bu metotdaki parametrelerle aynı olmasıdır.
        // ayrıca formun action özelliğinin bu metodun çalıştırılmasını sağlayacak şekilde ayarlanması gerekmektedir.
        // bu örnekte formun action özelliği "/Meeting/Apply" şeklinde ayarlanmıştır.
        // bu durumda form submit edildiğinde bu metot çalışacaktır.
        // bu metotun çalışması için formun method özelliğinin "post" olması gerekmektedir.
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            System.Diagnostics.Debug.WriteLine(model.Name+"ahahahasad");
            System.Diagnostics.Debug.WriteLine(model.Phone);

            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }
}
