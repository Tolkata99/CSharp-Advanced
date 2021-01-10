using System;
using System.Collections.Generic;

namespace CreateStackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string book = Console.ReadLine();

            while(book != "end")
            {
                stack.Push(book);
                book = Console.ReadLine();

            }

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Peek());
                Console.WriteLine(stack.Pop());
            }
            
        }
    }
}
