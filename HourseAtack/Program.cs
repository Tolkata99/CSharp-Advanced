using System;

namespace HourseAtack
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAtack = 0;
            int rowKiller = 0;
            int colKiller = 0;
            int countAtacks = 0;
            int countREplaced = 0;

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);

            while (true)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char curSimbol = matrix[row, col];

                        if (curSimbol == 'K')
                        {
                            countAtacks = GetAtack(matrix, row, ref col, ref countAtacks);
                            if (countAtacks > maxAtack)
                            {
                                maxAtack = countAtacks;
                                rowKiller = row;
                                colKiller = col;
                            }
                        }
                    }
                }

                if (maxAtack > 0)
                {
                    matrix[rowKiller, colKiller] = '0';
                    countREplaced++;
                }
                else
                {
                    Console.WriteLine(countAtacks);
                    break;
                }
            }

        }

        private static int GetAtack(char[,] matrix, int row, ref int col, ref int countAtacks)
        {
            if (IsInnside(matrix, row - 2, col - 2) && matrix[row - 2, col - 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInnside(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
            {
                countAtacks++;
            }
            if (IsInnside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInnside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInnside(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInnside(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInnside(matrix, row + 2, col - 1) && matrix[row + 2, col  - 1] == 'K')
            {
                countAtacks++;
            }
            if (IsInnside(matrix, row + 2, col = +1) && matrix[row + 2, col + 1] == 'K')
            {
                countAtacks++;
            }

            return countAtacks;
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] tokens = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = tokens[col];
                }
            }

        }
        private static bool IsInnside(char[,] matrix, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0) &&
                   targetCol >= 0 && targetCol < matrix.GetLength(0);
        }
    }
}