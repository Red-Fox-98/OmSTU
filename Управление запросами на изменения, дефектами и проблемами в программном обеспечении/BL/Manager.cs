using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Manager : Employee
    { 
        private int constantlySalary = 25000;
        private int bonusPerTrade = 1500;
        private int valueOfSales;

        public int ValueOfSales { get => valueOfSales; set => valueOfSales = value; }

        public Manager(string surname, string firstName, string patronymic, int valueOfSales) : base(surname, firstName, patronymic)
        {
            this.ValueOfSales = valueOfSales;
        }

        public double PayrollToManager()
        {
            return constantlySalary + (ValueOfSales * bonusPerTrade);
        }
    }
}