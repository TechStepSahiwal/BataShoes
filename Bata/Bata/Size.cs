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
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSize a = new AddSize();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteSize d = new DeleteSize();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateSize s = new UpdateSize();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewSize v = new ViewSize();
            v.Show();
        }
    }
}
