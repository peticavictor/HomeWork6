using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Roof : IPart
    {
        int area;
        public Roof(int x, int y)
        {
            area = x * y;
        }

        public void done()
        {
            Console.WriteLine("Roof is done");
            Console.WriteLine("House is build");
        }
        public int getSize()
        {
            return this.area;
        }
    }
}
