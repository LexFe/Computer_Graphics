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
    public partial class ex10 : Form
    {
        public ex10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:\\years 3\\ComputerGrapic\\LAB\\Week1_ComGrapic\\Week1_ComGrapic\\1.png"), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            g.DrawImage(bmp, 10, 12);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:\\years 3\\ComputerGrapic\\LAB\\Week1_ComGrapic\\Week1_ComGrapic\\1.png"), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            g.DrawImage(bmp, 10, 270);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:\\years 3\\ComputerGrapic\\LAB\\Week1_ComGrapic\\Week1_ComGrapic\\1.png"), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            g.DrawImage(bmp, 10, 270);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:\\years 3\\ComputerGrapic\\LAB\\Week1_ComGrapic\\Week1_ComGrapic\\1.png"), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            g.DrawImage(bmp, 270, 270);

        }

        private void ex10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
