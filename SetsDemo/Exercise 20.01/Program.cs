using System;
using System.Collections.Generic;

namespace Exercise_20._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
