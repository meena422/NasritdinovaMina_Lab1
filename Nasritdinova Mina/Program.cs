using System;

namespace EmployeeLab
{
    // Описание класса Employee (Сотрудник)
    public class Employee
    {
        // 1. Открытые поля для хранения ФИО и зарплаты
        public string FullName = string.Empty;
        public double Salary;

        // 2. Метод Show() – показать на экране данные о служащем
        public void Show()
        {
            Console.WriteLine($"Сотрудник: {FullName}");
            Console.WriteLine($"Зарплата в месяц: {Salary} руб.");
        }

        // 3. Метод расчета годовой зарплаты = зарплата * 12
        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. В методе Main() нужно создать объект класса Employee
            Employee emp = new Employee();

            // 2. Задать свойствам объекта следующие значения: ФИО = Иванов, зарплата = 63500
            emp.FullName = "Иванов";
            emp.Salary = 63500;

            // 3. Вывести на экран данные, хранящиеся в объекте
            emp.Show();

            // 4. Рассчитать годовой размер зарплаты сотрудника и вывести на печать
            double annualSalary = emp.CalculateAnnualSalary();
            Console.WriteLine($"Годовая зарплата: {annualSalary} руб.");

            // Чтобы консоль не закрылась сразу
            Console.ReadKey();
        }
    }
}
