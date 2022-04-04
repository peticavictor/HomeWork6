using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6.Models
{
    class TeamLeader : IWorker
    {
        string name;
        Queue<IPart> parts = new Queue<IPart>();
        House house;
        public TeamLeader(string name, House house)
        {
            this.name=name;
            this.house = house;
        }

        public void work(IPart part)
        {
            parts.Enqueue(part);
            switch (part)
            {
                case Basement b:
                    house.setBasement(b);
                    break;
                case Walls w:
                    house.setWalls(w);
                    break;
                case Door d:
                    house.setDoor(d);
                    break;
                case Window w:
                    house.setWindows(w);
                    break;
                case Roof r:
                    house.setRoof(r);
                    break;
            }
        }
        public Queue<IPart> getProject()
        {
            return this.parts;
        }

    }
}
