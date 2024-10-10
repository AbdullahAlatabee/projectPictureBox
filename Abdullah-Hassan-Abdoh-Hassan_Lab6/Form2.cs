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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ToolTip tooltip1;
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                
                picImage.BorderStyle = BorderStyle.FixedSingle;
                picImage.Image = Image.FromFile(@textBox1.Text.Trim());

                tooltip1 = new ToolTip();
                tooltip1.SetToolTip(picImage, " Tool PictureBox .");
                this.AutoSize = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("pleas enter the path of the image");
            }
           
        }

        PictureBox picImage2 = new PictureBox();

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            
                picImage.Image = picImage2.Image;
                picImage.BackgroundImage = picImage2.BackgroundImage;
                picImage.BackColor = picImage2.BackColor;
                picImage.BackColor = Color.Silver;
            
        }
    }
}
