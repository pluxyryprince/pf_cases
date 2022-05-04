using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.EntityFramework;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pfr_casesDataSet.действующие_дела". При необходимости она может быть перемещена или удалена.
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);
            authorization a = new authorization();
            a.Hide();
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_access access = new admin_access();
            access.Show();
        }
        private void general_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
