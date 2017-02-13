using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AntsAlgorithm.Classes;
using AntsAlgorithm.Enums;

namespace AntsAlgorithm.Views
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

            nodeList.Add(new Point(239, 107));
            nodeList.Add(new Point(775, 225));

            canvas = CreateGraphics();
            brush = new SolidBrush(Color.Black);
            start = true;
            nodeSelect = false;
            rOp = RadioOptions.Point;
        }

        #region graphic shits

        private void DrawAntPooint(Point node)
        {
            if (start)
            {
                canvas.FillEllipse(new SolidBrush(Color.Red), nodeList[0].X, nodeList[0].Y, radius, radius);
                canvas.FillEllipse(new SolidBrush(Color.Red), nodeList[1].X, nodeList[1].Y, radius, radius);
                Font font = new Font(FontFamily.GenericMonospace, 6.0F, FontStyle.Regular);
                canvas.DrawString("AntsColony " + nodeList.Count + "[" + nodeList[0].X + "," + nodeList[0].Y + "]", font, new SolidBrush(Color.Brown), new Point(nodeList[0].X, nodeList[0].Y));
                canvas.DrawString("Food :) " + nodeList.Count + "[" + nodeList[1].X + "," + nodeList[1].Y + "]", font, new SolidBrush(Color.Brown), new Point(nodeList[1].X, nodeList[1].Y));
                start = false;
            }
            nodeList.Add(new Point(node.X, node.Y));
            canvas.FillEllipse(brush, node.X, node.Y, radius, radius);
        }

        private void DrawLineBeetweenPoints(Point nodeA, Point nodeB)
        {
            canvas.DrawLine(new Pen(Color.Purple, 5), nodeA, nodeB);
        }

        public static void RunAnt(Point actuallyPoint, Point destinationPoint)//only graphically, not by algorithm 
        {
            if (actuallyPoint == destinationPoint)
            {

            }
            else
            {

            }
        }

        private void DebugLabel(String message)
        {
            labelDebug.Text = message;
        }

        private void DebugLabel2(String message)
        {
            labelDebug2.Text = message;
        }

        #endregion

        #region form events

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            switch (rOp)
            {
                case RadioOptions.Select:
                    foreach (Point p in nodeList)
                    {
                        if (Utilities.InsideCircle(p.X, p.Y, radius, e.X, e.Y))
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
                        if (!Utilities.InsideCircle(p.X, p.Y, radius, e.X, e.Y))
                        {
                            DrawAntPooint(new Point(e.X, e.Y));
                            DebugLabel2("New node " + p.X + " " + p.Y);
                            Font font = new Font(FontFamily.GenericMonospace, 6.0F, FontStyle.Regular);
                            canvas.DrawString("Point " + nodeList.Count + "[" + e.X + "," + e.Y + "]", font, new SolidBrush(Color.Brown), new Point(e.X, e.Y));
                            break;
                        }
                    }
                    break;
                case RadioOptions.Line:
                    foreach (Point p in nodeList)
                    {
                        if (Utilities.InsideCircle(p.X, p.Y, radius, e.X, e.Y))
                        {
                            if (lastSel != Point.Empty)
                            {
                                DrawLineBeetweenPoints(lastSel, new Point(p.X, p.Y));
                                Dictionary<Point, Point> test  = new Dictionary<Point, Point>();
                                test.Add(new Point(lastSel.X, lastSel.Y), new Point(p.X, p.Y));
                                pathList.Add(pathList.Count + 1, test);
                                DebugLabel2("New path " + p.X + " " + p.Y + " to " + lastSel.X + " " + lastSel.Y);
                                Font font = new Font(FontFamily.GenericMonospace, 7.0F, FontStyle.Regular);
                                canvas.DrawString("Path " + pathList.Count + "[" + Math.Round(Utilities.DistanceInStraightLineBetweenPoints(p, lastSel), 2) + "]", font, new SolidBrush(Color.DarkGreen), new Point((p.X + lastSel.X) / 2, (p.Y + lastSel.Y) / 2));
                            }
                            break;
                        }
                    }
                    break;
                case RadioOptions.Ant:
                    foreach (Point p in nodeList)
                    {
                        if (Utilities.InsideCircle(p.X, p.Y, radius, e.X, e.Y))
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

#endregion
    }
}
