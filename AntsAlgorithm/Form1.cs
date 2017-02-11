using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntsAlgorithm
{
    public partial class Form1 : Form
    {

        private List<Point> pointList;
        private Graphics canvas;
        private Brush brush;
        private bool start;
        private const short radius = 20;
        private bool pointSelect;
        private bool drawPoint;
        private Point lastSel;

        public Form1()
        {
            InitializeComponent();
            pointList = new List<Point>();
            pointList.Add(new Point(139, 107));//home
            pointList.Add(new Point(575, 225));//food

            canvas = CreateGraphics();
            brush = new SolidBrush(Color.Black);
            start = true;
            pointSelect = false;
            drawPoint = true;

        }

        private void drawAntPooint(Point point)
        {
            if (start)
            {
                canvas.FillEllipse(new SolidBrush(Color.Red), pointList[0].X, pointList[0].Y, radius, radius);
                canvas.FillEllipse(new SolidBrush(Color.Red), pointList[1].X, pointList[1].Y, radius, radius);
                start = false;
            }
            pointList.Add(new Point(point.X, point.Y));
            canvas.FillEllipse(brush, point.X, point.Y, radius, radius);
        }

        private void drawLineBeetweenPoints(Point pointA, Point pointB)
        {
            canvas.DrawLine(new Pen(Color.Purple, 5), pointA, pointB );
        }

        private void DebugLabel(String message)
        {
            labelDebug.Text = message;
        }

        public static bool InsideCircle(int xc, int yc, int r, int x, int y)
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            DebugLabel(e.X + " " + e.Y);

            if (!drawPoint && lastSel != Point.Empty)
            {
                drawLineBeetweenPoints(lastSel, new Point(e.X, e.Y));
                lastSel = Point.Empty;
            }

            foreach (Point p in pointList)
            {
                if (InsideCircle(p.X, p.Y, radius, e.X, e.Y))
                {
                    DebugLabel("kropka!!!");
                    pointSelect = true;
                    lastSel = p;
                    drawPoint = false;
                    break;
                }
            }

            if(drawPoint)
                drawAntPooint(new Point(e.X, e.Y));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drawPoint = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            drawPoint = false;
        }

    }
}
