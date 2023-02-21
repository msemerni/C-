using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_Long_You_live
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор жизни";

            string choise = "Н";
            do
            {
                Console.Clear();

                Console.WriteLine("Пожалуйста, представьтесь:\n");
                string name = Console.ReadLine();
                Console.WriteLine("\nЗдравствуйте, {0} !", name);

                DateTime dateNow = DateTime.Now;
                Console.WriteLine("\nВведите год, месяц и дату своего рождения в формате: гггг,мм,дд\n");
                string dateTime = Console.ReadLine();
                DateTime dateStart = Convert.ToDateTime(dateTime);

                TimeSpan difference2 = dateNow - dateStart;

                int compMonth = (dateNow.Month + dateNow.Year * 12) - (dateStart.Month + dateStart.Year * 12);
                double daysInEndMonth = (dateNow - dateNow.AddMonths(1)).Days;
                double months = compMonth + (dateStart.Day - dateNow.Day) / daysInEndMonth;

                Console.WriteLine("\n{0}, на данный момент Вы прожили:\n\nДней: {1:#.##}", name, difference2.TotalDays);
                Console.WriteLine($"Месяцев: {months:#.##}");
                Console.WriteLine("\nЧто составляет:");
                Console.WriteLine("В часах: {0:#.##}", difference2.TotalHours);
                Console.WriteLine("В минутах: {0:#.##}", difference2.TotalMinutes);
                Console.WriteLine("В секундах: {0:#.##}", difference2.TotalSeconds);

                Console.Write("\nБудете еще рассчитывать кого-то? (Д/Н) ");
                choise = Console.ReadLine().ToUpper();
            }
            while (choise == "Д");

            Console.WriteLine("\nПока! До новых встреч !\nP.S. Всем привет !");

            Console.ReadKey();
        }
    }
}
