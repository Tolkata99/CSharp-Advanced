using System;
using System.Linq;

namespace ExercisesFunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printOntoName = (name) =>
            {
                Console.WriteLine(name);
            };

            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printOntoName);
        }
    }
}
