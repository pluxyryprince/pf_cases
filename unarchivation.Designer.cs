
namespace pfr
{
    partial class unarchivation
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
            System.Windows.Forms.Label дата_передачи_в_отделLabel;
            System.Windows.Forms.Label фио_специалистаLabel;
            System.Windows.Forms.Label дата_повторного_архивированияLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unarchivation));
            this.add_to_archiv = new System.Windows.Forms.Button();
            this.clear_data = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.запросы_архивных_делBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.дата_передачи_в_отделDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фио_специалистаTextBox = new System.Windows.Forms.TextBox();
            this.дата_повторного_архивированияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.запросы_архивных_делTableAdapter = new pfr.pfr_casesDataSetTableAdapters.запросы_архивных_делTableAdapter();
            this.tableAdapterManager = new pfr.pfr_casesDataSetTableAdapters.TableAdapterManager();
            дата_передачи_в_отделLabel = new System.Windows.Forms.Label();
            фио_специалистаLabel = new System.Windows.Forms.Label();
            дата_повторного_архивированияLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // дата_передачи_в_отделLabel
            // 
            дата_передачи_в_отделLabel.AutoSize = true;
            дата_передачи_в_отделLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_передачи_в_отделLabel.Location = new System.Drawing.Point(145, 91);
            дата_передачи_в_отделLabel.Name = "дата_передачи_в_отделLabel";
            дата_передачи_в_отделLabel.Size = new System.Drawing.Size(127, 13);
            дата_передачи_в_отделLabel.TabIndex = 48;
            дата_передачи_в_отделLabel.Text = "Дата передачи в отдел:";
            // 
            // фио_специалистаLabel
            // 
            фио_специалистаLabel.AutoSize = true;
            фио_специалистаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фио_специалистаLabel.Location = new System.Drawing.Point(61, 117);
            фио_специалистаLabel.Name = "фио_специалистаLabel";
            фио_специалистаLabel.Size = new System.Drawing.Size(211, 13);
            фио_специалистаLabel.TabIndex = 50;
            фио_специалистаLabel.Text = "ФИО специалиста, запросившего дело:";
            // 
            // дата_повторного_архивированияLabel
            // 
            дата_повторного_архивированияLabel.AutoSize = true;
            дата_повторного_архивированияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_повторного_архивированияLabel.Location = new System.Drawing.Point(98, 142);
            дата_повторного_архивированияLabel.Name = "дата_повторного_архивированияLabel";
            дата_повторного_архивированияLabel.Size = new System.Drawing.Size(177, 13);
            дата_повторного_архивированияLabel.TabIndex = 52;
            дата_повторного_архивированияLabel.Text = "Дата повторного архивирования:";
            // 
            // add_to_archiv
            // 
            this.add_to_archiv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_to_archiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.add_to_archiv.FlatAppearance.BorderSize = 0;
            this.add_to_archiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_archiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.add_to_archiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_to_archiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_to_archiv.Location = new System.Drawing.Point(499, 308);
            this.add_to_archiv.Name = "add_to_archiv";
            this.add_to_archiv.Size = new System.Drawing.Size(146, 29);
            this.add_to_archiv.TabIndex = 45;
            this.add_to_archiv.Text = "Разархивировать";
            this.add_to_archiv.UseVisualStyleBackColor = false;
            this.add_to_archiv.Click += new System.EventHandler(this.add_to_archiv_Click);
            // 
            // clear_data
            // 
            this.clear_data.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clear_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.clear_data.FlatAppearance.BorderSize = 0;
            this.clear_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.clear_data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear_data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clear_data.Location = new System.Drawing.Point(15, 212);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(103, 25);
            this.clear_data.TabIndex = 46;
            this.clear_data.Text = "Очистить";
            this.clear_data.UseVisualStyleBackColor = false;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(дата_передачи_в_отделLabel);
            this.panel1.Controls.Add(this.дата_передачи_в_отделDateTimePicker);
            this.panel1.Controls.Add(фио_специалистаLabel);
            this.panel1.Controls.Add(this.фио_специалистаTextBox);
            this.panel1.Controls.Add(дата_повторного_архивированияLabel);
            this.panel1.Controls.Add(this.дата_повторного_архивированияDateTimePicker);
            this.panel1.Controls.Add(this.clear_data);
            this.panel1.Controls.Add(this.add_to_archiv);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 342);
            this.panel1.TabIndex = 20;
            // 
            // запросы_архивных_делBindingSource
            // 
            this.запросы_архивных_делBindingSource.DataMember = "запросы_архивных_дел";
            this.запросы_архивных_делBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // pfr_casesDataSet
            // 
            this.pfr_casesDataSet.DataSetName = "pfr_casesDataSet";
            this.pfr_casesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дата_передачи_в_отделDateTimePicker
            // 
            this.дата_передачи_в_отделDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.запросы_архивных_делBindingSource, "дата_передачи_в_отдел", true));
            this.дата_передачи_в_отделDateTimePicker.Location = new System.Drawing.Point(278, 84);
            this.дата_передачи_в_отделDateTimePicker.Name = "дата_передачи_в_отделDateTimePicker";
            this.дата_передачи_в_отделDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_передачи_в_отделDateTimePicker.TabIndex = 49;
            // 
            // фио_специалистаTextBox
            // 
            this.фио_специалистаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.запросы_архивных_делBindingSource, "фио_специалиста", true));
            this.фио_специалистаTextBox.Location = new System.Drawing.Point(278, 110);
            this.фио_специалистаTextBox.Name = "фио_специалистаTextBox";
            this.фио_специалистаTextBox.Size = new System.Drawing.Size(200, 20);
            this.фио_специалистаTextBox.TabIndex = 51;
            // 
            // дата_повторного_архивированияDateTimePicker
            // 
            this.дата_повторного_архивированияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.запросы_архивных_делBindingSource, "дата_повторного_архивирования", true));
            this.дата_повторного_архивированияDateTimePicker.Location = new System.Drawing.Point(278, 136);
            this.дата_повторного_архивированияDateTimePicker.Name = "дата_повторного_архивированияDateTimePicker";
            this.дата_повторного_архивированияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_повторного_архивированияDateTimePicker.TabIndex = 53;
            // 
            // запросы_архивных_делTableAdapter
            // 
            this.запросы_архивных_делTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pfr.pfr_casesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.архивные_делаTableAdapter = null;
            this.tableAdapterManager.действующие_делаTableAdapter = null;
            this.tableAdapterManager.запросы_архивных_делTableAdapter = this.запросы_архивных_делTableAdapter;
            this.tableAdapterManager.пользователиTableAdapter = null;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(29, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(423, 20);
            label2.TabIndex = 54;
            label2.Text = "Укажите данные для журнала запросов дел из архива";
            // 
            // unarchivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(671, 418);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "unarchivation";
            this.Text = "Передать дело в отдел";
            this.Load += new System.EventHandler(this.unarchivation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_to_archiv;
        private System.Windows.Forms.Button clear_data;
        private System.Windows.Forms.Panel panel1;
        private pfr_casesDataSet pfr_casesDataSet;
        private System.Windows.Forms.BindingSource запросы_архивных_делBindingSource;
        private pfr_casesDataSetTableAdapters.запросы_архивных_делTableAdapter запросы_архивных_делTableAdapter;
        private pfr_casesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker дата_передачи_в_отделDateTimePicker;
        private System.Windows.Forms.TextBox фио_специалистаTextBox;
        private System.Windows.Forms.DateTimePicker дата_повторного_архивированияDateTimePicker;
    }
}