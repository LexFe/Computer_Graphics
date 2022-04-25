using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;



namespace Week1_ComGrapic
{
    public partial class ex8 : Form
    {
        Graphics g; Pen p;
        private void drawEllipe()
        {
            p = new Pen(Color.Red, 3);
            g.DrawEllipse(p, 10, 10, 100, 100);
        }

        private void FillRectangle()
        {
            p = new Pen(Color.Orange, 3);
            g.FillRectangle(Brushes.Cyan, 10, 180, 100, 100);
            g.Dispose();
        }


        public ex8()
        {
            InitializeComponent();
        }

        private void ex8_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            drawEllipe();
            FillRectangle();
            g.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(150, 0);
            drawEllipe();
            g.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(350, 30);
            g.RotateTransform(45);
            FillRectangle();
            g.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(0, 200);
            g.ScaleTransform(2, 1);
            FillRectangle();
            g.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Matrix m = new Matrix();
            m.Translate(-110, 120);
            m.Shear(2, 1);
            g.Transform = m;
            //g.TranslateTransform(350, 30);
            FillRectangle();
            g.Dispose();

        }
    }
}
