using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalChoice;
            do
            {
                Console.Clear();
                Console.WriteLine(@"Введите номер задачи:
1. Увеличить  введённое число на 10 и вывести на экран.
2. Найти сумму ряда чисел от 1 до n.
3. Найти расстояние по прямой между точками.
4. Определить какой четверти принадлежит точка.");

                Console.WriteLine();
                Console.Write("Задача #: ");

                int nomerZadachi;
                bool incorChoice = Int32.TryParse(Console.ReadLine(), out nomerZadachi);

                switch (nomerZadachi)
                {
                    case 1:
                        NumberMultiply10();
                        break;
                    case 2:
                        SumOfNumbers();
                        break;
                    case 3:
                        Coordinates();
                        break;
                    case 4:
                        Quaters();
                        break;
                    default:
                        if (incorChoice == false || nomerZadachi <= 0)
                        {
                            Console.WriteLine("Некорректный ввод !");
                        }
                        else
                        {
                            Console.WriteLine("Такой задачи нет !");
                        }
                        break;
                }
                Console.WriteLine("\nЖелаете повторить выбор задачи? y - да, n - нет");
                do
                {
                    finalChoice = Console.ReadLine();
                    if (finalChoice != "y" && finalChoice != "n")
                    {
                        Console.WriteLine("Некорректный ввод ! Введите y или n.");
                    }
                } while (finalChoice != "y" && finalChoice != "n");
            } while (finalChoice == "y");
            Console.WriteLine("\nДо свидания!");
            Console.ReadKey();
        }


        ////________________________________________Задача_1____________________________________________
        ////1) Пользователь вводит целое число из консоли. Умножить число на 10 и вывести на экран.

        static void NumberMultiply10()
        {
            try
            {
                Console.Write("Введите число: ");
                int number = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введенное число, умноженное на 10 равняется: {0}", number * 10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка! Введите число!");
            }
            Console.ReadKey();
        }
        ////________________________________________Задача_2____________________________________________
        ////Найти сумму ряда чисел от 1 до n. n - целое положительное число вводиться пользователем в консоли. 
        //// Если n - не удовлетворяет условию - вывести сообщение об ошибке.
        static void SumOfNumbers()
        {
            Console.Write("Введите число: ");
            try
            {
                int number = Int32.Parse(Console.ReadLine());

                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }

                Console.WriteLine("Сумма чисел от 1 до {0} составляет: {1}", number, sum);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка! Введите число!");
            }

            Console.ReadKey();

        }

        ////________________________________________Задача_3____________________________________________
        ////3) Пользователь из консоли вводит координаты x и y двух точек.Найти расстояние по прямой между этими точками.
        static void Coordinates()
        {

            Console.Write("Введите координату Х первой точки: ");
            double x1 = Double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y первой точки ");
            double y1 = Double.Parse(Console.ReadLine());

            Console.Write("Введите координату Х второй точки: ");
            double x2 = Double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y второй точки ");
            double y2 = Double.Parse(Console.ReadLine());

            double measure = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками составляет: {0}", measure);

            Console.ReadKey();

        }
        ////________________________________________Задача_4____________________________________________
        ////Пользователь из консоли вводит координаты x и y точки.
        ////Определить какой четверти принадлежит точка.
        ////Обработать результат когда точка имеет координаты 0.0
        static void Quaters()
        {

            Console.Write("Введите координату Х: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y: ");
            double y = Double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в четверти: I");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится в четверти: II");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в четверти: III");
            }
            else
            {
                Console.WriteLine("Точка находится в четверти: IV");
            }
        }

    }
 }
