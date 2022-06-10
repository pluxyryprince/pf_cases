
namespace pfr
{
    partial class archivation
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label дата_передачи_в_отделLabel;
            System.Windows.Forms.Label дата_повторного_архивированияLabel;
            System.Windows.Forms.Label дата_архивированияLabel;
            System.Windows.Forms.Label причина_архивированияLabel;
            System.Windows.Forms.Label фио_архивариусаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archivation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_data = new System.Windows.Forms.Button();
            this.add_to_archiv = new System.Windows.Forms.Button();
            this.дата_архивированияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.архивные_делаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.причина_архивированияTextBox = new System.Windows.Forms.TextBox();
            this.фио_архивариусаTextBox = new System.Windows.Forms.TextBox();
            this.дата_передачи_в_отделDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.запросы_архивных_делBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_повторного_архивированияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.действующие_делаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запросы_архивных_делTableAdapter = new pfr.pfr_casesDataSetTableAdapters.запросы_архивных_делTableAdapter();
            this.tableAdapterManager = new pfr.pfr_casesDataSetTableAdapters.TableAdapterManager();
            this.действующие_делаTableAdapter = new pfr.pfr_casesDataSetTableAdapters.действующие_делаTableAdapter();
            this.архивные_делаTableAdapter = new pfr.pfr_casesDataSetTableAdapters.архивные_делаTableAdapter();
            label2 = new System.Windows.Forms.Label();
            дата_передачи_в_отделLabel = new System.Windows.Forms.Label();
            дата_повторного_архивированияLabel = new System.Windows.Forms.Label();
            дата_архивированияLabel = new System.Windows.Forms.Label();
            причина_архивированияLabel = new System.Windows.Forms.Label();
            фио_архивариусаLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.архивные_делаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующие_делаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(28, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 20);
            label2.TabIndex = 20;
            label2.Text = "Укажите данные ";
            // 
            // дата_передачи_в_отделLabel
            // 
            дата_передачи_в_отделLabel.AutoSize = true;
            дата_передачи_в_отделLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_передачи_в_отделLabel.Location = new System.Drawing.Point(81, 31);
            дата_передачи_в_отделLabel.Name = "дата_передачи_в_отделLabel";
            дата_передачи_в_отделLabel.Size = new System.Drawing.Size(163, 16);
            дата_передачи_в_отделLabel.TabIndex = 20;
            дата_передачи_в_отделLabel.Text = "Дата передачи в отдел:";
            // 
            // дата_повторного_архивированияLabel
            // 
            дата_повторного_архивированияLabel.AutoSize = true;
            дата_повторного_архивированияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_повторного_архивированияLabel.Location = new System.Drawing.Point(16, 59);
            дата_повторного_архивированияLabel.Name = "дата_повторного_архивированияLabel";
            дата_повторного_архивированияLabel.Size = new System.Drawing.Size(227, 16);
            дата_повторного_архивированияLabel.TabIndex = 24;
            дата_повторного_архивированияLabel.Text = "Дата повторного архивирования:";
            // 
            // дата_архивированияLabel
            // 
            дата_архивированияLabel.AutoSize = true;
            дата_архивированияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_архивированияLabel.Location = new System.Drawing.Point(98, 115);
            дата_архивированияLabel.Name = "дата_архивированияLabel";
            дата_архивированияLabel.Size = new System.Drawing.Size(147, 16);
            дата_архивированияLabel.TabIndex = 39;
            дата_архивированияLabel.Text = "Дата архивирования:";
            // 
            // причина_архивированияLabel
            // 
            причина_архивированияLabel.AutoSize = true;
            причина_архивированияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            причина_архивированияLabel.Location = new System.Drawing.Point(73, 143);
            причина_архивированияLabel.Name = "причина_архивированияLabel";
            причина_архивированияLabel.Size = new System.Drawing.Size(173, 16);
            причина_архивированияLabel.TabIndex = 41;
            причина_архивированияLabel.Text = "Причина архивирования:";
            // 
            // фио_архивариусаLabel
            // 
            фио_архивариусаLabel.AutoSize = true;
            фио_архивариусаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фио_архивариусаLabel.Location = new System.Drawing.Point(118, 171);
            фио_архивариусаLabel.Name = "фио_архивариусаLabel";
            фио_архивариусаLabel.Size = new System.Drawing.Size(130, 16);
            фио_архивариусаLabel.TabIndex = 43;
            фио_архивариусаLabel.Text = "ФИО архивариуса:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clear_data);
            this.panel1.Controls.Add(this.add_to_archiv);
            this.panel1.Controls.Add(дата_архивированияLabel);
            this.panel1.Controls.Add(this.дата_архивированияDateTimePicker);
            this.panel1.Controls.Add(причина_архивированияLabel);
            this.panel1.Controls.Add(this.причина_архивированияTextBox);
            this.panel1.Controls.Add(фио_архивариусаLabel);
            this.panel1.Controls.Add(this.фио_архивариусаTextBox);
            this.panel1.Controls.Add(дата_передачи_в_отделLabel);
            this.panel1.Controls.Add(this.дата_передачи_в_отделDateTimePicker);
            this.panel1.Controls.Add(дата_повторного_архивированияLabel);
            this.panel1.Controls.Add(this.дата_повторного_архивированияDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 379);
            this.panel1.TabIndex = 19;
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
            this.clear_data.Location = new System.Drawing.Point(19, 249);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(103, 25);
            this.clear_data.TabIndex = 46;
            this.clear_data.Text = "Очистить";
            this.clear_data.UseVisualStyleBackColor = false;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
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
            this.add_to_archiv.Location = new System.Drawing.Point(503, 345);
            this.add_to_archiv.Name = "add_to_archiv";
            this.add_to_archiv.Size = new System.Drawing.Size(146, 29);
            this.add_to_archiv.TabIndex = 45;
            this.add_to_archiv.Text = "Архивировать";
            this.add_to_archiv.UseVisualStyleBackColor = false;
            this.add_to_archiv.Click += new System.EventHandler(this.add_to_archiv_Click);
            // 
            // дата_архивированияDateTimePicker
            // 
            this.дата_архивированияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.архивные_делаBindingSource, "дата_архивирования", true));
            this.дата_архивированияDateTimePicker.Location = new System.Drawing.Point(251, 109);
            this.дата_архивированияDateTimePicker.Name = "дата_архивированияDateTimePicker";
            this.дата_архивированияDateTimePicker.Size = new System.Drawing.Size(351, 22);
            this.дата_архивированияDateTimePicker.TabIndex = 40;
            // 
            // архивные_делаBindingSource
            // 
            this.архивные_делаBindingSource.DataMember = "архивные_дела";
            this.архивные_делаBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // pfr_casesDataSet
            // 
            this.pfr_casesDataSet.DataSetName = "pfr_casesDataSet";
            this.pfr_casesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // причина_архивированияTextBox
            // 
            this.причина_архивированияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "причина_архивирования", true));
            this.причина_архивированияTextBox.Location = new System.Drawing.Point(251, 137);
            this.причина_архивированияTextBox.Name = "причина_архивированияTextBox";
            this.причина_архивированияTextBox.Size = new System.Drawing.Size(351, 22);
            this.причина_архивированияTextBox.TabIndex = 42;
            // 
            // фио_архивариусаTextBox
            // 
            this.фио_архивариусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.архивные_делаBindingSource, "фио_архивариуса", true));
            this.фио_архивариусаTextBox.Location = new System.Drawing.Point(251, 165);
            this.фио_архивариусаTextBox.Name = "фио_архивариусаTextBox";
            this.фио_архивариусаTextBox.Size = new System.Drawing.Size(351, 22);
            this.фио_архивариусаTextBox.TabIndex = 44;
            // 
            // дата_передачи_в_отделDateTimePicker
            // 
            this.дата_передачи_в_отделDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.запросы_архивных_делBindingSource, "дата_передачи_в_отдел", true));
            this.дата_передачи_в_отделDateTimePicker.Location = new System.Drawing.Point(251, 25);
            this.дата_передачи_в_отделDateTimePicker.Name = "дата_передачи_в_отделDateTimePicker";
            this.дата_передачи_в_отделDateTimePicker.Size = new System.Drawing.Size(351, 22);
            this.дата_передачи_в_отделDateTimePicker.TabIndex = 21;
            // 
            // запросы_архивных_делBindingSource
            // 
            this.запросы_архивных_делBindingSource.DataMember = "запросы_архивных_дел";
            this.запросы_архивных_делBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // дата_повторного_архивированияDateTimePicker
            // 
            this.дата_повторного_архивированияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.запросы_архивных_делBindingSource, "дата_повторного_архивирования", true));
            this.дата_повторного_архивированияDateTimePicker.Location = new System.Drawing.Point(251, 53);
            this.дата_повторного_архивированияDateTimePicker.Name = "дата_повторного_архивированияDateTimePicker";
            this.дата_повторного_архивированияDateTimePicker.Size = new System.Drawing.Size(351, 22);
            this.дата_повторного_архивированияDateTimePicker.TabIndex = 25;
            // 
            // действующие_делаBindingSource
            // 
            this.действующие_делаBindingSource.DataMember = "действующие_дела";
            this.действующие_делаBindingSource.DataSource = this.pfr_casesDataSet;
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
            this.tableAdapterManager.действующие_делаTableAdapter = this.действующие_делаTableAdapter;
            this.tableAdapterManager.запросы_архивных_делTableAdapter = this.запросы_архивных_делTableAdapter;
            this.tableAdapterManager.пользователиTableAdapter = null;
            // 
            // действующие_делаTableAdapter
            // 
            this.действующие_делаTableAdapter.ClearBeforeFill = true;
            // 
            // архивные_делаTableAdapter
            // 
            this.архивные_делаTableAdapter.ClearBeforeFill = true;
            // 
            // archivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(678, 480);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "archivation";
            this.Text = "Архивировать дело";
            this.Load += new System.EventHandler(this.archivation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.архивные_делаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующие_делаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pfr_casesDataSet pfr_casesDataSet;
        private System.Windows.Forms.BindingSource запросы_архивных_делBindingSource;
        private pfr_casesDataSetTableAdapters.запросы_архивных_делTableAdapter запросы_архивных_делTableAdapter;
        private pfr_casesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private pfr_casesDataSetTableAdapters.действующие_делаTableAdapter действующие_делаTableAdapter;
        private System.Windows.Forms.BindingSource действующие_делаBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker дата_передачи_в_отделDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_повторного_архивированияDateTimePicker;
        private System.Windows.Forms.BindingSource архивные_делаBindingSource;
        private pfr_casesDataSetTableAdapters.архивные_делаTableAdapter архивные_делаTableAdapter;
        private System.Windows.Forms.DateTimePicker дата_архивированияDateTimePicker;
        private System.Windows.Forms.TextBox причина_архивированияTextBox;
        private System.Windows.Forms.TextBox фио_архивариусаTextBox;
        private System.Windows.Forms.Button add_to_archiv;
        private System.Windows.Forms.Button clear_data;
    }
}