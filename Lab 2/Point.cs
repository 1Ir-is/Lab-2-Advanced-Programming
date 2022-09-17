﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Point
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() : this(0, 0)
        {

        }
    }
}
