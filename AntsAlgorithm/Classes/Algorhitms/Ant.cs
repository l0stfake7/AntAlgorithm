using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AntsAlgorithm.Classes.Algorhitms
{
    class Ant
    {
        private Point _startPoint;
        private Point _endPoint;
        public Thread antThread;

        public Ant()
        {
            antThread = new Thread(StartAntThread);
        }

        private void StartAntThread()
        {
        }

        public Ant(Point startPoint, Point endPoint) : base()
        {
            this._startPoint = startPoint;
            this._endPoint = endPoint;
        }

        ~Ant()
        {

        }
    }
}
