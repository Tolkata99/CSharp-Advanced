using System;
using System.Collections.Generic;
using System.Text;

namespace DemoClasses
{
    class Book
    {

        public Book(string name, string autor, int pages)
        {
            Name = name;
            Pages = pages;
            Autor = autor;
        }


        public string Name { get; set; }

        public int Pages { get; set; }

        public string Autor { get; set; }


        public int PagesX2(int beb)
        {
            int result = beb * 2;

            return result;
        }

        public void Print(string name,string autor,int result)
        {
            Console.WriteLine($"Is a {name} from {autor} and have {result} pages");
        }

    }
}
