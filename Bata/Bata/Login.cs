﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                AdminHome h = new AdminHome();
                h.Show();
                this.Hide();
            }
            if (textBox1.Text == "employee" && textBox2.Text == "123")
            {
                EmployeeHome o = new EmployeeHome();
                o.Show();
                this.Hide();
               
            }
        }
    }
}
