using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkladVBank_2var
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
            int N = Int32.Parse(Console.ReadLine());

            string year = "год";
            double percent = 0.36;
            decimal money = S;

            //Как (if (N == 1 || N == 21 ||...) можно это записать короче???  - см. VkladVBank_anyPercent
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
            for (int i = 0; i < N; i++)
                S = S + (S * (decimal)percent);
                decimal pribil = (S - money);

            ////Можно так: (0.03m)? - ДА
            //for (int i = 0; i < N; i++)
            //    S = S + (S * 0.03m);
            //    decimal pribil = (S - money);

            //Так еще короче:
            //for (int i = 0; i < N; i++)
            //S = S * 1.03m;////можно и так:S = S * (decimal)1.03); но не желательно так как длиннее код
            //decimal pribil = (S - money);

            Console.WriteLine("\nСумма вклада через {0} {1} составит: {2:#.##} грн.", N, year, S);
            Console.WriteLine("\nПрибыль за {0} {1} составит: {2:#.##} грн.", N, year, pribil);

            Console.ReadKey();

        }
    }
}
