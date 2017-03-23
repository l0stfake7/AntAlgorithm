using System;
using System.Drawing;
using System.Threading;

namespace AntsAlgorithm.Classes
{
    class Ant
    {
        public Point A;
        public Point B;
        public Thread AntThread;
        private static readonly Random RandomGenerator = new Random();
        private static readonly object SyncLock = new object();

        public static int RandomNumber(int min, int max)
        {
            lock (SyncLock)
            { // synchronize
                return RandomGenerator.Next(min, max);
            }
        }

        public Ant()
        {
            AntThread = new Thread(StartAntThread);
        }

        public Ant(Point A, Point B) : base()
        {
            this.A = A;
            this.B = B;
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
                Thread.Sleep(World.TimeInterval);
            }
        }
    }
}
