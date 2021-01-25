using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversedAndDEvisible
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());


            Func<List<int>, List<int>> revers = (integers) =>
             {

                 integers.Reverse();

                 for (int i = 0; i < integers.Count; i++)
                 {
                     if (integers[i] % n == 0)
                     {
                         integers[i] = 0;
                     }

                 }


                 
                 return integers;

             };

            foreach (var item in (revers(array)))
            {
                if(item != 0)
                {
                    Console.Write(item);
                }
                
            }
        }
    }
}
