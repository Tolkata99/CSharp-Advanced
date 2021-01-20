using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            HashSet<string> parking = new HashSet<string>();
            while (comand != "END")
            {
                string[] tokens = comand.Split(", ");
                string comArg = tokens[0];
                string carNumber = tokens[1];

                if (comArg == "IN")
                {
                    parking.Add(carNumber);
                }
                else if (comArg == "OUT")
                {
                    parking.Remove(carNumber);
                }

                comand = Console.ReadLine();

            }
            if(parking.Count > 0)
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
                
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
