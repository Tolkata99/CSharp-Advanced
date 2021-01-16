using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var comand = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);


            for (int i = 0; i < comand[1]; i++)
            {
                queue.Dequeue();
            }

            if(queue.Contains(comand[2]))
            {
                Console.WriteLine("true");
            }
            else if(queue.Count > 0 )
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
