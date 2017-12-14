using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bata
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPurchase p = new NewPurchase();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePurchase p = new UpdatePurchase();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeletePurchase d = new DeletePurchase();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewPurchase p = new ViewPurchase();
            p.Show();
        }
    }
}
