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
using System.Drawing.Imaging;
using System.Drawing.Printing;


namespace Week1_ComGrapic
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen p;
        float ps;
        Brush b;

        public Form1()
        {
            InitializeComponent();
            ps = 1.0f;
            b = new SolidBrush(Color.Blue);
            button3.BackColor = ((SolidBrush)b).Color;
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);
            g.DrawRectangle(p, 50, 50, 200, 200);
            g.FillRectangle(b, 51, 51, 198, 198);
            g.DrawEllipse(p, 50, 250, 100, 200);
            g.FillEllipse(b, 51, 251, 98, 198);
            Font t = new Font("Saysettha OT", 16);
            g.DrawString("computer graphics ", t, Brushes.Black, 200, 10);
            g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            g = this.CreateGraphics();
            p = new Pen(Color.BlueViolet, ps);
            g.DrawRectangle(p, 50, 50, 200, 200);
            g.FillRectangle(b, 51, 51, 198, 198);
            g.DrawEllipse(p, 50, 250, 100, 200);
            g.FillEllipse(b, 51, 251, 98, 198);

            Font t = new Font("Times New Roman", 18);
            g.DrawString("Computer graphics ", t, Brushes.DarkRed, 300, 50);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.Dispose();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            ps = (float)numericUpDown1.Value;
            Invalidate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                /*button3.BackColor = clr.Color;*/
                b = new SolidBrush(clr.Color);
                Invalidate();
            }

        }
    }
}
