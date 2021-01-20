using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> store = new Dictionary<string, Dictionary<string, string>>();




            for (int i = 0; i < n; i++)
            {

                string comand = Console.ReadLine();
                string[] tokens = comand.Split(" ");
                string nameShop = tokens[0];
                string product = tokens[1];
                string price = tokens[2];

               
                
                    store.Add(nameShop, new Dictionary<string, string>());


                




                store[nameShop].Add(product, price);


            }



            StringBuilder sb = new StringBuilder();
            foreach (var item in store)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var price in item.Value)
                {

                    Console.WriteLine($"{price.Key}->{price.Value}");

                }

            }



        }

    }
}
