﻿
namespace pfr
{
    partial class admin_panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.пользователиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.фио_специалистаTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.отделTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.дата_созданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_account = new System.Windows.Forms.Button();
            this.clear_data = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.пенсионныеДелаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.учетныеЗаписиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.пользователиTableAdapter = new pfr.pfr_casesDataSetTableAdapters.пользователиTableAdapter();
            this.tableAdapterManager = new pfr.pfr_casesDataSetTableAdapters.TableAdapterManager();
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
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            idLabel.Location = new System.Drawing.Point(187, 76);
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
            фио_специалистаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фио_специалистаLabel.Location = new System.Drawing.Point(187, 104);
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
            должностьLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            должностьLabel.Location = new System.Drawing.Point(187, 132);
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
            отделLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            отделLabel.Location = new System.Drawing.Point(187, 160);
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
            логинLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            логинLabel.Location = new System.Drawing.Point(187, 188);
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
            парольLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            парольLabel.Location = new System.Drawing.Point(187, 216);
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
            дата_созданияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_созданияLabel.Location = new System.Drawing.Point(187, 245);
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
            this.tabControl1.Location = new System.Drawing.Point(102, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tabPage1.Controls.Add(this.пользователиDataGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список учетных записей";
            // 
            // пользователиDataGridView
            // 
            this.пользователиDataGridView.AllowUserToAddRows = false;
            this.пользователиDataGridView.AllowUserToDeleteRows = false;
            this.пользователиDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.пользователиDataGridView.AutoGenerateColumns = false;
            this.пользователиDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.пользователиDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.пользователиDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.пользователиDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.пользователиDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.пользователиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользователиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.пользователиDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.пользователиDataGridView.DataSource = this.пользователиBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.пользователиDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.пользователиDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.пользователиDataGridView.EnableHeadersVisualStyles = false;
            this.пользователиDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.пользователиDataGridView.Location = new System.Drawing.Point(6, 6);
            this.пользователиDataGridView.Name = "пользователиDataGridView";
            this.пользователиDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.пользователиDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.пользователиDataGridView.Size = new System.Drawing.Size(915, 447);
            this.пользователиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "фио_специалиста";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "должность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "отдел";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отдел";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "логин";
            this.dataGridViewTextBoxColumn5.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "пароль";
            this.dataGridViewTextBoxColumn6.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "дата_создания";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата создания учетной записи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(6, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Удалить строку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tabPage2.Controls.Add(this.label1);
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
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить учетную запись";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(159, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Создание новой учетной записи";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idTextBox.Location = new System.Drawing.Point(319, 73);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(395, 15);
            this.idTextBox.TabIndex = 1;
            // 
            // фио_специалистаTextBox
            // 
            this.фио_специалистаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.фио_специалистаTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.фио_специалистаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.фио_специалистаTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.фио_специалистаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "фио_специалиста", true));
            this.фио_специалистаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фио_специалистаTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.фио_специалистаTextBox.Location = new System.Drawing.Point(319, 101);
            this.фио_специалистаTextBox.Name = "фио_специалистаTextBox";
            this.фио_специалистаTextBox.Size = new System.Drawing.Size(394, 15);
            this.фио_специалистаTextBox.TabIndex = 3;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.должностьTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.должностьTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.должностьTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "должность", true));
            this.должностьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.должностьTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.должностьTextBox.Location = new System.Drawing.Point(319, 129);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(394, 15);
            this.должностьTextBox.TabIndex = 5;
            // 
            // отделTextBox
            // 
            this.отделTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.отделTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.отделTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.отделTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.отделTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "отдел", true));
            this.отделTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отделTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.отделTextBox.Location = new System.Drawing.Point(319, 157);
            this.отделTextBox.Name = "отделTextBox";
            this.отделTextBox.Size = new System.Drawing.Size(394, 15);
            this.отделTextBox.TabIndex = 7;
            // 
            // логинTextBox
            // 
            this.логинTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.логинTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.логинTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.логинTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "логин", true));
            this.логинTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.логинTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.логинTextBox.Location = new System.Drawing.Point(319, 185);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(394, 15);
            this.логинTextBox.TabIndex = 9;
            // 
            // парольTextBox
            // 
            this.парольTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.парольTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.парольTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.парольTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользователиBindingSource, "пароль", true));
            this.парольTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.парольTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.парольTextBox.Location = new System.Drawing.Point(319, 213);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.PasswordChar = '*';
            this.парольTextBox.Size = new System.Drawing.Size(394, 15);
            this.парольTextBox.TabIndex = 11;
            // 
            // дата_созданияDateTimePicker
            // 
            this.дата_созданияDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.дата_созданияDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.дата_созданияDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.дата_созданияDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.дата_созданияDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.дата_созданияDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.дата_созданияDateTimePicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.дата_созданияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пользователиBindingSource, "дата_создания", true));
            this.дата_созданияDateTimePicker.Location = new System.Drawing.Point(319, 241);
            this.дата_созданияDateTimePicker.Name = "дата_созданияDateTimePicker";
            this.дата_созданияDateTimePicker.Size = new System.Drawing.Size(394, 22);
            this.дата_созданияDateTimePicker.TabIndex = 13;
            this.дата_созданияDateTimePicker.Value = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.add_account);
            this.panel1.Controls.Add(this.clear_data);
            this.panel1.Location = new System.Drawing.Point(142, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 377);
            this.panel1.TabIndex = 16;
            // 
            // add_account
            // 
            this.add_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.add_account.FlatAppearance.BorderSize = 0;
            this.add_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_account.Location = new System.Drawing.Point(438, 324);
            this.add_account.Name = "add_account";
            this.add_account.Size = new System.Drawing.Size(183, 48);
            this.add_account.TabIndex = 15;
            this.add_account.Text = "Сохранить";
            this.add_account.UseVisualStyleBackColor = false;
            this.add_account.Click += new System.EventHandler(this.add_account_Click);
            // 
            // clear_data
            // 
            this.clear_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.clear_data.FlatAppearance.BorderSize = 0;
            this.clear_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear_data.Location = new System.Drawing.Point(47, 273);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(85, 28);
            this.clear_data.TabIndex = 14;
            this.clear_data.Text = "Очистить";
            this.clear_data.UseVisualStyleBackColor = false;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel2,
            this.toolStripDropDownButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(99, 552);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 15);
            this.toolStripStatusLabel1.Text = "Администратор";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(97, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            this.пользовательToolStripMenuItem.Click += new System.EventHandler(this.пользовательToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(97, 15);
            this.toolStripStatusLabel2.Text = "Отображать:";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.toolStripDropDownButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пенсионныеДелаToolStripMenuItem1,
            this.учетныеЗаписиToolStripMenuItem1});
            this.toolStripDropDownButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(97, 20);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // пенсионныеДелаToolStripMenuItem1
            // 
            this.пенсионныеДелаToolStripMenuItem1.Name = "пенсионныеДелаToolStripMenuItem1";
            this.пенсионныеДелаToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.пенсионныеДелаToolStripMenuItem1.Text = "Пенсионные дела";
            this.пенсионныеДелаToolStripMenuItem1.Click += new System.EventHandler(this.пенсионныеДелаToolStripMenuItem1_Click);
            // 
            // учетныеЗаписиToolStripMenuItem1
            // 
            this.учетныеЗаписиToolStripMenuItem1.Name = "учетныеЗаписиToolStripMenuItem1";
            this.учетныеЗаписиToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.учетныеЗаписиToolStripMenuItem1.Text = "Учетные записи";
            this.учетныеЗаписиToolStripMenuItem1.Click += new System.EventHandler(this.учетныеЗаписиToolStripMenuItem1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl2.Location = new System.Drawing.Point(102, 12);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(928, 540);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(920, 511);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Действующие дела";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(920, 511);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Архивные дела";
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
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1034, 552);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_panel_FormClosing);
            this.Load += new System.EventHandler(this.admin_authorization_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem пенсионныеДелаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem учетныеЗаписиToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}