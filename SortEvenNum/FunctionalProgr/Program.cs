using System;
using System.Linq;

namespace FunctionalProgr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            string result = (String.Join(", ", numArray));

            Console.WriteLine(result);

        }
    }
}
