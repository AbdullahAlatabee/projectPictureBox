using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdullah_Hassan_Abdoh_Hassan_Lab6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void choseImage_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap (pictureBox1.Width,pictureBox1.Height);
            //int x, y;
            //for (x = 0; x < 200; x++)
            //{
            //    y = x;
            //    bmp.SetPixel(x, y, Color.Red);
            //}
            //pictureBox1.Image = bmp;
            pictureBox1.CreateGraphics().DrawRectangle(Pens.Red,  150, 60,200,200);
            this.CreateGraphics().DrawRectangle(Pens.Red, 20, 40, 200, 200);
            //this.BackgroundImage = bmp;
        }

        private void closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
