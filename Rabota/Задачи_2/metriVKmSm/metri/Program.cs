using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Перевод метров в КМ или СМ";
            Console.WriteLine("Перевод метров в КМ или СМ\n");
            Console.WriteLine("Введите количество метров");
            double metri = Double.Parse(Console.ReadLine());


            ////Программа с циклом. Первый вариант.
            int choise;
            do
            {
                Console.WriteLine("Единицы измерения: 1- KM, 2-СМ");
                choise = Int32.Parse(Console.ReadLine());
                if (choise == 1)
                {
                    Console.WriteLine(metri / 1000 + " Км");
                    break;
                }
                else if (choise == 2)
                {
                    Console.WriteLine(metri * 100 + " См");
                    break;
                }
                else
                    Console.WriteLine("Нужно выбрать 1 или 2");
            }
            while (choise != 1 || choise != 2);

            Console.ReadLine();

            ////Программа с циклом. Второй вариант.
            //int choise;
            //do
            //{
            //    Console.WriteLine("Единицы измерения: 1- KM, 2-СМ");
            //    choise = Int32.Parse(Console.ReadLine());
            //    if (choise == 1 || choise == 2)
            //    {
            //        if (choise == 1)
            //            Console.WriteLine(metri / 1000 + " Км");
            //        else if (choise == 2)
            //            Console.WriteLine(metri * 100 + " См");
            //        break;
            //    }
            //    else
            //        Console.WriteLine("Нужно выбрать 1 или 2");
            //}
            //while (choise != 1 || choise != 2);

            //Console.ReadKey();


            ////Программа без цикла:
            //Console.WriteLine("Единицы измерения: 1- KM, 2-СМ");
            //int choise = Int32.Parse(Console.ReadLine());
            //if (choise == 1)
            //    Console.WriteLine(metri / 1000 + " Км");
            //else if (choise == 2)
            //    Console.WriteLine(metri * 100 + " См");
            //else
            //    Console.WriteLine("Нужно выбрать 1- KM или 2-СМ");

            //    Console.ReadLine();








        }
    }
}





//int number;
//   do
//   {
//      Console.WriteLine("Введите число 5");
//      number = Convert.ToInt32(Console.ReadLine());
//   }
//   while (number != 5); 