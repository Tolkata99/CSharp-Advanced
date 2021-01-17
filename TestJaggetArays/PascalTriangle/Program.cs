using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];

            int index = 1;
            for (int row = 0; row < n ; row++)
            {
                pascal[row] = new long[row + 1];
                for (int col = 0; col < row + 1; col++)
                {
                    long sum = 0;
                    if(row - 1 >= 0 && col < pascal[row - 1].Length )
                    {
                        sum += pascal[row - 1][col];
                    }
                    if(row - 1 >= 0 && col - 1 >= 0)
                    {
                        sum += pascal[row - 1][col - 1];
                    }

                    if(sum == 0)
                    {
                        sum = 1;
                    }

                    pascal[row][col] = sum;
                }
            }

            PrintJagget(pascal);
        }
        static void PrintJagget(long[][] pascal)
        {
            foreach (var item in pascal)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}
