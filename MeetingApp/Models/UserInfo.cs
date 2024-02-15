using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int? Id { get; set; }

        // Ad alanı girilmediğinde Error Message özelliği ile hata mesajı gösterilebilir ve varsayılan hata mesajı değiştirilebilir.
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string? Name { get; set; }

        // Burada telefon numarası yanlış girildiğinde gelecek hata mesajını değiştiriyoruz
        [Required(ErrorMessage = "Telefon numarası alanı zorunludur")]
        [Phone(ErrorMessage = "Telefon numarası yalnızca sayısal değerlerden oluşabilir.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [EmailAddress(ErrorMessage= "Email'i yanlış formatta girdiniz.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım bilgisi alanı zorunludur.")]
        public bool? WillAttend { get; set; }
    }
}
