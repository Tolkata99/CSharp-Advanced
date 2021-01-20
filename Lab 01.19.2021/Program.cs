using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01._19._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> memes = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(!memes.ContainsKey(numbers[i]))
                {
                    memes.Add(numbers[i], 0);
                }
                memes[numbers[i]]++;
            }

            foreach (var item in memes)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
