namespace MeetingApp.Models
{
    public class Repository
    {
        // UserInfo tipinde, kullanıcıların bilgilerini tutacak bir liste oluşturuyoruz
        private static List<UserInfo> _users = new();

        // çalıştırıldığında, kullanıcılar listesine 3 adet kullanıcı ekliyoruz
        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Mami", Email = "abc@gmail.com", Phone = "1231", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Burak", Email = "abc1@gmail.com", Phone = "2222", WillAttend = false });
            _users.Add(new UserInfo() { Name = "Furkan", Email = "abc2@gmail.com", Phone = "3333", WillAttend = true });
        }

        // Kullanıcılar listesinin okunabilmesi için dışarıya açıyoruz(get ile sadece okunabilir hale getiriyoruz
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        // Kullanıcı eklemek için bir metod oluşturuyoruz
        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}
