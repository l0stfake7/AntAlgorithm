using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntsAlgorithm
{
    public partial class MainForm : Form
    {

        private List<Point> nodeList;
        private MultiValueDictionary<int, Dictionary<Point, Point>> pathList;
        private Graphics canvas;
        private Brush brush;
        private bool start;
        private const short radius = 10;
        private bool nodeSelect;
        private RadioOptions rOp;
        private Point lastSel;

        public MainForm()
        {
            InitializeComponent();
            nodeList = new List<Point>();
            pathList = new MultiValueDictionary<int, Dictionary<Point, Point>>();

            nodeList.Add(new Point(139, 107));
            nodeList.Add(new Point(575, 225));

            canvas = CreateGraphics();
            brush = new SolidBrush(Color.Black);
            start = true;
            nodeSelect = false;
            rOp = RadioOptions.Point;
        }

        private void DrawAntPooint(Point node)
        {
            if (start)
            {
                canvas.FillEllipse(new SolidBrush(Color.Red), nodeList[0].X, nodeList[0].Y, radius, radius);
                canvas.FillEllipse(new SolidBrush(Color.Red), nodeList[1].X, nodeList[1].Y, radius, radius);
                start = false;
            }
            nodeList.Add(new Point(node.X, node.Y));
            canvas.FillEllipse(brush, node.X, node.Y, radius, radius);
        }

        private void DrawLineBeetweenPoints(Point nodeA, Point nodeB)
        {
            canvas.DrawLine(new Pen(Color.Purple, 5), nodeA, nodeB);
        }

        private void DebugLabel(String message)
        {
            labelDebug.Text = message;
        }

        private void DebugLabel2(String message)
        {
            labelDebug2.Text = message;
        }

        public static bool InsideCircle(int xc, int yc, int r, int x, int y)
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }

        public static double DistanceInStraightLineBetweenPoints(Point point1, Point point2)
        {
            var a = (double)(point2.X - point1.X);
            var b = (double)(point2.Y - point1.Y);

            return Math.Sqrt(a * a + b * b);
        }

        private void RunAnt(Point actuallyPoint, Point destinationPoint)//only graphically, not by algorithm 
        {
            if (actuallyPoint == destinationPoint)
            {

            }
            else
            {

            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            switch (rOp)
            {
                case RadioOptions.Select:
                    foreach (Point p in nodeList)
                    {
                        if (InsideCircle(p.X, p.Y, radius, e.X, e.Y))
                        {
                            lastSel = p;//current item in loop
                            DebugLabel2("Select " + p.X + " " + p.Y);
                            break;
                        }
                    }
                    break;
                case RadioOptions.Point:
                    foreach (Point p in nodeList)
                    {
                        if (!InsideCircle(p.X, p.Y, radius, e.X, e.Y))
                        {
                            DrawAntPooint(new Point(e.X, e.Y));
                            DebugLabel2("New node " + p.X + " " + p.Y);
                            break;
                        }
                    }
                    break;
                case RadioOptions.Line:
                    foreach (Point p in nodeList)
                    {
                        if (InsideCircle(p.X, p.Y, radius, e.X, e.Y))
                        {
                            if (lastSel != Point.Empty)
                            {
                                DrawLineBeetweenPoints(lastSel, new Point(p.X, p.Y));
                                Dictionary<Point, Point> test  = new Dictionary<Point, Point>();
                                test.Add(new Point(lastSel.X, lastSel.Y), new Point(p.X, p.Y));
                                pathList.Add(pathList.Count + 1, test);
                                DebugLabel2("New path " + p.X + " " + p.Y + " to " + lastSel.X + " " + lastSel.Y);
                                Font font = new Font(FontFamily.GenericMonospace, 10.0F, FontStyle.Regular);
                                canvas.DrawString("Path: " + pathList.Count + ", distance: " + DistanceInStraightLineBetweenPoints(p, lastSel), font, new SolidBrush(Color.DarkGreen), new Point((p.X + lastSel.X) / 2, (p.Y + lastSel.Y) / 2));
                            }
                            break;
                        }
                    }
                    break;
                case RadioOptions.Ant:
                    foreach (Point p in nodeList)
                    {
                        if (InsideCircle(p.X, p.Y, radius, e.X, e.Y))
                        {
                            if (lastSel != Point.Empty)
                            {
                                RunAnt(p, lastSel);
                            }
                        }
                    }
                    break;
            }
            DebugLabel(e.X + " " + e.Y);
        }

        private void radioButtonPoint_CheckedChanged(object sender, EventArgs e)
        {
            rOp = RadioOptions.Point;
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            rOp = RadioOptions.Line;
        }

        private void radioButtonAnt_CheckedChanged(object sender, EventArgs e)
        {
            rOp = RadioOptions.Ant;
        }

        private void radioButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            rOp = RadioOptions.Select;
        }
    }
}
