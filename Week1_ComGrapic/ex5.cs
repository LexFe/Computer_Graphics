using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_ComGrapic
{
    public partial class ex5 : Form
    {

        Graphics g;
        Pen p;

        void DrawSingleBezier(Pen p, Graphics cg)
        {
            cg = this.CreateGraphics();
            
            Point pt1 = new Point(10, 20); Point pt2 = new Point(80, 150);
            Point pt3 = new Point(300, 200); Point pt4 = new Point(250, 45);
            cg.DrawBezier(p, pt1, pt2, pt3, pt4);
        }
        void DrawMultiBezier(Pen p, Graphics cg)
        {
            
            cg.TranslateTransform(100, 300);
            cg.RotateTransform(-90);
            Point[] pt = {new Point(10,15),new Point(300,60),
                          new Point(350,80),new Point(100,150),
                          new Point(10,200),new Point(350,150),
                         new Point(30,250)};
            cg.DrawBeziers(p, pt);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen p1 = new Pen(Color.Red, 5);
            DrawSingleBezier(p1, g);
            p = new Pen(Color.Blue, 5);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            DrawMultiBezier(p, g);
            g.Dispose();
        }



        public ex5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Pen p1 = new Pen(Color.Red, 5);
            DrawSingleBezier(p1, g);
            p = new Pen(Color.Blue, 5);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            DrawMultiBezier(p, g);
            g.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
