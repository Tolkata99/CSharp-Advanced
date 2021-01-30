using System;

namespace DemoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("CleverMoney","Stoyne", 50);

            int result = book.PagesX2(111);

            book.Print(book.Name, book.Autor,result);
        }
    }
}
