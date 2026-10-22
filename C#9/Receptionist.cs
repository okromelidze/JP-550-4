using System;
using System.Collections.Generic;
using System.Text;

namespace C_9
{
    internal class Receptionist : Employee
    {
        private int _registeredPatients;

        public int RegisteredPatients
        {
            get 
            { 
                return _registeredPatients; 
            }
            set 
            { 
                if (value < 0)
                {
                    Console.WriteLine("რეგისტრირებული პაციენტების რაოდენობა არ შეიძლება იყოს უარყოფითი.");
                }
                else
                {
                    _registeredPatients = value;
                }
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine("რეგისტრატორი ");
            base.ShowInfo();
            Console.WriteLine($"რეგისტრირებული პაციენტები: {RegisteredPatients}");
        }

        public override void PerformDuty()
        {
            RegisteredPatients++;
            Console.WriteLine($"რეგისტრატორი {FullName} არეგისტრირებს პაციენტს.");
        }

        public override decimal CalculateBonus()
        {
            
            return RegisteredPatients * 5m;
        }
    }
}
