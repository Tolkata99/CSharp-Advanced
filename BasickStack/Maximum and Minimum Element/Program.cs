using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (elements[0] == 1)
                {
                    stack.Push(elements[1]);
                }
                else if (elements[0] == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    if (elements[0] == 3)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (elements[0] == 4)
                    {
                        Console.WriteLine(stack.Min());
                    }

                }


            }
            Console.WriteLine(string.Join(", ",stack));

        }
    }
}
