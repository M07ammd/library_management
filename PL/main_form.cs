using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libaray_management.PL
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void p_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;    
            }
            else
            {
                this.WindowState=FormWindowState.Normal;
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (p_bar.Size.Width == 175)
            {
                p_bar.Width = 50;
                button1.RightToLeft= RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                p_bar.Width = 175;
                button1.RightToLeft = RightToLeft.No;
                button2.RightToLeft = RightToLeft.No;
                button3.RightToLeft = RightToLeft.No;
                button4.RightToLeft = RightToLeft.No;
                button5.RightToLeft = RightToLeft.No;
                button6.RightToLeft = RightToLeft.No;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void p_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
