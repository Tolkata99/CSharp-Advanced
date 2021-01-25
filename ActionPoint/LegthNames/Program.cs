using System;
using System.Collections.Generic;
using System.Linq;

namespace LengthNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split().ToArray();

            
            Func<string[], string[]> filterSize = (length) =>
             {
                 for (int i = 0; i < array.Length; i++)
                 {
                     if (size < array[i].Length)
                     {
                         array[i] = "";
                     }

                 }

                 return array;
             };
            
            
            foreach (var item in filterSize(array))
            {
                if(item != "")
                Console.WriteLine(item + " ");
            }
        }
    }
}
