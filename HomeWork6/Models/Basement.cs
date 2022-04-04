using HomeWork6.Models;

namespace HomeWork6
{
    class Basement : IPart
    {
        int size { get; set; }

        public Basement(int x, int y)
        {
            size = 2* x + 2 * y;
        }

        public void done()
        {
            System.Console.WriteLine("Basement is done");           
        }

        public int getSize()
        {
            return this.size;
        }
    }
}
