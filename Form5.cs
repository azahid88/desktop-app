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
    public partial class Form5 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = restaurant; uid = root");
        public Form5()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into customer(name,mobile,content) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.richTextBox1.Text + "') ", conn);
            MySqlDataReader cdr;
            
            cdr = cmd.ExecuteReader();
            MessageBox.Show("Submitted successfully ");
        }
    }
}
