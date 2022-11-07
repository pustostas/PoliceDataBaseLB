namespace PoliceDataBaseLB
{
    partial class RSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSForm));
            System.Windows.Forms.Label act_idLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label citizenLabel;
            System.Windows.Forms.Label articleLabel;
            this.policeplatformDataSet = new PoliceDataBaseLB.policeplatformDataSet();
            this.actBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actTableAdapter = new PoliceDataBaseLB.policeplatformDataSetTableAdapters.actTableAdapter();
            this.tableAdapterManager = new PoliceDataBaseLB.policeplatformDataSetTableAdapters.TableAdapterManager();
            this.actBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.actBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.act_idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.citizenTextBox = new System.Windows.Forms.TextBox();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.criminal_in_actBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criminal_in_actTableAdapter = new PoliceDataBaseLB.policeplatformDataSetTableAdapters.criminal_in_actTableAdapter();
            this.criminal_in_actDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            act_idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            citizenLabel = new System.Windows.Forms.Label();
            articleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.policeplatformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingNavigator)).BeginInit();
            this.actBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminal_in_actBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminal_in_actDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // policeplatformDataSet
            // 
            this.policeplatformDataSet.DataSetName = "policeplatformDataSet";
            this.policeplatformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actBindingSource
            // 
            this.actBindingSource.DataMember = "act";
            this.actBindingSource.DataSource = this.policeplatformDataSet;
            // 
            // actTableAdapter
            // 
            this.actTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actTableAdapter = this.actTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.criminal_in_actTableAdapter = this.criminal_in_actTableAdapter;
            this.tableAdapterManager.criminalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PoliceDataBaseLB.policeplatformDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actBindingNavigator
            // 
            this.actBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actBindingNavigator.BindingSource = this.actBindingSource;
            this.actBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.actBindingNavigatorSaveItem});
            this.actBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actBindingNavigator.Name = "actBindingNavigator";
            this.actBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.actBindingNavigator.TabIndex = 0;
            this.actBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // actBindingNavigatorSaveItem
            // 
            this.actBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actBindingNavigatorSaveItem.Image")));
            this.actBindingNavigatorSaveItem.Name = "actBindingNavigatorSaveItem";
            this.actBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.actBindingNavigatorSaveItem.Text = "Save Data";
            this.actBindingNavigatorSaveItem.Click += new System.EventHandler(this.actBindingNavigatorSaveItem_Click);
            // 
            // act_idLabel
            // 
            act_idLabel.AutoSize = true;
            act_idLabel.Location = new System.Drawing.Point(12, 53);
            act_idLabel.Name = "act_idLabel";
            act_idLabel.Size = new System.Drawing.Size(37, 13);
            act_idLabel.TabIndex = 1;
            act_idLabel.Text = "Act id:";
            // 
            // act_idTextBox
            // 
            this.act_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actBindingSource, "Act_id", true));
            this.act_idTextBox.Location = new System.Drawing.Point(59, 50);
            this.act_idTextBox.Name = "act_idTextBox";
            this.act_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.act_idTextBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 80);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.actBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(59, 76);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // citizenLabel
            // 
            citizenLabel.AutoSize = true;
            citizenLabel.Location = new System.Drawing.Point(12, 105);
            citizenLabel.Name = "citizenLabel";
            citizenLabel.Size = new System.Drawing.Size(41, 13);
            citizenLabel.TabIndex = 5;
            citizenLabel.Text = "Citizen:";
            // 
            // citizenTextBox
            // 
            this.citizenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actBindingSource, "Citizen", true));
            this.citizenTextBox.Location = new System.Drawing.Point(59, 102);
            this.citizenTextBox.Name = "citizenTextBox";
            this.citizenTextBox.Size = new System.Drawing.Size(200, 20);
            this.citizenTextBox.TabIndex = 6;
            // 
            // articleLabel
            // 
            articleLabel.AutoSize = true;
            articleLabel.Location = new System.Drawing.Point(12, 131);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(39, 13);
            articleLabel.TabIndex = 7;
            articleLabel.Text = "Article:";
            // 
            // articleTextBox
            // 
            this.articleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actBindingSource, "Article", true));
            this.articleTextBox.Location = new System.Drawing.Point(59, 128);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(200, 20);
            this.articleTextBox.TabIndex = 8;
            // 
            // criminal_in_actBindingSource
            // 
            this.criminal_in_actBindingSource.DataMember = "criminal_in_act";
            this.criminal_in_actBindingSource.DataSource = this.policeplatformDataSet;
            // 
            // criminal_in_actTableAdapter
            // 
            this.criminal_in_actTableAdapter.ClearBeforeFill = true;
            // 
            // criminal_in_actDataGridView
            // 
            this.criminal_in_actDataGridView.AutoGenerateColumns = false;
            this.criminal_in_actDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminal_in_actDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.criminal_in_actDataGridView.DataSource = this.criminal_in_actBindingSource;
            this.criminal_in_actDataGridView.Location = new System.Drawing.Point(59, 187);
            this.criminal_in_actDataGridView.Name = "criminal_in_actDataGridView";
            this.criminal_in_actDataGridView.Size = new System.Drawing.Size(345, 243);
            this.criminal_in_actDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Criminal_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Criminal_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Act_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Act_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Accept changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.criminal_in_actDataGridView);
            this.Controls.Add(act_idLabel);
            this.Controls.Add(this.act_idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(citizenLabel);
            this.Controls.Add(this.citizenTextBox);
            this.Controls.Add(articleLabel);
            this.Controls.Add(this.articleTextBox);
            this.Controls.Add(this.actBindingNavigator);
            this.Name = "RSForm";
            this.Text = "Relationships";
            this.Load += new System.EventHandler(this.RSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policeplatformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingNavigator)).EndInit();
            this.actBindingNavigator.ResumeLayout(false);
            this.actBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminal_in_actBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminal_in_actDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private policeplatformDataSet policeplatformDataSet;
        private System.Windows.Forms.BindingSource actBindingSource;
        private policeplatformDataSetTableAdapters.actTableAdapter actTableAdapter;
        private policeplatformDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton actBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox act_idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox citizenTextBox;
        private System.Windows.Forms.TextBox articleTextBox;
        private policeplatformDataSetTableAdapters.criminal_in_actTableAdapter criminal_in_actTableAdapter;
        private System.Windows.Forms.BindingSource criminal_in_actBindingSource;
        private System.Windows.Forms.DataGridView criminal_in_actDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}