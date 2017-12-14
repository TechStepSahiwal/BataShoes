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
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBranch b = new AddBranch();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteBranch d = new DeleteBranch();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateBranch u = new UpdateBranch();
            u.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Branch b = new View_Branch();
            b.Show();
        }
    }
}
