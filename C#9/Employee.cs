using System;
using System.Collections.Generic;
using System.Text;

namespace C_9
{
    internal abstract class Employee
    {


		private string _fullName;

		public string FullName
        {
			get 
			{ 
				return _fullName; 
			}
			set 
			{
                if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 100)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _fullName = value;
                }
            }
		}


		private decimal _salary;

		public decimal Salary
		{
			get 
			{ 
				return _salary; 
			}
			set 
			{
                if (value < 0 )
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _salary = value;
                }
            }
		}




        public virtual void ShowInfo()
        {
            Console.WriteLine($"სახელი და გვარი: {FullName}");
            Console.WriteLine($"ხელფასი: {Salary} ლარი");
        }

        public abstract void PerformDuty();

        public abstract decimal CalculateBonus();
        }



    }
}
