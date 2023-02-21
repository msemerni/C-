using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raschet_procentov
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Расчёт процентов денежного вклада";

            string finalChoice;
            do
            {
                Console.Clear();

                decimal money;
                decimal percent;
                decimal N;
                string month = "год";

                    Console.WriteLine("Введите сумму вклада: ");
                    money = Decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Введите ставку процента в месяц: ");
                    percent = Decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Введите количество месяцев вклада: ");
                    N = Decimal.Parse(Console.ReadLine());



                    if (N == 1 || N == 21 || N == 31 || N == 41 || N == 51 || N == 61 || N == 71
                          || N == 81 || N == 91 || N == 101)
                    {
                        month = "месяц";
                    }
                    else if (N == 2 || N == 3 || N == 4 || N == 22 || N == 23 || N == 24 || N == 32 || N == 33 || N == 34 ||
                            N == 42 || N == 43 || N == 44 || N == 52 || N == 53 || N == 54 || N == 62 || N == 63 || N == 64 ||
                            N == 72 || N == 73 || N == 74 || N == 82 || N == 83 || N == 84 || N == 92 || N == 93 || N == 94)
                    {
                        month = "месяца";
                    }
                    else
                    {
                        month = "месяцев";
                    }

                    decimal S = money;
                    decimal moneyWithKapitalization = money;
                    decimal moneyWithoutKapitalization = money;


                    moneyWithoutKapitalization = moneyWithoutKapitalization + (moneyWithoutKapitalization * (percent / 100) * N);
                    decimal pribilWithoutKapitalization = (moneyWithoutKapitalization - S);

                    for (int i = 0; i < N; i++)
                    {
                        moneyWithKapitalization = moneyWithKapitalization + (moneyWithKapitalization * (percent / 100));
                        
                    }
                        decimal pribilWithKapitalization = (moneyWithKapitalization - S);

                Console.WriteLine("\nСумма вклада без капитализации через {0} {1} составит: {2:0.00} $.", N, month, moneyWithoutKapitalization);
                    Console.WriteLine("Прибыль за {0} {1} составит: {2:0.00} $. ({3:0.00} $ в месяц)", N, month, pribilWithoutKapitalization, pribilWithoutKapitalization/N);

                    Console.WriteLine("\nСумма вклада с капитализацией через {0} {1} составит: {2:0.00} $.", N, month, moneyWithKapitalization);
                    Console.WriteLine("Прибыль за {0} {1} составит: {2:0.00} $. ({3:0.00} $ в месяц)", N, month, pribilWithKapitalization, pribilWithKapitalization/12);

                    Console.WriteLine("\nЖелаете повторить расчёт? 'Д' - да, 'Н' - нет");
                    do
                    {
                        finalChoice = Console.ReadLine().ToUpper();
                        if (finalChoice != "Д" && finalChoice != "Н")
                        {
                            Console.WriteLine("Некорректный ввод ! Введите Д или Н.");
                        }
                    } while (finalChoice != "Д" && finalChoice != "Н");

                } while (finalChoice == "Д");
                Console.WriteLine("\nДо свидания!");
                Console.ReadKey();
            
        }
    }
}

//////////////////////////////////////////////////////////////////


    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.Title = "Расчёт процентов денежного вклада";

    //            string finalChoice;
    //            do
    //            {
    //                Console.Clear();

    //            decimal money;
    //            decimal percent;
    //            decimal pribil=0;
    //            int N;
    //            string month = "год";
    //            int variantRascheta;

    //                do
    //                {
    //                    Console.WriteLine(@"Выберите вариант расчёта процентов:
    //1. Без капитализации
    //2. С капитализацией");

    //                    Console.Write("Вариант #: ");
    //                    bool incorChoice = Int32.TryParse(Console.ReadLine(), out variantRascheta);
    //                    Console.Clear();
    //                }
    //                while (variantRascheta != 1 && variantRascheta != 2);

    //                Console.WriteLine("Введите сумму вклада: ");
    //            money = Decimal.Parse(Console.ReadLine());

    //            Console.WriteLine("Введите ставку процента в месяц: ");
    //            percent = Decimal.Parse(Console.ReadLine());

    //            Console.WriteLine("Введите количество месяцев вклада: ");
    //            N = Int32.Parse(Console.ReadLine());

    //            decimal S = money;


    //            if (N == 1 || N == 21 || N == 31 || N == 41 || N == 51 || N == 61 || N == 71
    //                  || N == 81 || N == 91 || N == 101)
    //            {
    //                month = "месяц";
    //            }
    //            else if (N == 2 || N == 3 || N == 4 || N == 22 || N == 23 || N == 24 || N == 32 || N == 33 || N == 34 ||
    //                    N == 42 || N == 43 || N == 44 || N == 52 || N == 53 || N == 54 || N == 62 || N == 63 || N == 64 ||
    //                    N == 72 || N == 73 || N == 74 || N == 82 || N == 83 || N == 84 || N == 92 || N == 93 || N == 94)
    //            {
    //                month = "месяца";
    //            }
    //            else
    //            {
    //                month = "месяцев";
    //            }

    //            switch (variantRascheta)
    //            {
    //                case 1:
    //                    money = money + (money * (percent / 100) * N);
    //                    pribil = (money - S);
    //                    break;
    //                case 2:
    //                    for (int i = 0; i < N; i++)
    //                        money = money + (money * (percent / 100));
    //                        pribil = (money - S);
    //                    break;
    //                }

    //                Console.WriteLine("\nСумма вклада через {0} {1} составит: {2:0.00} $.", N, month, money);
    //                Console.WriteLine("\nПрибыль за {0} {1} составит: {2:0.00} $.", N, month, pribil);

    //                Console.WriteLine("\nЖелаете повторить выбор задачи? Д - да, Н - нет");
    //                do
    //                {
    //                    finalChoice = Console.ReadLine().ToUpper();
    //                    if (finalChoice != "Д" && finalChoice != "Н")
    //                    {
    //                        Console.WriteLine("Некорректный ввод ! Введите Д или Н.");
    //                    }
    //                } while (finalChoice != "Д" && finalChoice != "Н");

    //            } while (finalChoice == "Д");
    //            Console.WriteLine("\nДо свидания!");
    //            Console.ReadKey();

    //        }
    //    }
//}
