using System;
using System.IO;

namespace StreamDemo
{
    class Program
    { 
        static void Main(string[] args)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("../../../StreamDemo.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    if(count % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();
                    line = reader.ReadLine();
                    count++;
                }
                
            }
        }
    }
}
