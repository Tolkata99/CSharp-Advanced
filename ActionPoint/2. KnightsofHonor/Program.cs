using System;
using System.Linq;

namespace _2._KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> honor = (name) =>
            {
                Console.WriteLine("Sir " + name);
            };

            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(honor);
        }
    }
}
