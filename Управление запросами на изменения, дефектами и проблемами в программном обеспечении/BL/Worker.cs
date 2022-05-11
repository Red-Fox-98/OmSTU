using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Worker : Employee
    {
        private double hourOfWork = 150;
        private double hours;

        public double HourOfWork { get => hourOfWork; set => hourOfWork = value; }
        public double Hours { get => hours; set => hours = value; }

        public Worker(string surname, string firstName, string patronymic, double hours) : base(surname, firstName, patronymic)
        {
            this.hours = hours;
        }

        public double PayrollToWorker()
        {
            double fullSalary = hourOfWork * 128;
            double result = 0;
            if (hours > 128)
            {
                result = fullSalary + (hours * (hourOfWork * 2));
            }
            if (hours <= 128)
            {
                result = hours * hourOfWork;
            }
            return result;
        }
    }
}