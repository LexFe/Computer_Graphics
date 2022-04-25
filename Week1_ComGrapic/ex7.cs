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
    public partial class ex7 : Form
    {
        Graphics g;
        Bitmap bmp = new Bitmap("C:\\Users\\Advice\\Downloads\\TikTok.jpg");
        public ex7()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save Drawed Image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|BNP Files(*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
            m.Rotate(45);
            g.Transform = m;*/
            g.RotateTransform(45);
            g.DrawImage(bmp, new Rectangle(212, 0, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
            m.Translate(int.Parse(txtX.Text),int.Parse(txtY.Text),MatrixOrder.Prepend);
            g.Transform = m;*/
            g.TranslateTransform(int.Parse(textBox1.Text), int.Parse(textBox2.Text), MatrixOrder.Prepend);
            g.DrawImage(bmp, new Rectangle(212, 0, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

            Matrix m = new Matrix();
            m.Shear(float.Parse(textBox3.Text), float.Parse(textBox4.Text));
            g.Transform = m;

            g.DrawImage(bmp, new Rectangle(0, 50, 150, 150), 0, 0,
                        bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
m.Scale(float.Parse(txtShx.Text), float.Parse(txtShy.Text),MatrixOrder.Prepend);
            g.Transform = m;*/
            g.ScaleTransform(float.Parse(textBox3.Text), float.Parse(textBox4.Text), MatrixOrder.Prepend);
            g.DrawImage(bmp, new Rectangle(112, 300, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

           

        }

        private void ex7_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, 150, 150);

            //ແຕ້ມຮູບອອກມາກຳນົດຂະໜາດເປັນ 150x150
            g.DrawImage(bmp, rect);

        }
    }
}
