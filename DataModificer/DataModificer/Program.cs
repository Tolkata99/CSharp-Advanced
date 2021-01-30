using System;

namespace DataModificer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DateModifier dataMod = new DateModifier();

            string first = Console.ReadLine();
            string second = Console.ReadLine();
            //1992 05 31
            //2016 06 17


            int result = dataMod.DataBetween(first, second);
            Console.WriteLine(result);
        }
    }
}
