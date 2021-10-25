using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int phut = Convert.ToInt32(label1.Text);
            int giay = Convert.ToInt32(label2.Text);
            giay--;
            if(giay < 0)
            {
                giay = 59;
                phut--;
            }
            if (giay < 10)
                label2.Text = "0" + giay;
            else
                label2.Text = "" + giay;
            if (phut < 10)
                label1.Text = "0" + phut;
            else
                label1.Text = "" + phut;
            if (giay == 0 && phut == 0)
            {
                timer1.Stop();
                {
                    frmMessage f = new frmMessage();
                    this.Hide();
                    f.ShowDialog();
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                button1.Text = "Chạy";
                timer1.Start();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Dừng lại";
            timer1.Stop();
        }
       
    }
}
