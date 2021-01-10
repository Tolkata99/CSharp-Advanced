using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] receive = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(receive);


            string comand = Console.ReadLine().ToLower();
            while (comand != "end")
            {
                string[] tokens = comand.Split();
                if (tokens[0] == "add")
                {
                    int firstAdd = int.Parse(tokens[1]);
                    int secondAdd = int.Parse(tokens[2]);

                    stack.Push(firstAdd);
                    stack.Push(secondAdd);

                }
                else if (tokens[0] == "remove")
                {
                    int removeCount = int.Parse(tokens[1]);
                    if (removeCount <= stack.Count)
                    {
                        for (int i = 0; i < removeCount; i++)
                        {
                            stack.Pop();
                        }
                    }
                }


                comand = Console.ReadLine().ToLower();
            }
            int result = 0;
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            Console.WriteLine($"Sum: {result}");
        }
    }
}
