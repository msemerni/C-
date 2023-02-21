using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekundomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Секундомер";
            int choise;
            do
            {
                Console.Clear();
                Console.WriteLine("Старт:\t1");
                Console.WriteLine("Стоп:\t2");
                Console.WriteLine("Сброс:\t3");
                Console.WriteLine();
                do
                {
                    Console.Write("Нажмите: 1-Старт: ");
                    choise = Convert.ToInt32(Console.ReadLine());
                }
                while (choise != 1);
                    Console.WriteLine("\nСекундомер включен");
                    DateTime startTime = DateTime.Now;
                    Console.WriteLine(startTime);
                    Console.WriteLine();
                //////////
                int count = 0;
                do
                {
                    do
                    {
                        Console.Write("Нажмите: 2-Стоп / 3-Сброс: ");
                        choise = Convert.ToInt32(Console.ReadLine());
                    }
                    while (choise != 2 && choise != 3); 
                        DateTime stopTime = DateTime.Now;
                        TimeSpan difference = stopTime - startTime;
                        count++;

                    Console.WriteLine("\n{0} результат: {1}", count, difference.ToString(@"hh\:mm\:ss\:fff"));
                    //// ТАК НЕ РАБОТАЕТ: ???????
                    ////Console.WriteLine("\n{0} результат: {1:dd.hh:mm:ss.ff}", count, difference);
                    ////Console.WriteLine("\n{0} результат: {1:ss.ff}", count, difference.Seconds);

                }
                while (choise == 2);
            }
            while (choise == 3);

            Console.ReadKey();


            //////////////////////////////////////////////////////////////////////////////////
            //// мой первый вариант:
            //int choise;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Старт:\t1");
            //    Console.WriteLine("Стоп:\t2");
            //    Console.WriteLine("Сброс:\t3");
            //    Console.WriteLine();
            //    do
            //    {
            //        Console.Write("Нажмите: 1-Старт: ");
            //        choise = Convert.ToInt32(Console.ReadLine());
            //    }
            //    while (choise != 1);
            //    Console.WriteLine("\nСекундомер включен");
            //    DateTime startTime = DateTime.Now;
            //    Console.WriteLine(startTime);
            //    Console.WriteLine();
            //    //////////
            //    int count = 0;
            //    do
            //    {
            //        Console.Write("Нажмите: 2-Стоп / 3-Сброс: ");
            //        choise = Convert.ToInt32(Console.ReadLine());
            //        DateTime stopTime = DateTime.Now;
            //        TimeSpan difference = stopTime - startTime;
            //        count++;
            //        ///:dd.hh:mm:ss.ff ?????????
            //        Console.WriteLine("\n{0} результат: {1}", count, difference);
            //    }
            //    while (choise == 2);
            //}
            //while (choise == 3);

            //Console.ReadKey();



            /////////////////////////////////////////////////////////////////
            ///////////  будет попытка неправильного ввода всех символов кроме 1, 2, 3...
            //string choise;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Старт:\t1");
            //    Console.WriteLine("Стоп:\t2");
            //    Console.WriteLine("Сброс:\t3");
            //    Console.WriteLine();
            //    do
            //    {
            //        Console.Write("Нажмите: 1-Старт: ");
            //        choise = (Console.ReadLine());
            //    }
            //    while (choise != 1);
            //    Console.WriteLine("\nСекундомер включен");
            //    DateTime startTime = DateTime.Now;
            //    Console.WriteLine(startTime);
            //    Console.WriteLine();
            //    //////////
            //    int count = 0;
            //    do
            //    {
            //        do
            //        {
            //            Console.Write("Нажмите: 2-Стоп / 3-Сброс: ");
            //            choise = Convert.ToInt32(Console.ReadLine());

            //            if (choise != 2 && choise != 3)
            //            {
            //                Console.WriteLine("Некорректный ввод !");
            //            }

            //        }
            //        while (choise != 2 && choise != 3);

            //        DateTime stopTime = DateTime.Now;
            //        TimeSpan difference = stopTime - startTime;
            //        count++;

            //        Console.WriteLine("\n{0} результат: {1}", count, difference.ToString(@"hh\:mm\:ss\:fff"));
            //        //// ТАК НЕ РАБОТАЕТ: ???????
            //        ////Console.WriteLine("\n{0} результат: {1:dd.hh:mm:ss.ff}", count, difference);
            //    }
            //    while (choise == 2);
            //}
            //while (choise == 3);

            //Console.ReadKey();




        }
    }
}
