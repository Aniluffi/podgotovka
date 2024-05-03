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
            Figure figure = new Figure(new Point("A",2,4), new Point("B",3,4), new Point("Z",5,1));

            Point[] point = figure.Points;
            int[] sids = new int[point.Length - 1];

            for (int i = 0; i < point.Length;i++)
            {
               if
            }
        }
    }
}
