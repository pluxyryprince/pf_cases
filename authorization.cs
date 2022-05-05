using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pfr
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }
        static public string role;
        public void go_Click(object sender, EventArgs e)
        {
            if (login.Text == "admin" && password.Text == "1q2w3e4r5t6y7u8i9o0p" || login.Text == "root" && password.Text == "root")
            {
                this.Hide();
                admin_panel a = new admin_panel();
                a.Show();
            }
            else
            {
                try
                {
                    string Login = login.Text;
                    string Password = password.Text;
                    connector db = new connector();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `логин` = @login AND `пароль` = @password", db.GetConnection());
                    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    MySqlDataAdapter users = new MySqlDataAdapter($"Select role From user", db.GetConnection());
                    role = Convert.ToString(table.Rows[0][5]);
                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                        general general = new general();
                        general.Show();
                    }
                    else
                        MessageBox.Show("Пользователя не существует. Проверьте правильность введенных данных");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при авторизации. Проверьте правильность введенных данных");
                }
            }       
        }
        private void authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
