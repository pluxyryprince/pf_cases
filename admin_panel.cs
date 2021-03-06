using System;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace pfr
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }
        void exportData(DataGridView dataGrid)//метод для экспорта данных в эксель
        {
            ExcelObj.Application ExcelApp = new ExcelObj.Application();
            ExcelObj.Workbook ExcelWorkBook;
            ExcelObj.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(Missing.Value);
            ExcelWorkSheet = ExcelWorkBook.Worksheets.get_Item(1) as ExcelObj.Worksheet;

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGrid.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
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
            this.архивные_делаTableAdapter.Fill(this.pfr_casesDataSet.архивные_дела);
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);
            tabControl2.Hide();
            tabControl1.Show();
            try
            {
                this.пользователиTableAdapter.Fill(this.pfr_casesDataSet.пользователи);          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                MessageBox.Show("Учетная запись создана");
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
            general g = new general();
            this.Hide();
            g.Show();
        }
        private void admin_panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void пенсионныеДелаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            tabControl2.Show();
        }
        private void учетныеЗаписиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl2.Hide();
            tabControl1.Show();
        }

        private void excel_exoprt_users_Click(object sender, EventArgs e)
        {
            try
            {
                exportData(пользователиDataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
