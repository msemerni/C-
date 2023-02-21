using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples4Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Введи номер программы 1-5
1 - Найти максимальный элемент массива. Вывести на экран элементы массива и максимум.
2 - Определить количество элементов в заданном массиве, отличающихся от минимального на 5.
3 - Найти сумму элементов, расположенных до максимального элемента массива.
4 - Определить значение и номер последнего отрицательного элемента массива размером 8.
5 - Все элементы, расположенные после максимального, заменить средним значением элементов массива.");
            int choise = Int32.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    oneDimension();
                    break;
                case 2:
                    FindElementInArray();
                    break;
                case 3:
                    FindSumBeforeMaxValue();
                    break;
                case 4:
                    FindLastMinNumber();
                    break;
                case 5:
                    ReplaceByAvarageValue();
                    break;
            }
        }
        static void WriteArrayInConsole(int[] ArraySize)
        {
            for (int i = 0; i < ArraySize.Length; i++)
            {
                Console.Write("[{0}] ", ArraySize[i]);
            }
            Console.WriteLine();
        }
        static void oneDimension()
        {
            int max = Int32.MinValue;
            int i = 0;
            int[] array = new int[5];
            for (; i < 5; i++)
            {
                Console.Write("Элемент {0}: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Максимальный элемент массива " + max);
            WriteArrayInConsole(array);
        }
        static void FindElementInArray()
        {
            int min = Int32.MaxValue;
            int count = 0;
            Console.WriteLine("Введите количество элементов массива");
            int number = Int32.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Элемент {0}: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Min value {0}", min);
            foreach (int variable in array)
            {
                if (variable == min + 5)
                    count++;
            }
            Console.WriteLine("Количество элементов в заданном массиве, отличающихся от минимального на 5 - {0}", count);
        }
        static void FindSumBeforeMaxValue()
        {
            Console.WriteLine("Введите количество элементов массива");
            int number = Int32.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Элемент {0}: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            int Result = 0;
            int MaxNumber = array.Max();
            int indexOfMaxNumber = Array.IndexOf(array, MaxNumber);
            for (int i = 0; i < indexOfMaxNumber; i++)
            {
                Result += array[i];
            }
            Console.WriteLine("Сумма элементов, расположенных до максимального элемента массива {0} ", Result);
        }



        static void FindLastMinNumber()
        {
            int LastMinNumber = 0;
            int[] array = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Элемент {0}: ", i);
                array[i] = Int32.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    LastMinNumber = array[i];
                }
            }
            if (LastMinNumber < 0)
                Console.WriteLine("Последний отрицательный элемент {0} под номером {1}", LastMinNumber, Array.IndexOf(array, LastMinNumber));
            else Console.WriteLine("Отрицательных элементов нет");
        }




        static void ReplaceByAvarageValue()
        {
            double AvarageValue = 0;
            Console.WriteLine("Введите количество элементов массива");
            int number = Int32.Parse(Console.ReadLine());
            double[] array = new double[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Элемент {0}: ", i);
                array[i] = Convert.ToDouble(Console.ReadLine());
                AvarageValue = AvarageValue + (array[i] / array.Length);
            }
            double MaxValue = array.Max();
            int IndexOfMaxValue = Array.IndexOf(array, MaxValue);
            for (int n = IndexOfMaxValue + 1; n < array.Length; n++)
            {
                array[n] = AvarageValue;
            }
            Console.Write("Массив приобрел вид: ");
            foreach (double i in array)
                Console.Write("[{0}] ", i);
            Console.WriteLine();
        }
    }
}