using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////Вызов консруктора: Поэтому надо new.
            ////DateTime date1 = new DateTime(2016, 10, 1);
            ////Console.WriteLine(DateTime.Now);

            ////Вызов структуры DateTime: Поэтому new не надо.
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Today;
            DateTime date3 = DateTime.UtcNow;

            ////Можно вытягивать что надо (в данном случае из date1):
            Console.WriteLine(date1.Year);
            Console.WriteLine(date1.Hour);

            ////Вывод на экран:
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);


            ////TimeSpan:
            //DateTime timeSpan = new timeSpan();

            ////DateTimeOffset:
            DateTimeOffset date5 = DateTimeOffset.Now;
            Console.WriteLine(date5);


            ////в другом формате отображение:
            ////такое есть только у DateTime !!!
            ///т.е. ToString переводит дату в строку?
            Console.WriteLine();

            DateTime date6 = DateTime.Now;
            Console.WriteLine(date6.ToShortDateString());
            Console.WriteLine(date6.ToShortTimeString());
            Console.WriteLine(date6.ToLongDateString());
            Console.WriteLine(date6.ToLongTimeString());


            ////выбрать отображение даты: (преобразование с помощью ToString):
            Console.WriteLine();
            DateTime date7 = DateTime.Now;
            Console.WriteLine(date7.ToString("IFormatProvider"));
            Console.WriteLine(date7.ToString("yyyy-*-mm-*-dd"));

            ////Вычитание дат:
            DateTime date8 = DateTime.Now;
            //DateTime date10 = DateTime.Now;
            Console.WriteLine("Введите год, месяц и дату рождения в формате: гггг,мм,дд");
            string dateTime = Console.ReadLine();
            DateTime date10 = Convert.ToDateTime(dateTime);

            ////можно так:
            //TimeSpan difference = date8.Subtract(date10);
            ////или так:
            TimeSpan difference2 = date8 - date10;

            Console.WriteLine("\nНа данный момент Вы прожили:\n\nДней: {0:#.##}", difference2.TotalDays);
            Console.WriteLine("В часах: {0:#.##}", difference2.TotalHours);
            Console.WriteLine("В минутах: {0:#.##}", difference2.TotalMinutes);
            Console.WriteLine("В секундах: {0:#.##}", difference2.TotalSeconds);

            Console.ReadKey();
        }
    }
}
