using System;
using System.Collections.Generic;
using System.Text;

namespace C_9
{
    internal class Doctor : Employee
    {
        
        public int ExaminedPatients { get; set; }
        public string Specialization { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine(" ექიმი ");
            base.ShowInfo();
            Console.WriteLine($"სპეციალიზაცია: {Specialization}");
            Console.WriteLine($"გასინჯული პაციენტები: {ExaminedPatients}");
        }

        public override void PerformDuty()
        {
            ExaminedPatients++;
            Console.WriteLine($"ექიმი {FullName} ასინჯავს პაციენტს ({Specialization}).");
        }

        public override decimal CalculateBonus()
        {
            
            return ExaminedPatients * 20m;
        }
    }
}