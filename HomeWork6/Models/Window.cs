using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Window : IPart
    {
        float size;
        public Window(float x, float y)
        {
            size = x * y;
        }
        public void done()
        {
            Console.WriteLine("Window is done");
        }
        public float getSize()
        {
            return this.size;
        }
    }
}
