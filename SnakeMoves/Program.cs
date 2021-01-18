using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[rowsAndCols[0], rowsAndCols[1]];

            string snake = Console.ReadLine();

            int currLetter = 0;
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {


                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[currLetter];
                        currLetter++;

                        if (currLetter == snake.Length)
                        {
                            currLetter = 0;

                        }
                    }

                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        currLetter = fillMatrix(matrix, snake, currLetter, row, col);
                    }

                }



            }
            PrintMatrix(matrix);

        }

        private static int fillMatrix(char[,] matrix, string snake, int currLetter, int row, int col)
        {
            matrix[row, col] = snake[currLetter];
            currLetter++;

            if (currLetter == snake.Length)
            {
                currLetter = 0;

            }

            return currLetter;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");

                }
                Console.WriteLine();
            }
        }

    }
}
