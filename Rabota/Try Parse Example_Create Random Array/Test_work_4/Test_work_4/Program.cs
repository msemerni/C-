using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestWork1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Task8();
            DrawBorder(5, 10, '*');
            Console.WriteLine();
            FirstTaskv1();
            Console.WriteLine();
            FirstTaskv2();
            Console.ReadKey();
        }

        static public void FirstTaskv1()
        {
            try
            {
                Console.WriteLine("Введите целое число: ");
                int number = Int32.Parse(Console.ReadLine());
                number = number + 10;
                Console.WriteLine("Введенное число + 10 равно: {0}", number);
            }
            catch (Exception)
            {

                Console.WriteLine("Неправильный ввод!");
            }

        }

        static public void FirstTaskv2()
        {
            Console.WriteLine("Введите целое число:");
            int number;
            bool result = Int32.TryParse(Console.ReadLine(), out number);

            if (result)
            {
                Console.WriteLine("Введенное число + 20 равно: {0}", number + 20);
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");
            }
        }

        static public bool TryParseExample(string parsedValue, out int number)
        {
            try
            {
                number = Int32.Parse(parsedValue);
                return true;
            }
            catch (Exception)
            {
                number = 0;
                return false;
            }
        }

        public static int[] CreateRandomIntArray(int size)
        {
            int[] intArray = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                intArray[i] = rnd.Next(1, 11);
            }

            return intArray;
        }

        public static void DrawBorder(int height, int width, char ch)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                        Console.Write(ch);
                    else if (j == 0 || j == width - 1)
                        Console.Write(ch);
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Task8()
        {
            int[] testArray = CreateRandomIntArray(10);

            int max = testArray.Max();
            int min = testArray.Min();
            int maxPosition = Array.IndexOf(testArray, max);
            int minPosition = Array.IndexOf(testArray, min);

            int count = 0;

            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] == max || testArray[i] == min)
                    count++;

                Console.Write("{0} ", testArray[i]);
            }

            //for (int i = 0; i < testArray.Length; i++)
            //{
            //    if (testArray[i] > max)
            //    {
            //        max = testArray[i];
            //        maxPosition = i;
            //    }

            //    if (testArray[i] < min)
            //    {
            //        min = testArray[i];
            //        minPosition = i;
            //    }

            //    Console.Write("{0} ", testArray[i]);
            //}

            Console.WriteLine();
            Console.WriteLine("Min: {0}, pos: {1}", min, minPosition);
            Console.WriteLine("Max: {0}, pos: {1}", max, maxPosition);
            Console.WriteLine("Общее число вхождений max и min: {0}", count);
            
        }
        
    }
}
