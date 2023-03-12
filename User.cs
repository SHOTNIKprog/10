namespace ConsoleApp16
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
