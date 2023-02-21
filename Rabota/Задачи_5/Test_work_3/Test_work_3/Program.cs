using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_work_3
{
    class Program
    {
        //// 6) Реализовать метод который создает и возвращает одномерный массив целочисленных значений 
        //// и заполняет его случайными числами в диапазоне от 1 до 1000. 
        //// Размер массива указывается во входящем параметре метода.
        //// 7) Вывести элементы массива на экран. Посчитать количество четных и нечетных элементов. 
        //// Для создания массива воспользоваться методом из предыдущего задания. Размер массива 5
        //// 8) Вывести массив на экран, найти позицию первого вхождения минимального и максимального элемента, 
        //// а так же общее кол-во вхождени й минимального и максимального элементов в массив
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int arraySize = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();

            CreateRandomArray(arraySize,rnd);
            FoundMaxAndMinInArray(arraySize, rnd);
            CountEvenAndOddInArray(rnd);

            Console.ReadKey();
        }

        public static int[] CreateRandomArray(int arraySize, Random rnd)
        {
            //// ЧТО ЕСЛИ ВО ВСЕХ ТРЁХ МЕТОДАХ ПЕРЕМЕННАЯ БУДЕТ "someArray", ВМЕСТО ТРЁХ (someArray, testArray, someArray2) ????????????????
            //// ОСТАНЕТСЯ В ПАМЯТИ ТА ПЕРЕМЕННАЯ, КОТОРАЯ БЫЛА В ПОСЛЕДНЕМ ИЗ ВЫЗЫВАЮЩИХСЯ МЕТОДОВ ???????
            //// ЧТО ЗАПИСЫВАЕТСЯ В ПАМЯТЬ, А ЧТО НЕТ ?????????
            ////////Ответ: Переменные с одинаковым именем будут записываться в разные места памяти, так как они объявляются в разных методах.
            ////////В разных методах можно называть переменные одинаковыми именами. Они все сохранятся в памяти и не затрут друг друга.

            int[] someArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                someArray[i] = rnd.Next(1, 1001);
            }
            return someArray;
        }

        public static void FoundMaxAndMinInArray(int arraySize, Random rnd)
        {
            int[] testArray = CreateRandomArray(arraySize, rnd);

            int max = testArray.Max();
            int min = testArray.Min();
            int maxPosition = Array.IndexOf(testArray, max);
            int minPosition = Array.IndexOf(testArray, min);
            int count = 0;

            Console.WriteLine("\nВсе элементы массива: ");
            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] == max || testArray[i] == min)
                    count++;
                Console.Write("{0} ", testArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное число: {0} находится на позиции: {1}", max, maxPosition);
            Console.WriteLine("Минимальное число: {0} находится на позиции: {1}", min, minPosition);
            Console.WriteLine("Общее число вхождений max и min: {0}", count);
        }

        public static void CountEvenAndOddInArray(Random rnd)
        {
            int[] someArray2 = CreateRandomArray(5, rnd);
            int count = 0;

            Console.WriteLine("\nВсе элементы массива размером 5: ");
            for (int i = 0; i < someArray2.Length; i++)
            {
                if (someArray2[i]%2 == 0)
                    count++;
                Console.Write("{0} ", someArray2[i]);
            }
            Console.WriteLine("\nКоличество чётных элементов: {0}", count);
            Console.WriteLine("Количество нечётных элементов: {0}", 5 - count);
        }
    }
}
