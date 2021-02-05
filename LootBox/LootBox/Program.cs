using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstField = new Queue<int>();
            Stack<int> secondField = new Stack<int>();

            

            int[] numFirst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numSeconds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numFirst.Length; i++)
            {
                firstField.Enqueue(numFirst[i]);
            }

            for (int i = 0; i < numSeconds.Length; i++)
            {
                secondField.Push(numSeconds[i]);
            }

            int totalSum = 0;
            int evenOrOdd = 0;

            while (firstField.Count != 0 && secondField.Count != 0)
            {
                int a = firstField.Peek();
                int b = secondField.Peek();

                evenOrOdd = a + b;

                if (evenOrOdd % 2 == 0)
                {
                    totalSum += firstField.Dequeue() + secondField.Pop();
                }
                else
                {
                    firstField.Enqueue(secondField.Pop());
                }
                

            }

            if(firstField.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if(totalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
