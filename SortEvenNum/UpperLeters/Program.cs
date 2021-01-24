using System;
using System.Linq;

namespace UpperLeters
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(l => l[0] == l.ToUpper()[0]).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}
