using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_120217
{
    ////Объявить базовый класс Employee.Класс содержит поле name и абстрактный метод CalculateSalary().
    ////Объявить два класса наследника: 
    ////1) Worker - класс содержит поле yearSalary и реализует метод CalculateSalary(). 
    ////Метод должен выводить на экран имя сотрудника и месячную зарплату(yearSalary/12)
    ////2) HourlyWorker -  класс содержит поля rate и hours и реализует метод CalculateSalary(). 
    ////Метод должен выводить на экран имя сотрудника и количество денег для выплаты(rate* hours)
    class Program
    {
        static void Main(string[] args)
        {
            List <Employee> employeesW = new List <Employee>();
            employeesW.Add(new Worker("Миша", 246500));
            employeesW.Add(new Worker("Ира", 231700));

            List <Employee> employeesHW = new List <Employee>();
            employeesHW.Add(new HourlyWorker("Андрей", 300, 10.8));
            employeesHW.Add(new HourlyWorker("Надя", 250.5, 15.2));

            Console.WriteLine("Workers:");
            foreach (var emp in employeesW)
            {
                emp.CalculateSalary();
            }

            Console.WriteLine("\nHourly Workers:");
            foreach (var emp in employeesHW)
            {
                emp.CalculateSalary();
            }

            Console.ReadKey();
        }
    }
}
