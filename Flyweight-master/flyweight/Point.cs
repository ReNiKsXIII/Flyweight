﻿using System;
using System.Collections.Generic;
using System.Text;

namespace flyweight
{
   public  class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point() { }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
