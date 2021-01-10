using System;
using System.Collections.Generic;

namespace ReverseStringWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackReverse = new Stack<char>();

            string words = (Console.ReadLine());


            for (int i = 0; i < words.Length; i++)
            {
                stackReverse.Push(words[i]);
            }

           
            while(stackReverse.Count > 0)
            {
                Console.Write(stackReverse.Pop());
            }

            
        }
    }
}
