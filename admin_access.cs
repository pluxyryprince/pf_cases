using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfr
{
    public partial class admin_access : Form
    {
        public admin_access()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (login.Text == "admin" && pass.Text == "1q2w3e4r5t6y7u8i9o0p" || login.Text == "root" && pass.Text == "root") 
            {
                general g = new general();
                g.Close();
                this.Hide();
                admin_panel a = new admin_panel();
                a.Show();
            }
            else
            {
                MessageBox.Show("Access denied. Try again");
            }
        }
        private void admin_access_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
