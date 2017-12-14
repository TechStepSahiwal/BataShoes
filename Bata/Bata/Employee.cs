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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee a = new AddEmployee();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Employee d = new Delete_Employee();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateEmployee u = new UpdateEmployee();
            u.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewEmployee v = new ViewEmployee();
            v.Show();
        }
    }
}
