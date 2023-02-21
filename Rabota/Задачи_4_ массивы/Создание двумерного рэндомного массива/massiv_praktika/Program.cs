using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv_praktika
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите размер массива:");

            int row = Int32.Parse(Console.ReadLine());
            int column = Int32.Parse(Console.ReadLine());


            int[,] testArray = CreateNewRandomDwoDimensionalArray(row, column, 1, 20);

            PrintTwoDimensionalArray(testArray);

            int chet = 0;
            int nechet = 0;

            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    if (testArray[i, j] % 2 == 0)
                    {
                        chet++;
                    }
                    else
                    {
                        nechet++;
                    }
                }

            }
            Console.WriteLine("Количество чётных элементов в массиве:{}", chet);
            Console.WriteLine("Количество нечётных элементов в массиве:{}", nechet);

            Console.ReadKey();
        }


        static int[,] CreateNewRandomDwoDimensionalArray(int rowCount, int columnCount, int randomMinValue, int randomMaxValue)
        {
            int[,] newArray = new int[rowCount, columnCount];
            Random rnd = new Random();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    newArray[i, j] = rnd.Next(randomMinValue, randomMaxValue + 1);
                }
            }

            return newArray;
        }



        static void PrintTwoDimensionalArray(int[,] arrayForPrint)
        {
            for (int i = 0; i < arrayForPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayForPrint.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arrayForPrint[i, j]);
                }
                Console.WriteLine();
            }

        }

        }
    }
