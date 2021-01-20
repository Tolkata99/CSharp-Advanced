using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] com = Console.ReadLine().Split();
                decimal grade = decimal.Parse(com[1]);

                if(dict.ContainsKey(com[0]) == false)
                {
                    
                    dict.Add(com[0], new List<decimal>());
                    dict[com[0]].Add(grade);
                }
                else
                {
                    dict[com[0]].Add(grade);
                }
            }

            
            foreach (var item in dict)
            {
                //double result = item.Value.Average();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    sb.Append($"{item.Value[i]:F2} ");
                }

                Console.WriteLine($"{item.Key} -> {sb.ToString()}(avg: {item.Value.Average():f2})");
            }

        }
    }
}
