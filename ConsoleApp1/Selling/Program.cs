using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            ReadMatrix(matrix);

            int savedMoney = 0;

            bool isOut = false;

            bool isSaveMoney = false;

            bool isBreak = false;

            int nowRow = 0;
            int nowCol = 0;
            FindS(n, matrix, ref nowRow, ref nowCol);

            string comand = Console.ReadLine();

            while (comand != default)
            {
                if (savedMoney >= 50)
                {
                    isSaveMoney = true;
                    break;
                }

                matrix[nowRow, nowCol] = '-';

                if (IndexIsValid(nowRow, nowCol, n))
                {
                    if(!MoveS(ref nowRow, ref nowCol, comand, n))
                    {
                        isOut = true;
                        break;
                    }
                }
                
                

                if (char.IsDigit(matrix[nowRow, nowCol]))
                {
                    string client = matrix[nowRow, nowCol].ToString();
                    savedMoney += int.Parse(client);

                    matrix[nowRow, nowCol] = 'S';
                }
                else if (matrix[nowRow, nowCol] == 'O')
                {
                    matrix[nowRow, nowCol] = '-';

                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'O')
                            {
                                nowRow = row;
                                nowCol = col;

                               matrix[nowRow, nowCol] = '-';

                                isBreak = true;
                                break;
                            }
                        }
                        if (isBreak)
                        {
                            break;
                        }
                    }

                }


                
                if (savedMoney >= 50 == false)
                {
                    comand = Console.ReadLine();
                    isOut = isBreak;
                }
                else
                {
                    break;
                }

            }
            

            if (isOut)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else if (isSaveMoney)
            {
                Console.WriteLine($"Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {savedMoney}");

            PrintMatrix(matrix);
        }

        private static bool MoveS(ref int nowRow, ref int nowCol, string comand, int n)
        {
            if (comand == "up")
            {
                if (IndexIsValid(nowRow - 1, nowCol, n))
                {
                    nowRow--;
                }
                else
                {
                    return false;
                }
            }
            else if (comand == "down")
            {
                if (IndexIsValid(nowRow + 1, nowCol, n))
                {
                    nowRow++;
                }
                else
                {
                    return false;
                }
            }
            else if (comand == "left")
            {
                if (IndexIsValid(nowRow, nowCol - 1, n))
                {
                    nowCol--;
                }
                else
                {
                    return false;
                }
            }
            else if (comand == "right")
            {
                if (IndexIsValid(nowRow, nowCol + 1, n))
                {
                    nowCol++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static void FindS(int n, char[,] matrix, ref int nowRow, ref int nowCol)
        {
            bool isBreak = false;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        nowRow = row;
                        nowCol = col;

                        isBreak = true;
                        break;
                    }
                }

                if (isBreak)
                {
                    break;
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

        private static bool IndexIsValid(int row, int col, int n)
        {
            return row >= 0 && col >= 0 && row < n && col < n;
        }
    }
}
