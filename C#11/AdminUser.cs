using System;
using System.Collections.Generic;
using System.Text;

namespace C_11
{
    public class AdminUser : User
    {
        public int AccessLevel { get; set; }

        public AdminUser() : base()
        {
            AccessLevel = 1;
        }

        public AdminUser(string name, string email, string password, int accessLevel)
            : base(name, email, password)
        {
            AccessLevel = accessLevel;
        }

        
        public override void ShowInfo()
        {
            Console.WriteLine($"[ადმინი] სახელი: {Name}, მეილი: {Email}, წვდომის დონე: {AccessLevel}");
        }
    }
}
