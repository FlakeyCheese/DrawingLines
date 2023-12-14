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
        static int red = 0;
        static int green = 0;
        static int blue = 0;
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
            
            foreach (LineSegment line in lines)
            {   Pen thisPen = new Pen(Color.FromArgb(line.red, line.green, line.blue), 5);
                e.Graphics.DrawLine(thisPen,line.StartPoint, line.EndPoint);
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
            lines.Add(new LineSegment(startPoint, endPoint, red, green, blue));
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            DrawLine(double.Parse(txt_angle.Text), double.Parse(txt_length.Text));
            Point startPoint = new Point(startX, startY);
            Point endPoint = new Point(endX, endY);
            lines.Add(new LineSegment(startPoint, endPoint, red, green, blue));
            Refresh();
            startX = endX;
            startY = endY;
        }

        private void btn_colour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            red = colorDialog1.Color.R;
            green = colorDialog1.Color.G;
            blue = colorDialog1.Color.B;
        }
    }
    class LineSegment
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }



        public LineSegment(Point startPoint, Point endPoint, int red, int green, int blue)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }



    }
}
