using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> times = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(times.ContainsKey(number) == false)
                {
                    times.Add(number, 0);
                }

                times[number]++;
            }

            var tim = times.Where(t => t.Value % 2 == 0);

            foreach (var item in tim)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
