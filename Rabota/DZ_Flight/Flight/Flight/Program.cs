using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flight> allFlights = new List<Flight>();

            ////Если убрать do, т.е. ввести всего один рейс: 
            ////надо переименовать oneFlight в другое имя, например, oneFlight11 в строке foreach (var oneFlight in allFlights)
            ////это потому что oneFlight уже определён раньше. И при убирании скобок в "do" 
            ////область видимости открывается. Когда есть do, то oneFlight (в foreach (var oneFlight in allFlights))
            ////не видит другой oneFlight, который уже определён раньше (в "do").
            ////
            string choise = "Н";
            do
            {
                Console.Clear();
                Console.WriteLine("Введитете данные о рейсе");

                Flight oneFlight = new Flight();
                oneFlight.AddFlightInfo();
                allFlights.Add(oneFlight);
                Console.WriteLine("Будете еще добавлять? (Д/Н)");
                choise = Console.ReadLine().ToUpper();
            }
            while (choise == "Д");

            Console.Clear();
            Console.WriteLine("Введите город, куда Вам лететь: ");
            string city = Console.ReadLine();

            Console.WriteLine("\nСписок рейсов: ");

            int count = 0;
            foreach (var oneFlight in allFlights)
            {
                if (city == oneFlight.destinationPoint)
                {
                    oneFlight.PrintInfo();
                    count++;
                }
                //// Так не будет работать:
                //else
                //    Console.WriteLine("В город {0} рейсов нет", city);
                ////Чтобы работало нужно создавать count.
            }
                if (count == 0)
                {
                    Console.WriteLine("В город {0} рейсов нет", city);
                }

            Console.ReadLine();
        }
    }
}
