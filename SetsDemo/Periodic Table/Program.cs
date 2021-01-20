using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> sets = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicalElement = Console.ReadLine().Split();
                for (int ch = 0; ch < chemicalElement.Length; ch++)
                {
                    string cur = chemicalElement[ch];
                    sets.Add(cur);
                }
                

            }

            foreach (var item in sets)
            {
                Console.Write(item + " ");
            }
        }
    }
}
