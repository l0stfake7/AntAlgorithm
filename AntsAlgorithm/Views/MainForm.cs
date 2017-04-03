using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using AntsAlgorithm.Classes;
using AntsAlgorithm.Enums;

namespace AntsAlgorithm.Views
{
    public partial class MainForm : Form
    {
        private readonly Brush _brush;
        private const short Radius = 10;
        private SelectMode _rOp;
        private Point _lastSel;
        private Font _font;
        private readonly Bitmap _bmp;
        private Graphics g;
        private readonly World _world;
        private int _counter;

        #region form events

        public MainForm()
        {
            InitializeComponent();
            DebugLabel1("work");
            DebugLabel2("work2");
            _bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(_bmp);
            g.Clear(Color.PeachPuff);

            _world = new World
            {
                NodeList = new List<Point>(),
                Ants = new List<Ant>(),
                PathList = new Dictionary<int, Tuple<Point, Point>>()
            };

            DrawStart();

            _brush = new SolidBrush(Color.Black);
            _rOp = SelectMode.Select;
            _lastSel = _world.NodeList[0];
            _counter = 0;

        }

        private void radioButtonPath_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = SelectMode.Path;
        }

        private void radioButtonNode_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = SelectMode.Node;
        }

        private void radioButtonAnt_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = SelectMode.Ant;
        }

        private void radioButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            _rOp = SelectMode.Select;
        }

        private void pictureBox_Click(object sender, EventArgs ea)
        {
            MouseEventArgs e = (MouseEventArgs)ea;
            DebugLabel1("Select " + e.X + " " + e.X);
            switch (_rOp)
            {
                case SelectMode.Select:
                {
                    foreach (Point p in _world.NodeList)
                    {
                        if (Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            _lastSel = p; //current item in loop
                            DebugLabel2("Select " + p.X + " " + p.Y);
                            break;
                        }
                    }
                    break;
                }
                case SelectMode.Node:
                {
                    foreach (Point p in _world.NodeList)
                    {
                        if (!Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            _world.NodeList.Add(new Point(e.X, e.Y));
                            DrawNode(new Point(e.X, e.Y));
                            DebugLabel2("New node " + e.X + " " + e.Y);
                            //pictureBox.Refresh();
                            break;
                        }
                    }
                    break;
                }
                case SelectMode.Path:
                {
                    foreach (Point p in _world.NodeList)
                    {
                        if (Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            if (_lastSel != Point.Empty)
                            {
                                var path = Tuple.Create(new Point(_lastSel.X, _lastSel.Y), new Point(p.X, p.Y));
                                _world.PathList.Add(_world.PathList.Count + 1, path);
                                DrawPath(_lastSel, new Point(p.X, p.Y));
                                DebugLabel2("New path " + _lastSel.X + " " + _lastSel.Y + " to " + p.X + " " + p.Y);
                            }
                            break;
                        }
                    }
                    break;
                }
                case SelectMode.Ant:
                {
                    foreach (Point p in _world.NodeList)
                    {
                        if (Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            if (_lastSel != Point.Empty)
                            {
                                var path = Tuple.Create(new Point(_lastSel.X, _lastSel.Y), new Point(p.X, p.Y));
                                foreach (KeyValuePair<int, Tuple<Point, Point>> entry in _world.PathList)
                                {
                                    if (entry.Value.Equals(path))
                                    {//find path with start point p.x, p.y and end point e.x e.y, ///todo find from e.x e.y to p.x, p.y
                                        IList<Tuple<Double, Double>> points = Utility.SplitLine(
                                            new Tuple<Double, Double>(_lastSel.X, _lastSel.Y),
                                            new Tuple<Double, Double>(p.X, p.Y), 25);
                                        Ant ant = new Ant(points);
                                        _world.Ants.Add(ant);
                                        DebugLabel2("New Ant");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                }
            }
            DebugLabel1(e.X + " " + e.Y);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {//here only moving
            if (_world.Ants.Count > 0 && World.Run)
            {
                g.Clear(Color.PeachPuff);
                for (int x = 0; x < _world.Ants.Count; x++)
                {
                    Font drawFont = new Font("Arial", 8);
                    SolidBrush drawBrush = new SolidBrush(Color.Fuchsia);
                    g.DrawEllipse(new Pen(Color.DarkGreen, 5), (float)_world.Ants[x].ActualPoint.Item1, (float)_world.Ants[x].ActualPoint.Item2, 5, 5);
                    g.DrawString(x.ToString(), drawFont, drawBrush, (float)_world.Ants[x].ActualPoint.Item1 + 25, (float)_world.Ants[x].ActualPoint.Item2 - 5);                  
                }
                _font = new Font(FontFamily.GenericMonospace, 7.5F, FontStyle.Regular);
                g.FillEllipse(new SolidBrush(Color.Red), _world.NodeList[0].X, _world.NodeList[0].Y, Radius + 5, Radius + 5);
                g.DrawString("AntsColony " + "[" + _world.NodeList[0].X + "," + _world.NodeList[0].Y + "]", _font, new SolidBrush(Color.Brown), new Point(_world.NodeList[0].X, _world.NodeList[0].Y));
                g.FillEllipse(new SolidBrush(Color.Red), _world.NodeList[1].X, _world.NodeList[1].Y, Radius + 5, Radius + 5);
                g.DrawString("Food :) " + "[" + _world.NodeList[1].X + "," + _world.NodeList[1].Y + "]", _font, new SolidBrush(Color.Brown), new Point(_world.NodeList[1].X, _world.NodeList[1].Y));

                foreach (Point p in _world.NodeList)
                {
                    g.FillEllipse(_brush, p.X, p.Y, Radius, Radius);
                    _font = new Font(FontFamily.GenericMonospace, 6.0F, FontStyle.Regular);
                    g.DrawString("Point " + _world.NodeList.Count + "[" + p.X + "," + p.Y + "]", _font,
                        new SolidBrush(Color.Brown), new Point(p.X, p.Y));
                }

                foreach (KeyValuePair<int, Tuple<Point, Point>> entry in _world.PathList)
                {
                    g.DrawLine(new Pen(Color.Purple, 4), entry.Value.Item1, entry.Value.Item2);
                    _font = new Font(FontFamily.GenericMonospace, 7.0F, FontStyle.Regular);
                    g.DrawString(
                        "Path " + _world.PathList.Count + "[" +
                        Math.Round(Utility.DistanceInStraightLineBetweenPoints(entry.Value.Item1, entry.Value.Item2), 2) + "]", _font,
                        new SolidBrush(Color.DarkGreen),
                        new Point((entry.Value.Item1.X + entry.Value.Item2.X) / 2, (entry.Value.Item1.Y + entry.Value.Item2.Y) / 2)
                    );
                }
                pictureBox.Image = _bmp;
            }
            _counter++;
            countLabel.Text = "On Paint called counter: " + _counter;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            World.Run = true;
            for (int i = 0; i < _world.Ants.Count; i++)
            {
                _world.Ants[i].AntThread.Start();
                while (!_world.Ants[i].AntThread.IsAlive)
                {
                    Thread.Sleep(1);
                }
            }
            pictureBox.Image = _bmp;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            World.Run = false;
            for (int i = 0; i < _world.Ants.Count; i++)
            {
                if (!_world.Ants[i].AntThread.IsAlive)
                    _world.Ants[i].AntThread.Abort();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            World.Run = false;
            _world.NodeList.Clear();
            _world.Ants.Clear();
            _world.PathList.Clear();
            g.Clear(Color.PeachPuff);
            DrawStart();
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            toolStripStatusLabel.Text = @"X: 0.00 Y: 0.00";
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel.Text = @"X: " + e.X + @" Y:" + e.Y;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = @"jpeg (*.jpeg)|*.jpeg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox.Width);
                int height = Convert.ToInt32(pictureBox.Height);
                Bitmap bmp = new Bitmap(width, height);
                pictureBox.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        #endregion

        #region graphic shits

        private void DebugLabel1(String message)
        {
            labelDebug1.Text = message;
        }

        private void DebugLabel2(String message)
        {
            labelDebug2.Text = message;
        }

        private void DrawStart()
        {
            _world.NodeList.Add(new Point(100, 150));
            _world.NodeList.Add(new Point(250, 175));
            _font = new Font(FontFamily.GenericMonospace, 7.5F, FontStyle.Regular);
            g.FillEllipse(new SolidBrush(Color.Red), _world.NodeList[0].X, _world.NodeList[0].Y, Radius + 5, Radius + 5);
            g.DrawString("AntsColony " + "[" + _world.NodeList[0].X + "," + _world.NodeList[0].Y + "]", _font, new SolidBrush(Color.Brown), new Point(_world.NodeList[0].X, _world.NodeList[0].Y));
            g.FillEllipse(new SolidBrush(Color.Red), _world.NodeList[1].X, _world.NodeList[1].Y, Radius + 5, Radius + 5);
            g.DrawString("Food :) " + "[" + _world.NodeList[1].X + "," + _world.NodeList[1].Y + "]", _font, new SolidBrush(Color.Brown), new Point(_world.NodeList[1].X, _world.NodeList[1].Y));
            pictureBox.Image = _bmp;
        }

        private void DrawNode(Point p)
        {
            g.FillEllipse(_brush, p.X, p.Y, Radius, Radius);
            _font = new Font(FontFamily.GenericMonospace, 6.0F, FontStyle.Regular);
            g.DrawString("Point " + _world.NodeList.Count + "[" + p.X + "," + p.Y + "]", _font,
                new SolidBrush(Color.Brown), new Point(p.X, p.Y));
            pictureBox.Image = _bmp;
        }

        private void DrawPath(Point a, Point b)
        {
            g.DrawLine(new Pen(Color.Purple, 4), a, b);
            _font = new Font(FontFamily.GenericMonospace, 7.0F, FontStyle.Regular);
            g.DrawString(
                "Path " + _world.PathList.Count + "[" +
                Math.Round(Utility.DistanceInStraightLineBetweenPoints(a, b), 2) + "]", _font,
                new SolidBrush(Color.DarkGreen),
                new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2)
            );
            pictureBox.Image = _bmp;
        }

        #endregion
    }
}
