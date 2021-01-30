using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRace
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }



        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }




        public void Distance(double fuelAmoth, double fuelOneKm,double distance)
        {
            double GetFuel = distance * fuelOneKm;

            if(fuelAmoth >= GetFuel)
            {
                this.FuelAmount -= GetFuel;
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

       


    }
}
