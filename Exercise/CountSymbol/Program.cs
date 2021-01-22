using System;
using System.Collections.Generic;

namespace CountSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> time = new SortedDictionary<char, int>();


            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];

                if(time.ContainsKey(ch) == false)
                {
                    time.Add(ch, 0);
                }
            
                time[ch]++;
            }

            foreach (var item in time)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
