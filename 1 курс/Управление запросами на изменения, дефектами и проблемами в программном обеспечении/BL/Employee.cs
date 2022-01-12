using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Employee
    {
        private string firstName;
        private string surname;
        private string patronymic;
        private DateTime dateOfBirth;

        public string FirstName { get => firstName; set => firstName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        
        public Employee() { }

        public Employee(string surname, string firstName, string patronymic)
        {
            this.surname = surname;
            this.firstName = firstName;
            this.patronymic = patronymic;
        }
        
        public string FullNameOutput()
        {
            return surname + " " + firstName[0] + "." + patronymic[0] + ".";
        }
    }
}