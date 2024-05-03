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
            Console.Write("Введите сторону 1 - ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону 2 - ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1,side2);
            Console.WriteLine($"S = {rectangle.S()}");
            Console.WriteLine($"P = {rectangle.P()}");

            Console.ReadKey();
        }
    }
}
