namespace Letter_Creator_1._0
{
    partial class Unreceived_Cases_Database
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
            System.Windows.Forms.Label judgeNameLabel;
            System.Windows.Forms.Label caseNameLabel;
            System.Windows.Forms.Label caseNoLabel;
            System.Windows.Forms.Label status1Label;
            System.Windows.Forms.Label status2Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unreceived_Cases_Database));
            this.Label1 = new System.Windows.Forms.Label();
            this.letterCreatorDBDataSet1 = new Letter_Creator_1._0.LetterCreatorDBDataSet1();
            this.unreceivedCasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unreceivedCasesTableAdapter = new Letter_Creator_1._0.LetterCreatorDBDataSet1TableAdapters.UnreceivedCasesTableAdapter();
            this.tableAdapterManager = new Letter_Creator_1._0.LetterCreatorDBDataSet1TableAdapters.TableAdapterManager();
            this.unreceivedCasesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.unreceivedCasesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.judgeNameTextBox = new System.Windows.Forms.TextBox();
            this.caseNameTextBox = new System.Windows.Forms.TextBox();
            this.caseNoTextBox = new System.Windows.Forms.TextBox();
            this.status1TextBox = new System.Windows.Forms.TextBox();
            this.status2TextBox = new System.Windows.Forms.TextBox();
            this.unreceivedCasesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button4 = new System.Windows.Forms.Button();
            judgeNameLabel = new System.Windows.Forms.Label();
            caseNameLabel = new System.Windows.Forms.Label();
            caseNoLabel = new System.Windows.Forms.Label();
            status1Label = new System.Windows.Forms.Label();
            status2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.letterCreatorDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unreceivedCasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unreceivedCasesBindingNavigator)).BeginInit();
            this.unreceivedCasesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unreceivedCasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // judgeNameLabel
            // 
            judgeNameLabel.AutoSize = true;
            judgeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            judgeNameLabel.Location = new System.Drawing.Point(48, 128);
            judgeNameLabel.Name = "judgeNameLabel";
            judgeNameLabel.Size = new System.Drawing.Size(108, 20);
            judgeNameLabel.TabIndex = 3;
            judgeNameLabel.Text = "Judge Name:";
            // 
            // caseNameLabel
            // 
            caseNameLabel.AutoSize = true;
            caseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            caseNameLabel.Location = new System.Drawing.Point(48, 156);
            caseNameLabel.Name = "caseNameLabel";
            caseNameLabel.Size = new System.Drawing.Size(102, 20);
            caseNameLabel.TabIndex = 5;
            caseNameLabel.Text = "Case Name:";
            // 
            // caseNoLabel
            // 
            caseNoLabel.AutoSize = true;
            caseNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            caseNoLabel.Location = new System.Drawing.Point(48, 351);
            caseNoLabel.Name = "caseNoLabel";
            caseNoLabel.Size = new System.Drawing.Size(79, 20);
            caseNoLabel.TabIndex = 7;
            caseNoLabel.Text = "Case No:";
            // 
            // status1Label
            // 
            status1Label.AutoSize = true;
            status1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            status1Label.Location = new System.Drawing.Point(48, 379);
            status1Label.Name = "status1Label";
            status1Label.Size = new System.Drawing.Size(71, 20);
            status1Label.TabIndex = 9;
            status1Label.Text = "Status1:";
            // 
            // status2Label
            // 
            status2Label.AutoSize = true;
            status2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            status2Label.Location = new System.Drawing.Point(48, 407);
            status2Label.Name = "status2Label";
            status2Label.Size = new System.Drawing.Size(71, 20);
            status2Label.TabIndex = 11;
            status2Label.Text = "Status2:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(380, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(478, 46);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Unreceived Cases Details";
            // 
            // letterCreatorDBDataSet1
            // 
            this.letterCreatorDBDataSet1.DataSetName = "LetterCreatorDBDataSet1";
            this.letterCreatorDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unreceivedCasesBindingSource
            // 
            this.unreceivedCasesBindingSource.DataMember = "UnreceivedCases";
            this.unreceivedCasesBindingSource.DataSource = this.letterCreatorDBDataSet1;
            // 
            // unreceivedCasesTableAdapter
            // 
            this.unreceivedCasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MissingCasesTableAdapter = null;
            this.tableAdapterManager.UnreceivedCasesTableAdapter = this.unreceivedCasesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Letter_Creator_1._0.LetterCreatorDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // unreceivedCasesBindingNavigator
            // 
            this.unreceivedCasesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.unreceivedCasesBindingNavigator.BindingSource = this.unreceivedCasesBindingSource;
            this.unreceivedCasesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.unreceivedCasesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.unreceivedCasesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.unreceivedCasesBindingNavigatorSaveItem});
            this.unreceivedCasesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.unreceivedCasesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.unreceivedCasesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.unreceivedCasesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.unreceivedCasesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.unreceivedCasesBindingNavigator.Name = "unreceivedCasesBindingNavigator";
            this.unreceivedCasesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.unreceivedCasesBindingNavigator.Size = new System.Drawing.Size(1153, 27);
            this.unreceivedCasesBindingNavigator.TabIndex = 12;
            this.unreceivedCasesBindingNavigator.Text = "bindingNavigator1";
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
            // unreceivedCasesBindingNavigatorSaveItem
            // 
            this.unreceivedCasesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unreceivedCasesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("unreceivedCasesBindingNavigatorSaveItem.Image")));
            this.unreceivedCasesBindingNavigatorSaveItem.Name = "unreceivedCasesBindingNavigatorSaveItem";
            this.unreceivedCasesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.unreceivedCasesBindingNavigatorSaveItem.Text = "Save Data";
            this.unreceivedCasesBindingNavigatorSaveItem.Click += new System.EventHandler(this.unreceivedCasesBindingNavigatorSaveItem_Click_1);
            // 
            // judgeNameTextBox
            // 
            this.judgeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unreceivedCasesBindingSource, "JudgeName", true));
            this.judgeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judgeNameTextBox.Location = new System.Drawing.Point(162, 128);
            this.judgeNameTextBox.Name = "judgeNameTextBox";
            this.judgeNameTextBox.Size = new System.Drawing.Size(341, 27);
            this.judgeNameTextBox.TabIndex = 13;
            // 
            // caseNameTextBox
            // 
            this.caseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unreceivedCasesBindingSource, "CaseName", true));
            this.caseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseNameTextBox.Location = new System.Drawing.Point(162, 157);
            this.caseNameTextBox.Multiline = true;
            this.caseNameTextBox.Name = "caseNameTextBox";
            this.caseNameTextBox.Size = new System.Drawing.Size(341, 191);
            this.caseNameTextBox.TabIndex = 15;
            // 
            // caseNoTextBox
            // 
            this.caseNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unreceivedCasesBindingSource, "CaseNo", true));
            this.caseNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseNoTextBox.Location = new System.Drawing.Point(162, 351);
            this.caseNoTextBox.Name = "caseNoTextBox";
            this.caseNoTextBox.Size = new System.Drawing.Size(341, 27);
            this.caseNoTextBox.TabIndex = 17;
            // 
            // status1TextBox
            // 
            this.status1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unreceivedCasesBindingSource, "Status1", true));
            this.status1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1TextBox.Location = new System.Drawing.Point(162, 379);
            this.status1TextBox.Name = "status1TextBox";
            this.status1TextBox.Size = new System.Drawing.Size(341, 27);
            this.status1TextBox.TabIndex = 19;
            // 
            // status2TextBox
            // 
            this.status2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unreceivedCasesBindingSource, "Status2", true));
            this.status2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2TextBox.Location = new System.Drawing.Point(162, 407);
            this.status2TextBox.Name = "status2TextBox";
            this.status2TextBox.Size = new System.Drawing.Size(341, 27);
            this.status2TextBox.TabIndex = 21;
            // 
            // unreceivedCasesDataGridView
            // 
            this.unreceivedCasesDataGridView.AutoGenerateColumns = false;
            this.unreceivedCasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unreceivedCasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.unreceivedCasesDataGridView.DataSource = this.unreceivedCasesBindingSource;
            this.unreceivedCasesDataGridView.Location = new System.Drawing.Point(540, 128);
            this.unreceivedCasesDataGridView.Name = "unreceivedCasesDataGridView";
            this.unreceivedCasesDataGridView.RowTemplate.Height = 24;
            this.unreceivedCasesDataGridView.Size = new System.Drawing.Size(536, 464);
            this.unreceivedCasesDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "JudgeName";
            this.dataGridViewTextBoxColumn1.HeaderText = "JudgeName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CaseName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CaseName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CaseNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "CaseNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Button4.Location = new System.Drawing.Point(496, 617);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(160, 44);
            this.Button4.TabIndex = 23;
            this.Button4.Text = "Close";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // Unreceived_Cases_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1153, 681);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.unreceivedCasesDataGridView);
            this.Controls.Add(this.judgeNameTextBox);
            this.Controls.Add(this.caseNameTextBox);
            this.Controls.Add(this.caseNoTextBox);
            this.Controls.Add(this.status1TextBox);
            this.Controls.Add(this.status2TextBox);
            this.Controls.Add(this.unreceivedCasesBindingNavigator);
            this.Controls.Add(judgeNameLabel);
            this.Controls.Add(caseNameLabel);
            this.Controls.Add(caseNoLabel);
            this.Controls.Add(status1Label);
            this.Controls.Add(status2Label);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unreceived_Cases_Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Creator 1.0";
            this.Load += new System.EventHandler(this.Unreceived_Cases_Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.letterCreatorDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unreceivedCasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unreceivedCasesBindingNavigator)).EndInit();
            this.unreceivedCasesBindingNavigator.ResumeLayout(false);
            this.unreceivedCasesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unreceivedCasesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private LetterCreatorDBDataSet1 letterCreatorDBDataSet1;
        private System.Windows.Forms.BindingSource unreceivedCasesBindingSource;
        private LetterCreatorDBDataSet1TableAdapters.UnreceivedCasesTableAdapter unreceivedCasesTableAdapter;
        private LetterCreatorDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator unreceivedCasesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton unreceivedCasesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox judgeNameTextBox;
        private System.Windows.Forms.TextBox caseNameTextBox;
        private System.Windows.Forms.TextBox caseNoTextBox;
        private System.Windows.Forms.TextBox status1TextBox;
        private System.Windows.Forms.TextBox status2TextBox;
        private System.Windows.Forms.DataGridView unreceivedCasesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        internal System.Windows.Forms.Button Button4;
    }
}