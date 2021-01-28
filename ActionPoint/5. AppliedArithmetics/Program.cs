using System;
using System.Linq;

namespace _5._AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = (arr) =>
            {
                Console.WriteLine(string.Join(" ", arr));
            };

            
            int[] colections = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                if(comand == "print")
                {
                    print(colections);
                }
                else
                {
                    Func<int[], int[]> process = Matematics(comand);

                    colections = process(colections);
                }



                comand = Console.ReadLine();
            }


        }
        static Func<int[], int[]> Matematics(string comand)
        {

            Func<int[], int[]> process = null;

            if (comand == "add")
            {
                process = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]++;
                    }
                    return arr;
                });
            }
            else if (comand == "multiply")
            {
                process = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] *= 2;
                    }
                    return arr;
                });
            }
            else if (comand == "subtract")
            {

                process = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }
                    return arr;
                });
            }
            
            

            return process;
        }
    }
}
