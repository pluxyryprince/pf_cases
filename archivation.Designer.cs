
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archivation));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label дата_передачи_в_отделLabel;
            System.Windows.Forms.Label фио_специалистаLabel;
            System.Windows.Forms.Label дата_повторного_архивированияLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.pfr_casesDataSet = new pfr.pfr_casesDataSet();
            this.запросы_архивных_делBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запросы_архивных_делTableAdapter = new pfr.pfr_casesDataSetTableAdapters.запросы_архивных_делTableAdapter();
            this.tableAdapterManager = new pfr.pfr_casesDataSetTableAdapters.TableAdapterManager();
            this.запросы_архивных_делBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.запросы_архивных_делBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.дата_передачи_в_отделDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фио_специалистаTextBox = new System.Windows.Forms.TextBox();
            this.дата_повторного_архивированияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.действующие_делаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.действующие_делаTableAdapter = new pfr.pfr_casesDataSetTableAdapters.действующие_делаTableAdapter();
            this.archivate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            дата_передачи_в_отделLabel = new System.Windows.Forms.Label();
            фио_специалистаLabel = new System.Windows.Forms.Label();
            дата_повторного_архивированияLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingNavigator)).BeginInit();
            this.запросы_архивных_делBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.действующие_делаBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pfr_casesDataSet
            // 
            this.pfr_casesDataSet.DataSetName = "pfr_casesDataSet";
            this.pfr_casesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запросы_архивных_делBindingSource
            // 
            this.запросы_архивных_делBindingSource.DataMember = "запросы_архивных_дел";
            this.запросы_архивных_делBindingSource.DataSource = this.pfr_casesDataSet;
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
            // запросы_архивных_делBindingNavigator
            // 
            this.запросы_архивных_делBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.запросы_архивных_делBindingNavigator.BindingSource = this.запросы_архивных_делBindingSource;
            this.запросы_архивных_делBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.запросы_архивных_делBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.запросы_архивных_делBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.запросы_архивных_делBindingNavigatorSaveItem});
            this.запросы_архивных_делBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.запросы_архивных_делBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.запросы_архивных_делBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.запросы_архивных_делBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.запросы_архивных_делBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.запросы_архивных_делBindingNavigator.Name = "запросы_архивных_делBindingNavigator";
            this.запросы_архивных_делBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.запросы_архивных_делBindingNavigator.Size = new System.Drawing.Size(629, 25);
            this.запросы_архивных_делBindingNavigator.TabIndex = 0;
            this.запросы_архивных_делBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(46, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // запросы_архивных_делBindingNavigatorSaveItem
            // 
            this.запросы_архивных_делBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.запросы_архивных_делBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("запросы_архивных_делBindingNavigatorSaveItem.Image")));
            this.запросы_архивных_делBindingNavigatorSaveItem.Name = "запросы_архивных_делBindingNavigatorSaveItem";
            this.запросы_архивных_делBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.запросы_архивных_делBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.запросы_архивных_делBindingNavigatorSaveItem.Click += new System.EventHandler(this.запросы_архивных_делBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            idLabel.Location = new System.Drawing.Point(29, 123);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(112, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Номер запроса:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.запросы_архивных_делBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(261, 120);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(344, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // дата_передачи_в_отделLabel
            // 
            дата_передачи_в_отделLabel.AutoSize = true;
            дата_передачи_в_отделLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_передачи_в_отделLabel.Location = new System.Drawing.Point(29, 152);
            дата_передачи_в_отделLabel.Name = "дата_передачи_в_отделLabel";
            дата_передачи_в_отделLabel.Size = new System.Drawing.Size(163, 16);
            дата_передачи_в_отделLabel.TabIndex = 3;
            дата_передачи_в_отделLabel.Text = "Дата передачи в отдел:";
            // 
            // дата_передачи_в_отделDateTimePicker
            // 
            this.дата_передачи_в_отделDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.запросы_архивных_делBindingSource, "дата_передачи_в_отдел", true));
            this.дата_передачи_в_отделDateTimePicker.Location = new System.Drawing.Point(261, 148);
            this.дата_передачи_в_отделDateTimePicker.Name = "дата_передачи_в_отделDateTimePicker";
            this.дата_передачи_в_отделDateTimePicker.Size = new System.Drawing.Size(344, 22);
            this.дата_передачи_в_отделDateTimePicker.TabIndex = 4;
            // 
            // фио_специалистаLabel
            // 
            фио_специалистаLabel.AutoSize = true;
            фио_специалистаLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            фио_специалистаLabel.Location = new System.Drawing.Point(29, 179);
            фио_специалистаLabel.Name = "фио_специалистаLabel";
            фио_специалистаLabel.Size = new System.Drawing.Size(130, 16);
            фио_специалистаLabel.TabIndex = 5;
            фио_специалистаLabel.Text = "ФИО специалиста:";
            // 
            // фио_специалистаTextBox
            // 
            this.фио_специалистаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.запросы_архивных_делBindingSource, "фио_специалиста", true));
            this.фио_специалистаTextBox.Location = new System.Drawing.Point(261, 176);
            this.фио_специалистаTextBox.Name = "фио_специалистаTextBox";
            this.фио_специалистаTextBox.Size = new System.Drawing.Size(344, 22);
            this.фио_специалистаTextBox.TabIndex = 6;
            // 
            // дата_повторного_архивированияLabel
            // 
            дата_повторного_архивированияLabel.AutoSize = true;
            дата_повторного_архивированияLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            дата_повторного_архивированияLabel.Location = new System.Drawing.Point(29, 208);
            дата_повторного_архивированияLabel.Name = "дата_повторного_архивированияLabel";
            дата_повторного_архивированияLabel.Size = new System.Drawing.Size(227, 16);
            дата_повторного_архивированияLabel.TabIndex = 7;
            дата_повторного_архивированияLabel.Text = "Дата повторного архивирования:";
            // 
            // дата_повторного_архивированияDateTimePicker
            // 
            this.дата_повторного_архивированияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.запросы_архивных_делBindingSource, "дата_повторного_архивирования", true));
            this.дата_повторного_архивированияDateTimePicker.Location = new System.Drawing.Point(261, 204);
            this.дата_повторного_архивированияDateTimePicker.Name = "дата_повторного_архивированияDateTimePicker";
            this.дата_повторного_архивированияDateTimePicker.Size = new System.Drawing.Size(344, 22);
            this.дата_повторного_архивированияDateTimePicker.TabIndex = 8;
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
            // archivate
            // 
            this.archivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.archivate.FlatAppearance.BorderSize = 0;
            this.archivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archivate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.archivate.Location = new System.Drawing.Point(482, 270);
            this.archivate.Name = "archivate";
            this.archivate.Size = new System.Drawing.Size(120, 28);
            this.archivate.TabIndex = 18;
            this.archivate.Text = "Очистить";
            this.archivate.UseVisualStyleBackColor = false;
            this.archivate.Click += new System.EventHandler(this.archivate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.archivate);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 301);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(17, 164);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 16);
            label1.TabIndex = 20;
            label1.Text = "Причина архивирования:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Смерть",
            "Прекращение начислений по возрасту\t"});
            this.comboBox1.Location = new System.Drawing.Point(249, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 24);
            this.comboBox1.TabIndex = 21;
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
            // archivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(629, 424);
            this.Controls.Add(label2);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(дата_передачи_в_отделLabel);
            this.Controls.Add(this.дата_передачи_в_отделDateTimePicker);
            this.Controls.Add(фио_специалистаLabel);
            this.Controls.Add(this.фио_специалистаTextBox);
            this.Controls.Add(дата_повторного_архивированияLabel);
            this.Controls.Add(this.дата_повторного_архивированияDateTimePicker);
            this.Controls.Add(this.запросы_архивных_делBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "archivation";
            this.Text = "Архивировать дело";
            this.Load += new System.EventHandler(this.archivation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfr_casesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросы_архивных_делBindingNavigator)).EndInit();
            this.запросы_архивных_делBindingNavigator.ResumeLayout(false);
            this.запросы_архивных_делBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.действующие_делаBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pfr_casesDataSet pfr_casesDataSet;
        private System.Windows.Forms.BindingSource запросы_архивных_делBindingSource;
        private pfr_casesDataSetTableAdapters.запросы_архивных_делTableAdapter запросы_архивных_делTableAdapter;
        private pfr_casesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator запросы_архивных_делBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton запросы_архивных_делBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker дата_передачи_в_отделDateTimePicker;
        private System.Windows.Forms.TextBox фио_специалистаTextBox;
        private System.Windows.Forms.DateTimePicker дата_повторного_архивированияDateTimePicker;
        private pfr_casesDataSetTableAdapters.действующие_делаTableAdapter действующие_делаTableAdapter;
        private System.Windows.Forms.BindingSource действующие_делаBindingSource;
        private System.Windows.Forms.Button archivate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}