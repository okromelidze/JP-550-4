using System;
using System.Collections.Generic;
using System.Text;

namespace C_8
{
    internal class User
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null || value == "" || string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _name = value;
                }
            }
        }
        



            private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == null || value == "" || string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _lastName = value;
                }
            }
        }


             private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length == 0 || value.Length < 5)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _email = value;
                }
            }
        }

        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0 || value > 25)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _id = value;
                }
            }


        }


        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length < 5 || value.Length > 20 || value == null || value == "" || string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _password = value;
                }
            }


        }


        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if ( value <= 0 || value >= 150 )
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _age = value;
                }
            }

        }

        private bool _gender;
        public bool Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value != true && value != false)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _gender = value;
                }
            }

        }



//  მეტი ფროფერთი ვეღარ მოვიფიქრე 



    }
}
