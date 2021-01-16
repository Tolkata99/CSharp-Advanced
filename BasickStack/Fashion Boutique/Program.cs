using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dressBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(dressBox);
            
            int count = 0;
            int sum = 0;
            while (stack.Count > 0)
            {
                var current = stack.Peek();

                if(sum + current > maxCapacity)
                {
                    count++;
                    sum = 0;
                }
                else if(sum + current == maxCapacity)
                {
                    count++;
                    sum = 0;
                    stack.Pop();
                }
                else
                {
                    sum += stack.Pop();
                }
            }
            if(sum > 0)
            {
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
