using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoHashSets
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B= new HashSet<int>();

            for (int i = 0; i < n[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                A.Add(number);
            }

            for (int i = 0; i < n[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                B.Add(number);
            }

            var a = A.Intersect(B);

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
        }
    }
}
