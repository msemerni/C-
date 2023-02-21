using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    class Flight
    {
        public string destinationPoint;
        public string flightNumber;
        public string planeModel;
        public double timeRoute;

        public void AddFlightInfo()
        {
            Console.WriteLine("Введите пункт назначения: ");
            destinationPoint = Console.ReadLine();
            Console.WriteLine("Введите номер рейса: ");
            flightNumber = Console.ReadLine();
            Console.WriteLine("Введите модель самолёта: ");
            planeModel = Console.ReadLine();
            Console.WriteLine("Введите время в пути в часах: ");
            timeRoute = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintInfo()
        {
            Console.WriteLine("Рейс {0} ({1}), время в пути {2} ч", flightNumber, planeModel, timeRoute);
        }
    }
}
