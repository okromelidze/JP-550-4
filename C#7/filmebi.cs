using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace C_7
{
    internal class filmebi
    {
        public string Name;
        public string Director;
        public int Year;
        public string Genre;
        public double Rating;




        public void PrintInfo()
        {
            Console.WriteLine($"სახელი: {Name}");
            Console.WriteLine($" წელი: {Year}");
            Console.WriteLine($"რეჟისორი: {Director}");
            Console.WriteLine($"ჟანრი: {Genre}");
            Console.WriteLine($"რეიტინგი: {Rating}");
            Console.WriteLine();
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Year;
        }

        public bool IsClassic()
        {
            return GetAge() > 30;
        }
    }
}
