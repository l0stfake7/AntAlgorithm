using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace AntsAlgorithm.Classes
{
    class Ant
    {
        public Tuple<Double, Double> ActualPoint;
        public IList<Tuple<Double, Double>> Points;
        public Thread AntThread;
        public int counterMove;
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
            this.Points = points;
            counterMove = 0;
            AntThread = new Thread(StartAntThread);
        }

        ~Ant()
        {

        }

        private void StartAntThread()
        {
            while (World.Run)
            {
                
                //X = RandomGenerator.Next(700);
                //Y = RandomGenerator.Next(350);
                
                
                if (counterMove > 10)
                {
                    AntThread.Abort();
                }
                else
                {
                    ActualPoint = Points[counterMove];
                    Thread.Sleep(World.TimeInterval);
                    counterMove++;
                }
            }
        }
    }
}
