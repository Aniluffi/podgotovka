﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        double side1;
        double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double S()
        {
            return side1 * side2;
        }

        public double P()
        {
            return (side1 + side2)*2;
        }
    }
}
