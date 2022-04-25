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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Week1_ComGrapic
{
    public partial class Form2 : Form
    {
        Graphics g; Pen p; int ps; SolidBrush b; Bitmap  bmp;
        public Form2()
        {
            b = new SolidBrush(Color.Gold);
            p = new Pen(b.Color, 3);
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = clr.Color;
                b = new SolidBrush(clr.Color);
                p = new Pen(clr.Color, 3);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);

            int x = 50;
            int y = 50;
            int width = 350;
            int height = 350;
            Rectangle rect = new Rectangle(x, y, width, height);

            

            g.DrawEllipse(p, 50, 50, 350, 350);
            g.FillEllipse(b, rect);

            PointF[] Star1 = Calculate5StarPoints(new PointF(225, 210), 50f, 20f);
            SolidBrush FillBrush = new SolidBrush(Color.Red);
            g.FillPolygon(FillBrush, Star1);
            g.DrawPolygon(new Pen(Color.Red, 1), Star1);

            pictureBox1.Image = bmp;
            g.Dispose();
            Invalidate();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save Drawed Image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|BNP Files(*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sf.FileName);
            }

        }
        private PointF[] Calculate5StarPoints(PointF Orig, float outerradius, float innerradius)
        {
            // Define some variables to avoid as much calculations as possible
            // conversions to radians
            double Ang36 = Math.PI / 5.0;   // 36Â° x PI/180
            double Ang72 = 2.0 * Ang36;     // 72Â° x PI/180
            // some sine and cosine values we need
            float Sin36 = (float)Math.Sin(Ang36);
            float Sin72 = (float)Math.Sin(Ang72);
            float Cos36 = (float)Math.Cos(Ang36);
            float Cos72 = (float)Math.Cos(Ang72);
            // Fill array with 10 origin points
            PointF[] pnts = { Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig };
            pnts[0].Y -= outerradius;  // top off the star, or on a clock this is 12:00 or 0:00 hours
            pnts[1].X += innerradius * Sin36; pnts[1].Y -= innerradius * Cos36; // 0:06 hours
            pnts[2].X += outerradius * Sin72; pnts[2].Y -= outerradius * Cos72; // 0:12 hours
            pnts[3].X += innerradius * Sin72; pnts[3].Y += innerradius * Cos72; // 0:18
            pnts[4].X += outerradius * Sin36; pnts[4].Y += outerradius * Cos36; // 0:24 
            // Phew! Glad I got that trig working.
            pnts[5].Y += innerradius;
            // I use the symmetry of the star figure here
            pnts[6].X += pnts[6].X - pnts[4].X; pnts[6].Y = pnts[4].Y;  // mirror point
            pnts[7].X += pnts[7].X - pnts[3].X; pnts[7].Y = pnts[3].Y;  // mirror point
            pnts[8].X += pnts[8].X - pnts[2].X; pnts[8].Y = pnts[2].Y;  // mirror point
            pnts[9].X += pnts[9].X - pnts[1].X; pnts[9].Y = pnts[1].Y;  // mirror point
            return pnts;
        }
    }
}
