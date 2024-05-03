using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Title
    {
        string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Имя автора - {title}");
        }
    }
}
