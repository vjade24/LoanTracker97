﻿namespace LoanTracker97.Forms
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
            this.components = new System.ComponentModel.Container();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loans));
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.noOfPaymentsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loantrackerdbDataSet = new LoanTracker97.loantrackerdbDataSet();
            this.loanDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanDetailsTableAdapter = new LoanTracker97.loantrackerdbDataSetTableAdapters.LoanDetailsTableAdapter();
            this.tableAdapterManager = new LoanTracker97.loantrackerdbDataSetTableAdapters.TableAdapterManager();
            this.loanDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.loanDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loantrackerdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsBindingNavigator)).BeginInit();
            this.loanDetailsBindingNavigator.SuspendLayout();
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
            // loanIDLabel
            // 
            loanIDLabel.AutoSize = true;
            loanIDLabel.Location = new System.Drawing.Point(48, 27);
            loanIDLabel.Name = "loanIDLabel";
            loanIDLabel.Size = new System.Drawing.Size(48, 13);
            loanIDLabel.TabIndex = 18;
            loanIDLabel.Text = "Loan ID:";
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Location = new System.Drawing.Point(36, 54);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new System.Drawing.Size(60, 13);
            loanDateLabel.TabIndex = 22;
            loanDateLabel.Text = "Loan Date:";
            // 
            // loanAmountLabel
            // 
            loanAmountLabel.AutoSize = true;
            loanAmountLabel.Location = new System.Drawing.Point(23, 79);
            loanAmountLabel.Name = "loanAmountLabel";
            loanAmountLabel.Size = new System.Drawing.Size(73, 13);
            loanAmountLabel.TabIndex = 25;
            loanAmountLabel.Text = "Loan Amount:";
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.Location = new System.Drawing.Point(51, 131);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(45, 13);
            interestLabel.TabIndex = 29;
            interestLabel.Text = "Interest:";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(23, 157);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(73, 13);
            totalAmountLabel.TabIndex = 31;
            totalAmountLabel.Text = "Total Amount:";
            // 
            // amountPerPaymentLabel
            // 
            amountPerPaymentLabel.AutoSize = true;
            amountPerPaymentLabel.Location = new System.Drawing.Point(-13, 183);
            amountPerPaymentLabel.Name = "amountPerPaymentLabel";
            amountPerPaymentLabel.Size = new System.Drawing.Size(109, 13);
            amountPerPaymentLabel.TabIndex = 33;
            amountPerPaymentLabel.Text = "Amount Per Payment:";
            // 
            // noOfPaymentsLabel
            // 
            noOfPaymentsLabel.AutoSize = true;
            noOfPaymentsLabel.Location = new System.Drawing.Point(9, 105);
            noOfPaymentsLabel.Name = "noOfPaymentsLabel";
            noOfPaymentsLabel.Size = new System.Drawing.Size(87, 13);
            noOfPaymentsLabel.TabIndex = 39;
            noOfPaymentsLabel.Text = "No Of Payments:";
            // 
            // borrowerIDTextBox
            // 
            this.borrowerIDTextBox.Location = new System.Drawing.Point(109, 12);
            this.borrowerIDTextBox.Name = "borrowerIDTextBox";
            this.borrowerIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.borrowerIDTextBox.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(219, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.ifMemberCheckBox.Enabled = false;
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
            // loanIDTextBox
            // 
            this.loanIDTextBox.Location = new System.Drawing.Point(102, 24);
            this.loanIDTextBox.Name = "loanIDTextBox";
            this.loanIDTextBox.Size = new System.Drawing.Size(238, 20);
            this.loanIDTextBox.TabIndex = 19;
            // 
            // loanDateDateTimePicker
            // 
            this.loanDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.loanDateDateTimePicker.Location = new System.Drawing.Point(102, 50);
            this.loanDateDateTimePicker.Name = "loanDateDateTimePicker";
            this.loanDateDateTimePicker.Size = new System.Drawing.Size(238, 20);
            this.loanDateDateTimePicker.TabIndex = 23;
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(102, 76);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(238, 20);
            this.loanAmountTextBox.TabIndex = 26;
            this.loanAmountTextBox.Text = "0.00";
            this.loanAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(102, 128);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(238, 20);
            this.interestTextBox.TabIndex = 30;
            this.interestTextBox.Text = "0.00";
            this.interestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(102, 154);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(238, 20);
            this.totalAmountTextBox.TabIndex = 32;
            this.totalAmountTextBox.Text = "0.00";
            this.totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountPerPaymentTextBox
            // 
            this.amountPerPaymentTextBox.Location = new System.Drawing.Point(102, 180);
            this.amountPerPaymentTextBox.Name = "amountPerPaymentTextBox";
            this.amountPerPaymentTextBox.Size = new System.Drawing.Size(238, 20);
            this.amountPerPaymentTextBox.TabIndex = 34;
            this.amountPerPaymentTextBox.Text = "0.00";
            this.amountPerPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(102, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.noOfPaymentsComboBox.Location = new System.Drawing.Point(102, 102);
            this.noOfPaymentsComboBox.Name = "noOfPaymentsComboBox";
            this.noOfPaymentsComboBox.Size = new System.Drawing.Size(121, 21);
            this.noOfPaymentsComboBox.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(loanIDLabel);
            this.groupBox1.Controls.Add(noOfPaymentsLabel);
            this.groupBox1.Controls.Add(this.loanDateDateTimePicker);
            this.groupBox1.Controls.Add(this.noOfPaymentsComboBox);
            this.groupBox1.Controls.Add(loanDateLabel);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.loanIDTextBox);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.amountPerPaymentTextBox);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(amountPerPaymentLabel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.totalAmountTextBox);
            this.groupBox1.Controls.Add(loanAmountLabel);
            this.groupBox1.Controls.Add(totalAmountLabel);
            this.groupBox1.Controls.Add(this.loanAmountTextBox);
            this.groupBox1.Controls.Add(this.interestTextBox);
            this.groupBox1.Controls.Add(interestLabel);
            this.groupBox1.Location = new System.Drawing.Point(23, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 297);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avail Loan";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(403, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 297);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // loantrackerdbDataSet
            // 
            this.loantrackerdbDataSet.DataSetName = "loantrackerdbDataSet";
            this.loantrackerdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanDetailsBindingSource
            // 
            this.loanDetailsBindingSource.DataMember = "LoanDetails";
            this.loanDetailsBindingSource.DataSource = this.loantrackerdbDataSet;
            // 
            // loanDetailsTableAdapter
            // 
            this.loanDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.LoanDetailsTableAdapter = this.loanDetailsTableAdapter;
            this.tableAdapterManager.LoansTableAdapter = null;
            this.tableAdapterManager.PaymentScheduleTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoanTracker97.loantrackerdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loanDetailsBindingNavigator
            // 
            this.loanDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loanDetailsBindingNavigator.BindingSource = this.loanDetailsBindingSource;
            this.loanDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loanDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loanDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.loanDetailsBindingNavigatorSaveItem});
            this.loanDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loanDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loanDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loanDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loanDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loanDetailsBindingNavigator.Name = "loanDetailsBindingNavigator";
            this.loanDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loanDetailsBindingNavigator.Size = new System.Drawing.Size(1058, 25);
            this.loanDetailsBindingNavigator.TabIndex = 43;
            this.loanDetailsBindingNavigator.Text = "bindingNavigator1";
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
            // loanDetailsBindingNavigatorSaveItem
            // 
            this.loanDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loanDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loanDetailsBindingNavigatorSaveItem.Image")));
            this.loanDetailsBindingNavigatorSaveItem.Name = "loanDetailsBindingNavigatorSaveItem";
            this.loanDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.loanDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.loanDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.loanDetailsBindingNavigatorSaveItem_Click);
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 468);
            this.Controls.Add(this.loanDetailsBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(borrowerNameLabel);
            this.Controls.Add(this.borrowerNameTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(investmentLabel);
            this.Controls.Add(this.investmentTextBox);
            this.Controls.Add(this.ifMemberCheckBox);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(borrowerIDLabel);
            this.Controls.Add(this.borrowerIDTextBox);
            this.Name = "Loans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loantrackerdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsBindingNavigator)).EndInit();
            this.loanDetailsBindingNavigator.ResumeLayout(false);
            this.loanDetailsBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox noOfPaymentsComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private loantrackerdbDataSet loantrackerdbDataSet;
        private System.Windows.Forms.BindingSource loanDetailsBindingSource;
        private loantrackerdbDataSetTableAdapters.LoanDetailsTableAdapter loanDetailsTableAdapter;
        private loantrackerdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loanDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton loanDetailsBindingNavigatorSaveItem;
    }
}