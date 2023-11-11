using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_15
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, decimal salary)
        {
            Name=name;
            Surname=surname;
            Salary=salary;
        }

        public override string ToString()
        {
            return "Имя: " + Name + ", Фамилия: " + Surname + ", Зарплата: " + Salary;
        }
    }
}
