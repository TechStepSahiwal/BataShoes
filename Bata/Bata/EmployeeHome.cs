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
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale s = new Sale();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Return r = new Return();
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Change_Password c = new Change_Password();
            c.Show();
        }
    }
}
