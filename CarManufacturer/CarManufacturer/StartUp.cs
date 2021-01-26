using System;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "houp";
            car.Model = "53u0";
            car.Year = 7;
            car.FuelConsumption = 200;
            car.FuelQuantity = 200;


            car.Drive(20);
            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
