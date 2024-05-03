using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Author
    {
        string name;

        public Author(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Имя автора - {name}");
        }
    }
}
