namespace MeetingApp.Models
{
    public class Repository
    {
        // UserInfo tipinde, kullanıcıların bilgilerini tutacak bir liste oluşturuyoruz
        private static List<UserInfo> _users = new();

        // çalıştırıldığında, kullanıcılar listesine 3 adet kullanıcı ekliyoruz
        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Mami", Email = "abc@gmail.com", Phone = "1231", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Burak", Email = "abc1@gmail.com", Phone = "2222", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Furkan", Email = "abc2@gmail.com", Phone = "3333", WillAttend = true });
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
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        // Id'si verilen kullanıcıyı getiren bir metod oluşturuyoruz
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(i => i.Id == id);
        }
    }
}
