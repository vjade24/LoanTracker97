namespace LoanTracker97.Forms
{
    partial class Loans
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
            this.borrowerIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.borrowerNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.investmentTextBox = new System.Windows.Forms.TextBox();
            this.ifMemberCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            borrowerIDLabel = new System.Windows.Forms.Label();
            borrowerNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            investmentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // borrowerIDLabel
            // 
            borrowerIDLabel.AutoSize = true;
            borrowerIDLabel.Location = new System.Drawing.Point(13, 15);
            borrowerIDLabel.Name = "borrowerIDLabel";
            borrowerIDLabel.Size = new System.Drawing.Size(90, 13);
            borrowerIDLabel.TabIndex = 3;
            borrowerIDLabel.Text = "Enter Member ID:";
            // 
            // borrowerNameLabel
            // 
            borrowerNameLabel.AutoSize = true;
            borrowerNameLabel.Location = new System.Drawing.Point(20, 105);
            borrowerNameLabel.Name = "borrowerNameLabel";
            borrowerNameLabel.Size = new System.Drawing.Size(83, 13);
            borrowerNameLabel.TabIndex = 11;
            borrowerNameLabel.Text = "Borrower Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(20, 131);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 13;
            departmentLabel.Text = "Department:";
            // 
            // investmentLabel
            // 
            investmentLabel.AutoSize = true;
            investmentLabel.Location = new System.Drawing.Point(20, 157);
            investmentLabel.Name = "investmentLabel";
            investmentLabel.Size = new System.Drawing.Size(62, 13);
            investmentLabel.TabIndex = 15;
            investmentLabel.Text = "Investment:";
            // 
            // borrowerIDTextBox
            // 
            this.borrowerIDTextBox.Location = new System.Drawing.Point(109, 12);
            this.borrowerIDTextBox.Name = "borrowerIDTextBox";
            this.borrowerIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.borrowerIDTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borrowerNameTextBox
            // 
            this.borrowerNameTextBox.Location = new System.Drawing.Point(109, 102);
            this.borrowerNameTextBox.Name = "borrowerNameTextBox";
            this.borrowerNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.borrowerNameTextBox.TabIndex = 12;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(109, 128);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(104, 20);
            this.departmentTextBox.TabIndex = 14;
            // 
            // investmentTextBox
            // 
            this.investmentTextBox.Location = new System.Drawing.Point(109, 154);
            this.investmentTextBox.Name = "investmentTextBox";
            this.investmentTextBox.Size = new System.Drawing.Size(104, 20);
            this.investmentTextBox.TabIndex = 16;
            this.investmentTextBox.Text = "0.00";
            this.investmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ifMemberCheckBox
            // 
            this.ifMemberCheckBox.Location = new System.Drawing.Point(109, 180);
            this.ifMemberCheckBox.Name = "ifMemberCheckBox";
            this.ifMemberCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ifMemberCheckBox.TabIndex = 17;
            this.ifMemberCheckBox.Text = "Member";
            this.ifMemberCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(borrowerNameLabel);
            this.Controls.Add(this.borrowerNameTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(investmentLabel);
            this.Controls.Add(this.investmentTextBox);
            this.Controls.Add(this.ifMemberCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(borrowerIDLabel);
            this.Controls.Add(this.borrowerIDTextBox);
            this.Name = "Loans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox borrowerIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox borrowerNameTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox investmentTextBox;
        private System.Windows.Forms.CheckBox ifMemberCheckBox;
        private System.Windows.Forms.Button button2;
    }
}