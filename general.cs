using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace pfr
{
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        connector db = new connector();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void general_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pfr_casesDataSet.архивные_дела". При необходимости она может быть перемещена или удалена.
            this.архивные_делаTableAdapter.Fill(this.pfr_casesDataSet.архивные_дела);
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);


        }
        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_access access = new admin_access();
            this.Hide();
            access.Show();
        }
        private void general_FormClosing_1(object sender, FormClosingEventArgs e)
        {         
            Application.Exit();
        }

        private void case_card_open_Archiv(object sender, DataGridViewCellMouseEventArgs e)
        {
            int select_num = dataGridView2.SelectedCells[0].RowIndex;
            MySqlCommand command = new MySqlCommand("select * from архивные_дела where номер_архивного_дела = '{select_num}'", db.GetConnection());

            MessageBox.Show(command.ToString());
        }
    }
}
