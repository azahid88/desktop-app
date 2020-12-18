using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flat_restaurant_app
{
    public partial class eatin : UserControl
    {
        public eatin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();

        }
    }
}
