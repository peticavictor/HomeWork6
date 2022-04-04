using HomeWork6.Models;
using System;
using System.Collections.Generic;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.Now;

            int wallsNum = 4;
            int windowsNum = 4;
            float doorWidth = 1.5f;
            float doorHeight = 2.2f;
            float windowHeight = 1.5f;
            float windowWidth = 1.5f;

            Console.Write("Insert the house x size : ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Insert the house y size : ");
            int y = Int32.Parse(Console.ReadLine());

            //creating and adding all elements in house project
            House house = new House(x, y);
            Basement basement = new Basement(x, y);
            List<Walls> walls = new List<Walls>();
            for (int i=0; i<wallsNum; i++)
            {
                walls.Add(new Walls(i % 2 == 0 ? x : y, 2.5f)) ;
            }
            List<Window> windows = new List<Window>();
            for (int i = 0; i<windowsNum; i++)
            {
                windows.Add(new Window(windowHeight, windowWidth));
            }
            Door door = new Door(doorHeight,doorWidth);
            Roof roof = new Roof(x, y);

            Console.Write("Insert the number of workers : ");
            int workersNum = Int32.Parse(Console.ReadLine());

            List<Worker> workers = new List<Worker>();
            for(int i=0; i< workersNum; i++)
            {
                workers.Add(new Worker("Worker" + i));
            }
            TeamLeader teamLeader = new TeamLeader("Djamshut", house);
            Team team = new Team(teamLeader, workers);

            teamLeader.work(basement);
            foreach (IPart part in walls)
            {
                teamLeader.work(part);
            }
            foreach (IPart part in windows)
            {
                teamLeader.work(part);
            }
            teamLeader.work(door);
            teamLeader.work(roof);

            //building house
            team.build(teamLeader.getProject(), house);
            

            foreach(Worker worker in team.getWorkers())
            {
                Console.WriteLine(worker.getName() + " worked : "+ worker.getHours() + " hours");
            }

            long elapsedTicks = DateTime.Now.Ticks - startDate.Ticks;
            TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

            Console.WriteLine($"House was build in {elapsedSpan.Seconds} hours");
        }
    }
}
