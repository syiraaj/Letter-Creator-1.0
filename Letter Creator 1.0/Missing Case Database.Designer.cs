namespace Letter_Creator_1._0
{
    partial class Missing_Case_Database
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
            System.Windows.Forms.Label caseNameLabel;
            System.Windows.Forms.Label caseNoLabel;
            System.Windows.Forms.Label courtLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label judgeNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Missing_Case_Database));
            this.Label1 = new System.Windows.Forms.Label();
            this.letterCreatorDBDataSet1 = new Letter_Creator_1._0.LetterCreatorDBDataSet1();
            this.missingCasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.missingCasesTableAdapter = new Letter_Creator_1._0.LetterCreatorDBDataSet1TableAdapters.MissingCasesTableAdapter();
            this.tableAdapterManager = new Letter_Creator_1._0.LetterCreatorDBDataSet1TableAdapters.TableAdapterManager();
            this.missingCasesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.missingCasesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.caseNameTextBox = new System.Windows.Forms.TextBox();
            this.caseNoTextBox = new System.Windows.Forms.TextBox();
            this.courtTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.judgeNameTextBox = new System.Windows.Forms.TextBox();
            this.missingCasesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button4 = new System.Windows.Forms.Button();
            caseNameLabel = new System.Windows.Forms.Label();
            caseNoLabel = new System.Windows.Forms.Label();
            courtLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            judgeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.letterCreatorDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingCasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingCasesBindingNavigator)).BeginInit();
            this.missingCasesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missingCasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // caseNameLabel
            // 
            caseNameLabel.AutoSize = true;
            caseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            caseNameLabel.Location = new System.Drawing.Point(42, 124);
            caseNameLabel.Name = "caseNameLabel";
            caseNameLabel.Size = new System.Drawing.Size(102, 20);
            caseNameLabel.TabIndex = 3;
            caseNameLabel.Text = "Case Name:";
            // 
            // caseNoLabel
            // 
            caseNoLabel.AutoSize = true;
            caseNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            caseNoLabel.Location = new System.Drawing.Point(42, 319);
            caseNoLabel.Name = "caseNoLabel";
            caseNoLabel.Size = new System.Drawing.Size(79, 20);
            caseNoLabel.TabIndex = 5;
            caseNoLabel.Text = "Case No:";
            // 
            // courtLabel
            // 
            courtLabel.AutoSize = true;
            courtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courtLabel.Location = new System.Drawing.Point(42, 347);
            courtLabel.Name = "courtLabel";
            courtLabel.Size = new System.Drawing.Size(55, 20);
            courtLabel.TabIndex = 7;
            courtLabel.Text = "Court:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(42, 375);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(62, 20);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "Status:";
            // 
            // judgeNameLabel
            // 
            judgeNameLabel.AutoSize = true;
            judgeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            judgeNameLabel.Location = new System.Drawing.Point(42, 403);
            judgeNameLabel.Name = "judgeNameLabel";
            judgeNameLabel.Size = new System.Drawing.Size(108, 20);
            judgeNameLabel.TabIndex = 11;
            judgeNameLabel.Text = "Judge Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(428, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(412, 46);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Missing Cases Details";
            // 
            // letterCreatorDBDataSet1
            // 
            this.letterCreatorDBDataSet1.DataSetName = "LetterCreatorDBDataSet1";
            this.letterCreatorDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // missingCasesBindingSource
            // 
            this.missingCasesBindingSource.DataMember = "MissingCases";
            this.missingCasesBindingSource.DataSource = this.letterCreatorDBDataSet1;
            // 
            // missingCasesTableAdapter
            // 
            this.missingCasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MissingCasesTableAdapter = this.missingCasesTableAdapter;
            this.tableAdapterManager.UnreceivedCasesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Letter_Creator_1._0.LetterCreatorDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // missingCasesBindingNavigator
            // 
            this.missingCasesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.missingCasesBindingNavigator.BindingSource = this.missingCasesBindingSource;
            this.missingCasesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.missingCasesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.missingCasesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.missingCasesBindingNavigatorSaveItem});
            this.missingCasesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.missingCasesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.missingCasesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.missingCasesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.missingCasesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.missingCasesBindingNavigator.Name = "missingCasesBindingNavigator";
            this.missingCasesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.missingCasesBindingNavigator.Size = new System.Drawing.Size(1153, 27);
            this.missingCasesBindingNavigator.TabIndex = 12;
            this.missingCasesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // missingCasesBindingNavigatorSaveItem
            // 
            this.missingCasesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.missingCasesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("missingCasesBindingNavigatorSaveItem.Image")));
            this.missingCasesBindingNavigatorSaveItem.Name = "missingCasesBindingNavigatorSaveItem";
            this.missingCasesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.missingCasesBindingNavigatorSaveItem.Text = "Save Data";
            this.missingCasesBindingNavigatorSaveItem.Click += new System.EventHandler(this.missingCasesBindingNavigatorSaveItem_Click_1);
            // 
            // caseNameTextBox
            // 
            this.caseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missingCasesBindingSource, "CaseName", true));
            this.caseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseNameTextBox.Location = new System.Drawing.Point(160, 128);
            this.caseNameTextBox.Multiline = true;
            this.caseNameTextBox.Name = "caseNameTextBox";
            this.caseNameTextBox.Size = new System.Drawing.Size(373, 187);
            this.caseNameTextBox.TabIndex = 13;
            // 
            // caseNoTextBox
            // 
            this.caseNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missingCasesBindingSource, "CaseNo", true));
            this.caseNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseNoTextBox.Location = new System.Drawing.Point(160, 317);
            this.caseNoTextBox.Name = "caseNoTextBox";
            this.caseNoTextBox.Size = new System.Drawing.Size(373, 27);
            this.caseNoTextBox.TabIndex = 15;
            // 
            // courtTextBox
            // 
            this.courtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missingCasesBindingSource, "Court", true));
            this.courtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courtTextBox.Location = new System.Drawing.Point(160, 345);
            this.courtTextBox.Name = "courtTextBox";
            this.courtTextBox.Size = new System.Drawing.Size(373, 27);
            this.courtTextBox.TabIndex = 17;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missingCasesBindingSource, "Status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(160, 373);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(373, 27);
            this.statusTextBox.TabIndex = 19;
            // 
            // judgeNameTextBox
            // 
            this.judgeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missingCasesBindingSource, "JudgeName", true));
            this.judgeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judgeNameTextBox.Location = new System.Drawing.Point(160, 401);
            this.judgeNameTextBox.Name = "judgeNameTextBox";
            this.judgeNameTextBox.Size = new System.Drawing.Size(373, 27);
            this.judgeNameTextBox.TabIndex = 21;
            // 
            // missingCasesDataGridView
            // 
            this.missingCasesDataGridView.AutoGenerateColumns = false;
            this.missingCasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.missingCasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.missingCasesDataGridView.DataSource = this.missingCasesBindingSource;
            this.missingCasesDataGridView.Location = new System.Drawing.Point(576, 128);
            this.missingCasesDataGridView.Name = "missingCasesDataGridView";
            this.missingCasesDataGridView.RowTemplate.Height = 24;
            this.missingCasesDataGridView.Size = new System.Drawing.Size(541, 451);
            this.missingCasesDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CaseName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CaseName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CaseNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "CaseNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Court";
            this.dataGridViewTextBoxColumn3.HeaderText = "Court";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "JudgeName";
            this.dataGridViewTextBoxColumn5.HeaderText = "JudgeName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Button4.Location = new System.Drawing.Point(496, 617);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(160, 44);
            this.Button4.TabIndex = 22;
            this.Button4.Text = "Close";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // Missing_Case_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1153, 677);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.missingCasesDataGridView);
            this.Controls.Add(this.caseNameTextBox);
            this.Controls.Add(this.caseNoTextBox);
            this.Controls.Add(this.courtTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.judgeNameTextBox);
            this.Controls.Add(this.missingCasesBindingNavigator);
            this.Controls.Add(caseNameLabel);
            this.Controls.Add(caseNoLabel);
            this.Controls.Add(courtLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(judgeNameLabel);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Missing_Case_Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Creator 1.0";
            this.Load += new System.EventHandler(this.Missing_Case_Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.letterCreatorDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingCasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missingCasesBindingNavigator)).EndInit();
            this.missingCasesBindingNavigator.ResumeLayout(false);
            this.missingCasesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missingCasesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private LetterCreatorDBDataSet1 letterCreatorDBDataSet1;
        private System.Windows.Forms.BindingSource missingCasesBindingSource;
        private LetterCreatorDBDataSet1TableAdapters.MissingCasesTableAdapter missingCasesTableAdapter;
        private LetterCreatorDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator missingCasesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton missingCasesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox caseNameTextBox;
        private System.Windows.Forms.TextBox caseNoTextBox;
        private System.Windows.Forms.TextBox courtTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox judgeNameTextBox;
        private System.Windows.Forms.DataGridView missingCasesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        internal System.Windows.Forms.Button Button4;
    }
}