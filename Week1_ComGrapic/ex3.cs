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

    public partial class EX4 : Form
    {
        Graphics g;
        SolidBrush b;
        Pen p;
        Bitmap im, bmp;

        public EX4()
        {
            InitializeComponent();
            b = new SolidBrush(Color.Red);
            button2.BackColor = ((SolidBrush)b).Color;
            p = new Pen(b.Color, 3);
            im = new Bitmap("C:\\years 3\\ComputerGrapic\\LAB\\Week1_ComGrapic\\Week1_ComGrapic\\TikTok.jpg");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = clr.Color;
                b = new SolidBrush(clr.Color);
                p = new Pen(clr.Color, 3);
                pictureBox1.Invalidate();
            }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Dash")
            {
                p.DashStyle = DashStyle.Dash;
                pictureBox1.Refresh();
            }
            if (comboBox1.SelectedItem == "DashDot")
            {
                p.DashStyle = DashStyle.DashDot;
                pictureBox1.Refresh();
            }
            if (comboBox1.SelectedItem == "DashDotDot")
            {
                p.DashStyle = DashStyle.DashDotDot;
                pictureBox1.Refresh();
            }
            if (comboBox1.SelectedItem == "Solid")
            {
                p.DashStyle = DashStyle.Solid;
                pictureBox1.Refresh();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dash");
            comboBox1.Items.Add("DashDot");
            comboBox1.Items.Add("DashDotDot");
            comboBox1.Items.Add("Solid");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(im, 10, 10, 200, 200);
            g.DrawRectangle(p, 10, 10, 200, 200);
            pictureBox1.Image = bmp;
            /*this.CreateGraphics().DrawImage(bmp, 0, 0);*/
            g.Dispose();
            Invalidate();

        }
    }
}
