using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queue = new Queue<string>(songs);
            string comands = Console.ReadLine();
            while (queue.Count > 0)
            {
                if(comands.Contains("Add"))
                {
                    string[] tokens = comands.Split(" ");
                    comands = comands.Replace("Add",String.Empty).Trim();
                   
                    if (queue.Contains(comands) == false)
                    {
                       
                        
                        queue.Enqueue(comands);
                    }
                    else
                    {
                        Console.WriteLine($"{comands} is already contained!");

                    }
                    
                }
                else if( comands.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (comands.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                    
                }

                comands = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
