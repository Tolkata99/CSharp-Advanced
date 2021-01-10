using System;
using System.Linq;

namespace MethodsAdv
{
    class Program
    {
        public static int Add(params int[]  nums)
        {
            return  nums.Sum();
        }
        public static int Add(int b,int a)
        {
            return b + a;
        }
        public static double Add(double b, double a)
        {
            return b * a;
        }
       
        public static int Add(int b, int a, int c)
        {

            return b + a + c;
        }


        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(a , b));
        }
    }
}
