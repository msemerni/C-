using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOne
{
    class Program
    {
        ////________________________________________Главная панель выбора задачи________________________
        static void Main(string[] args)
        {
            string finalChoice;
            do
            {
                Console.Clear();
                Console.WriteLine(@"Введите номер задачи:
1. Расчёт количества положительных чисел, отрицательных и нулей из заданных
2. Вывод всех чисел от 1 до 100, кратных заданному числу
3. Определение количества цифр в числе, max и min цифры в числе
4. Квадраты чисел от 10 до 20 включительно
5. Нахождение максимального и минимального числа из 5-ти введённых
6. Расчёт деления амёбы за 24 часа
7. Расчёт денежного вклада на депозит
8. Цифры от 20 до 50, которые делятся на 3, но не делятся на 5
9. Преобразование цифр числа в обратном порядке");

            Console.WriteLine();
            Console.Write("Задача #: ");

                int nomerZadachi;
                //int nomerZadachi = Int32.Parse(Console.ReadLine());
                bool incorChoice = Int32.TryParse(Console.ReadLine(), out nomerZadachi);

                switch (nomerZadachi)
            {
                case 1:
                    CountPosNegZeroNumbers();
                    break;
                case 2:
                    DivideNumberToN();
                    break;
                case 3:
                    CountQuantityOfDigitsAndMinMaxDigit();
                    break;
                case 4:
                    OutputNumberSquare();
                    break;
                case 5:
                    FindMaxMinNumber();
                    break;
                case 6:
                    CountOfAmyoba();
                    break;
                case 7:
                    CountDeposit();
                    break;
                case 8:
                    DelenieNa3NoNeNa5();
                    break;
                case 9:
                    ReverseNumber();
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
        static void CountPosNegZeroNumbers()
        {
            //С клавиатуры вводятся n чисел.Составьте программу, которая определяет кол-во 
            //отрицательных, кол - во положительных и кол - во нулей
            Console.Title = "Расчёт количества положительных чисел, отрицательных и нулей из заданных";
            Console.WriteLine("Расчёт количества положительных чисел, отрицательных и нулей из заданных");

            int countPos = 0;
            int countNeg = 0;
            int countZero = 0;

            Console.Write("Введите количество чисел: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите числа:");
            for (int i = 0; i < n; i++)
            {
                int chislo = Int32.Parse(Console.ReadLine());

                if (chislo > 0)
                    countPos += 1;
                else if (chislo < 0)
                    countNeg += 1;
                else
                    countZero += 1;
            }
            Console.WriteLine("\nВсего чисел: {0}", n);
            Console.WriteLine("\nПоложительных чисел: {0}, отрицательных: {1}, нулей: {2}", countPos, countNeg, countZero);

            Console.ReadKey();

        }

        //////________________________________________Задача_2____________________________________________
        static void DivideNumberToN()
        {
            //Вывести все двухзначные числа от 1 до 100 кратные N
            Console.Title = "Вывод всех чисел от 1 до 100, кратных заданному числу";
            Console.WriteLine("Вывод всех чисел от 1 до 100, кратных заданному числу\n");
            Console.Write("Введите делитель: ");

            int delitel = Convert.ToInt32(Console.ReadLine());
            int i;

            Console.WriteLine("Числа от 1 до 100, кратные {0}: ", delitel);
            for (i = 1; i <= 100; i++)
            {
                if (i % delitel == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }


        ////________________________________________Задача_3____________________________________________
        static void CountQuantityOfDigitsAndMinMaxDigit()
        {
            //   3) Пользователь вводит число.
            //3.1) Определить количество цифр в числе
            //3.2) Найти минимальную и максимальную цифру в числе
            Console.Title = "Определение количества цифр в числе, max и min цифры в числе";
            Console.WriteLine("Определение количества цифр в числе, max и min цифры в числе\n");
            Console.Write("Введите число: ");

            int number = Int32.Parse(Console.ReadLine());
            int count = 1;
            int max = 0;
            int min = 9;
            int mid = 0;
            while (number / 10 > 0)
            {
                mid = number % 10;
                if (max < mid)
                    max = mid;
                if (mid < min)
                    min = mid;
                number /= 10;
                count++;
            }
            if (max < number)
                max = number;
            if (number < min)
                min = number;
            Console.WriteLine("\nКоличество цифр в числе: " + count);
            Console.WriteLine("Максимальная цифра в числе: " + max);
            Console.WriteLine("Минимальная цифра в числе: " + min);

            Console.ReadKey();
        }

        ////________________________________________Задача_4____________________________________________
        static void OutputNumberSquare()
        {
            //Составьте программу, выводящую на экран квадраты чисел от 10 до 20 включительно.
            Console.Title = "Квадраты чисел от 10 до 20 включительно";
            Console.WriteLine("Квадраты чисел от 10 до 20 включительно:\n");

            for (int i = 10; i <= 20; i++)
                Console.WriteLine("Квадрат числа {0} равен {1} ", i, i * i);

            Console.ReadKey();
        }

        ////________________________________________Задача_5____________________________________________
        static void FindMaxMinNumber()
        {
            //Пользователь вводит 5 чисел. Найти max из введенных чисел
            Console.Title = "Нахождение максимального и минимального числа из 5-ти введённых";
            Console.WriteLine("Нахождение максимального и минимального числа из 5-ти введённых.\n");
            Console.WriteLine("Введите 5 целых чисел:");

            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int number;

            //Первый вариант:
            for (int i = 0; i < 5; i++)
            {
                number = Int32.Parse(Console.ReadLine());
                if (max < number)
                    max = number;
                if (min > number)
                    min = number;
            }
            Console.WriteLine("\nМаксимальное число: " + max);
            Console.WriteLine("\nМинимальное число: " + min);
            Console.ReadKey();
        }
        ////________________________________________Задача_6____________________________________________
        static void CountOfAmyoba()
        {
            //Одноклеточная амеба каждые 3 часа делится на 2 клетки. 
            //Определить, сколько амеб будет через 3, 6, 9, 12,..., 24 часа.
                Console.WriteLine("\nРасчёт деления амёбы за 24 часа:\n");
                int ameba = 1;
                for (int hour = 3; hour <= 24; hour += 3)
                {
                    ameba *= 2;
                    Console.WriteLine("Через\t {0} ч.\t амёб будет\t {1}\n", hour, ameba);
                }
                Console.ReadKey();
         }
        ////________________________________________Задача_7____________________________________________
        static void CountDeposit()
        {
            //В банк на P-процентный вклад положили S гривен. 
            //Какой станет сумма вклада через N лет.

            Console.Title = "Расчёт денежного вклада на депозит";
            Console.WriteLine("Расчёт денежного вклада на депозит\n");

            Console.WriteLine("Введите процент денежного вклада: ");
            decimal P = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму вклада: ");
            decimal S = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество лет вклада: ");
            int N = Int32.Parse(Console.ReadLine());

            string year;
            decimal money = S;
            int lastNumber = N % 10;

            if (lastNumber == 2 || lastNumber == 3 || lastNumber == 4)
            {
                year = "года";
            }
            else if (lastNumber == 1)
            {
                year = "год";
            }
            else
            {
                year = "лет";
            }

            for (int i = 0; i < N; i++)
                S = S + (S * (P / 100));
            decimal pribil = (S - money);

            Console.WriteLine("\nСумма вклада через {0} {1} составит: {2:#.##} грн.", N, year, S);
            Console.WriteLine("\nПрибыль за {0} {1} составит: {2:#.##} грн.", N, year, pribil);

            Console.ReadKey();
        }

        ////________________________________________Задача_8____________________________________________
        static void DelenieNa3NoNeNa5()
        {
            //Даны натуральные числа от 20 до 50.
            //Напечатать те из них, которые делятся на 3, но не делятся на 5.

            Console.Title = "Числа от 20 до 50, которые делятся на 3, но не делятся на 5";
            Console.WriteLine("Числа от 20 до 50, которые делятся на 3, но не делятся на 5:\n");

            for (int i = 20; i <= 50; i++)
                if ((i % 3 == 0) && (i % 5 != 0))
                    Console.WriteLine(i);

            Console.ReadKey();
        }
        ////________________________________________Задача_9____________________________________________
        static void ReverseNumber()
        {
            //Вводится число. Преобразовать его в другое число, 
            //цифры которого будут следовать в обратном порядке.
            //Вывод числа в память компа, не только на экран (как было в ChisloVObratnomPoryadke)

            Console.Title = "Преобразование цифр числа в обратном порядке.\n";
            Console.WriteLine("Преобразование цифр числа в обратном порядке.\n");
            Console.Write("Введите целое число:\t");

            int number = Int32.Parse(Console.ReadLine());
            int reversNumber = 0;

            do
            {
                reversNumber *= 10;
                reversNumber += (number % 10);

                number /= 10;
            }
            while (number != 0);

            ////Как сделать, чтобы выводились ноли до и после в результате????????????????????????????????????
            Console.WriteLine("\nРезультат:\t\t{0}", reversNumber);

            Console.ReadKey();
        }
    }
}
