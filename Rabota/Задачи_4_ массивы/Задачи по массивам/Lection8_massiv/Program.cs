using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection8_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"Введите номер задачи:
1. Найти максимальный элемент массива из 5-ти элементов
2. Определить кол-во элементов в массиве, отличающихся от минимального на 5
3. Найти сумму элементов, расположенных до максимального элемента массива
4. Значение и номер последнего отрицательного элемента массива размером 8
5. Заменить все элементы массива после максимального средним значением");

            Console.WriteLine();
            Console.Write("Задача #: ");

            int nomerZadachi = Int32.Parse(Console.ReadLine());

            switch (nomerZadachi)
            {
                case 1:
                    FindMaxInArray();
                    break;
                case 2:
                    FindElementsDiffersOnFiveInArray();
                    break;
                case 3:
                    FindSumTillMaxElement();
                    break;
                case 4:
                    FindValueAndPositionLastNegElement();
                    break;
                case 5:
                    ChangeAllValuesAfterMaxToAverage();
                    break;
                default:
                    Console.WriteLine("Такой задачи нет !");
                    Console.ReadKey();
                    break;
            }
        }

        ////________________________________________Задача_1___________________________________________
        //Пользователь вводит массив из 5 элементов.
        //1) Найти максимальный элемент массива. Вывести на экран элементы массива и максимум.

        static void FindMaxInArray()
        {
            Console.Title = "Определение максимального числа в массиве из введённого";
            Console.WriteLine("Определение максимального числа в массиве из введённого\n");

            Console.WriteLine("Введите пять элементов массива");

            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} элемент массива: " ,i);
                array[i] = Int32.Parse(Console.ReadLine());

                if (max < array[i])
                    max = array[i];
                if (min > array[i])
                    min = array[i];
            }

            Console.WriteLine("\nВсе элементы массива: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            ////или так лучше??:
            //foreach (int i in array)
            //    Console.WriteLine(i);

            Console.WriteLine();
            
            int rank = array.Rank;
            Console.WriteLine("\nРазмерность массива: {0}", rank);

            Console.WriteLine("\nКоличество элементов массива: {0}", array.Length);
            ////или можно так:
            //int arrayLength = array.Length;
            //Console.WriteLine("\nКоличество элементов массива: {0}", arrayLength);

            Console.WriteLine("\nМаксимальное значение в массиве: {0}", max);
            ////или можно так - так проще:
            //int maxValue = array.Max();
            //Console.WriteLine("\nМаксимальное значение в массиве: {0}", maxValue);
            ////А так еще проще
            Console.WriteLine("\nМаксимальное значение в массиве: {0}", array.Max());

            Console.WriteLine("\nМинимальное значение в массиве: {0}", min);
            ////или можно так - так проще:
            //int minValue = array.Min();
            //Console.WriteLine("\nМинимальное значение в массиве: {0}", minValue);
            ////А так еще проще
            Console.WriteLine("\nМинимальное значение в массиве: {0}", array.Min());

            //Array.Reverse(array);
            Array.Sort(array);

            Console.WriteLine("\nВсе новые элементы массива: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();

            Console.ReadKey();
        }

        ////________________________________________Задача_2___________________________________________
        //2) Определить количество элементов в заданном массиве, отличающихся от минимального на 5.
        //   Размер массива пользователь вводит в консоли

        static void FindElementsDiffersOnFiveInArray()
        {
            Console.Title = "Определить количество элементов в массиве, отличающихся от минимального на 5";
            Console.WriteLine("Определить количество элементов в массиве, отличающихся от минимального на 5\n");

            //////int min = Int32.MaxValue;
            int countDifferOnFive = 0;
            Console.Write("Введите размер одномерного массива: ");
            int razmerMas = Int32.Parse(Console.ReadLine());

            int[] array = new int[razmerMas];
            for (int i = 0; i < razmerMas; i++)
            ////Так лучше ниписать: ???
            //for (int i = 0; i < array.Length; i++) - так больше нагрузка
            {
                Console.Write("{0} элемент массива: ", i);
                array[i] = Int32.Parse(Console.ReadLine());

                //////if (min > array[i])
                //////    min = array[i];

                //if (i <= min + 5)
                //    countDifferOnFive++;
            }
            foreach (int number in array)
            {
                if (number == array.Min() + 5)
                    countDifferOnFive++;
            }
            ////////Console.WriteLine("\nМинимальное значение в массиве: {0}", min);

            Console.WriteLine("\nМинимальное значение в массиве: {0}", array.Min());
            Console.WriteLine("\nКоличество элементов в массиве, отличающихся от минимального на 5: {0}", countDifferOnFive);

            Console.ReadKey();

        }

            ////________________________________________Задача_3___________________________________________
            //3) Дан одномерный массив, размер массива задается пользователем из консоли. 
            //Найти сумму элементов, расположенных до максимального элемента массива. 
            //Если максимальных элементов несколько - то найти сумму элементов до первого максимального элемента. 
            //Если максимальный элемент первый в массиве - то сумма равна 0
        
        static void FindSumTillMaxElement()
        {
            Console.Title = "Найти сумму элементов, расположенных до максимального элемента массива";
            Console.WriteLine("Найти сумму элементов, расположенных до максимального элемента массива\n");

            Console.Write("Введите размер одномерного массива: ");
            int razmerMas = Int32.Parse(Console.ReadLine());

            int[] array = new int[razmerMas];
            for (int i = 0; i < razmerMas; i++)
            {
                Console.Write("{0} элемент массива: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            int sum = 0;
            //int max = array.Max();
            //int indexMax = Array.IndexOf(array, max);
            int indexMax = Array.IndexOf(array, array.Max());

            Console.WriteLine("\nМаксимальное значение находится на позиции: {0}", indexMax);

            for (int i = 0; i < indexMax; i++)
            {
                if (indexMax == 0)
                {
                    sum = 0;
                    //здесь же надо break вставить, чтобы не считало дальше???? ДА! меньше нагрузка
                    break;
                }
                else
                {
                    sum += array[i];
                }
            }

            Console.WriteLine("\nСумма элементов, расположенных до максимального элемента массива: {0}", sum);

            Console.ReadKey();
        }

        ////________________________________________Задача_4___________________________________________
        //4) Определить значение и номер последнего отрицательного элемента массива размером 8. 
        //Если отрицательных элементов нет - вывести соответствующее сообщение.

        static void FindValueAndPositionLastNegElement()
        {

            Console.Title = "Значение и номер последнего отрицательного элемента массива размером 8";
            Console.WriteLine("Значение и номер последнего отрицательного элемента массива размером 8\n");

            int negNumber = 0;
            int value = 0;
            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} элемент массива: ", i);
                array[i] = Int32.Parse(Console.ReadLine());

                if (array[i] < 0)
                {
                    negNumber = i;
                    value = array[i];
                }
            }

            Console.WriteLine("\nНомер последнего отрицательного элемента массива: {0}", negNumber);
            Console.WriteLine("\nЗначение последнего отрицательного элемента массива: {0}", value);
            Console.ReadKey();
        }

        ////________________________________________Задача_5___________________________________________
        //5) В одномерном массиве все элементы, расположенные после максимального, 
        //  заменить средним значением элементов массива. 
        //  Вывести обновленный массив на экран. Размер массива указывается пользователем

        static void ChangeAllValuesAfterMaxToAverage()

        {
            Console.Write("Введите размер одномерного массива: ");
            int razmerMas = Int32.Parse(Console.ReadLine());

            double[] array = new double[razmerMas];
            double sum = 0;

            //Значение! или позиция - i , array[i] -  i=0 перезаписывается на цифру пользователя??
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} элемент массива: ", i);
                array[i] = Double.Parse(Console.ReadLine());

                sum = sum + array[i];
            }

            Console.WriteLine("\nСумма всех элементы массива: {0}", sum);

            double averageInMassive = sum / razmerMas;
            Console.WriteLine("\nСреднее значение элементов массива: {0:#.##}", averageInMassive);

            Console.WriteLine("\nВсе элементы начального массива: ");
            foreach (double i in array)
                Console.Write("{0} ", i);

            Console.WriteLine();

            int indexMax = Array.IndexOf(array, array.Max());
            Console.WriteLine("\nНаибольшее значение находится на позиции: {0}", indexMax);

            Console.WriteLine("\nВсе элементы нового массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i > indexMax)
                    array[i] = averageInMassive;
                else
                    array[i] = array[i];
            }

            foreach (double xi in array)
            Console.Write("{0:#.##} ", xi);

            Console.ReadKey();
        }
    }
}

