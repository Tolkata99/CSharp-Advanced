using System;
using System.Linq;

namespace _4._FindEvensorOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string comand = Console.ReadLine();


            Predicate<int> predicate = comand == "odd" ?
                new Predicate<int>((n) => n % 2 != 0) :
                new Predicate<int>((n) => n % 2 == 0);

            for (int i = bounds[0]; i < bounds[1]; i++)
            {
                if(predicate)
            }

        }
    }
}
