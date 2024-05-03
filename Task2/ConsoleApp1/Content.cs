using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Content
    {
        string contentText;

        public Content(string contentText)
        {
            this.contentText = contentText;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Имя автора - {contentText}");
        }
    }
}
