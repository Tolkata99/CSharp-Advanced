using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charBrackets = Console.ReadLine().ToCharArray();

            int count = 0;

            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < charBrackets.Length; i++)
            {
                if(i < charBrackets.Length / 2)
                {
                    queue.Enqueue(charBrackets[i]);
                }
                else
                {
                    
                    stack.Push(charBrackets[i]);
                }
            }

            while (stack.Count > 0)
            {
                char first = stack.Pop();
                char seconds = queue.Dequeue();

                if(first == '}' && seconds == '{'
                    || first == '(' && seconds == ')'
                    || first == '[' && seconds == ']')
                {

                }
                else
                {
                    count++;
                }
            }






            if (count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
