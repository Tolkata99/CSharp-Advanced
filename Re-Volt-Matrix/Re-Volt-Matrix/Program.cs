using System;

namespace Re_Volt_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int r = 0;
            bool isWon = false;

            char currChar = ' ';
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        r = row;
                        c = col;

                    }
                }
            }
            //logic
            matrix[r, c] = '-';

            for (int comands = 0; comands < m; comands++)
            {
                string comand = Console.ReadLine();
                
                if (comand == "up")
                {
                    r = r - 1;
                    if (r < 0)
                    {
                        r = n - 1;
                    }
                    else if(r == n)
                    {
                        r = 0;
                    }
                }
                else if (comand == "down")
                {
                    r = r + 1;
                    if (r < 0)
                    {
                        r = n - 1;
                    }
                    else if (r == n)
                    {
                        r = 0;
                    }

                }
                else if (comand == "right")
                {
                    c = c + 1;
                    if (c < 0)
                    {
                        c = n - 1;
                    }
                    else if (c == n)
                    {
                        c = 0;
                    }
                }
                else if (comand == "left")
                {
                    c = c - 1;
                    if (c < 0)
                    {
                        c = n - 1;
                    }
                    else if (c == n)
                    {
                        c = 0;
                    }
                }
                currChar = matrix[r, c];
            

                if (currChar == 'B')
                {
                    if (comand == "up")
                    {
                        r = r - 1;
                        if (r < 0)
                        {
                            r = n - 1;
                        }
                        else if (r == n)
                        {
                            r = 0;
                        }
                    }
                    else if (comand == "down")
                    {
                        r = r + 1;
                        if (r < 0)
                        {
                            r = n - 1;
                        }
                        else if (r == n)
                        {
                            r = 0;
                        }

                    }
                    else if (comand == "right")
                    {
                        c = c + 1;
                        if (c < 0)
                        {
                            c = n - 1;
                        }
                        else if (c == n)
                        {
                            c = 0;
                        }
                    }
                    else if (comand == "left")
                    {
                        c = c - 1;
                        if (c < 0)
                        {
                            c = n - 1;
                        }
                        else if (c == n)
                        {
                            c = 0;
                        }
                    }
                    currChar = matrix[r, c];
                }
                else if (currChar == 'T')
                {
                    if (comand == "up")
                    {
                        r = r + 1;
                        if (r < 0)
                        {
                            r = n - 1;
                        }
                        else if (r == n)
                        {
                            r = 0;
                        }
                    }
                    else if (comand == "down")
                    {
                        r = r - 1;
                        if (r < 0)
                        {
                            r = n - 1;
                        }
                        else if (r == n)
                        {
                            r = 0;
                        }

                    }
                    else if (comand == "right")
                    {
                        c = c - 1;
                        if (c < 0)
                        {
                            c = n - 1;
                        }
                        else if (c == n)
                        {
                            c = 0;
                        }
                    }
                    else if (comand == "left")
                    {
                        c = c + 1;
                        if (c < 0)
                        {
                            c = n - 1;
                        }
                        else if (c == n)
                        {
                            c = 0;
                        }
                    }
                    currChar = matrix[r, c];
                }
                else if (currChar == 'F')
                {
                    matrix[r, c] = 'f';
                    isWon = true;
                    break;
                }
                else if (currChar == '-')
                {
                    matrix[r, c] = 'f';
                }

                if(matrix[r, c] == 'f' && comands != m - 1)
                {
                    matrix[r, c] = '-';
                }

            }

            if(isWon)
            {
                Console.WriteLine("Player won!");
            }            
            else
            {
                Console.WriteLine("Player lost!");
            }
            
            PrintMatrix(matrix);
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] tokens = Console.ReadLine().ToCharArray();

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
       
    }
} 
