using System;
using System.Windows.Forms;

namespace pfr
{
    public partial class delete_case : Form
    {
        public delete_case()
        {
            InitializeComponent();
        }

        private void архивные_делаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.архивные_делаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pfr_casesDataSet);
        }

        private void delete_case_Load(object sender, EventArgs e)
        {
            this.архивные_делаTableAdapter.Fill(this.pfr_casesDataSet.архивные_дела);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дело удалено");
            this.Close();
        }
    }
}
