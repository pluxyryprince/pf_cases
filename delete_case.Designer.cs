
namespace pfr
{
    partial class delete_case
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
            System.Windows.Forms.Label номер_архивного_делаLabel;
            System.Windows.Forms.Label номер_делаLabel;
            System.Windows.Forms.Label фиоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label вид_начисленийLabel;
            System.Windows.Forms.Label район_проживанияLabel;
            System.Windows.Forms.Label адрес_проживанияLabel;
            System.Windows.Forms.Label дата_архивированияLabel;
            System.Windows.Forms.Label причина_архивированияLabel;
            System.Windows.Forms.Label фио_архивариусаLabel;
            System.Windows.Forms.Label фио_создавшегоLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_case));
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.архивные_делаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.архивные_делаTableAdapter = new pfr.pfr_casesDataSetTableAdapters.архивные_делаTableAdapter();
            this.tableAdapterManager = new pfr.pfr_casesDataSetTableAdapters.TableAdapterManager();
            this.номер_архивного_делаTextBox = new System.Windows.Forms.TextBox();
            this.номер_делаTextBox = new System.Windows.Forms.TextBox();
            this.фиоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.вид_начисленийTextBox = new System.Windows.Forms.TextBox();
            this.район_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.дата_архивированияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.причина_архивированияTextBox = new System.Windows.Forms.TextBox();
            this.фио_архивариусаTextBox = new System.Windows.Forms.TextBox();
            this.фио_создавшегоTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            номер_архивного_делаLabel = new System.Windows.Forms.Label();
            номер_делаLabel = new System.Windows.Forms.Label();
            фиоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            вид_начисленийLabel = new System.Windows.Forms.Label();
            район_проживанияLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            дата_архивированияLabel = new System.Windows.Forms.Label();
            причина_архивированияLabel = new System.Windows.Forms.Label();
            фио_архивариусаLabel = new System.Windows.Forms.Label();
            фио_создавшегоLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.архивные_делаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pfr_casesDataSet
            // 
            this.pfr_casesDataSet.DataSetName = "pfr_casesDataSet";
            this.pfr_casesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // архивные_делаBindingSource
            // 
            this.архивные_делаBindingSource.DataMember = "архивные_дела";
            this.архивные_делаBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // архивные_делаTableAdapter
            // 
            this.архивные_делаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pfr.pfr_casesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.архивные_делаTableAdapter = this.архивные_делаTableAdapter;
            this.tableAdapterManager.действующие_делаTableAdapter = null;
            this.tableAdapterManager.запросы_архивных_делTableAdapter = null;
            this.tableAdapterManager.пользователиTableAdapter = null;
            // 
            // номер_архивного_делаLabel
            // 
            номер_архивного_делаLabel.AutoSize = true;
            номер_архивного_делаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            номер_архивного_делаLabel.Location = new System.Drawing.Point(108, 100);
            номер_архивного_делаLabel.Name = "номер_архивного_делаLabel";
            номер_архивного_делаLabel.Size = new System.Drawing.Size(126, 13);
            номер_архивного_делаLabel.TabIndex = 1;
            номер_архивного_делаLabel.Text = "Номер архивного дела:";
            // 
            // номер_архивного_делаTextBox
            // 
            this.номер_архивного_делаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "номер_архивного_дела", true));
            this.номер_архивного_делаTextBox.Location = new System.Drawing.Point(245, 97);
            this.номер_архивного_делаTextBox.Name = "номер_архивного_делаTextBox";
            this.номер_архивного_делаTextBox.Size = new System.Drawing.Size(316, 20);
            this.номер_архивного_делаTextBox.TabIndex = 2;
            // 
            // номер_делаLabel
            // 
            номер_делаLabel.AutoSize = true;
            номер_делаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            номер_делаLabel.Location = new System.Drawing.Point(165, 126);
            номер_делаLabel.Name = "номер_делаLabel";
            номер_делаLabel.Size = new System.Drawing.Size(71, 13);
            номер_делаLabel.TabIndex = 3;
            номер_делаLabel.Text = "Номер дела:";
            // 
            // номер_делаTextBox
            // 
            this.номер_делаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "номер_дела", true));
            this.номер_делаTextBox.Location = new System.Drawing.Point(245, 123);
            this.номер_делаTextBox.Name = "номер_делаTextBox";
            this.номер_делаTextBox.Size = new System.Drawing.Size(316, 20);
            this.номер_делаTextBox.TabIndex = 4;
            // 
            // фиоLabel
            // 
            фиоLabel.AutoSize = true;
            фиоLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фиоLabel.Location = new System.Drawing.Point(197, 156);
            фиоLabel.Name = "фиоLabel";
            фиоLabel.Size = new System.Drawing.Size(37, 13);
            фиоLabel.TabIndex = 5;
            фиоLabel.Text = "ФИО:";
            // 
            // фиоTextBox
            // 
            this.фиоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "фио", true));
            this.фиоTextBox.Location = new System.Drawing.Point(245, 149);
            this.фиоTextBox.Name = "фиоTextBox";
            this.фиоTextBox.Size = new System.Drawing.Size(316, 20);
            this.фиоTextBox.TabIndex = 6;
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_рожденияLabel.Location = new System.Drawing.Point(148, 182);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 7;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.архивные_делаBindingSource, "дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(245, 175);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(316, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 8;
            // 
            // вид_начисленийLabel
            // 
            вид_начисленийLabel.AutoSize = true;
            вид_начисленийLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            вид_начисленийLabel.Location = new System.Drawing.Point(144, 208);
            вид_начисленийLabel.Name = "вид_начисленийLabel";
            вид_начисленийLabel.Size = new System.Drawing.Size(91, 13);
            вид_начисленийLabel.TabIndex = 9;
            вид_начисленийLabel.Text = "Вид начислений:";
            // 
            // вид_начисленийTextBox
            // 
            this.вид_начисленийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "вид_начислений", true));
            this.вид_начисленийTextBox.Location = new System.Drawing.Point(245, 201);
            this.вид_начисленийTextBox.Name = "вид_начисленийTextBox";
            this.вид_начисленийTextBox.Size = new System.Drawing.Size(316, 20);
            this.вид_начисленийTextBox.TabIndex = 10;
            // 
            // район_проживанияLabel
            // 
            район_проживанияLabel.AutoSize = true;
            район_проживанияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            район_проживанияLabel.Location = new System.Drawing.Point(129, 234);
            район_проживанияLabel.Name = "район_проживанияLabel";
            район_проживанияLabel.Size = new System.Drawing.Size(106, 13);
            район_проживанияLabel.TabIndex = 11;
            район_проживанияLabel.Text = "Район проживания:";
            // 
            // район_проживанияTextBox
            // 
            this.район_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "район_проживания", true));
            this.район_проживанияTextBox.Location = new System.Drawing.Point(245, 227);
            this.район_проживанияTextBox.Name = "район_проживанияTextBox";
            this.район_проживанияTextBox.Size = new System.Drawing.Size(316, 20);
            this.район_проживанияTextBox.TabIndex = 12;
            // 
            // адрес_проживанияLabel
            // 
            адрес_проживанияLabel.AutoSize = true;
            адрес_проживанияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            адрес_проживанияLabel.Location = new System.Drawing.Point(129, 260);
            адрес_проживанияLabel.Name = "адрес_проживанияLabel";
            адрес_проживанияLabel.Size = new System.Drawing.Size(106, 13);
            адрес_проживанияLabel.TabIndex = 13;
            адрес_проживанияLabel.Text = "Адрес проживания:";
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "адрес_проживания", true));
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(245, 253);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(316, 20);
            this.адрес_проживанияTextBox.TabIndex = 14;
            // 
            // дата_архивированияLabel
            // 
            дата_архивированияLabel.AutoSize = true;
            дата_архивированияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_архивированияLabel.Location = new System.Drawing.Point(121, 286);
            дата_архивированияLabel.Name = "дата_архивированияLabel";
            дата_архивированияLabel.Size = new System.Drawing.Size(116, 13);
            дата_архивированияLabel.TabIndex = 15;
            дата_архивированияLabel.Text = "Дата архивирования:";
            // 
            // дата_архивированияDateTimePicker
            // 
            this.дата_архивированияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.архивные_делаBindingSource, "дата_архивирования", true));
            this.дата_архивированияDateTimePicker.Location = new System.Drawing.Point(245, 279);
            this.дата_архивированияDateTimePicker.Name = "дата_архивированияDateTimePicker";
            this.дата_архивированияDateTimePicker.Size = new System.Drawing.Size(316, 20);
            this.дата_архивированияDateTimePicker.TabIndex = 16;
            // 
            // причина_архивированияLabel
            // 
            причина_архивированияLabel.AutoSize = true;
            причина_архивированияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            причина_архивированияLabel.Location = new System.Drawing.Point(106, 312);
            причина_архивированияLabel.Name = "причина_архивированияLabel";
            причина_архивированияLabel.Size = new System.Drawing.Size(133, 13);
            причина_архивированияLabel.TabIndex = 17;
            причина_архивированияLabel.Text = "Причина архивирования:";
            // 
            // причина_архивированияTextBox
            // 
            this.причина_архивированияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "причина_архивирования", true));
            this.причина_архивированияTextBox.Location = new System.Drawing.Point(245, 305);
            this.причина_архивированияTextBox.Name = "причина_архивированияTextBox";
            this.причина_архивированияTextBox.Size = new System.Drawing.Size(316, 20);
            this.причина_архивированияTextBox.TabIndex = 18;
            // 
            // фио_архивариусаLabel
            // 
            фио_архивариусаLabel.AutoSize = true;
            фио_архивариусаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фио_архивариусаLabel.Location = new System.Drawing.Point(132, 334);
            фио_архивариусаLabel.Name = "фио_архивариусаLabel";
            фио_архивариусаLabel.Size = new System.Drawing.Size(104, 13);
            фио_архивариусаLabel.TabIndex = 19;
            фио_архивариусаLabel.Text = "ФИО архивариуса:";
            // 
            // фио_архивариусаTextBox
            // 
            this.фио_архивариусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "фио_архивариуса", true));
            this.фио_архивариусаTextBox.Location = new System.Drawing.Point(245, 331);
            this.фио_архивариусаTextBox.Name = "фио_архивариусаTextBox";
            this.фио_архивариусаTextBox.Size = new System.Drawing.Size(316, 20);
            this.фио_архивариусаTextBox.TabIndex = 20;
            // 
            // фио_создавшегоLabel
            // 
            фио_создавшегоLabel.AutoSize = true;
            фио_создавшегоLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фио_создавшегоLabel.Location = new System.Drawing.Point(140, 360);
            фио_создавшегоLabel.Name = "фио_создавшегоLabel";
            фио_создавшегоLabel.Size = new System.Drawing.Size(101, 13);
            фио_создавшегоLabel.TabIndex = 21;
            фио_создавшегоLabel.Text = "ФИО создавшего:";
            // 
            // фио_создавшегоTextBox
            // 
            this.фио_создавшегоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "фио_создавшего", true));
            this.фио_создавшегоTextBox.Location = new System.Drawing.Point(245, 357);
            this.фио_создавшегоTextBox.Name = "фио_создавшегоTextBox";
            this.фио_создавшегоTextBox.Size = new System.Drawing.Size(316, 20);
            this.фио_создавшегоTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(418, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Уничтожить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(591, 419);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(24, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(285, 20);
            label2.TabIndex = 21;
            label2.Text = "Проверье данные перед удалением";
            // 
            // delete_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(620, 492);
            this.Controls.Add(label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(номер_архивного_делаLabel);
            this.Controls.Add(this.номер_архивного_делаTextBox);
            this.Controls.Add(номер_делаLabel);
            this.Controls.Add(this.номер_делаTextBox);
            this.Controls.Add(фиоLabel);
            this.Controls.Add(this.фиоTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(вид_начисленийLabel);
            this.Controls.Add(this.вид_начисленийTextBox);
            this.Controls.Add(район_проживанияLabel);
            this.Controls.Add(this.район_проживанияTextBox);
            this.Controls.Add(адрес_проживанияLabel);
            this.Controls.Add(this.адрес_проживанияTextBox);
            this.Controls.Add(дата_архивированияLabel);
            this.Controls.Add(this.дата_архивированияDateTimePicker);
            this.Controls.Add(причина_архивированияLabel);
            this.Controls.Add(this.причина_архивированияTextBox);
            this.Controls.Add(фио_архивариусаLabel);
            this.Controls.Add(this.фио_архивариусаTextBox);
            this.Controls.Add(фио_создавшегоLabel);
            this.Controls.Add(this.фио_создавшегоTextBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_case";
            this.Text = "Уничтожить дело";
            this.Load += new System.EventHandler(this.delete_case_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.архивные_делаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pfr_casesDataSet pfr_casesDataSet;
        private System.Windows.Forms.BindingSource архивные_делаBindingSource;
        private pfr_casesDataSetTableAdapters.архивные_делаTableAdapter архивные_делаTableAdapter;
        private pfr_casesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номер_архивного_делаTextBox;
        private System.Windows.Forms.TextBox номер_делаTextBox;
        private System.Windows.Forms.TextBox фиоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox вид_начисленийTextBox;
        private System.Windows.Forms.TextBox район_проживанияTextBox;
        private System.Windows.Forms.TextBox адрес_проживанияTextBox;
        private System.Windows.Forms.DateTimePicker дата_архивированияDateTimePicker;
        private System.Windows.Forms.TextBox причина_архивированияTextBox;
        private System.Windows.Forms.TextBox фио_архивариусаTextBox;
        private System.Windows.Forms.TextBox фио_создавшегоTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}