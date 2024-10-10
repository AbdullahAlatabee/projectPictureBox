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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void choseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Filter = "Image File|*.png;*.jbg";
            ofd.Title = "chose any image to show it on the form.";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
                
                Bitmap bmp = new Bitmap(ofd.FileName);
                pictureBox1.Image =bmp;
                label1.Text = ofd.FileName;
            }
        }

        private void closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
