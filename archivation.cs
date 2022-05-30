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
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);
            this.запросы_архивных_делTableAdapter.Fill(this.pfr_casesDataSet.запросы_архивных_дел);
        }
        private void archivate_Click(object sender, EventArgs e)
        {

        }
    }
}
