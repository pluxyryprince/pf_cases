using System;
using System.Windows.Forms;

namespace pfr
{
    public partial class admin_authorization : Form
    {
        public admin_authorization()
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
    }
}
