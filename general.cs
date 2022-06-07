using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace pfr
{
    public partial class general : Form
    {
        public general()
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
        private void general_Load(object sender, EventArgs e)
        {
            this.запросы_архивных_делTableAdapter.Fill(this.pfr_casesDataSet1.запросы_архивных_дел);
            this.архивные_делаTableAdapter.Fill(this.pfr_casesDataSet.архивные_дела);
            this.действующие_делаTableAdapter.Fill(this.pfr_casesDataSet.действующие_дела);
        }
        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_access access = new admin_access();
            access.Show();
        }
        private void general_FormClosing_1(object sender, FormClosingEventArgs e)
        {         
            Application.Exit();
        }
        private void add_case_Click(object sender, EventArgs e)
        {
            add_case add = new add_case();
            add.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            действующие_делаTableAdapter.Update(pfr_casesDataSet.действующие_дела);
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView2.Refresh();
            архивные_делаTableAdapter.Update(pfr_casesDataSet.архивные_дела);
        }

        public void add_to_archiv_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentCell.Value.ToString();
            string command = "INSERT INTO `архивные_дела` (`номер_архивного_дела`," +
                " `номер_дела`, `фио`, `дата_рождения`, `вид_начислений`, `район_проживания`," +
                " `адрес_проживания`, `фио_создавшего`, `дата_архивирования`, `причина_архивирования`," +
                " `фио_архивариуса`) VALUES (NULL, '', '', '', '', '', '', '', {}, '', '')";
            archivation a = new archivation();
            a.Show();
        }

        private void excel_export__current_cases_Click(object sender, EventArgs e)
        {
            try
            {
                exportData(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.Refresh();
            действующие_делаTableAdapter.Update(pfr_casesDataSet.действующие_дела);
        }

        private void excel_exoprt_archiv_cases_Click(object sender, EventArgs e)
        {
            try
            {
                exportData(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void excel_exoprt_requests_Click(object sender, EventArgs e)
        {
            try
            {
                exportData(dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void unarchiv_Click(object sender, EventArgs e)
        {

        }
    }
}
