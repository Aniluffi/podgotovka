using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите автора - ");
            string author = Console.ReadLine();
            Console.Write("Введите заголовок - ");

            string title = Console.ReadLine();
            Console.Write("Введите содержание - ");

            string content = Console.ReadLine();

            Book book = new Book(new Author(author),new Title(title),new Content(content));
            book.Show();

            Console.ReadKey();
        }
    }
}
