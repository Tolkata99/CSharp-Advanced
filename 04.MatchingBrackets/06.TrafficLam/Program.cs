using System;
using System.Collections.Generic;

namespace _06.TrafficLam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenCount = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int count = 0;

            while (car != "end")
            {
                

                if(car == "green")
                {
                    for (int i = 0; i < greenCount; i++)
                    {
                        if (queue.Count == 0) break;
                        count++;
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                    }
                }
                else
                {
                    queue.Enqueue(car);
                }

                car = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads");
        }
    }
}
