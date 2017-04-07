using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntsAlgorithm.Enums;

namespace AntsAlgorithm.Classes
{
    class Node
    {
        public Point Point;
        public NodeType NodeType;

        public Node(Point point, NodeType nodeType)
        {
            this.Point = point;
            this.NodeType = nodeType;
        }

    }
}
