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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

       

        private void choseImage_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Enabled = true;
        }

        int s = -1, m = 0, h = 0, y = 0,Days=0;

        private void closed_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        string[] days = { "Saterday", "Saunday", "Monday", "Tuesday", "Wenesday", "Thursday", "Fraiday" };

        private void timer1_Tick(object sender, EventArgs e)
        {
            daysName.Text = days[Days];
            s++;
            if(s>9)
                label3.Text =s.ToString();
            else
                label3.Text ="0"+s.ToString();

            if (s >= 59)
            {
                s = 0;
                //timer1.Interval = 10;
                m++;

                if(m>9)
                    label2.Text= m.ToString();
                else
                    label2.Text="0"+m.ToString();   
            }

            if (m >= 59)
            {
                m = 0;
                h++;
                if(h>9)
                    label1.Text=h.ToString();
                else
                    label1.Text ="0"+h.ToString();
            }

            if (h >= 24)
            {
                h = 0;
                Days++;
            }

        }
    }
}
