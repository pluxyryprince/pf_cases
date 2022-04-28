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
    public partial class admin_authorization : Form
    {
        public admin_authorization()
        {
            InitializeComponent();
        }

        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pfr_casesDataSet);

        }

        private void admin_authorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pfr_casesDataSet.пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.pfr_casesDataSet.пользователи);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void clear_data_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.AddNew();
        }

        private void add_account_Click(object sender, EventArgs e)
        {
            пользователиBindingSource.EndEdit();
            пользователиTableAdapter.Update(pfr_casesDataSet);
        }
    }
}
