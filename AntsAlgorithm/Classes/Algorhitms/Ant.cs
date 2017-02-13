using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsAlgorithm.Classes.Algorhitms
{
    class Ant
    {
        private static uint _antsCounter = 0;
        private Point _startPoint;
        private Point _endPoint;

        public Ant()
        {
            _antsCounter++;
        }

        public Ant(Point startPoint, Point endPoint) : base()
        {
            this._startPoint = startPoint;
            this._endPoint = endPoint;
        }

        ~Ant()
        {
            _antsCounter--;
        }

        public static uint AntsCounter
        {
            get { return _antsCounter; }
        }
    }
}
