using System;

namespace _04.MatrixAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowAndCol = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowAndCol, rowAndCol];

            for (int row = 0; row < rowAndCol; row++)
            {
                char[] sign = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rowAndCol; col++)
                {
                    matrix[row, col] = sign[col];
                }
            }

            int rows = 0;
            int colw = 0;

            bool isFinded = false;
            char find = char.Parse(Console.ReadLine());

            for (int r = 0; r < rowAndCol; r++)
            {
                
                for (int c = 0; c < rowAndCol; c++)
                {
                    int fin = find;
                    int matri = matrix[r, c];
                    if (fin == matri)
                    {
                        rows = r;
                        colw = c;
                        isFinded = true;
                        break;
                    }
                    
                }
                if (isFinded)
                {
                    break;
                }
            }

            if(isFinded)
            Console.WriteLine($"({rows}, {colw})");
            else
                Console.WriteLine($"{find} does not occur in the matrix ");
        }
    }
}
