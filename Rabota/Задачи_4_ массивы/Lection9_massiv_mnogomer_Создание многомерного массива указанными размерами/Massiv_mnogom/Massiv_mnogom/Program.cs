using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv_mnogom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testArray = CreateNewRandomDwoDimensionalArray (4, 5, 1, 10);
            PrintTwoDimensionalArray(testArray);
            Console.ReadKey();
        }

        //static int[,] CreateNewRandomTwoDimensionArray(int razmerMasI, int razmerMasJ, a, b)
        //{

        //    Console.Write("Введите размер массива: ");

        //    ////это если было бы не в методе, в который возвращается:
        //    //int razmerMasI = Int32.Parse(Console.ReadLine());
        //    //int razmerMasJ = Int32.Parse(Console.ReadLine());

        //    int[,] array = new int[razmerMasI, razmerMasJ];

        //    Random rnd = 

        //    //Заполнить массив значениями из консоли
        //    for (int i = 0; i < razmerMasI; i++)
        //    {
        //        for (int j = 0; j < razmerMasJ; j++)
        //        {
        //            Console.Write("[{0},{1}]: ", i, j);
        //            array[i, j] = rnd.Next(a,b);
        //        }
        //}

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

        //static void PrintTwoDimensionalArray(int[,] arrayForPrint)
        //{
        //    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        //        {
        //            Console.Write("{0}\t", arrayForPrint[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }
}
