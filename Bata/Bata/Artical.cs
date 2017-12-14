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
    public partial class Artical : Form
    {
        public Artical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddArtical a = new AddArtical();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteArtical d = new DeleteArtical();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateArtical a = new UpdateArtical();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewArtical v = new ViewArtical();
            v.Show();
        }
    }
}
