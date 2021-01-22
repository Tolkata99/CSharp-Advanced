using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../TextFileFirst.txt").ToArray();

            string[] end = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)          
            {
                end[i] = $"{i} " + lines[i];
               
            }
            
            File.WriteAllLines("../../../TextFileSecond.txt", lines);
            Console.WriteLine(File.ReadAllLines("../../../TextFileSecond.txt"));

            


            


        }
    }
}
