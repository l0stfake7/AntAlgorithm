using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntsAlgorithm.Classes;
using AntsAlgorithm.Enums;

namespace AntsAlgorithm
{
    public partial class MainForm : Form
    {
        private bool _start;
        private Brush _brush;
        private const short Radius = 10;
        private bool _nodeSelect;
        private SelectMode _rOp;
        private Point _lastSel;
        private Font _font;
        private Image antImage;
        private Point temp;
        private Bitmap bmp;
        private Graphics g;
        private World world;
        private int counter;

        #region form events

        public MainForm()
        {
            InitializeComponent();
            DebugLabel1("work");
            DebugLabel2("work2");
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.PeachPuff);
 
            world = new World
            {
                NodeList = new List<Point>(),
                Ants = new List<Ant>(),
                PathList = new Dictionary<int, Tuple<Point, Point>>()
            };

            DrawStart();

            _brush = new SolidBrush(Color.Black);
            _nodeSelect = false;
            _start = false;
            _rOp = SelectMode.Select;
            _lastSel = world.NodeList[0];
            counter = 0;

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
                    foreach (Point p in world.NodeList)
                    {
                        if (Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            _lastSel = p; //current item in loop
                            DebugLabel2("Select " + p.X + " " + p.X);
                            break;
                        }
                    }
                    break;
                }
                case SelectMode.Node:
                {
                    foreach (Point p in world.NodeList)
                    {
                        if (!Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            world.NodeList.Add(new Point(e.X, e.Y));
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
                    foreach (Point p in world.NodeList)
                    {
                        if (Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            if (_lastSel != Point.Empty)
                            {
                                var path = Tuple.Create(new Point(_lastSel.X, _lastSel.Y), new Point(p.X, p.Y));
                                world.PathList.Add(world.PathList.Count + 1, path);
                                DrawPath(_lastSel, new Point(p.X, p.Y));
                                DebugLabel2("New path " + p.X + " " + p.Y + " to " + _lastSel.X + " " + _lastSel.Y);
                            }
                            break;
                        }
                    }
                    break;
                }
                case SelectMode.Ant:
                {
                    foreach (Point p in world.NodeList)
                    {
                        if (Utility.InsideCircle(p.X, p.Y, Radius, e.X, e.Y))
                        {
                            if (_lastSel != Point.Empty)
                            {
                                var path = Tuple.Create(new Point(_lastSel.X, _lastSel.Y), new Point(p.X, p.Y));
                                foreach (KeyValuePair<int, Tuple<Point, Point>> entry in world.PathList)
                                {
                                    if (entry.Value.Equals(path))
                                    {//find path with start point p.x, p.y and end point e.x e.y, todo find from e.x e.y to p.x, p.y
                                        Ant ant = new Ant(0, 0);
                                        world.Ants.Add(ant);
                                        ant.AntThread.Start();
                                        while (!ant.AntThread.IsAlive)
                                        {
                                            Thread.Sleep(1);
                                        }
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
            //g.Clear(Color.PeachPuff);
            if (world.Ants.Count != 0)
            {
                //bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                //g = Graphics.FromImage(bmp);
                for (int x = 0; x < world.Ants.Count; x++)
                {

                    Point p1 = new Point(world.Ants[x].X, world.Ants[x].Y);
                    Point p2 = new Point(world.Ants[x].X + 50, world.Ants[x].Y + 50);

                    Font drawFont = new Font("Arial", 8);
                    SolidBrush drawBrush = new SolidBrush(Color.Fuchsia);
                    g.DrawEllipse(new Pen(Color.Black, 5), world.Ants[x].X, world.Ants[x].Y, 5, 5);
                    g.DrawString(x.ToString(), drawFont, drawBrush, world.Ants[x].X + 25, world.Ants[x].Y - 5);
                    //g.DrawEllipse(p, World.Ants[x].X + 50, World.Ants[x].Y + 50, 5, 5);
                    //g.DrawLine(p, p1, p2);

                }
                //pictureBox.Image = bmp;
            }
            counter++;
            countLabel.Text = "On Paint called counter: " + counter;
        }
        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            World.Run = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            World.Run = false;
            for (int i = 0; i < world.Ants.Count; i++)
            {
                world.Ants[i].AntThread.Abort();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            World.Run = false;
            world.NodeList.Clear();
            world.Ants.Clear();
            world.PathList.Clear();
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
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel.Text = "X: " + e.X + " Y:" + e.Y;
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
            world.NodeList.Add(new Point(100, 150));
            world.NodeList.Add(new Point(250, 175));
            _font = new Font(FontFamily.GenericMonospace, 7.5F, FontStyle.Regular);
            g.FillEllipse(new SolidBrush(Color.Red), world.NodeList[0].X, world.NodeList[0].Y, Radius + 5, Radius + 5);
            g.DrawString("AntsColony " + "[" + world.NodeList[0].X + "," + world.NodeList[0].Y + "]", _font, new SolidBrush(Color.Brown), new Point(world.NodeList[0].X, world.NodeList[0].Y));
            g.FillEllipse(new SolidBrush(Color.Red), world.NodeList[1].X, world.NodeList[1].Y, Radius + 5, Radius + 5);
            g.DrawString("Food :) " + "[" + world.NodeList[1].X + "," + world.NodeList[1].Y + "]", _font, new SolidBrush(Color.Brown), new Point(world.NodeList[1].X, world.NodeList[1].Y));
            pictureBox.Image = bmp;
        }

        private void DrawNode(Point p)
        {
            g.FillEllipse(_brush, p.X, p.Y, Radius, Radius);
            _font = new Font(FontFamily.GenericMonospace, 6.0F, FontStyle.Regular);
            g.DrawString("Point " + world.NodeList.Count + "[" + p.X + "," + p.Y + "]", _font,
                new SolidBrush(Color.Brown), new Point(p.X, p.Y));
            pictureBox.Image = bmp;
        }

        private void DrawPath(Point a, Point b)
        {
            g.DrawLine(new Pen(Color.Purple, 4), a, b);
            _font = new Font(FontFamily.GenericMonospace, 7.0F, FontStyle.Regular);
            g.DrawString(
                "Path " + world.PathList.Count + "[" +
                Math.Round(Utility.DistanceInStraightLineBetweenPoints(a, b), 2) + "]", _font,
                new SolidBrush(Color.DarkGreen),
                new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2)
            );
            pictureBox.Image = bmp;
        }

        #endregion
    }
}
