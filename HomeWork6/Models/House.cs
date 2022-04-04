using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class House
    {
        int xSize;
        int ySize;
        Basement basement;
        List<Walls> walls = new List<Walls>();
        Door door;
        List<Window> windows = new List<Window>();
        Roof roof;

        public House(int xSize, int ySize)
        {
            this.xSize=xSize;
            this.ySize=ySize;
        }

        public void setBasement(Basement basement)
        {
            this.basement = basement;
        }

        public void setWalls(Walls wall)
        {
            if (basement != null)
            {
                this.walls.Add(wall);
            }
            else
            {
                throw new Exception("ERror building house");
            }
        }
        public void setDoor(Door door)
        {
            if (walls.Count >= 4)
            {
                this.door = door;
            }
            else
            {
                throw new Exception("ERror building house");
            }
        }
        public void setWindows(Window window)
        {
            if (walls.Count >= 4)
            {
                this.windows.Add(window);
            }
            else
            {
                throw new Exception("ERror building house");
            }
        }
        public void setRoof(Roof roof)
        {
            if (walls.Count >= 4)
            {
                this.roof = roof;
            }
            else
            {
                throw new Exception("ERror building house");
            }
            Console.WriteLine("Project is done!!!");
        }

    }
}
