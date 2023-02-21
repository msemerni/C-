using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkladVBank_anyPercent
{
    class Program
    {
        static void Main(string[] args)
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


            //Как(if (N == 1 || N == 21 ||...) можно это записать короче??? - см. Выше

            //if (N == 1 || N == 21 || N == 31 || N == 41 || N == 51 || N == 61 || N == 71
            //      || N == 81 || N == 91 || N == 101)
            //    {
            //        year = "год";
            //    }
            //    else if (N == 2 || N == 3 || N == 4 || N == 22 || N == 23 || N == 24 || N == 32 || N == 33 || N == 34 ||
            //            N == 42 || N == 43 || N == 44 || N == 52 || N == 53 || N == 54 || N == 62 || N == 63 || N == 64 ||
            //            N == 72 || N == 73 || N == 74 || N == 82 || N == 83 || N == 84 || N == 92 || N == 93 || N == 94)
            //    {
            //        year = "года";
            //    }
            //    else
            //    {
            //        year = "лет";
            //    }


            for (int i = 0; i < N; i++)
                S = S + (S * (P / 100));
            decimal pribil = (S - money);

            ////Можно так: (0.03m)? - ДА
            //for (int i = 0; i < N; i++)
            //    S = S + (S * 0.03m); 
            ////можно и так, но не желательно так как длиннее код: S = S + (S * (decimal)0.03);
            //decimal pribil = (S - money);

            //Так еще короче:
            //for (int i = 0; i < N; i++)
            //    S = S * 1.03m;
            //decimal pribil = (S - money);

            Console.WriteLine("\nСумма вклада через {0} {1} составит: {2:#.##} грн.", N, year, S);
            Console.WriteLine("\nПрибыль за {0} {1} составит: {2:#.##} грн.", N, year, pribil);

            Console.ReadKey();

        }
    }
}
////Максима код:
//if (N >= 11 && N <= 19)
//{
//    year = "лет";
//}
//else
//{
//    int lastNumber = N % 10;
//    if (lastNumber == 1)
//    {

//    }
//}


