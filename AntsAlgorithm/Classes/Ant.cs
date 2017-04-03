using System;
using System.Collections.Generic;
using System.Threading;

namespace AntsAlgorithm.Classes
{
    class Ant
    {
        public Tuple<Double, Double> ActualPoint;
        public IList<Tuple<Double, Double>> Points;
        public Thread AntThread;
        public int CounterMove;
        private static readonly Random RandomGenerator = new Random();
        private static readonly object SyncLock = new object();

        public static int RandomNumber(int min, int max)
        {
            lock (SyncLock)
            { // synchronize
                return RandomGenerator.Next(min, max);
            }
        }

        public Ant(IList<Tuple<Double, Double>> points)
        {
            Points = points;
            CounterMove = 0;
            AntThread = new Thread(StartAntThread);
        }

        ~Ant()
        {

        }

        private void StartAntThread()
        {
            while (World.Run)
            {
                CounterMove++;
                if (CounterMove > 25)
                {
                    AntThread.Abort();
                    World.Run = false;
                }
                else
                {
                    ActualPoint = Points[CounterMove];
                    Thread.Sleep(World.TimeInterval);
                }
            }
        }
    }
}
