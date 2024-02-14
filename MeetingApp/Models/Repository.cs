namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Mami", Email = "abc@gmail.com", Phone = "1231", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Burak", Email = "abc1@gmail.com", Phone = "2222", WillAttend = false });
            _users.Add(new UserInfo() { Name = "Furkan", Email = "abc2@gmail.com", Phone = "3333", WillAttend = true });
        }


        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}
