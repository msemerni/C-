using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkladVBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //В банк на трёхпроцентный вклад положили S гривен. 
            //Какой станет сумма вклада через N лет.

            Console.Title = "Расчёт денежного вклада в банк под 3%";
            Console.WriteLine("Расчёт денежного вклада в банк под 3%\n");

            Console.WriteLine("Введите сумму вклада: ");
            decimal S = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество лет вклада: ");
            //int N = Int32.Parse(Console.ReadLine()); - // Можно так?
            decimal N = Decimal.Parse(Console.ReadLine());

            int i = 1;
            decimal percent = 0;
            decimal pribil = 0;
            decimal money = S;
            string year = "год";
            //decimal p = 0.03m;

            while (i <= N)
            {
                //Как (if (N == 1 || N == 21 ||...) можно это записать короче??? - см. VkladVBank_anyPercent
                if (N == 1 || N == 21 || N == 31 || N == 41 || N == 51 || N == 61 || N == 71
                    || N == 81 || N == 91 || N == 101)
                {
                    year = "год";
                }
                else if (N == 2 || N == 3 || N == 4 || N == 22 || N == 23 || N == 24 || N == 32 || N == 33 || N == 34 ||
                        N == 42 || N == 43 || N == 44 || N == 52 || N == 53 || N == 54 || N == 62 || N == 63 || N == 64 ||
                        N == 72 || N == 73 || N == 74 || N == 82 || N == 83 || N == 84 || N == 92 || N == 93 || N == 94)
                {
                    year = "года";
                }
                else
                {
                    year = "лет";
                }

                percent = S * 0.03m; //можно вначале объявить: decimal p = 0.03m;
                S = S + percent;
                // Чтобы рассчитывало за каждый год:
                Console.WriteLine("\nСумма вклада через {0} {1} составит: {2:#.##} грн.", i, year, S);
                pribil = pribil + percent;
                i++;
            }

            //Console.WriteLine("\nСумма вклада через {0} {1} составит: {2:#.##} грн.", N, year, S);
            Console.WriteLine("\nПрибыль за {0} {1} составит: {2:#.##} грн.", N, year, pribil);
            Console.ReadKey();

        }
    }
}


//for (i = 1; i <= N; i++)

//do
//{
//    sum = (S * N) * 1.03;

//    i++;
//}
//while (i < N);



//// *** Расчет стоимости капиталовложения с ***
//// *** фиксированной нормой прибыли***
//decimal money, percent;
//int i;
//const byte years = 15;

//money = 1000.0m;
//            percent = 0.045m;

//            for (i = 1; i <= years; i++)
//            {
//                money *= 1 + percent;
//            }

//            Console.WriteLine("Общий доход за {0} лет: {1} $$",years,money);
//            Console.ReadLine();


