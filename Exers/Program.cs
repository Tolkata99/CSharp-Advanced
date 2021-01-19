using System;
using System.Linq;

namespace Exers
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isBreak = false;
            bool isBreakTwo = false;
            int n = int.Parse(Console.ReadLine());

            int[][] jaggetArays = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] curElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggetArays[row] = new int[curElements.Length];
                for (int col = 0; col < jaggetArays[row].Length; col++)
                {
                    jaggetArays[row][col] = curElements[col];
                }
            }
  
            for (int r = 0; r < n - 1; r++)
            {

                if (jaggetArays[r].Length == jaggetArays[r + 1].Length && jaggetArays[r].Length > 1)
                {
                    for (int x = 0; x < jaggetArays[r].Length; x++)
                    {
                        jaggetArays[r][x] *= 2;
                    }
                    r++; 
                }
                else 
                {
                    if(jaggetArays[r].Length > 1)
                    for (int x = 0; x < jaggetArays[r].Length; x++)
                    {
                        jaggetArays[r][x] /= 2;
                    }
                }

                
            }

            for (int r = n - 1; r < n; r++)
            {                            
                    if (jaggetArays[r].Length > 1)
                        for (int x = 0; x < jaggetArays[r].Length; x++)
                        {
                            jaggetArays[r][x] /= 2;
                        }              
            }

            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] tokens = comand.Split();
                string comArg = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);


                if (row >= 0 && col >= 0 && row <= n)
                {
                    if(comArg == "Add")
                    {
                        for (int r = 0; r < n; r++)
                        {
                            for (int c = 0; c < jaggetArays[r].Length; c++)
                            {
                                if (col <= jaggetArays[r].Length)
                                {
                                    jaggetArays[r][c] += value;
                                    isBreak = true;
                                    break;
                                }
                                else
                                {
                                    isBreak = true;
                                    break;
                                    
                                }
                            }
                            if(isBreak)
                            {
                                break;
                            }
                        }
                    }
                    else if (comArg == "Subtract ")
                    {
                        for (int r = 0; r < n; r++)
                        {
                            for (int c = 0; c < jaggetArays[r].Length; c++)
                            {
                                if (col <= jaggetArays[r].Length)
                                {
                                    jaggetArays[r][c] -= value;
                                    isBreak = true;
                                    break;
                                }
                                else
                                {
                                    isBreakTwo = true;
                                    break;
                                    
                                }
                            }
                            if(isBreakTwo)
                            {
                                break;
                            }
                        }
                    }
                }


                comand = Console.ReadLine();
            }





            PrintMatrix(jaggetArays,n);
        }
        private static void PrintMatrix(int[][] jaggetArray, int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < jaggetArray[r].Length; c++)
                {
                    Console.Write(jaggetArray[r][c] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
