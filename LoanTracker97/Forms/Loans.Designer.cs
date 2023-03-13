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
            System.Windows.Forms.Label loanIDLabel;
            System.Windows.Forms.Label loanDateLabel;
            System.Windows.Forms.Label loanAmountLabel;
            System.Windows.Forms.Label interestLabel;
            System.Windows.Forms.Label totalAmountLabel;
            System.Windows.Forms.Label amountPerPaymentLabel;
            System.Windows.Forms.Label noOfPaymentsLabel;
            this.borrowerIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.borrowerNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.investmentTextBox = new System.Windows.Forms.TextBox();
            this.ifMemberCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loanIDTextBox = new System.Windows.Forms.TextBox();
            this.loanDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.amountPerPaymentTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.noOfPaymentsComboBox = new System.Windows.Forms.ComboBox();
            borrowerIDLabel = new System.Windows.Forms.Label();
            borrowerNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            investmentLabel = new System.Windows.Forms.Label();
            loanIDLabel = new System.Windows.Forms.Label();
            loanDateLabel = new System.Windows.Forms.Label();
            loanAmountLabel = new System.Windows.Forms.Label();
            interestLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            amountPerPaymentLabel = new System.Windows.Forms.Label();
            noOfPaymentsLabel = new System.Windows.Forms.Label();
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
            borrowerNameLabel.Location = new System.Drawing.Point(20, 57);
            borrowerNameLabel.Name = "borrowerNameLabel";
            borrowerNameLabel.Size = new System.Drawing.Size(83, 13);
            borrowerNameLabel.TabIndex = 11;
            borrowerNameLabel.Text = "Borrower Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(228, 60);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 13;
            departmentLabel.Text = "Department:";
            // 
            // investmentLabel
            // 
            investmentLabel.AutoSize = true;
            investmentLabel.Location = new System.Drawing.Point(433, 63);
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
            this.borrowerNameTextBox.BackColor = System.Drawing.Color.White;
            this.borrowerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerNameTextBox.Enabled = false;
            this.borrowerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerNameTextBox.Location = new System.Drawing.Point(23, 73);
            this.borrowerNameTextBox.Name = "borrowerNameTextBox";
            this.borrowerNameTextBox.Size = new System.Drawing.Size(180, 19);
            this.borrowerNameTextBox.TabIndex = 12;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BackColor = System.Drawing.Color.White;
            this.departmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmentTextBox.Enabled = false;
            this.departmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTextBox.Location = new System.Drawing.Point(231, 76);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(180, 19);
            this.departmentTextBox.TabIndex = 14;
            // 
            // investmentTextBox
            // 
            this.investmentTextBox.BackColor = System.Drawing.Color.White;
            this.investmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.investmentTextBox.Enabled = false;
            this.investmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentTextBox.Location = new System.Drawing.Point(436, 76);
            this.investmentTextBox.Name = "investmentTextBox";
            this.investmentTextBox.Size = new System.Drawing.Size(180, 19);
            this.investmentTextBox.TabIndex = 16;
            this.investmentTextBox.Text = "0.00";
            this.investmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ifMemberCheckBox
            // 
            this.ifMemberCheckBox.Location = new System.Drawing.Point(632, 75);
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
            // loanIDLabel
            // 
            loanIDLabel.AutoSize = true;
            loanIDLabel.Location = new System.Drawing.Point(224, 146);
            loanIDLabel.Name = "loanIDLabel";
            loanIDLabel.Size = new System.Drawing.Size(48, 13);
            loanIDLabel.TabIndex = 18;
            loanIDLabel.Text = "Loan ID:";
            // 
            // loanIDTextBox
            // 
            this.loanIDTextBox.Location = new System.Drawing.Point(278, 143);
            this.loanIDTextBox.Name = "loanIDTextBox";
            this.loanIDTextBox.Size = new System.Drawing.Size(238, 20);
            this.loanIDTextBox.TabIndex = 19;
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Location = new System.Drawing.Point(212, 173);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new System.Drawing.Size(60, 13);
            loanDateLabel.TabIndex = 22;
            loanDateLabel.Text = "Loan Date:";
            // 
            // loanDateDateTimePicker
            // 
            this.loanDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.loanDateDateTimePicker.Location = new System.Drawing.Point(278, 169);
            this.loanDateDateTimePicker.Name = "loanDateDateTimePicker";
            this.loanDateDateTimePicker.Size = new System.Drawing.Size(238, 20);
            this.loanDateDateTimePicker.TabIndex = 23;
            // 
            // loanAmountLabel
            // 
            loanAmountLabel.AutoSize = true;
            loanAmountLabel.Location = new System.Drawing.Point(199, 198);
            loanAmountLabel.Name = "loanAmountLabel";
            loanAmountLabel.Size = new System.Drawing.Size(73, 13);
            loanAmountLabel.TabIndex = 25;
            loanAmountLabel.Text = "Loan Amount:";
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(278, 195);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(238, 20);
            this.loanAmountTextBox.TabIndex = 26;
            this.loanAmountTextBox.Text = "0.00";
            this.loanAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.Location = new System.Drawing.Point(227, 250);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(45, 13);
            interestLabel.TabIndex = 29;
            interestLabel.Text = "Interest:";
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(278, 247);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(238, 20);
            this.interestTextBox.TabIndex = 30;
            this.interestTextBox.Text = "0.00";
            this.interestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(199, 276);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(73, 13);
            totalAmountLabel.TabIndex = 31;
            totalAmountLabel.Text = "Total Amount:";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(278, 273);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(238, 20);
            this.totalAmountTextBox.TabIndex = 32;
            this.totalAmountTextBox.Text = "0.00";
            this.totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountPerPaymentLabel
            // 
            amountPerPaymentLabel.AutoSize = true;
            amountPerPaymentLabel.Location = new System.Drawing.Point(163, 302);
            amountPerPaymentLabel.Name = "amountPerPaymentLabel";
            amountPerPaymentLabel.Size = new System.Drawing.Size(109, 13);
            amountPerPaymentLabel.TabIndex = 33;
            amountPerPaymentLabel.Text = "Amount Per Payment:";
            // 
            // amountPerPaymentTextBox
            // 
            this.amountPerPaymentTextBox.Location = new System.Drawing.Point(278, 299);
            this.amountPerPaymentTextBox.Name = "amountPerPaymentTextBox";
            this.amountPerPaymentTextBox.Size = new System.Drawing.Size(238, 20);
            this.amountPerPaymentTextBox.TabIndex = 34;
            this.amountPerPaymentTextBox.Text = "0.00";
            this.amountPerPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(359, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(359, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(278, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(278, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // noOfPaymentsLabel
            // 
            noOfPaymentsLabel.AutoSize = true;
            noOfPaymentsLabel.Location = new System.Drawing.Point(185, 224);
            noOfPaymentsLabel.Name = "noOfPaymentsLabel";
            noOfPaymentsLabel.Size = new System.Drawing.Size(87, 13);
            noOfPaymentsLabel.TabIndex = 39;
            noOfPaymentsLabel.Text = "No Of Payments:";
            // 
            // noOfPaymentsComboBox
            // 
            this.noOfPaymentsComboBox.FormattingEnabled = true;
            this.noOfPaymentsComboBox.Items.AddRange(new object[] {
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.noOfPaymentsComboBox.Location = new System.Drawing.Point(278, 221);
            this.noOfPaymentsComboBox.Name = "noOfPaymentsComboBox";
            this.noOfPaymentsComboBox.Size = new System.Drawing.Size(121, 21);
            this.noOfPaymentsComboBox.TabIndex = 40;
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(noOfPaymentsLabel);
            this.Controls.Add(this.noOfPaymentsComboBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(loanAmountLabel);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(interestLabel);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(totalAmountLabel);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(amountPerPaymentLabel);
            this.Controls.Add(this.amountPerPaymentTextBox);
            this.Controls.Add(loanIDLabel);
            this.Controls.Add(this.loanIDTextBox);
            this.Controls.Add(loanDateLabel);
            this.Controls.Add(this.loanDateDateTimePicker);
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
        private System.Windows.Forms.TextBox loanIDTextBox;
        private System.Windows.Forms.DateTimePicker loanDateDateTimePicker;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox amountPerPaymentTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox noOfPaymentsComboBox;
    }
}