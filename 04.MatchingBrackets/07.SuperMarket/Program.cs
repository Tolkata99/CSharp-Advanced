using System;
using System.Collections.Generic;

namespace _07.SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            while (names != "End")
            {
                if(names == "Paid")
                {
                    while (queue.Count > 0) //greshka
                    {
                        Console.WriteLine(queue.Dequeue());
                       // queue.Dequeue();
                    }
                }
                else
                {
                    queue.Enqueue(names);
                }



                names = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining");
        }
    }
}
