using House_Rental_Management_System.ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rental_Management_System
{
    public partial class First_Page : Form
    {
        public First_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Login adminForm = new Admin_Login();
            adminForm.FormClosed += (s, args) => Application.Exit();
            adminForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register(); 
            registerForm.FormClosed += (s, args) => Application.Exit();
            registerForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
