﻿namespace Общежитие
{
    partial class RasselenieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasselenieForm));
            System.Windows.Forms.Label room_nLabel;
            System.Windows.Forms.Label value_rLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label toolsLabel;
            System.Windows.Forms.Label flourLabel;
            this.общежитиеDataSet = new Общежитие.ОбщежитиеDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Общежитие.ОбщежитиеDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new Общежитие.ОбщежитиеDataSetTableAdapters.TableAdapterManager();
            this.roomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.roomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.room_nTextBox = new System.Windows.Forms.TextBox();
            this.value_rTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.toolsTextBox = new System.Windows.Forms.TextBox();
            this.flourTextBox = new System.Windows.Forms.TextBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Общежитие.ОбщежитиеDataSetTableAdapters.StudentsTableAdapter();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submit = new System.Windows.Forms.Button();
            room_nLabel = new System.Windows.Forms.Label();
            value_rLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            toolsLabel = new System.Windows.Forms.Label();
            flourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).BeginInit();
            this.roomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // общежитиеDataSet
            // 
            this.общежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
            this.общежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.общежитиеDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LgotaTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Общежитие.ОбщежитиеDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomsBindingNavigator
            // 
            this.roomsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomsBindingNavigator.BindingSource = this.roomsBindingSource;
            this.roomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.roomsBindingNavigatorSaveItem});
            this.roomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomsBindingNavigator.Name = "roomsBindingNavigator";
            this.roomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomsBindingNavigator.Size = new System.Drawing.Size(710, 25);
            this.roomsBindingNavigator.TabIndex = 0;
            this.roomsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
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
            // roomsBindingNavigatorSaveItem
            // 
            this.roomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roomsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomsBindingNavigatorSaveItem.Image")));
            this.roomsBindingNavigatorSaveItem.Name = "roomsBindingNavigatorSaveItem";
            this.roomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.roomsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.roomsBindingNavigatorSaveItem.Click += new System.EventHandler(this.roomsBindingNavigatorSaveItem_Click);
            // 
            // room_nLabel
            // 
            room_nLabel.AutoSize = true;
            room_nLabel.Location = new System.Drawing.Point(43, 42);
            room_nLabel.Name = "room_nLabel";
            room_nLabel.Size = new System.Drawing.Size(66, 13);
            room_nLabel.TabIndex = 1;
            room_nLabel.Text = "№ комнаты";
            // 
            // room_nTextBox
            // 
            this.room_nTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Room_n", true));
            this.room_nTextBox.Location = new System.Drawing.Point(129, 39);
            this.room_nTextBox.Name = "room_nTextBox";
            this.room_nTextBox.Size = new System.Drawing.Size(100, 20);
            this.room_nTextBox.TabIndex = 2;
            // 
            // value_rLabel
            // 
            value_rLabel.AutoSize = true;
            value_rLabel.Location = new System.Drawing.Point(43, 68);
            value_rLabel.Name = "value_rLabel";
            value_rLabel.Size = new System.Drawing.Size(61, 13);
            value_rLabel.TabIndex = 3;
            value_rLabel.Text = "стоимость";
            // 
            // value_rTextBox
            // 
            this.value_rTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Value_r", true));
            this.value_rTextBox.Location = new System.Drawing.Point(129, 65);
            this.value_rTextBox.Name = "value_rTextBox";
            this.value_rTextBox.Size = new System.Drawing.Size(100, 20);
            this.value_rTextBox.TabIndex = 4;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(43, 94);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(65, 13);
            amountLabel.TabIndex = 5;
            amountLabel.Text = "количество";
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(129, 91);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 6;
            // 
            // toolsLabel
            // 
            toolsLabel.AutoSize = true;
            toolsLabel.Location = new System.Drawing.Point(43, 120);
            toolsLabel.Name = "toolsLabel";
            toolsLabel.Size = new System.Drawing.Size(60, 13);
            toolsLabel.TabIndex = 7;
            toolsLabel.Text = "инвентарь";
            // 
            // toolsTextBox
            // 
            this.toolsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Tools", true));
            this.toolsTextBox.Location = new System.Drawing.Point(129, 117);
            this.toolsTextBox.Name = "toolsTextBox";
            this.toolsTextBox.Size = new System.Drawing.Size(100, 20);
            this.toolsTextBox.TabIndex = 8;
            // 
            // flourLabel
            // 
            flourLabel.AutoSize = true;
            flourLabel.Location = new System.Drawing.Point(43, 146);
            flourLabel.Name = "flourLabel";
            flourLabel.Size = new System.Drawing.Size(32, 13);
            flourLabel.TabIndex = 9;
            flourLabel.Text = "этаж";
            // 
            // flourTextBox
            // 
            this.flourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Flour", true));
            this.flourTextBox.Location = new System.Drawing.Point(129, 143);
            this.flourTextBox.Name = "flourTextBox";
            this.flourTextBox.Size = new System.Drawing.Size(100, 20);
            this.flourTextBox.TabIndex = 10;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "RoomsStudents";
            this.studentsBindingSource.DataSource = this.roomsBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(0, 181);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(710, 316);
            this.studentsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "student_kod";
            this.dataGridViewTextBoxColumn1.HeaderText = "student_kod";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SNP";
            this.dataGridViewTextBoxColumn2.HeaderText = "SNP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Birth_year";
            this.dataGridViewTextBoxColumn3.HeaderText = "Birth_year";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Group";
            this.dataGridViewTextBoxColumn6.HeaderText = "Group";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Privelege_cod";
            this.dataGridViewTextBoxColumn7.HeaderText = "Privelege_cod";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn8.HeaderText = "Passport";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn9.HeaderText = "Room";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Colonize_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Colonize_date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(329, 146);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(176, 23);
            this.submit.TabIndex = 12;
            this.submit.Text = "Подтвердить изменения";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // RasselenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 496);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(room_nLabel);
            this.Controls.Add(this.room_nTextBox);
            this.Controls.Add(value_rLabel);
            this.Controls.Add(this.value_rTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(toolsLabel);
            this.Controls.Add(this.toolsTextBox);
            this.Controls.Add(flourLabel);
            this.Controls.Add(this.flourTextBox);
            this.Controls.Add(this.roomsBindingNavigator);
            this.Name = "RasselenieForm";
            this.Text = "RasselenieForm";
            this.Load += new System.EventHandler(this.RasselenieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).EndInit();
            this.roomsBindingNavigator.ResumeLayout(false);
            this.roomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ОбщежитиеDataSet общежитиеDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private ОбщежитиеDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private ОбщежитиеDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roomsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton roomsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox room_nTextBox;
        private System.Windows.Forms.TextBox value_rTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox toolsTextBox;
        private System.Windows.Forms.TextBox flourTextBox;
        private ОбщежитиеDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button submit;
    }
}