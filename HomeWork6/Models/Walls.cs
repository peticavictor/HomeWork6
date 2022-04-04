using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Walls : IPart
    {
        float size;

        public Walls(int x, float height)
        {
            size = x * height;
        }

        public void done()
        {
            Console.WriteLine("Wall is done");
        }
        public float getSize()
        {
            return this.size;
        }
    }
}
