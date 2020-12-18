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
    public partial class bill : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = restaurant; uid = root");
        public bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();




            MySqlDataAdapter sqt = new MySqlDataAdapter("SELECT * FROM tem_order", conn);
            DataTable dt = new DataTable();
            sqt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView1.Width,this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp,new Rectangle(0,0,this.dataGridView1.Width,this.dataGridView1.Height));
            e.Graphics.DrawImage(bmp,250,90);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
