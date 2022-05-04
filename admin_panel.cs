using System;
using System.Windows.Forms;

namespace pfr
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }
        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.пользователиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pfr_casesDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void admin_authorization_Load(object sender, EventArgs e)
        {
            authorization a = new authorization();
            a.Dispose();
            a.Close();
            try
            {
                this.пользователиTableAdapter.Fill(this.pfr_casesDataSet.пользователи);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }
        private void clear_data_Click(object sender, EventArgs e)
        {
            try
            {
                пользователиBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void add_account_Click(object sender, EventArgs e)
        {
            try
            {
                пользователиBindingSource.EndEdit();
                пользователиTableAdapter.Update(pfr_casesDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)//удалить строку
        {
            try
            {
                int delete = пользователиDataGridView.SelectedCells[0].RowIndex;
                пользователиDataGridView.Rows.RemoveAt(delete);
                пользователиTableAdapter.Update(pfr_casesDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            general g = new general();
            g.Show();
        }
        private void admin_panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void пенсионныеДелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            tabControl2.Show();
        }

        private void пенсионныеДелаToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void учетныеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.Hide();
            tabControl1.Show();
        }
    }
}
