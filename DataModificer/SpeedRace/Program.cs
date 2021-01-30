using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRace
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                double fuelAmouth = double.Parse(data[1]);
                double fuelAmouthPerKm = double.Parse(data[2]);


                Car car = new Car(model, fuelAmouth, fuelAmouthPerKm);

                cars.Add(car);
            }

            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] data = comand.Split();
                string model = data[1];
                double distance = double.Parse(data[2]);

                //var car = FindCar(model, cars);

                Car car = cars.FirstOrDefault(x => x.Model == model);

                car.Distance(car.FuelAmount, car.FuelConsumptionPerKilometer, distance);

                comand = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }


            
        }

        //private static Car FindCar(string model, List<Car> cars)
        //{
        //    Car car = null;
        //    foreach (var item in cars)
        //    {
        //        if (item.Model == model)
        //        {
        //            car = item;

        //        }

        //    }
        //    return car;
        //}



    }
}
