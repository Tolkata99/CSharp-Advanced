using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = 0;
            int Cake = 0;
            int Pustry = 0;
            int fruit = 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            Queue<int> queue = new Queue<int>();//Technost
            Stack<int> stack = new Stack<int>();//sustavka

            int[] technost = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sustavka = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < technost.Length; i++)
            {
                queue.Enqueue(technost[i]);
            }

            for (int i = 0; i < sustavka.Length; i++)
            {
                stack.Push(sustavka[i]);
            }

            while (true)
            {
                int result = queue.Peek() + stack.Peek();
                if (result == 25)
                {
                    bread++;
                    queue.Dequeue();
                    stack.Pop();

                }
                else if (result == 50)
                {
                    Cake++;
                    queue.Dequeue();
                    stack.Pop();

                }
                else if (result == 75)
                {
                    Pustry++;
                    queue.Dequeue();
                    stack.Pop();

                }
                else if (result == 100)
                {
                    fruit++;
                    queue.Dequeue();
                    stack.Pop();

                }
                else
                {
                    queue.Dequeue();
                    int n = stack.Pop() + 3;
                    stack.Push(n);

                }

                if (queue.Count == 0 || stack.Count == 0)
                {

                    break;

                }
            }
            dict.Add("Bread", bread);
            dict.Add("Cake", Cake);
            dict.Add("Pastry", Pustry);
            dict.Add("Fruit Pie", fruit);

            Print(bread, Cake, Pustry, fruit, dict, queue, stack);
        }

        private static void Print(int bread, int Cake, int Pustry, int fruit, Dictionary<string, int> dict, Queue<int> queue, Stack<int> stack)
        {
            if (bread >= 1 && Cake >= 1 && Pustry >= 1 && fruit >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");

            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Liquids left: {String.Join(", ", queue)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            //ready
            if (stack.Count > 0)
            {

                Console.WriteLine($"Ingredients left: {String.Join(", ", stack)}");

            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {

                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
