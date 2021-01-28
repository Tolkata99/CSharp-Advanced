using System;
using System.Linq;

namespace _3._CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallest = (min) =>
            {
                int minInteger = int.MaxValue;

                foreach (var num in min)
                {
                    if(num < minInteger)
                    {
                        minInteger = num;
                    }
                }
                return minInteger;
            };

            int[] min = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(smallest(min));
            
        }
    }
}
