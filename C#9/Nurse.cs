using System;
using System.Collections.Generic;
using System.Text;

namespace C_9
{
    internal class Nurse : Employee
    {
        
        private int _completedShifts;

        public int CompletedShifts
        {
            get { return _completedShifts; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ცვლების რაოდენობა არ შეიძლება იყოს უარყოფითი.");
                }
                else
                {
                    _completedShifts = value;
                }
            }
        }

        public string Department { get; set; }


        public override void ShowInfo()
        {
            Console.WriteLine("ექთანი ");
            base.ShowInfo();
            Console.WriteLine($"განყოფილება: {Department}");
            Console.WriteLine($"შესრულებული ცვლები: {CompletedShifts}");
        }

        public override void PerformDuty()
        {
            CompletedShifts++;
            Console.WriteLine($"ექთანი {FullName} პაციენტს უწევს დახმარებას ({Department} განყოფილებაში).");
        }

        public override decimal CalculateBonus()
        {
            
            return CompletedShifts * 30m;
        }
    }
}
