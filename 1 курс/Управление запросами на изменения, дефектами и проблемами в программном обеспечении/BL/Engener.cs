using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Engener : Employee
    {
        private int constantlySalary = 25000;
        private int premium = 15000;
        private string availabilityOfAPremium;

        public string AvailabilityOfAPremium { get => availabilityOfAPremium; set => availabilityOfAPremium = value; }
        public Engener(string surname, string firstName, string patronymic, string availabilityOfAPremium) : base(surname, firstName, patronymic)
        {
            this.availabilityOfAPremium = availabilityOfAPremium;
        }

        public double PayrollToEngineer()
        {
            double result = 0;
            if (availabilityOfAPremium == "+")
            {
                result = constantlySalary + premium;
            }
            if (availabilityOfAPremium == "-")
            {
                result = constantlySalary;
            }
            return result;
        }
    }
}