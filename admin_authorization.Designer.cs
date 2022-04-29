
namespace pfr
{
    partial class admin_authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label фио_специалистаLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label отделLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label дата_созданияLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.пользователиDataGridView = new System.Windows.Forms.DataGridView();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_account = new System.Windows.Forms.Button();
            this.clear_data = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.фио_специалистаTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.отделTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.дата_созданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.пользователиTableAdapter = new pfr.pfr_casesDataSetTableAdapters.пользователиTableAdapter();
            this.tableAdapterManager = new pfr.pfr_casesDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            фио_специалистаLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            отделLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            дата_созданияLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(90, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // фио_специалистаLabel
            // 
            фио_специалистаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            фио_специалистаLabel.AutoSize = true;
            фио_специалистаLabel.Location = new System.Drawing.Point(90, 37);
            фио_специалистаLabel.Name = "фио_специалистаLabel";
            фио_специалистаLabel.Size = new System.Drawing.Size(39, 16);
            фио_специалистаLabel.TabIndex = 2;
            фио_специалистаLabel.Text = "ФИО";
            // 
            // должностьLabel
            // 
            должностьLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(90, 65);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(79, 16);
            должностьLabel.TabIndex = 4;
            должностьLabel.Text = "Должность";
            // 
            // отделLabel
            // 
            отделLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            отделLabel.AutoSize = true;
            отделLabel.Location = new System.Drawing.Point(90, 93);
            отделLabel.Name = "отделLabel";
            отделLabel.Size = new System.Drawing.Size(49, 16);
            отделLabel.TabIndex = 6;
            отделLabel.Text = "Отдел";
            // 
            // логинLabel
            // 
            логинLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(90, 121);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(47, 16);
            логинLabel.TabIndex = 8;
            логинLabel.Text = "Логин";
            // 
            // парольLabel
            // 
            парольLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(90, 149);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(57, 16);
            парольLabel.TabIndex = 10;
            парольLabel.Text = "Пароль";
            // 
            // дата_созданияLabel
            // 
            дата_созданияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            дата_созданияLabel.AutoSize = true;
            дата_созданияLabel.Location = new System.Drawing.Point(90, 178);
            дата_созданияLabel.Name = "дата_созданияLabel";
            дата_созданияLabel.Size = new System.Drawing.Size(105, 16);
            дата_созданияLabel.TabIndex = 12;
            дата_созданияLabel.Text = "Дата создания";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.пользователиDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список учетных записей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // пользователиDataGridView
            // 
            this.пользователиDataGridView.AllowUserToAddRows = false;
            this.пользователиDataGridView.AllowUserToDeleteRows = false;
            this.пользователиDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.пользователиDataGridView.AutoGenerateColumns = false;
            this.пользователиDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.пользователиDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.пользователиDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.пользователиDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.пользователиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользователиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.пользователиDataGridView.DataSource = this.пользователиBindingSource;
            this.пользователиDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.пользователиDataGridView.Location = new System.Drawing.Point(6, 6);
            this.пользователиDataGridView.Name = "пользователиDataGridView";
            this.пользователиDataGridView.Size = new System.Drawing.Size(827, 414);
            this.пользователиDataGridView.TabIndex = 0;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "пользователи";
            this.пользователиBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // pfr_casesDataSet
            // 
            this.pfr_casesDataSet.DataSetName = "pfr_casesDataSet";
            this.pfr_casesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_account);
            this.tabPage2.Controls.Add(this.clear_data);
            this.tabPage2.Controls.Add(idLabel);
            this.tabPage2.Controls.Add(this.idTextBox);
            this.tabPage2.Controls.Add(фио_специалистаLabel);
            this.tabPage2.Controls.Add(this.фио_специалистаTextBox);
            this.tabPage2.Controls.Add(должностьLabel);
            this.tabPage2.Controls.Add(this.должностьTextBox);
            this.tabPage2.Controls.Add(отделLabel);
            this.tabPage2.Controls.Add(this.отделTextBox);
            this.tabPage2.Controls.Add(логинLabel);
            this.tabPage2.Controls.Add(this.логинTextBox);
            this.tabPage2.Controls.Add(парольLabel);
            this.tabPage2.Controls.Add(this.парольTextBox);
            this.tabPage2.Controls.Add(дата_созданияLabel);
            this.tabPage2.Controls.Add(this.дата_созданияDateTimePicker);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить учетную запись";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // add_account
            // 
            this.add_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_account.Location = new System.Drawing.Point(657, 410);
            this.add_account.Name = "add_account";
            this.add_account.Size = new System.Drawing.Size(173, 62);
            this.add_account.TabIndex = 15;
            this.add_account.Text = "Сохранить";
            this.add_account.UseVisualStyleBackColor = true;
            this.add_account.Click += new System.EventHandler(this.add_account_Click);
            // 
            // clear_data
            // 
            this.clear_data.Location = new System.Drawing.Point(26, 225);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(85, 28);
            this.clear_data.TabIndex = 14;
            this.clear_data.Text = "Очистить";
            this.clear_data.UseVisualStyleBackColor = true;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(222, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(521, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // фио_специалистаTextBox
            // 
            this.фио_специалистаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.фио_специалистаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "фио_специалиста", true));
            this.фио_специалистаTextBox.Location = new System.Drawing.Point(222, 34);
            this.фио_специалистаTextBox.Name = "фио_специалистаTextBox";
            this.фио_специалистаTextBox.Size = new System.Drawing.Size(521, 22);
            this.фио_специалистаTextBox.TabIndex = 3;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(222, 62);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(521, 22);
            this.должностьTextBox.TabIndex = 5;
            // 
            // отделTextBox
            // 
            this.отделTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.отделTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "отдел", true));
            this.отделTextBox.Location = new System.Drawing.Point(222, 90);
            this.отделTextBox.Name = "отделTextBox";
            this.отделTextBox.Size = new System.Drawing.Size(521, 22);
            this.отделTextBox.TabIndex = 7;
            // 
            // логинTextBox
            // 
            this.логинTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(222, 118);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(521, 22);
            this.логинTextBox.TabIndex = 9;
            // 
            // парольTextBox
            // 
            this.парольTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(222, 146);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.PasswordChar = '*';
            this.парольTextBox.Size = new System.Drawing.Size(521, 22);
            this.парольTextBox.TabIndex = 11;
            // 
            // дата_созданияDateTimePicker
            // 
            this.дата_созданияDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.дата_созданияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пользователиBindingSource, "дата_создания", true));
            this.дата_созданияDateTimePicker.Location = new System.Drawing.Point(222, 174);
            this.дата_созданияDateTimePicker.Name = "дата_созданияDateTimePicker";
            this.дата_созданияDateTimePicker.Size = new System.Drawing.Size(521, 22);
            this.дата_созданияDateTimePicker.TabIndex = 13;
            this.дата_созданияDateTimePicker.Value = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pfr.pfr_casesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.архивные_делаTableAdapter = null;
            this.tableAdapterManager.действующие_делаTableAdapter = null;
            this.tableAdapterManager.запросы_архивных_делTableAdapter = null;
            this.tableAdapterManager.пользователиTableAdapter = this.пользователиTableAdapter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "фио_специалиста";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 64;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "должность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "отдел";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отдел";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "логин";
            this.dataGridViewTextBoxColumn5.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 72;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "пароль";
            this.dataGridViewTextBoxColumn6.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 82;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "дата_создания";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата создания учетной записи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 174;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(6, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 531);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin_authorization";
            this.Text = "Учетные записи";
            this.Load += new System.EventHandler(this.admin_authorization_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private pfr_casesDataSet pfr_casesDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private pfr_casesDataSetTableAdapters.пользователиTableAdapter пользователиTableAdapter;
        private pfr_casesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView пользователиDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox фио_специалистаTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox отделTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.DateTimePicker дата_созданияDateTimePicker;
        private System.Windows.Forms.Button add_account;
        private System.Windows.Forms.Button clear_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
    }
}