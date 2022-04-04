using HomeWork6.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeWork6.Models
{
    class Team
    {
        List<Worker> workers;
        TeamLeader teamLeader;
        public Team(TeamLeader teamLeader, List<Worker> workers)
        {
            this.teamLeader = teamLeader;
            this.workers = workers;
        }

        public List<Worker> getWorkers()
        {
            return this.workers;
        }

        public void build(Queue<IPart> parts, House house)
        {
            if(workers.Count < 1)
            {
                throw new Exception("Error not enough workers");
            }
            int worker = 0;
            while(parts.Count > 1)
            {
                switch (parts.Peek())
                {
                    case Basement b:
                        for (int i = 0; i < b.getSize() / workers.Count; i++)
                        {
                            workers[worker].work(b);
                            if (worker < workers.Count-1)
                            {
                                worker++;
                            }
                            else
                            {
                                worker = 0;
                            }
                            Thread.Sleep(100);
                        }
                        teamLeader.work(b);
                        b.done();
                        break;
                    case Walls w:
                        for (int i = 0; i < workers.Count; i++)
                        {
                            workers[worker].work(w);
                            if (worker < workers.Count -1)
                            {
                                worker++;
                            }
                            else
                            {
                                worker = 0;
                            }
                            Thread.Sleep(100);
                        }
                        w.done();
                        break;
                    case Door d:
                        for (int i = 0; i < d.getSize() / workers.Count; i++)
                        {
                            workers[worker].work(d);
                            if (worker < workers.Count - 1)
                            {
                                worker++;
                            }
                            else
                            {
                                worker = 0;
                            }
                            Thread.Sleep(100);
                        }
                        d.done();
                        break;
                    case Window w:
                        for (int i = 0; i < w.getSize() / workers.Count; i++)
                        {
                            workers[worker].work(w);
                            if (worker < workers.Count - 1)
                            {
                                worker++;
                            }
                            else
                            {
                                worker = 0;
                            }
                            Thread.Sleep(100);
                        }
                        w.done();
                        break;
                    case Roof r:
                        for (int i = 0; i < r.getSize() / workers.Count; i++)
                        {
                            workers[worker].work(r);
                            if (worker < workers.Count - 1)
                            {
                                worker++;
                            }
                            else
                            {
                                worker = 0;
                            }
                            Thread.Sleep(100);
                        }
                        r.done();
                        break;
                }
                parts.Dequeue();
            }
        }
    }
}
