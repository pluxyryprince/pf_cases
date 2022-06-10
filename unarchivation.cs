using System;
using System.Windows.Forms;

namespace pfr
{
    public partial class unarchivation : Form
    {
        public unarchivation()
        {
            InitializeComponent();
        }

        private void clear_data_Click(object sender, EventArgs e)
        {
            try
            {
                запросы_архивных_делBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void запросы_архивных_делBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.запросы_архивных_делBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pfr_casesDataSet);
        }

        private void unarchivation_Load(object sender, EventArgs e)
        {
            this.запросы_архивных_делTableAdapter.Fill(this.pfr_casesDataSet.запросы_архивных_дел);
        }

        private void add_to_archiv_Click(object sender, EventArgs e)
        {
            try
            {
                запросы_архивных_делBindingSource.EndEdit();
                запросы_архивных_делTableAdapter.Update(pfr_casesDataSet);
                MessageBox.Show("Дело передано в действующие");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
