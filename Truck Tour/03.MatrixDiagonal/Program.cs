using System;
using System.Linq;

namespace _03.MatrixDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowAndCol = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowAndCol, rowAndCol];

            for (int row = 0; row < rowAndCol; row++)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowAndCol; col++)
                {
                    matrix[row, col] = tokens[col];
                }
            }

            int sum = 0;

            for (int r = 0; r < rowAndCol; r++)
            {
                for (int c = 0; c < rowAndCol; c++)
                {
                    if(r == c)
                    {
                        sum += matrix[r, c];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
