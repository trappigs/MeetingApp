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

        // Farkettiğiniz üzere, amacımız toplantıya katılacak kişileri kaydetmek, bunun için
        // Repository sınıfımızda bir metod oluşturduk ve sıra bu metodu, kayıt yani Apply
        // metodumuzda çağırmaya geldi
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {

            if (ModelState.IsValid == true)
            {
                Repository.CreateUser(model);

                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

                return View("Thanks", model);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult List()
        {
            // Repository sınıfından Users listesini alıp, view'e gönderiyoruz
            return View(Repository.Users);
        }

        // Details sayfası için bir metot oluşturuyoruz
        // Bu metot, id'si verilen kullanıcının detaylarını göstermek için kullanılacak
        // id parametresi, Repository sınıfının GetById metodundan gelecek
        // Details sayfasına gönderilen id değeriyle, id değerine göre kullanıcının detay bilgileri gösterilecek
        // örneğin meeting/details/2 dendiğinde, Id değeri 2 olan kullanıcının biglileri gösterilecek
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
