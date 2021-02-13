using System;
using System.Linq;

namespace Seling
{
    class Program
    {
        static void Main(string[] args)
        {
            char matricNow = default;

            int rowNowBee = 0;
            int colNowBee = 0;
            int counter = default;

            bool teritory = false;

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);
            FindBee(ref rowNowBee, ref colNowBee, n, matrix);

            string comand = Console.ReadLine();
            while (comand != "End")
            {

                matrix[rowNowBee, colNowBee] = '.';
                Position(ref rowNowBee, ref colNowBee, comand);

                if (IsValid(rowNowBee, colNowBee, n))
                {

                    if (IsValid(rowNowBee, colNowBee, n))
                    {
                        matricNow = matrix[rowNowBee, colNowBee];
                    }
                    else
                    {
                        teritory = true;
                        break;
                    }



                    if (matricNow == 'O')
                    {
                        matrix[rowNowBee, colNowBee] = '.';
                        Position(ref rowNowBee, ref colNowBee, comand);

                        if (IsValid(rowNowBee, colNowBee, n))
                        {
                            matricNow = matrix[rowNowBee, colNowBee];
                        }
                        else
                        {
                            
                            matrix[rowNowBee, colNowBee] = 'B';
                            teritory = true;
                            break;
                        }
                    }

                    if (matricNow == '.')
                    {
                        matrix[rowNowBee, colNowBee] = 'B';
                    }
                    else if (matricNow == 'f')
                    {
                        counter++;
                        matrix[rowNowBee, colNowBee] = 'B';
                    }

                    if (!IsValid(rowNowBee, colNowBee, n))
                    {
                        teritory = true;
                        break;
                    }

                }
                else
                {
                    teritory = true;
                    break;
                }

                comand = Console.ReadLine();
            }

            if (teritory)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (counter < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - counter} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {counter} flowers!");
            }

            PrintMatrix(matrix);


        }

        private static void FindBee(ref int rowNowBee, ref int colNowBee, int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        rowNowBee = row;
                        colNowBee = col;
                    }
                }
            }
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

        private static void PrintMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);

                }
                Console.WriteLine();
            }
        }


        private static bool IsValid(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }

        private static void Position(ref int rowNowBee, ref int colNowBee, string comand)
        {
            if (comand == "up")
            {
                rowNowBee--;
            }
            else if (comand == "down")
            {
                rowNowBee++;
            }
            else if (comand == "left")
            {
                colNowBee--;
            }
            else if (comand == "right")
            {
                colNowBee++;

            }
        }
    }
}
