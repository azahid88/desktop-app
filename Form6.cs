using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace flat_restaurant_app
{
    
    public partial class Form6 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = restaurant; uid = root");
        public Form6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c;
            int b = Convert.ToInt32(textBox1.Text);
            b = b - 1;
            if (b < 0)
            {
                b = 0;
                textBox1.Text = b.ToString();
                c = b * 15;
                textBox3.Text = c.ToString();
            }
            else
                textBox1.Text = b.ToString();
            c = b * 15;
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            a = a + 1;
            int b = a * 15;
            textBox3.Text = b.ToString();
            textBox1.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into tem_order values ('" + this.textBox2.Text + "','" + Convert.ToInt32(textBox1.Text) + "','" + Convert.ToInt32(textBox3.Text) + "') ", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
