using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rental_Management_System.ADMIN
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            First_Page firstPageForm = new First_Page();
            firstPageForm.FormClosed += (s, args) => Application.Exit();
            firstPageForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
