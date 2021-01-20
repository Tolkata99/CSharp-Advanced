using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, double>> store = new Dictionary<string, Dictionary<string, double>>();

            string comand = Console.ReadLine();
            while (comand != "Revision")
            {
                string[] tokens = comand.Split(", ");
                string nameShop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (store.ContainsKey(nameShop) == false)
                {
                    store.Add(nameShop, new Dictionary<string, double>());
                    store[nameShop].Add(product, price);
                }
                else
                {
                    store[nameShop].Add(product, price);
                }


                comand = Console.ReadLine();
            }

            foreach (var item in store.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var price in item.Value)
                {
                   // string name = item
                    Console.WriteLine($"Product: {price.Key}, Price: {price.Value}");
                }
            }



        }
            
    }
}
