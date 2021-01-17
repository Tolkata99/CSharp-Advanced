using System;
using System.Linq;

namespace JaggetArrayModifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
               // jaggetArays[row] = new int[input.Length];

                for (int i = 0; i < n; i++)
                {
                    matrix[row,i] = input[i];
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

                
                if (row >= 0 && col >= 0 
                    && row < n && col < n)
                {
                    if (comdArg == "Add")
                    {
                        matrix[row,col] += number;
                    }
                    else if (comdArg == "Subtract")
                    {
                        matrix[row,col] -= number;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
               
                comand = Console.ReadLine();
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
