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
            System.Windows.Forms.Label noOfPaymentsLabel;
            System.Windows.Forms.Label interestLabel;
            System.Windows.Forms.Label totalAmountLabel;
            System.Windows.Forms.Label amountPerPaymentLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.borrowerIDTextBox = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
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
            this.noOfPaymentsComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxInterest_amt = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vw_Borrower_Loans_LoanDetailsDataGridView = new System.Windows.Forms.DataGridView();
            borrowerIDLabel = new System.Windows.Forms.Label();
            borrowerNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            investmentLabel = new System.Windows.Forms.Label();
            loanIDLabel = new System.Windows.Forms.Label();
            loanDateLabel = new System.Windows.Forms.Label();
            loanAmountLabel = new System.Windows.Forms.Label();
            noOfPaymentsLabel = new System.Windows.Forms.Label();
            interestLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            amountPerPaymentLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Borrower_Loans_LoanDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowerIDLabel
            // 
            borrowerIDLabel.AutoSize = true;
            borrowerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            borrowerIDLabel.Location = new System.Drawing.Point(40, 28);
            borrowerIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            borrowerIDLabel.Name = "borrowerIDLabel";
            borrowerIDLabel.Size = new System.Drawing.Size(111, 16);
            borrowerIDLabel.TabIndex = 3;
            borrowerIDLabel.Text = "Enter Member ID:";
            // 
            // borrowerNameLabel
            // 
            borrowerNameLabel.AutoSize = true;
            borrowerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            borrowerNameLabel.Location = new System.Drawing.Point(41, 37);
            borrowerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            borrowerNameLabel.Name = "borrowerNameLabel";
            borrowerNameLabel.Size = new System.Drawing.Size(105, 16);
            borrowerNameLabel.TabIndex = 11;
            borrowerNameLabel.Text = "Borrower Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(412, 37);
            departmentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(81, 16);
            departmentLabel.TabIndex = 13;
            departmentLabel.Text = "Department:";
            // 
            // investmentLabel
            // 
            investmentLabel.AutoSize = true;
            investmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            investmentLabel.Location = new System.Drawing.Point(782, 37);
            investmentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            investmentLabel.Name = "investmentLabel";
            investmentLabel.Size = new System.Drawing.Size(75, 16);
            investmentLabel.TabIndex = 15;
            investmentLabel.Text = "Investment:";
            // 
            // loanIDLabel
            // 
            loanIDLabel.AutoSize = true;
            loanIDLabel.Location = new System.Drawing.Point(34, 43);
            loanIDLabel.Name = "loanIDLabel";
            loanIDLabel.Size = new System.Drawing.Size(87, 24);
            loanIDLabel.TabIndex = 29;
            loanIDLabel.Text = "Loan ID:";
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Location = new System.Drawing.Point(34, 79);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new System.Drawing.Size(110, 24);
            loanDateLabel.TabIndex = 31;
            loanDateLabel.Text = "Loan Date:";
            // 
            // loanAmountLabel
            // 
            loanAmountLabel.AutoSize = true;
            loanAmountLabel.Location = new System.Drawing.Point(34, 113);
            loanAmountLabel.Name = "loanAmountLabel";
            loanAmountLabel.Size = new System.Drawing.Size(140, 24);
            loanAmountLabel.TabIndex = 33;
            loanAmountLabel.Text = "Loan Amount:";
            // 
            // noOfPaymentsLabel
            // 
            noOfPaymentsLabel.AutoSize = true;
            noOfPaymentsLabel.Location = new System.Drawing.Point(34, 148);
            noOfPaymentsLabel.Name = "noOfPaymentsLabel";
            noOfPaymentsLabel.Size = new System.Drawing.Size(166, 24);
            noOfPaymentsLabel.TabIndex = 35;
            noOfPaymentsLabel.Text = "No Of Payments:";
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.Location = new System.Drawing.Point(379, 148);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(84, 24);
            interestLabel.TabIndex = 37;
            interestLabel.Text = "Interest:";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(34, 218);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(140, 24);
            totalAmountLabel.TabIndex = 39;
            totalAmountLabel.Text = "Total Amount:";
            // 
            // amountPerPaymentLabel
            // 
            amountPerPaymentLabel.AutoSize = true;
            amountPerPaymentLabel.Location = new System.Drawing.Point(34, 253);
            amountPerPaymentLabel.Name = "amountPerPaymentLabel";
            amountPerPaymentLabel.Size = new System.Drawing.Size(212, 24);
            amountPerPaymentLabel.TabIndex = 41;
            amountPerPaymentLabel.Text = "Amount Per Payment:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(548, 153);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(26, 24);
            label1.TabIndex = 46;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 183);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 24);
            label2.TabIndex = 47;
            label2.Text = "Interest Amount:";
            // 
            // borrowerIDTextBox
            // 
            this.borrowerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerIDTextBox.Location = new System.Drawing.Point(226, 25);
            this.borrowerIDTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.borrowerIDTextBox.Name = "borrowerIDTextBox";
            this.borrowerIDTextBox.Size = new System.Drawing.Size(178, 29);
            this.borrowerIDTextBox.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(416, 12);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(194, 57);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // borrowerNameTextBox
            // 
            this.borrowerNameTextBox.BackColor = System.Drawing.Color.White;
            this.borrowerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerNameTextBox.Location = new System.Drawing.Point(45, 67);
            this.borrowerNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.borrowerNameTextBox.Name = "borrowerNameTextBox";
            this.borrowerNameTextBox.ReadOnly = true;
            this.borrowerNameTextBox.Size = new System.Drawing.Size(360, 24);
            this.borrowerNameTextBox.TabIndex = 12;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BackColor = System.Drawing.Color.White;
            this.departmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTextBox.Location = new System.Drawing.Point(416, 67);
            this.departmentTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(360, 24);
            this.departmentTextBox.TabIndex = 14;
            // 
            // investmentTextBox
            // 
            this.investmentTextBox.BackColor = System.Drawing.Color.White;
            this.investmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.investmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentTextBox.Location = new System.Drawing.Point(786, 67);
            this.investmentTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.investmentTextBox.Name = "investmentTextBox";
            this.investmentTextBox.ReadOnly = true;
            this.investmentTextBox.Size = new System.Drawing.Size(130, 24);
            this.investmentTextBox.TabIndex = 16;
            this.investmentTextBox.Text = "0.00";
            this.investmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ifMemberCheckBox
            // 
            this.ifMemberCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifMemberCheckBox.Location = new System.Drawing.Point(937, 61);
            this.ifMemberCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.ifMemberCheckBox.Name = "ifMemberCheckBox";
            this.ifMemberCheckBox.Size = new System.Drawing.Size(112, 44);
            this.ifMemberCheckBox.TabIndex = 17;
            this.ifMemberCheckBox.Text = "Member";
            this.ifMemberCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1005, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 18;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loanIDTextBox
            // 
            this.loanIDTextBox.Location = new System.Drawing.Point(252, 40);
            this.loanIDTextBox.Name = "loanIDTextBox";
            this.loanIDTextBox.Size = new System.Drawing.Size(347, 29);
            this.loanIDTextBox.TabIndex = 30;
            // 
            // loanDateDateTimePicker
            // 
            this.loanDateDateTimePicker.Location = new System.Drawing.Point(252, 75);
            this.loanDateDateTimePicker.Name = "loanDateDateTimePicker";
            this.loanDateDateTimePicker.Size = new System.Drawing.Size(347, 29);
            this.loanDateDateTimePicker.TabIndex = 32;
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(252, 110);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(211, 29);
            this.loanAmountTextBox.TabIndex = 34;
            this.loanAmountTextBox.Text = "0.00";
            this.loanAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loanAmountTextBox.TextChanged += new System.EventHandler(this.loanAmountTextBox_TextChanged);
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(469, 148);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.ReadOnly = true;
            this.interestTextBox.Size = new System.Drawing.Size(73, 29);
            this.interestTextBox.TabIndex = 38;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(252, 215);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(211, 29);
            this.totalAmountTextBox.TabIndex = 40;
            this.totalAmountTextBox.Text = "0.00";
            this.totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountPerPaymentTextBox
            // 
            this.amountPerPaymentTextBox.Location = new System.Drawing.Point(252, 250);
            this.amountPerPaymentTextBox.Name = "amountPerPaymentTextBox";
            this.amountPerPaymentTextBox.ReadOnly = true;
            this.amountPerPaymentTextBox.Size = new System.Drawing.Size(211, 29);
            this.amountPerPaymentTextBox.TabIndex = 42;
            this.amountPerPaymentTextBox.Text = "0.00";
            this.amountPerPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // noOfPaymentsComboBox
            // 
            this.noOfPaymentsComboBox.FormattingEnabled = true;
            this.noOfPaymentsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.noOfPaymentsComboBox.Location = new System.Drawing.Point(252, 145);
            this.noOfPaymentsComboBox.Name = "noOfPaymentsComboBox";
            this.noOfPaymentsComboBox.Size = new System.Drawing.Size(121, 32);
            this.noOfPaymentsComboBox.TabIndex = 45;
            this.noOfPaymentsComboBox.SelectedIndexChanged += new System.EventHandler(this.noOfPaymentsComboBox_SelectedIndexChanged);
            // 
            // textBoxInterest_amt
            // 
            this.textBoxInterest_amt.Location = new System.Drawing.Point(252, 183);
            this.textBoxInterest_amt.Name = "textBoxInterest_amt";
            this.textBoxInterest_amt.ReadOnly = true;
            this.textBoxInterest_amt.Size = new System.Drawing.Size(211, 29);
            this.textBoxInterest_amt.TabIndex = 48;
            this.textBoxInterest_amt.Text = "0.00";
            this.textBoxInterest_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 40);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(borrowerNameLabel);
            this.groupBox1.Controls.Add(this.ifMemberCheckBox);
            this.groupBox1.Controls.Add(this.investmentTextBox);
            this.groupBox1.Controls.Add(investmentLabel);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Controls.Add(departmentLabel);
            this.groupBox1.Controls.Add(this.borrowerNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 121);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(loanIDLabel);
            this.groupBox2.Controls.Add(this.amountPerPaymentTextBox);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(amountPerPaymentLabel);
            this.groupBox2.Controls.Add(this.textBoxInterest_amt);
            this.groupBox2.Controls.Add(this.totalAmountTextBox);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(totalAmountLabel);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.interestTextBox);
            this.groupBox2.Controls.Add(this.noOfPaymentsComboBox);
            this.groupBox2.Controls.Add(interestLabel);
            this.groupBox2.Controls.Add(noOfPaymentsLabel);
            this.groupBox2.Controls.Add(this.loanAmountTextBox);
            this.groupBox2.Controls.Add(this.loanIDTextBox);
            this.groupBox2.Controls.Add(loanAmountLabel);
            this.groupBox2.Controls.Add(loanDateLabel);
            this.groupBox2.Controls.Add(this.loanDateDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(31, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 349);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Details";
            // 
            // vw_Borrower_Loans_LoanDetailsDataGridView
            // 
            this.vw_Borrower_Loans_LoanDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_Borrower_Loans_LoanDetailsDataGridView.Location = new System.Drawing.Point(674, 215);
            this.vw_Borrower_Loans_LoanDetailsDataGridView.Name = "vw_Borrower_Loans_LoanDetailsDataGridView";
            this.vw_Borrower_Loans_LoanDetailsDataGridView.Size = new System.Drawing.Size(481, 339);
            this.vw_Borrower_Loans_LoanDetailsDataGridView.TabIndex = 51;
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 582);
            this.Controls.Add(this.vw_Borrower_Loans_LoanDetailsDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(borrowerIDLabel);
            this.Controls.Add(this.borrowerIDTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Loans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_Borrower_Loans_LoanDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox borrowerIDTextBox;
        private System.Windows.Forms.Button btnFind;
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
        private System.Windows.Forms.ComboBox noOfPaymentsComboBox;
        private System.Windows.Forms.TextBox textBoxInterest_amt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView vw_Borrower_Loans_LoanDetailsDataGridView;
    }
}