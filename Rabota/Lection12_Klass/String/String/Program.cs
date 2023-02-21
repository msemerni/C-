using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new int[5] { 1, 2, 3, 4, 5 };
            //string numberList = string.Join(":;=", numbers);
            //Console.WriteLine(numberList);
            //Console.ReadKey();

            ////так нельзя-ошибка:
            ////Console.WriteLine("Меня зовут 
            ////    Миша");
            ////Надо ставить @ перед текстом:
            //Console.WriteLine(@"Меня зовут 
            //    Миша");

            //Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////Магазин по продаже чая:
            List<Tea> teaList = new List<Tea>();
            string choise = "Н";
            do
            {
                Console.Clear();

                Tea sortOfTea = new Tea();
                sortOfTea.AddTeaInfo();
                teaList.Add(sortOfTea);
                Console.WriteLine("Будете еще добавлять? (Д/Н)");
                choise = Console.ReadLine().ToUpper();
            }
            while (choise == "Д");

            Console.Clear();
            Console.WriteLine("Список всех видов чая: ");

            foreach (var sortOfTea in teaList)
                sortOfTea.PrintInfo();

            Console.WriteLine("\nВведите страну производства чая, который вы желаете преобрести:");
            ////switch / case ???
            ////Как сделать первую букву заглавной, независимо от того, как вводит пользователь???????????? - потом будет рассматривать как это делается
            string countryTeaUser = Console.ReadLine();

            int count = 0;
            foreach (var sortOfTea in teaList)
            ////????Как сделать при помощи for ????
            ////for (int i = 0; i < teaList.Length; i++)
            {
            if (countryTeaUser == sortOfTea.teaCountryName)
                {
                sortOfTea.PrintInfo();
                ////break не нужен, т.к. в таком случае выведет только первый сорт чая, который встретится
                ////и цикл прекратит работу"
                count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Чая производства {0} нет в наличии", countryTeaUser);
            }
            ////так норм когда вложенные циклы или можно/нужно сделать проще??????????:
            else
            {
                Console.WriteLine("\nВведите название чая, который вы желаете преобрести:");
                string nameTeaUser = Console.ReadLine();
                int count2 = 0;
                foreach (var sortOfTea in teaList)
                {
                    if (nameTeaUser == sortOfTea.teaName)
                    {
                        sortOfTea.PrintInfo();
                        count2++;
                    }
                }
                if (count2 == 0)
                {
                    Console.WriteLine("Чая {0} нет в наличии", nameTeaUser);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nВведите количество грамм чая, который вы желаете преобрести:");
                    double weightTeaUser = Convert.ToDouble(Console.ReadLine());

                    foreach (var sortOfTea in teaList)
                    {
                        if (nameTeaUser == sortOfTea.teaName)
                        {
                            double totalPrice = sortOfTea.teaPrice * weightTeaUser / 100;
                            Console.WriteLine("\nВы заказали {0} гр. чая {1}. Общя стоимость {2} грн.", weightTeaUser, nameTeaUser, totalPrice);
                        }
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}