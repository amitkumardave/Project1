namespace WindowsFormsApplication1
{
    partial class FrmBusinessEntity
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.chkLogging = new System.Windows.Forms.CheckBox();
            this.chkAuditing = new System.Windows.Forms.CheckBox();
            this.chkHistory = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdAttributes = new System.Windows.Forms.DataGridView();
            this.AttributeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RelationEntity = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsCalculated = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Security = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Triggers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Workflow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Validation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAttributes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entity Name";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(93, 13);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(519, 20);
            this.txtEntityName.TabIndex = 1;
            // 
            // chkLogging
            // 
            this.chkLogging.AutoSize = true;
            this.chkLogging.Location = new System.Drawing.Point(93, 48);
            this.chkLogging.Name = "chkLogging";
            this.chkLogging.Size = new System.Drawing.Size(109, 17);
            this.chkLogging.TabIndex = 2;
            this.chkLogging.Text = "Requires Logging";
            this.chkLogging.UseVisualStyleBackColor = true;
            // 
            // chkAuditing
            // 
            this.chkAuditing.AutoSize = true;
            this.chkAuditing.Location = new System.Drawing.Point(355, 48);
            this.chkAuditing.Name = "chkAuditing";
            this.chkAuditing.Size = new System.Drawing.Size(109, 17);
            this.chkAuditing.TabIndex = 3;
            this.chkAuditing.Text = "Requires Auditing";
            this.chkAuditing.UseVisualStyleBackColor = true;
            // 
            // chkHistory
            // 
            this.chkHistory.AutoSize = true;
            this.chkHistory.Location = new System.Drawing.Point(492, 48);
            this.chkHistory.Name = "chkHistory";
            this.chkHistory.Size = new System.Drawing.Size(103, 17);
            this.chkHistory.TabIndex = 4;
            this.chkHistory.Text = "Requires History";
            this.chkHistory.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(635, 10);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(276, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "On new entity",
            "On change of entity",
            "On delete of entity",
            "On list all object (performance degrade)",
            "On selection of object (performance degrade)"});
            this.checkedListBox1.Location = new System.Drawing.Point(93, 71);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(250, 94);
            this.checkedListBox1.TabIndex = 6;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "On new entity",
            "On change of entity",
            "On delete of entity"});
            this.checkedListBox2.Location = new System.Drawing.Point(492, 71);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox2.TabIndex = 7;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "On new entity",
            "On change of entity",
            "On delete of entity"});
            this.checkedListBox3.Location = new System.Drawing.Point(355, 71);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Attribtes";
            // 
            // grdAttributes
            // 
            this.grdAttributes.AllowUserToOrderColumns = true;
            this.grdAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttributeName,
            this.DataType,
            this.Length,
            this.Audit,
            this.PrimaryKey,
            this.RelationEntity,
            this.IsCalculated,
            this.Security,
            this.Triggers,
            this.Workflow,
            this.Validation});
            this.grdAttributes.Location = new System.Drawing.Point(25, 204);
            this.grdAttributes.Name = "grdAttributes";
            this.grdAttributes.Size = new System.Drawing.Size(1301, 254);
            this.grdAttributes.TabIndex = 10;
            // 
            // AttributeName
            // 
            this.AttributeName.HeaderText = "Attribute Name";
            this.AttributeName.Name = "AttributeName";
            this.AttributeName.Width = 350;
            // 
            // DataType
            // 
            this.DataType.HeaderText = "Data Type";
            this.DataType.Items.AddRange(new object[] {
            "Text",
            "Number",
            "Decimal",
            "Currency",
            "Date",
            "DateTime",
            "Binar Data",
            "XML"});
            this.DataType.Name = "DataType";
            this.DataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            // 
            // Audit
            // 
            this.Audit.HeaderText = "Audit Required";
            this.Audit.Name = "Audit";
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.HeaderText = "Primary Key";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrimaryKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RelationEntity
            // 
            this.RelationEntity.HeaderText = "Relation";
            this.RelationEntity.Name = "RelationEntity";
            this.RelationEntity.Text = "Relation";
            this.RelationEntity.Width = 80;
            // 
            // IsCalculated
            // 
            this.IsCalculated.HeaderText = "Is Calculated";
            this.IsCalculated.Name = "IsCalculated";
            this.IsCalculated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsCalculated.Width = 80;
            // 
            // Security
            // 
            this.Security.HeaderText = "Security";
            this.Security.Name = "Security";
            this.Security.Text = "Security";
            this.Security.Width = 80;
            // 
            // Triggers
            // 
            this.Triggers.HeaderText = "Triggers";
            this.Triggers.Name = "Triggers";
            this.Triggers.Text = "Triggers";
            this.Triggers.Width = 80;
            // 
            // Workflow
            // 
            this.Workflow.HeaderText = "Workflows";
            this.Workflow.Name = "Workflow";
            this.Workflow.Text = "Workflows";
            this.Workflow.Width = 80;
            // 
            // Validation
            // 
            this.Validation.HeaderText = "Validation Rules";
            this.Validation.Name = "Validation";
            this.Validation.Text = "Validation Rules";
            this.Validation.Width = 80;
            // 
            // FrmBusinessEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 608);
            this.Controls.Add(this.grdAttributes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkHistory);
            this.Controls.Add(this.chkAuditing);
            this.Controls.Add(this.chkLogging);
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.label1);
            this.Name = "FrmBusinessEntity";
            this.Text = "Business Entity";
            ((System.ComponentModel.ISupportInitialize)(this.grdAttributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.CheckBox chkLogging;
        private System.Windows.Forms.CheckBox chkAuditing;
        private System.Windows.Forms.CheckBox chkHistory;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttributeName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Audit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrimaryKey;
        private System.Windows.Forms.DataGridViewButtonColumn RelationEntity;
        private System.Windows.Forms.DataGridViewButtonColumn IsCalculated;
        private System.Windows.Forms.DataGridViewButtonColumn Security;
        private System.Windows.Forms.DataGridViewButtonColumn Triggers;
        private System.Windows.Forms.DataGridViewButtonColumn Workflow;
        private System.Windows.Forms.DataGridViewButtonColumn Validation;

    }
}

