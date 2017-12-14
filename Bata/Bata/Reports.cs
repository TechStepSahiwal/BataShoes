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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailyShopMirror d = new DailyShopMirror();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnDetails d = new ReturnDetails();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StockDispatchInvoice s = new StockDispatchInvoice();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockRecieveInvoice s = new StockRecieveInvoice();
            s.Show();
        }
    }
}
