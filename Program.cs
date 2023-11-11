using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            

        }

        public static void Task_1()
        {
            /*
                Задание: Система контроля переплавки меди
            Вам необходимо разработать систему контроля переплавки меди на 
            медеплавильном заводе. Система должна позволять контролировать 
            температуру плавления меди, автоматически регулировать процесс 
            переплавки и предоставлять информацию о текущем состоянии переплавки.

            Требования:
            Создайте класс CopperSmeltingControlSystem, который будет 
            представлять систему контроля переплавки меди. Класс должен иметь 
            следующие основные свойства и методы:

            Свойство IsRunning (тип bool): указывает, запущена ли система 
            контроля переплавки меди.
            Метод Start(): запускает систему контроля.
            Метод Stop(): останавливает систему контроля.
            Событие TemperatureExceededThreshold: возникает, если температура 
            переплавки превысила установленный порог.
            Создайте класс CopperFurnace, представляющий медеплавильную печь. 
            Класс должен иметь следующие основные свойства и методы:

            Свойство Temperature (тип double): текущая температура печи.
            Метод MeltCopper(): запускает процесс переплавки меди в печи.
            Создайте интерфейс ITemperatureSensor, который будет представлять 
            датчик температуры. Интерфейс должен объявлять следующий метод:

            Метод GetTemperature(): возвращает текущую температуру.
            Создайте класс CopperTemperatureSensor, который реализует интерфейс 
            ITemperatureSensor. Класс должен предоставлять возможность 
            получить текущую температуру измерительного прибора.

            Задачи:
            Создайте классы в соответствии с требованиями, описанными выше.

            Реализуйте логику класса CopperSmeltingControlSystem, чтобы 
            система запускалась и останавливалась при вызове соответствующих 
            методов. 
            Когда система запущена, она должна периодически получать текущую 
            температуру измерительного прибора CopperTemperatureSensor и 
            проверять, не превысила ли температура установленный порог. Если 
            температура превысила пороговое значение, необходимо возбудить 
            событие TemperatureExceededThreshold.

            Реализуйте логику класса CopperFurnace для запуска и остановки 
            процесса переплавки меди. При запуске процесса переплавки методом 
            MeltCopper() должна автоматически устанавливаться температура 
            плавления меди и включаться контроль.

            Реализуйте класс CopperTemperatureSensor и метод GetTemperature(), 
            чтобы он возвращал случайное значение температуры в пределах 
            допустимого диапазона.

            Замечания:
            Для генерации случайного значения температуры в классе 
            CopperTemperatureSensor используйте класс Random из стандартной 
            библиотеки C#.

            Для возбуждения и обработки событий используйте делегаты и события.
            */
            CopperSmeltingControlSystem CSCS = new CopperSmeltingControlSystem();
            CSCS.TemperatureExceededThreshold += (o) =>
            Console.WriteLine("Температура плавления превышена " + CSCS.GetTempreture());
            CSCS.Start();
        }

        public static void Task_2()
        {
            /*
                Задание:
            Разработайте простую систему управления сотрудниками для небольшой 
            компании. Система должна поддерживать следующие возможности:

            Создание нового сотрудника с указанием имени, должности и зарплаты.
            Просмотр списка всех сотрудников.
            Увольнение сотрудника по его имени.
            Подсчет общей суммы зарплаты всех сотрудников.
            Подсчет средней зарплаты среди всех сотрудников.
            Поиск сотрудников с зарплатой выше заданного значения.
            Требования:

            Реализуйте необходимые классы (например, Employee, 
            EmployeeManagementSystem и т.д.) с использованием основ ООП.
            Используйте делегаты или события для обработки увольнения сотрудника.
            Используйте лямбды для выполнения поиска сотрудников по критерию 
            зарплаты.
            Реализуйте пользовательский интерфейс (консольный или графический) для 
            взаимодействия с системой управления сотрудниками.
            Представьте ваше решение в виде полноценного проекта, включая все 
            необходимые классы, интерфейсы, методы и демонстрацию работы системы 
            с примерами использования всех функций.
             */
            Random rnd = new Random();
            List<string> list_male_names = new List<string> { "Иван", "Сергей", "Андрей", "Михаил", "Пётр", "Максим", 
                                                              "Евгений", "Дмитрий", "Леонид", "Игорь", "Олег", "Николай" };

            List<string> list_female_names = new List<string> { "Ирина", "Светлана", "Анна", "Мария", "Полина", "Маргарита", 
                                                                "Евгения", "Диана", "Лида", "Инна", "Ольга", "Нина" };

            List<string> list_male_surnames = new List<string> {"Иванов", "Петров", "Сидоров", "Петухов", "Смирнов", "Семёнов", "Григорьев",
                                                                "Тарасов", "Терентьев", "Валынкин", "Зернов", "Тетерин", "Марков", "Пухов", 
                                                                "Ларин", "Борисов", "Белов", "Найденов", "Луконин", "Крылов", "Кротов", 
                                                                "Кудряшов", "Соловьёв", "Солодов", "Филиппов", "Цветков", "Чернов"};

            List<string> list_female_surnames = new List<string> { "Попова", "Полякова", "Волкова", "Викторова", "Бобова", "Карандашова", 
                                                                   "Краснова", "Степанова", "Быкова", "Балашова", "Егорова", "Дружинина", 
                                                                   "Абрамова", "Александрова", "Алексеева", "Воробьёва", "Воронина",
                                                                   "Лебедева", "Ершова", "Медведева", "Прокофьева", "Павлова", "Осипова", 
                                                                   "Денисова", "Козлова", "Ковалёва", "Носкова" };

            List<Employee> employees = new List<Employee>();
            int male = 0;
            for(int i = 0; i < 20; i++)
            {
                male = rnd.Next(2);
                if (male == 0)
                {
                    int numberOfName = rnd.Next(list_female_names.Count());
                    int numberOfSurname = rnd.Next(list_female_surnames.Count());
                    employees.Add(new Employee(list_female_names[numberOfName], 
                                                list_female_surnames[numberOfSurname], 
                                                rnd.Next(50000) + 50000));
                }
                else
                {
                    int numberOfName = rnd.Next(list_male_names.Count());
                    int numberOfSurname = rnd.Next(list_male_surnames.Count());
                    employees.Add(new Employee(list_male_names[numberOfName],
                                                list_male_surnames[numberOfSurname],
                                                rnd.Next(50000) + 50000));
                }
            }

            
            int choice = 0;
            EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();
            do
            {
                Console.WriteLine("Меню для управления сотрудниками: ");
                Console.WriteLine("1. Создание нового сотрудника.");
                Console.WriteLine("2. Просмотр списка сотрудников.");
                Console.WriteLine("3. Увольнение сотрудника по Имени и Фамилии.");
                Console.WriteLine("4. Подсчёт суммарной зарплаты всех сотрудников.");
                Console.WriteLine("5. Подсчёт средней зарплаты всех сотрудников.");
                Console.WriteLine("6. Поиск сотрудников с зарплатой выше заданного.");
                Console.WriteLine("7. Выход.");
                Console.Write("Введите номер меню: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    employees.Add(employeeManagementSystem.AddEmployee());
                }
                else if(choice == 2)
                {
                    employeeManagementSystem.PrintAllEmployees(employees);
                }
                else if(choice == 3)
                {
                    employeeManagementSystem.DismissalOfEmployee(employees);
                }
                else if(choice == 4)
                {
                    employeeManagementSystem.SummarySalary(employees);
                }
                else if(choice == 5)
                {
                    employeeManagementSystem.AverageSalary(employees);
                }
                else if(choice == 6)
                {
                    employeeManagementSystem.PrintAllEmployees(employeeManagementSystem.SearchEmployeesBySalaryLevel(employees));
                }
                else if(choice == 7)
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }
    }
}
