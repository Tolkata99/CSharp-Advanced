using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> task = new Stack<int>();

            Queue<int> nishka = new Queue<int>();

            int[] tasked = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int i = 0; i < tasked.Length; i++)
            {
                task.Push(tasked[i]);
            }

            int[] nishki = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nishki.Length; i++)
            {
                nishka.Enqueue(nishki[i]);
            }

            int killer = int.Parse(Console.ReadLine());
            int nishkaKiller = 0;

            while (task.Count != 0 && nishka.Count != 0)
            {
                // int result = task.Peek() + nishka.Dequeue();



                if (killer == task.Peek())
                {
                    nishkaKiller = nishka.Peek();
                    break;
                }

                if (nishka.Peek() >= task.Peek())
                {
                    nishka.Dequeue();
                    task.Pop();
                }
                else
                {
                    nishka.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {nishkaKiller} killed task {killer}");

            Console.WriteLine(string.Join(" ",nishka));
        }
    }
}
