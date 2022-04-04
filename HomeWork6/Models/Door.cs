using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Door : IPart
    {
        float size;

        public Door(float x, float y)
        {
            size = x * y;
        }
        public void done()
        {
            Console.WriteLine("Door is done");
        }
        public float getSize()
        {
            return this.size;
        }
    }
}
