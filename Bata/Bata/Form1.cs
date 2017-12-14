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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            AdminHome h = new AdminHome();
            h.Show();
            EmployeeHome o = new EmployeeHome();
            o.Show();
            l.Show();
            this.Hide();
            
        }
    }
}
