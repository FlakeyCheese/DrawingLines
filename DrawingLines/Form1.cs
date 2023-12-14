using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingLines
{
    public partial class Form1 : Form
    {
        static int startX;
        static int startY;
        static int endX;
        static int endY;
        List<LineSegment> lines = new List<LineSegment>();
        public Form1()
        {
            InitializeComponent();
        }
        public static void DrawLine(double angle, double length)
        {

            // Calculate the ending point coordinates
            endX = (int)(startX + length * Math.Sin(angle * Math.PI / 180));
            endY = (int)(startY - length * Math.Cos(angle * Math.PI / 180));

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen redPen = new Pen(Color.FromArgb(0, 255, 0), 5);
            foreach (LineSegment line in lines)
            {
                e.Graphics.DrawLine(redPen,line.StartPoint, line.EndPoint);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startX = 300;
            startY = 300;
            endX = 300;
            endY = 305;
            Point startPoint = new Point(startX, startY);
            Point endPoint = new Point(endX, endY);
            lines.Add(new LineSegment(startPoint, endPoint));
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            DrawLine(double.Parse(txt_angle.Text), double.Parse(txt_length.Text));
            Point startPoint = new Point(startX, startY);
            Point endPoint = new Point(endX, endY);
            lines.Add(new LineSegment(startPoint, endPoint));
            Refresh();
            startX = endX;
            startY = endY;
        }
    }
    class LineSegment
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public LineSegment(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }



    }
}
