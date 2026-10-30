using System;
using System.Collections.Generic;
using System.Text;

namespace C_11
{
    public abstract class User
    {
        
        private string _name;
        private string _password;
        private string _email;

        
        public string Name
        {
            get { return _name; }
            set { _name = string.IsNullOrWhiteSpace(value) ? "უცნობი" : value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        
        public string Password
        {
            set { _password = value; }
        }

        
        public User()
        {
            _name = "უცნობი";
            _email = "";
            _password = "";
        }

        
        public User(string name, string email)
        {
            Name = name;
            Email = email;
            _password = "";
        }

       
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            _password = password;
        }

        
        public bool Authorize()
        {
            Console.Write("შეიყვანეთ მეილი: ");
            string inputEmail = Console.ReadLine();

            Console.Write("შეიყვანეთ პაროლი: ");
            string inputPassword = Console.ReadLine();

            if (inputEmail == _email && inputPassword == _password)
            {
                Console.WriteLine("ავტორიზაცია წარმატებულია!");
                return true;
            }

            Console.WriteLine("მეილი ან პაროლი არასწორია!");
            return false;
        }

        
        public abstract void ShowInfo();
    }
}
