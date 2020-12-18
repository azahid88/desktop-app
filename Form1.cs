using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flat_restaurant_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel5.Height = button2.Height;
            panel5.Top = button2.Top;
            userControl11.BringToFront();
            panel6.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Height = button2.Height;
            panel5.Top = button2.Top;
            userControl11.BringToFront();
            panel6.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Height = button3.Height;
            panel5.Top = button3.Top;
            panel6.Hide();
            eatin1.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eatin1_Load(object sender, EventArgs e)
        {

        }

        private void delivery1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Show();
            button9.Focus();
            delivery1.BringToFront();
            panel5.Height = button4.Height;
            panel5.Top = button4.Top;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            delivery1.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            delibery21.BringToFront();
            button10.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delibery21.BringToFront();
            panel5.Height = button5.Height;
            panel5.Top = button5.Top;
            panel6.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            panel5.Height = button6.Height;
            panel5.Top = button6.Top;
            panel6.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bill f1 = new bill();
            f1.Show();
        }
    }
}
