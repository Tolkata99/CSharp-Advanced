using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.SimpleCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string[] expressions = Console.ReadLine()
                .Split(" ")
                .Reverse()
                .ToArray();

            Stack<string> stack = new Stack<string>(expressions);

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string sing = stack.Pop();
                int second = int.Parse(stack.Pop());

                if(sing == "+")
                {
                    result = first + second;
                }
                else if (sing == "-")
                {
                    result = first - second;
                }

                stack.Push(result.ToString());


            }

            Console.WriteLine(stack.Pop());


        }
    }
}
