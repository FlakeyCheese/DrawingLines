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
        static int startX= 300;
        static int startY=300;
        static int endX=300;
        static int endY = 300;
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

            // Calculate the ending point coordinates from the start point and the length
            endX = (int)(startX + length * Math.Sin(angle * Math.PI / 180));
            endY = (int)(startY - length * Math.Cos(angle * Math.PI / 180));

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen startPen = new Pen(Color.Black, 1);
            Rectangle startRectangle = new Rectangle(startX, startY, 2, 2);
            g.DrawRectangle(startPen,startRectangle);
            foreach (LineSegment line in lines)
            {   Pen thisPen = new Pen(Color.FromArgb(line.red, line.green, line.blue), 5);
                g.DrawLine(thisPen,line.StartPoint, line.EndPoint);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            
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

        private void btn_changeXY_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txt_newX.Text);
            int y = Int32.Parse(txt_newY.Text);
            if (x < 0) { x = 0; }
            else if (x>this.Width) { x = this.Width-100; }
            startX  = (int)x;

            if (y>this.Height) { y = this.Height-100; }
            else if (y<0) { y = 0; }
            startY = (int)y;


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
