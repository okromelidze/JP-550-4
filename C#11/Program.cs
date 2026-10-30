namespace C_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users =
         {
            new ClientUser("გიორგი", "giorgi@mail.com", "1234", 500),
            new AdminUser("ნინო", "nino@mail.com", "admin777", 5)
        };

            foreach (User user in users)
            {
                user.ShowInfo();   
                user.Authorize();  
                Console.WriteLine();
            }
        }
    }
}
