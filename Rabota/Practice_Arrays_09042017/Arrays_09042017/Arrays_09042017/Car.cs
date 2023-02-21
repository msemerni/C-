using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_09042017
{
    class Car
    {
        public string brand;
        public string model;
        public int cost;
        public string color;
        public int year;

        public Car(string brand, string model, int cost, string color, int year)
        {
            this.brand = brand;
            this.model = model;
            this.cost = cost;
            this.color = color;
            this.year = year;
        }

        //public void GetInformation()
        //{
        //    Console.WriteLine("Автомобиль: {0} {1}. Цвет: {3}. Год: {4}. Цена: {2}", brand, model, cost, color, year);
        //}

        public override string ToString()
        {
            StringBuilder carInfo = new StringBuilder();

            Console.WriteLine("{0} {1}. Цвет: {3}. Год: {4}. Цена: {2}", brand, model, cost, color, year);
            //carInfo.AppendFormat("{0} - {1} - {2} - {3} - {4}", brand, cost, color, year, model);
            string cars = carInfo.ToString();
            return cars;
        }

    }
}
