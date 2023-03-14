using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoanTracker97.Forms
{
    public partial class Loans : Form
    {
        CommonClass cmn = new CommonClass();
        public Loans()
        {
            InitializeComponent();
        }
        private void Loans_Load(object sender, EventArgs e)
        {
            noOfPaymentsComboBox.Text = "1";
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Borrower where BorrowerID = '" + borrowerIDTextBox.Text + "'";
                DataTable dt = cmn.RetrieveData(query);
                if (dt.Rows.Count > 0)
                {
                    LoadPaymentSchedule(borrowerIDTextBox.Text);
                    borrowerNameTextBox.Text = dt.Rows[0]["BorrowerName"].ToString();
                    departmentTextBox.Text   = dt.Rows[0]["Department"].ToString();
                    investmentTextBox.Text   = dt.Rows[0]["Investment"].ToString();
                    ifMemberCheckBox.Checked = Boolean.Parse(dt.Rows[0]["IfMember"].ToString());
                }
                else
                {
                     borrowerNameTextBox.Text = "";
                     departmentTextBox.Text   = "";
                     investmentTextBox.Text   = "";
                     ifMemberCheckBox.Checked = false;

                    MessageBox.Show("No Member Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.MainPage MainPage = new Forms.MainPage();
            MainPage.ShowDialog();
        }

        private void CalculateLoan()
        {
            try
            {
                double total_amount             = 0;
                double interest_amt             = 0;
                double amount_per_payment       = 0;

                interest_amt                    = (double.Parse(loanAmountTextBox.Text) * (double.Parse(interestTextBox.Text) / 100));
                total_amount                    = double.Parse(loanAmountTextBox.Text) + interest_amt;
                amount_per_payment              = total_amount / double.Parse(noOfPaymentsComboBox.Text);

                textBoxInterest_amt.Text        = interest_amt.ToString("###,##0.00");
                totalAmountTextBox.Text         = total_amount.ToString("###,##0.00");
                amountPerPaymentTextBox.Text    = amount_per_payment.ToString("###,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }
        
        

        private void noOfPaymentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (noOfPaymentsComboBox.Text)
            {
                case "1":
                    interestTextBox.Text = "2";
                    break;
                case "2":
                    interestTextBox.Text = "4";
                    break;
                case "3":
                    interestTextBox.Text = "5";
                    break;
                case "4":
                    interestTextBox.Text = "7";
                    break;
                case "5":
                    interestTextBox.Text = "9";
                    break;
                case "6":
                    interestTextBox.Text = "10";
                    break;
            }
            CalculateLoan();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string query1   = "insert into Loans(LoanID,MemberID,LoanDate) values ('" + loanIDTextBox.Text + "' , '"+borrowerIDTextBox.Text+ "','" + DateTime.Parse(loanDateDateTimePicker.Text) + "')";
            string message1 = cmn.CreateUpdateDelete(query1, "Insert");

            if (message1.ToString().Split('-')[0].ToString() != "X")
            {
                string query2 = "insert into LoanDetails(LoanID,LoanAmount,NoOfPayments,Interest,TotalAmount,AmountPerPayment) values ('" + loanIDTextBox.Text + "' , '" + double.Parse(loanAmountTextBox.Text) + "','" + int.Parse(noOfPaymentsComboBox.Text) + "','" + int.Parse(interestTextBox.Text) + "','" + double.Parse(totalAmountTextBox.Text) + "','" + double.Parse(amountPerPaymentTextBox.Text) + "')";
                string message2 = cmn.CreateUpdateDelete(query2, "Insert");

                if (message2.ToString().Split('-')[0].ToString() != "X")
                {
                    DateTime payment_date = DateTime.Parse(loanDateDateTimePicker.Text);
                    int counter = int.Parse(noOfPaymentsComboBox.Text);
                    for (int i = 0; i < counter; i++)
                    {
                        // *********************************************************
                        // *** CreateUpdateDelete 2nd Parameter is the following ;**
                        // **** 1.) Insert - Insert Data from Database
                        // **** 2.) Update - Update Data from Database
                        // **** 3.) Delete - Delete Data from Database
                        // *********************************************************
                        string query    = "insert into PaymentSchedule(LoanID,PaymentNumber,PaymentDate) values ('" + loanIDTextBox.Text + "' , '" + (i + 1) + "', '" + payment_date.AddMonths(i+1) + "')";
                        string message  = cmn.CreateUpdateDelete(query, "Insert");
                        // *********************************************************
                        // *********************************************************
                        if (i == (counter -1))
                        {
                            MessageBox.Show(message);
                            LoadPaymentSchedule(borrowerIDTextBox.Text);
                        }
                    }
                }
            }
        }

        private void LoadPaymentSchedule(string borrower_id)
        {
            string query = "SELECT PaymentSchedule.PaymentNumber, PaymentSchedule.PaymentDate,LoanDetails.AmountPerPayment  FROM((Borrower INNER JOIN Loans ON Borrower.BorrowerID = Loans.MemberID) LEFT JOIN LoanDetails ON Loans.LoanID = LoanDetails.LoanID) INNER JOIN PaymentSchedule ON Loans.LoanID = PaymentSchedule.LoanID where Borrower.BorrowerID = '" + borrower_id + "'";
            DataTable dt = cmn.RetrieveData(query);
            vw_Borrower_Loans_LoanDetailsDataGridView.DataSource = dt;
        }

        private void loanAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateLoan();
        }
    }
}
