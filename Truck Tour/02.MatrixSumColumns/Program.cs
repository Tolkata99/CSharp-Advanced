using System;
using System.Linq;

namespace _02.MatrixSumColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowAndCol[0];
            int cols = rowAndCol[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] AddElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = AddElements[col];
                }
            }

            for (int coll = 0; coll < matrix.GetLength(1); coll++)
            {
                sum = 0;
                for (int roww = 0; roww < matrix.GetLength(0); roww++)
                {
                    sum += matrix[roww, coll];
                    
                }
                Console.WriteLine(sum);

            }
        }
    }
}
