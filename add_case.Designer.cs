
namespace pfr
{
    partial class add_case
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
            System.Windows.Forms.Label номер_делаLabel;
            System.Windows.Forms.Label дата_создания_делаLabel;
            System.Windows.Forms.Label фиоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label вид_начисленийLabel;
            System.Windows.Forms.Label снилсLabel;
            System.Windows.Forms.Label район_проживанияLabel;
            System.Windows.Forms.Label адрес_проживанияLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_case));
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.действующие_делаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.действующие_делаTableAdapter = new pfr.pfr_casesDataSetTableAdapters.действующие_делаTableAdapter();
            this.tableAdapterManager = new pfr.pfr_casesDataSetTableAdapters.TableAdapterManager();
            this.номер_делаTextBox = new System.Windows.Forms.TextBox();
            this.дата_создания_делаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фиоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.вид_начисленийTextBox = new System.Windows.Forms.TextBox();
            this.снилсTextBox = new System.Windows.Forms.TextBox();
            this.район_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_data = new System.Windows.Forms.Button();
            this.add_account = new System.Windows.Forms.Button();
            номер_делаLabel = new System.Windows.Forms.Label();
            дата_создания_делаLabel = new System.Windows.Forms.Label();
            фиоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            вид_начисленийLabel = new System.Windows.Forms.Label();
            снилсLabel = new System.Windows.Forms.Label();
            район_проживанияLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующие_делаBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_делаLabel
            // 
            номер_делаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            номер_делаLabel.AutoSize = true;
            номер_делаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_делаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            номер_делаLabel.Location = new System.Drawing.Point(39, 124);
            номер_делаLabel.Name = "номер_делаLabel";
            номер_делаLabel.Size = new System.Drawing.Size(89, 16);
            номер_делаLabel.TabIndex = 1;
            номер_делаLabel.Text = "Номер дела:";
            // 
            // дата_создания_делаLabel
            // 
            дата_создания_делаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            дата_создания_делаLabel.AutoSize = true;
            дата_создания_делаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_создания_делаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_создания_делаLabel.Location = new System.Drawing.Point(39, 151);
            дата_создания_делаLabel.Name = "дата_создания_делаLabel";
            дата_создания_делаLabel.Size = new System.Drawing.Size(143, 16);
            дата_создания_делаLabel.TabIndex = 3;
            дата_создания_делаLabel.Text = "Дата создания дела:";
            // 
            // фиоLabel
            // 
            фиоLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            фиоLabel.AutoSize = true;
            фиоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фиоLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фиоLabel.Location = new System.Drawing.Point(39, 176);
            фиоLabel.Name = "фиоLabel";
            фиоLabel.Size = new System.Drawing.Size(42, 16);
            фиоLabel.TabIndex = 5;
            фиоLabel.Text = "ФИО:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_рожденияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_рожденияLabel.Location = new System.Drawing.Point(39, 203);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(110, 16);
            дата_рожденияLabel.TabIndex = 7;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // вид_начисленийLabel
            // 
            вид_начисленийLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            вид_начисленийLabel.AutoSize = true;
            вид_начисленийLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            вид_начисленийLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            вид_начисленийLabel.Location = new System.Drawing.Point(39, 228);
            вид_начисленийLabel.Name = "вид_начисленийLabel";
            вид_начисленийLabel.Size = new System.Drawing.Size(118, 16);
            вид_начисленийLabel.TabIndex = 9;
            вид_начисленийLabel.Text = "Вид начислений:";
            // 
            // снилсLabel
            // 
            снилсLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            снилсLabel.AutoSize = true;
            снилсLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            снилсLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            снилсLabel.Location = new System.Drawing.Point(39, 254);
            снилсLabel.Name = "снилсLabel";
            снилсLabel.Size = new System.Drawing.Size(58, 16);
            снилсLabel.TabIndex = 11;
            снилсLabel.Text = "СНИЛС:";
            // 
            // район_проживанияLabel
            // 
            район_проживанияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            район_проживанияLabel.AutoSize = true;
            район_проживанияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            район_проживанияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            район_проживанияLabel.Location = new System.Drawing.Point(39, 280);
            район_проживанияLabel.Name = "район_проживанияLabel";
            район_проживанияLabel.Size = new System.Drawing.Size(135, 16);
            район_проживанияLabel.TabIndex = 13;
            район_проживанияLabel.Text = "Район проживания:";
            // 
            // адрес_проживанияLabel
            // 
            адрес_проживанияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            адрес_проживанияLabel.AutoSize = true;
            адрес_проживанияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адрес_проживанияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            адрес_проживанияLabel.Location = new System.Drawing.Point(39, 306);
            адрес_проживанияLabel.Name = "адрес_проживанияLabel";
            адрес_проживанияLabel.Size = new System.Drawing.Size(134, 16);
            адрес_проживанияLabel.TabIndex = 15;
            адрес_проживанияLabel.Text = "Адрес проживания:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(25, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 20);
            label1.TabIndex = 17;
            label1.Text = "Введите данные";
            // 
            // pfr_casesDataSet
            // 
            this.pfr_casesDataSet.DataSetName = "pfr_casesDataSet";
            this.pfr_casesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // действующие_делаBindingSource
            // 
            this.действующие_делаBindingSource.DataMember = "действующие_дела";
            this.действующие_делаBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // действующие_делаTableAdapter
            // 
            this.действующие_делаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pfr.pfr_casesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.архивные_делаTableAdapter = null;
            this.tableAdapterManager.действующие_делаTableAdapter = this.действующие_делаTableAdapter;
            this.tableAdapterManager.запросы_архивных_делTableAdapter = null;
            this.tableAdapterManager.пользователиTableAdapter = null;
            // 
            // номер_делаTextBox
            // 
            this.номер_делаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.номер_делаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.действующие_делаBindingSource, "номер_дела", true));
            this.номер_делаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_делаTextBox.Location = new System.Drawing.Point(235, 124);
            this.номер_делаTextBox.Name = "номер_делаTextBox";
            this.номер_делаTextBox.Size = new System.Drawing.Size(283, 22);
            this.номер_делаTextBox.TabIndex = 2;
            // 
            // дата_создания_делаDateTimePicker
            // 
            this.дата_создания_делаDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.дата_создания_делаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.действующие_делаBindingSource, "дата_создания_дела", true));
            this.дата_создания_делаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_создания_делаDateTimePicker.Location = new System.Drawing.Point(235, 150);
            this.дата_создания_делаDateTimePicker.Name = "дата_создания_делаDateTimePicker";
            this.дата_создания_делаDateTimePicker.Size = new System.Drawing.Size(283, 22);
            this.дата_создания_делаDateTimePicker.TabIndex = 4;
            // 
            // фиоTextBox
            // 
            this.фиоTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.фиоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.действующие_делаBindingSource, "фио", true));
            this.фиоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фиоTextBox.Location = new System.Drawing.Point(235, 176);
            this.фиоTextBox.Name = "фиоTextBox";
            this.фиоTextBox.Size = new System.Drawing.Size(283, 22);
            this.фиоTextBox.TabIndex = 6;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.действующие_делаBindingSource, "дата_рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(235, 202);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(283, 22);
            this.дата_рожденияDateTimePicker.TabIndex = 8;
            // 
            // вид_начисленийTextBox
            // 
            this.вид_начисленийTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.вид_начисленийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.действующие_делаBindingSource, "вид_начислений", true));
            this.вид_начисленийTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вид_начисленийTextBox.Location = new System.Drawing.Point(235, 228);
            this.вид_начисленийTextBox.Name = "вид_начисленийTextBox";
            this.вид_начисленийTextBox.Size = new System.Drawing.Size(283, 22);
            this.вид_начисленийTextBox.TabIndex = 10;
            // 
            // снилсTextBox
            // 
            this.снилсTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.снилсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.действующие_делаBindingSource, "снилс", true));
            this.снилсTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.снилсTextBox.Location = new System.Drawing.Point(235, 254);
            this.снилсTextBox.Name = "снилсTextBox";
            this.снилсTextBox.Size = new System.Drawing.Size(283, 22);
            this.снилсTextBox.TabIndex = 12;
            // 
            // район_проживанияTextBox
            // 
            this.район_проживанияTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.район_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.действующие_делаBindingSource, "район_проживания", true));
            this.район_проживанияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.район_проживанияTextBox.Location = new System.Drawing.Point(235, 280);
            this.район_проживанияTextBox.Name = "район_проживанияTextBox";
            this.район_проживанияTextBox.Size = new System.Drawing.Size(283, 22);
            this.район_проживанияTextBox.TabIndex = 14;
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.действующие_делаBindingSource, "адрес_проживания", true));
            this.адрес_проживанияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(235, 306);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(283, 22);
            this.адрес_проживанияTextBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clear_data);
            this.panel1.Controls.Add(this.add_account);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 324);
            this.panel1.TabIndex = 18;
            // 
            // clear_data
            // 
            this.clear_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.clear_data.FlatAppearance.BorderSize = 0;
            this.clear_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear_data.Location = new System.Drawing.Point(3, 291);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(120, 28);
            this.clear_data.TabIndex = 17;
            this.clear_data.Text = "Очистить";
            this.clear_data.UseVisualStyleBackColor = false;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // add_account
            // 
            this.add_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.add_account.FlatAppearance.BorderSize = 0;
            this.add_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_account.Location = new System.Drawing.Point(395, 291);
            this.add_account.Name = "add_account";
            this.add_account.Size = new System.Drawing.Size(129, 28);
            this.add_account.TabIndex = 16;
            this.add_account.Text = "Сохранить";
            this.add_account.UseVisualStyleBackColor = false;
            this.add_account.Click += new System.EventHandler(this.add_account_Click);
            // 
            // add_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(553, 446);
            this.Controls.Add(label1);
            this.Controls.Add(номер_делаLabel);
            this.Controls.Add(this.номер_делаTextBox);
            this.Controls.Add(дата_создания_делаLabel);
            this.Controls.Add(this.дата_создания_делаDateTimePicker);
            this.Controls.Add(фиоLabel);
            this.Controls.Add(this.фиоTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(вид_начисленийLabel);
            this.Controls.Add(this.вид_начисленийTextBox);
            this.Controls.Add(снилсLabel);
            this.Controls.Add(this.снилсTextBox);
            this.Controls.Add(район_проживанияLabel);
            this.Controls.Add(this.район_проживанияTextBox);
            this.Controls.Add(адрес_проживанияLabel);
            this.Controls.Add(this.адрес_проживанияTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_case";
            this.Text = "Добавить дело";
            this.Load += new System.EventHandler(this.add_case_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующие_делаBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pfr_casesDataSet pfr_casesDataSet;
        private System.Windows.Forms.BindingSource действующие_делаBindingSource;
        private pfr_casesDataSetTableAdapters.действующие_делаTableAdapter действующие_делаTableAdapter;
        private pfr_casesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номер_делаTextBox;
        private System.Windows.Forms.DateTimePicker дата_создания_делаDateTimePicker;
        private System.Windows.Forms.TextBox фиоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox вид_начисленийTextBox;
        private System.Windows.Forms.TextBox снилсTextBox;
        private System.Windows.Forms.TextBox район_проживанияTextBox;
        private System.Windows.Forms.TextBox адрес_проживанияTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_account;
        private System.Windows.Forms.Button clear_data;
    }
}