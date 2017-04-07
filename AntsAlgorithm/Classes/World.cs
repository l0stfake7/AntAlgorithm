using System;
using System.Collections.Generic;
using System.Drawing;

namespace AntsAlgorithm.Classes
{
    class World
    {
        public static bool Run = false;
        public static short TimeInterval = 750;//in ms

        public List<Node> NodeList;
        public List<Ant> Ants;
        public Dictionary<int, Tuple<Point, Point>> PathList;
    }
}
