using System;
using System.Collections.Generic;
using System.Text;

namespace C_11
{
    public class ClientUser : User
    {
        public double Balance { get; set; }

        public ClientUser() : base()
        {
            Balance = 0;
        }

        public ClientUser(string name, string email, string password, double balance)
            : base(name, email, password)
        {
            Balance = balance;
        }

       
        public override void ShowInfo()
        {
            Console.WriteLine($"[კლიენტი] სახელი: {Name}, მეილი: {Email}, ბალანსი: {Balance}");
        }
    }
}
