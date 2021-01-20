using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<int> numbers = new SortedSet<int>();

            for (int i = 0; i < n; i++)
            {
                int curNum = int.Parse(Console.ReadLine());
                numbers.Add(curNum);
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
