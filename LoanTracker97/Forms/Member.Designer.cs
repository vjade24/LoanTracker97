namespace LoanTracker97
{
    partial class Member
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
            System.Windows.Forms.Label borrowerIDLabel;
            System.Windows.Forms.Label borrowerNameLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label investmentLabel;
            System.Windows.Forms.Label label1;
            this.borrowerIDTextBox = new System.Windows.Forms.TextBox();
            this.borrowerNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.investmentTextBox = new System.Windows.Forms.TextBox();
            this.ifMemberCheckBox = new System.Windows.Forms.CheckBox();
            this.borrowerDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            borrowerIDLabel = new System.Windows.Forms.Label();
            borrowerNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            investmentLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowerIDLabel
            // 
            borrowerIDLabel.AutoSize = true;
            borrowerIDLabel.Location = new System.Drawing.Point(36, 130);
            borrowerIDLabel.Name = "borrowerIDLabel";
            borrowerIDLabel.Size = new System.Drawing.Size(66, 13);
            borrowerIDLabel.TabIndex = 1;
            borrowerIDLabel.Text = "Borrower ID:";
            // 
            // borrowerNameLabel
            // 
            borrowerNameLabel.AutoSize = true;
            borrowerNameLabel.Location = new System.Drawing.Point(19, 156);
            borrowerNameLabel.Name = "borrowerNameLabel";
            borrowerNameLabel.Size = new System.Drawing.Size(83, 13);
            borrowerNameLabel.TabIndex = 3;
            borrowerNameLabel.Text = "Borrower Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(37, 182);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 5;
            departmentLabel.Text = "Department:";
            // 
            // investmentLabel
            // 
            investmentLabel.AutoSize = true;
            investmentLabel.Location = new System.Drawing.Point(40, 208);
            investmentLabel.Name = "investmentLabel";
            investmentLabel.Size = new System.Drawing.Size(62, 13);
            investmentLabel.TabIndex = 7;
            investmentLabel.Text = "Investment:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(54, 236);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 17;
            label1.Text = "Member:";
            // 
            // borrowerIDTextBox
            // 
            this.borrowerIDTextBox.Location = new System.Drawing.Point(108, 127);
            this.borrowerIDTextBox.Name = "borrowerIDTextBox";
            this.borrowerIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.borrowerIDTextBox.TabIndex = 2;
            // 
            // borrowerNameTextBox
            // 
            this.borrowerNameTextBox.Location = new System.Drawing.Point(108, 153);
            this.borrowerNameTextBox.Name = "borrowerNameTextBox";
            this.borrowerNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.borrowerNameTextBox.TabIndex = 4;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(108, 179);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(104, 20);
            this.departmentTextBox.TabIndex = 6;
            // 
            // investmentTextBox
            // 
            this.investmentTextBox.Location = new System.Drawing.Point(108, 205);
            this.investmentTextBox.Name = "investmentTextBox";
            this.investmentTextBox.Size = new System.Drawing.Size(104, 20);
            this.investmentTextBox.TabIndex = 8;
            this.investmentTextBox.Text = "0.00";
            this.investmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ifMemberCheckBox
            // 
            this.ifMemberCheckBox.Location = new System.Drawing.Point(108, 231);
            this.ifMemberCheckBox.Name = "ifMemberCheckBox";
            this.ifMemberCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ifMemberCheckBox.TabIndex = 10;
            this.ifMemberCheckBox.UseVisualStyleBackColor = true;
            // 
            // borrowerDataGridView
            // 
            this.borrowerDataGridView.AllowUserToAddRows = false;
            this.borrowerDataGridView.AllowUserToDeleteRows = false;
            this.borrowerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowerDataGridView.Location = new System.Drawing.Point(230, 127);
            this.borrowerDataGridView.Name = "borrowerDataGridView";
            this.borrowerDataGridView.ReadOnly = true;
            this.borrowerDataGridView.Size = new System.Drawing.Size(548, 220);
            this.borrowerDataGridView.TabIndex = 11;
            this.borrowerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowerDataGridView_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(56, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(137, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.borrowerDataGridView);
            this.Controls.Add(borrowerIDLabel);
            this.Controls.Add(this.borrowerIDTextBox);
            this.Controls.Add(borrowerNameLabel);
            this.Controls.Add(this.borrowerNameTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(investmentLabel);
            this.Controls.Add(this.investmentTextBox);
            this.Controls.Add(this.ifMemberCheckBox);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox borrowerIDTextBox;
        private System.Windows.Forms.TextBox borrowerNameTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox investmentTextBox;
        private System.Windows.Forms.CheckBox ifMemberCheckBox;
        private System.Windows.Forms.DataGridView borrowerDataGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}