using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_15
{
    internal class EmployeeManagementSystem
    {
        public Employee AddEmployee()
        {
            Console.Write("Введите фамилию работника: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя работника: ");
            string name = Console.ReadLine();
            Console.Write("Введите зарплату: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            return new Employee(name, surname, salary);
        }

        public void PrintAllEmployees(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        public void DismissalOfEmployee(List<Employee> employees)
        {
            PrintAllEmployees(employees);
            Console.Write("Введите фамилию работника: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя работника: ");
            string name = Console.ReadLine();
            for(int i = 0; i < employees.Count(); i++)
            {
                if (employees[i].Name == name && employees[i].Surname == surname) 
                {
                    employees.Remove(employees[i]);
                    Console.WriteLine("Сотрудник " + name + " " + surname + " удалён из списка.");
                    return;
                }
            }
            Console.WriteLine("Сотрудник " + name + " " + surname + " не найден в списке.");
            return;
        }

        public decimal SummarySalary(List<Employee> employees)
        {
            decimal total = employees.Sum(emp => emp.Salary);
            return total;
        }

        public decimal AverageSalary(List<Employee> employees)
        {
            return employees.Average(emp => emp.Salary);
        }

        public List<Employee> SearchEmployeesBySalaryLevel(List<Employee> employees)
        {
            List<Employee> result = new List<Employee>();
            Console.Write("Введите размер зарплаты: ");
            decimal levelOfSalary = decimal.Parse(Console.ReadLine());
            return employees.FindAll(emp => emp.Salary >= levelOfSalary).ToList();
        }

    }
}
