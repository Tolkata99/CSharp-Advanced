using System;
using System.Linq;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] rolsAndColl = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rolsAndColl[0];
            int colls = rolsAndColl[1];
            int sum = 0;


            int[,] matrix = new int[rows, colls];

            for (int rols = 0; rols < matrix.GetLength(0); rols++)
            {
                int[] addElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rols, cols] = addElements[cols];

                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int coll = 0; coll < matrix.GetLength(1); coll++)
                {
                    sum += matrix[row, coll];
                }
            }




            Console.WriteLine(rows);
            Console.WriteLine(colls);
            Console.WriteLine(sum);
        }

    }
}
