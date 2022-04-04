using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6.Models
{
    class Worker : IWorker
    {
        string name;
        int workedHours;

        public Worker(string name)
        {
            this.name=name;
            this.workedHours = 0;
        }

        public string getName()
        {
            return this.name;
        }

        public int getHours()
        {
            return this.workedHours;
        }

        public void work(IPart part)
        {
            Console.WriteLine(name + " Is working on " + part.GetType());
            workedHours++;
        }
    }
}
