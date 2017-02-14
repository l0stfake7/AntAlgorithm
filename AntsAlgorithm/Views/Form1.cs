using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using AntsAlgorithm.Classes;
using AntsAlgorithm.Enums;

namespace AntsAlgorithm.Views
{
    public partial class MainForm : Form
    {

        private List<Point> _nodeList;
        private Dictionary<int, Tuple<Point, Point>> _pathList;
        private Graphics _canvas;
        private Brush _brush;
        private bool _start;
        private const short Radius = 10;
        private bool _nodeSelect;
        private RadioOptions _rOp;
        private Point _lastSel;
        private Font _font;


        public MainForm()
        {
            InitializeComponent();
            _nodeList = new List<Point>();
            _pathList = new Dictionary<int, Tuple<Point, Point>>();

            _nodeList.Add(new Point(239, 107));
            _nodeList.Add(new Point(775, 225));

            _canvas = CreateGraphics();
            _brush = new SolidBrush(Color.Black);
            _start = true;
            _nodeSelect = false;
            _rOp = RadioOptions.Point;
            _lastSel = _nodeList[0];
        }

        #region graphic shits

        private void DrawAntPooint(Point node)
        {//TODO check if new point is close to another
            if (_start)
            {
                _font = new Font(FontFamily.GenericMonospace, 6.0F, FontStyle.Regular);
                _canvas.FillEllipse(new SolidBrush(Color.Red), _nodeList[0].X, _nodeList[0].Y, Radius, Radius);
                _canvas.DrawString("AntsColony " + _nodeList.Count + "[" + _nodeList[0].X + "," + _nodeList[0].Y + "]", _font, new SolidBrush(Color.Brown), new Point(_nodeList[0].X, _nodeList[0].Y));
                _canvas.FillEllipse(new SolidBrush(Color.Red), _nodeList[1].X, _nodeList[1].Y, Radius, Radius);
                _canvas.DrawString("Food :) " + _nodeList.Count + "[" + _nodeList[1].X + "," + _nodeList[1].Y + "]", _font, new SolidBrush(Color.Brown), new Point(_nodeList[1].X, _nodeList[1].Y));
                _start = false;
            }
            _nodeList.Add(new Point(node.X, node.Y));
            _canvas.FillEllipse(_brush, node.X, node.Y, Radius, Radius);
        }

        private void DrawLineBeetweenPoints(Point nodeA, Point nodeB)
        {
            _canvas.DrawLine(new Pen(Color.Purple, 5), nodeA, nodeB);
        }

        private static void RunAnt(object source, ElapsedEventArgs e)
        {
            
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
            switch (_rOp)
            {
                case RadioOptions.Select:
                    foreach (Point p in _nodeList)
                    {
                        if (Utilities.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            _lastSel = p;//current item in loop
                            DebugLabel2("Select " + p.X + " " + p.Y);
                            break;
                        }
                    }
                    break;
                case RadioOptions.Point:
                    foreach (Point p in _nodeList)
                    {
                        if (!Utilities.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            DrawAntPooint(new Point(e.X, e.Y));
                            DebugLabel2("New node " + p.X + " " + p.Y);
                            _font = new Font(FontFamily.GenericMonospace, 6.0F, FontStyle.Regular);
                            _canvas.DrawString("Point " + _nodeList.Count + "[" + e.X + "," + e.Y + "]", _font, new SolidBrush(Color.Brown), new Point(e.X, e.Y));
                            break;
                        }
                    }
                    break;
                case RadioOptions.Line:
                    foreach (Point p in _nodeList)
                    {
                        if (Utilities.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            if (_lastSel != Point.Empty)
                            {
                                DrawLineBeetweenPoints(_lastSel, new Point(p.X, p.Y));

                                var test123 = Tuple.Create(new Point(_lastSel.X, _lastSel.Y), new Point(p.X, p.Y));

                                _pathList.Add(_pathList.Count + 1, test123);

                                DebugLabel2("New path " + p.X + " " + p.Y + " to " + _lastSel.X + " " + _lastSel.Y);
                                _font = new Font(FontFamily.GenericMonospace, 7.0F, FontStyle.Regular);
                                _canvas.DrawString("Path " + _pathList.Count + "[" + Math.Round(Utilities.DistanceInStraightLineBetweenPoints(p, _lastSel), 2) + "]", _font, new SolidBrush(Color.DarkGreen), new Point((p.X + _lastSel.X) / 2, (p.Y + _lastSel.Y) / 2));
                            }
                            break;
                        }
                    }
                    break;
                case RadioOptions.Ant:
                    foreach (Point p in _nodeList)
                    {
                        if (Utilities.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            if (_lastSel != Point.Empty)
                            {
                                var test123 = Tuple.Create(new Point(_lastSel.X, _lastSel.Y), new Point(p.X, p.Y));
                                foreach (KeyValuePair<int, Tuple<Point, Point>> entry in _pathList)
                                {
                                    if (entry.Value.Equals(test123))//find path with start point p.x, p.y and end point e.x e.y, todo find from e.x e.y to p.x, p.y
                                    {
                                        MessageBox.Show("Ok");
                                        System.Timers.Timer aTimer = new System.Timers.Timer();
                                        aTimer.Elapsed += RunAnt;
                                        aTimer.Interval = 100;
                                        aTimer.Enabled = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
            DebugLabel(e.X + " " + e.Y);
        }

        private void radioButtonPoint_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = RadioOptions.Point;
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = RadioOptions.Line;
        }

        private void radioButtonAnt_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = RadioOptions.Ant;
        }

        private void radioButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = RadioOptions.Select;
        }

#endregion
    }
}
