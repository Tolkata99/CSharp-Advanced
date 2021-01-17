using System;
using System.Linq;

namespace JaggetArrayModifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggetArays = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggetArays[row] = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    jaggetArays[row][i] = input[i];
                }
            }

            string comand = Console.ReadLine();
            while (comand != "END")
            {
                string[] tokens = comand.Split();
                string comdArg = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int number = int.Parse(tokens[3]);

                if (row < n
                    && col < n 
                    && row >= 0 
                    && col >= 0)
                {
                    if (comdArg == "Add")
                    {
                        jaggetArays[row][col] += number;
                    }
                    else if (comdArg == "Subtract")
                    {
                        jaggetArays[row][col] -= number;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                comand = Console.ReadLine();
            }
            foreach (var item in jaggetArays)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
