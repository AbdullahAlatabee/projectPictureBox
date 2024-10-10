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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ToolTip tooltip1;
        private void Form1_Load(object sender, EventArgs e)
        {
            picImage.Width = 450;
            picImage.Height = 300;
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.BackColor = Color.Red;
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Image = Image.FromFile("clobas.jpg");
            picImage.BackgroundImage = Image.FromFile("three.png");
            tooltip1 = new ToolTip();
            tooltip1.SetToolTip(picImage, " Tool PictureBox .");
            this.AutoSize = true;

        }

        PictureBox picImage2=new PictureBox();
        private void btnRemove_Click(object sender, EventArgs e)
        {
            picImage.Image = picImage2.Image;
            picImage.BackgroundImage = picImage2.BackgroundImage;
            picImage.BackColor = picImage2.BackColor;
        }
    }
}
