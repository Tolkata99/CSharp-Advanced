using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string expressions = (Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expressions.Length; i++)
            {
                if(expressions[i] == '(')
                {
                    stack.Push(i);
                }

                if(expressions[i] == ')')
                {
                    int start = stack.Pop();
                    Console.WriteLine(expressions.Substring(start, i - start + 1));
                }

                
            }

        }
    }
}
