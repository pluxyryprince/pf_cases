using System;
using System.Windows.Forms;

namespace pfr
{
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }
        private void general_Load(object sender, EventArgs e)
        {
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);
        }
        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            admin_access access = new admin_access();
            access.Show();
        }
        private void general_FormClosing_1(object sender, FormClosingEventArgs e)
        {         
            Application.Exit();
        }
    }
}
