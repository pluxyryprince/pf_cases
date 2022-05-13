
namespace pfr
{
    partial class general
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(general));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.действующиеделаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.действующие_делаTableAdapter = new pfr.pfr_casesDataSetTableAdapters.действующие_делаTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.пользователиDataGridView = new System.Windows.Forms.DataGridView();
            this.архивныеделаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.архивные_делаTableAdapter = new pfr.pfr_casesDataSetTableAdapters.архивные_делаTableAdapter();
            this.номерархивногоделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видначисленийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районпроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адреспроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаархивированияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаархивированияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоархивариусаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующиеделаBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.архивныеделаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Name = "tabPage1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администраторToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            resources.ApplyResources(this.администраторToolStripMenuItem, "администраторToolStripMenuItem");
            this.администраторToolStripMenuItem.Click += new System.EventHandler(this.администраторToolStripMenuItem_Click);
            // 
            // pfr_casesDataSet
            // 
            this.pfr_casesDataSet.DataSetName = "pfr_casesDataSet";
            this.pfr_casesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // действующиеделаBindingSource
            // 
            this.действующиеделаBindingSource.DataMember = "действующие_дела";
            this.действующиеделаBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // действующие_делаTableAdapter
            // 
            this.действующие_делаTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.пользователиDataGridView);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // пользователиDataGridView
            // 
            this.пользователиDataGridView.AllowUserToAddRows = false;
            this.пользователиDataGridView.AllowUserToDeleteRows = false;
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
            this.номерархивногоделаDataGridViewTextBoxColumn,
            this.номерделаDataGridViewTextBoxColumn,
            this.фиоDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.видначисленийDataGridViewTextBoxColumn,
            this.районпроживанияDataGridViewTextBoxColumn,
            this.адреспроживанияDataGridViewTextBoxColumn,
            this.датаархивированияDataGridViewTextBoxColumn,
            this.причинаархивированияDataGridViewTextBoxColumn,
            this.фиоархивариусаDataGridViewTextBoxColumn});
            this.пользователиDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.пользователиDataGridView.DataSource = this.архивныеделаBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.пользователиDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.пользователиDataGridView, "пользователиDataGridView");
            this.пользователиDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.пользователиDataGridView.EnableHeadersVisualStyles = false;
            this.пользователиDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // 
            // архивныеделаBindingSource
            // 
            this.архивныеделаBindingSource.DataMember = "архивные_дела";
            this.архивныеделаBindingSource.DataSource = this.pfr_casesDataSet;
            // 
            // архивные_делаTableAdapter
            // 
            this.архивные_делаTableAdapter.ClearBeforeFill = true;
            // 
            // номерархивногоделаDataGridViewTextBoxColumn
            // 
            this.номерархивногоделаDataGridViewTextBoxColumn.DataPropertyName = "Номер архивного дела";
            resources.ApplyResources(this.номерархивногоделаDataGridViewTextBoxColumn, "номерархивногоделаDataGridViewTextBoxColumn");
            this.номерархивногоделаDataGridViewTextBoxColumn.Name = "номерархивногоделаDataGridViewTextBoxColumn";
            // 
            // номерделаDataGridViewTextBoxColumn
            // 
            this.номерделаDataGridViewTextBoxColumn.DataPropertyName = "номер_дела";
            resources.ApplyResources(this.номерделаDataGridViewTextBoxColumn, "номерделаDataGridViewTextBoxColumn");
            this.номерделаDataGridViewTextBoxColumn.Name = "номерделаDataGridViewTextBoxColumn";
            // 
            // фиоDataGridViewTextBoxColumn
            // 
            this.фиоDataGridViewTextBoxColumn.DataPropertyName = "фио";
            resources.ApplyResources(this.фиоDataGridViewTextBoxColumn, "фиоDataGridViewTextBoxColumn");
            this.фиоDataGridViewTextBoxColumn.Name = "фиоDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "дата_рождения";
            resources.ApplyResources(this.датарожденияDataGridViewTextBoxColumn, "датарожденияDataGridViewTextBoxColumn");
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // видначисленийDataGridViewTextBoxColumn
            // 
            this.видначисленийDataGridViewTextBoxColumn.DataPropertyName = "вид_начислений";
            resources.ApplyResources(this.видначисленийDataGridViewTextBoxColumn, "видначисленийDataGridViewTextBoxColumn");
            this.видначисленийDataGridViewTextBoxColumn.Name = "видначисленийDataGridViewTextBoxColumn";
            // 
            // районпроживанияDataGridViewTextBoxColumn
            // 
            this.районпроживанияDataGridViewTextBoxColumn.DataPropertyName = "район_проживания";
            resources.ApplyResources(this.районпроживанияDataGridViewTextBoxColumn, "районпроживанияDataGridViewTextBoxColumn");
            this.районпроживанияDataGridViewTextBoxColumn.Name = "районпроживанияDataGridViewTextBoxColumn";
            // 
            // адреспроживанияDataGridViewTextBoxColumn
            // 
            this.адреспроживанияDataGridViewTextBoxColumn.DataPropertyName = "адрес_проживания";
            resources.ApplyResources(this.адреспроживанияDataGridViewTextBoxColumn, "адреспроживанияDataGridViewTextBoxColumn");
            this.адреспроживанияDataGridViewTextBoxColumn.Name = "адреспроживанияDataGridViewTextBoxColumn";
            // 
            // датаархивированияDataGridViewTextBoxColumn
            // 
            this.датаархивированияDataGridViewTextBoxColumn.DataPropertyName = "дата_архивирования";
            resources.ApplyResources(this.датаархивированияDataGridViewTextBoxColumn, "датаархивированияDataGridViewTextBoxColumn");
            this.датаархивированияDataGridViewTextBoxColumn.Name = "датаархивированияDataGridViewTextBoxColumn";
            // 
            // причинаархивированияDataGridViewTextBoxColumn
            // 
            this.причинаархивированияDataGridViewTextBoxColumn.DataPropertyName = "причина_архивирования";
            resources.ApplyResources(this.причинаархивированияDataGridViewTextBoxColumn, "причинаархивированияDataGridViewTextBoxColumn");
            this.причинаархивированияDataGridViewTextBoxColumn.Name = "причинаархивированияDataGridViewTextBoxColumn";
            // 
            // фиоархивариусаDataGridViewTextBoxColumn
            // 
            this.фиоархивариусаDataGridViewTextBoxColumn.DataPropertyName = "фио_архивариуса";
            resources.ApplyResources(this.фиоархивариусаDataGridViewTextBoxColumn, "фиоархивариусаDataGridViewTextBoxColumn");
            this.фиоархивариусаDataGridViewTextBoxColumn.Name = "фиоархивариусаDataGridViewTextBoxColumn";
            // 
            // general
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "general";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.general_FormClosing_1);
            this.Load += new System.EventHandler(this.general_Load);
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующиеделаBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.архивныеделаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private pfr_casesDataSet pfr_casesDataSet;
        private System.Windows.Forms.BindingSource действующиеделаBindingSource;
        private pfr_casesDataSetTableAdapters.действующие_делаTableAdapter действующие_делаTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView пользователиDataGridView;
        private System.Windows.Forms.BindingSource архивныеделаBindingSource;
        private pfr_casesDataSetTableAdapters.архивные_делаTableAdapter архивные_делаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерархивногоделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видначисленийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районпроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адреспроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаархивированияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаархивированияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоархивариусаDataGridViewTextBoxColumn;
    }
}