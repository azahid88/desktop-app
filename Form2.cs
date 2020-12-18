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
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = restaurant; uid = root");
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32 (textBox1.Text);
            a = a + 1;
            int b = a * 20;
            textBox3.Text = b.ToString();
            textBox1.Text = a.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c=20;
            int b = Convert.ToInt32(textBox1.Text);
            b = b - 1;
            if (b < 0)
            {
                b = 0;
                textBox1.Text = b.ToString();
                c = b * 20;
                textBox3.Text = c.ToString();
            }
            else
                textBox1.Text = b.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into tem_order values ('" +this.textBox2.Text+ "','" + Convert.ToInt32( textBox1.Text)+"','" + Convert.ToInt32( textBox3.Text) + "') ", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            

        }
    }
}
