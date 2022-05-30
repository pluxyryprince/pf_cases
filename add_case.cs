using System;
using System.Windows.Forms;

namespace pfr
{
    public partial class add_case : Form
    {
        public add_case()
        {
            InitializeComponent();
        }
        private void действующие_делаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.действующие_делаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pfr_casesDataSet);
        }
        private void add_case_Load(object sender, EventArgs e)
        {
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);
        }
        private void clear_data_Click(object sender, EventArgs e)
        {
            try
            {
                действующие_делаBindingSource.AddNew();
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
                действующие_делаBindingSource.EndEdit();
                действующие_делаTableAdapter.Update(pfr_casesDataSet);
                MessageBox.Show("Данные успешно добавлены");
                this.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
