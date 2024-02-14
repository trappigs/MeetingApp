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
            // CreateUser metoduna modelimizi göndererek, kullanıcıyı kaydediyoruz
            Repository.CreateUser(model);

            // Kullanıcıya katılımcı sayısını gösterebilmek adına bir ViewBag oluşturup, kullanıyoruz
            // Sadece katılan kişilerin sayısını göstermek istediğimiz için, bir koşul ekliyoruz
            // bu koşul bir linq expression olarak geçiyor
            ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();


            // Kullanıcı kaydını gerçekleştirdiği için, teşekkür(thanks) sayfasına(veiwine) yönlendiriyoruz
            // thanks sayfasının, kullanıcıya hitap etmek için kaydını gerçekleştirdiğimiz bilgileri
            // model ile gönderiyoruz
            return View("Thanks", model);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }
}
