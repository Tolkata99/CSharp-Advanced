using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {

            
            int n = int.Parse(Console.ReadLine());
           
            
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                //{tire1Pressure} " +
                //    "{tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string model = data[0];
                
                int engineSpeed = int.Parse(data[1]);
                double enginePower = double.Parse(data[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tires[] tires = new Tires[4];


                int count = 0;
                for (int j = 5; j < data.Length; j++)
                {
                    int age = int.Parse(data[j + 1]);
                    double pressure = double.Parse(data[j]);
                    j++;
                    //warrning
                    Tires tire = new Tires(age, pressure);
                    tires[count++] = tire;
                    
                   
                }
                Car car = new Car(tires, cargo, engine, model);
                cars.Add(car);
            }

            string comand = Console.ReadLine();

            if(comand == "fragile")
            {
                var fragileCar = cars.Where(x => x.Cargo.CargoType == "fragile"
                                         && x.Tires.Any(p => p.tirePressure < 1.00)).ToList();

                foreach (var item in fragileCar)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else if(comand == "flamable")
            {
                var flamableCar = cars.Where(x => x.Cargo.CargoType == "flamable"
                                 && x.Engine.EnginePower > 250).ToList();

                foreach (var item in flamableCar)
                {
                    Console.WriteLine(item.Model);
                }
            }

            
            



        }
       
        
    }
}
