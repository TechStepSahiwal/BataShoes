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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Change_Password c = new Change_Password();
            c.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale S = new Sale();
            S.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size s = new Size();
            s.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Artical a = new Artical();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Employee w= new Employee();
            w.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Branch b = new Branch();
            b.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Vendors v = new Vendors();
            v.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
