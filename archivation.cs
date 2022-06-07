using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;


namespace pfr
{
    public partial class archivation : Form
    {
        public archivation()
        {
            InitializeComponent();
        }
        private void запросы_архивных_делBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.запросы_архивных_делBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pfr_casesDataSet);
        }
        private void archivation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pfr_casesDataSet.архивные_дела". При необходимости она может быть перемещена или удалена.
            this.архивные_делаTableAdapter.Fill(this.pfr_casesDataSet.архивные_дела);
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);
            this.запросы_архивных_делTableAdapter.Fill(this.pfr_casesDataSet.запросы_архивных_дел);
        }

        private void add_to_archiv_Click(object sender, EventArgs e)
        {
            try
            {
                запросы_архивных_делBindingSource.AddNew();
                архивные_делаBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
