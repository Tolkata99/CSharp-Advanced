using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //int a = 4;
            //int b = 4;

            string a = "anatoli";
            string b = "anatoli";
            EqualityScale<string> numbers = new EqualityScale<string>(a,b);

            Console.WriteLine(numbers.AreEqual());

        }
    }
}
