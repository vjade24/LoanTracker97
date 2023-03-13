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

namespace LoanTracker97
{
    public partial class Member : Form
    {
        CommonClass cmn = new CommonClass();
        public Member()
        {
            InitializeComponent();
        }
        
        private void Member_Load(object sender, EventArgs e)
        {
            LoadBorrower();
        }
        private void LoadBorrower()
        {
            btnSave.Enabled   = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            string query = "Select * from Borrower";
            DataTable dt = cmn.RetrieveData(query);
            borrowerDataGridView.DataSource = dt;
        }
        
        private void borrowerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            borrowerIDTextBox.Text      = borrowerDataGridView.CurrentRow.Cells[0].Value.ToString();
            borrowerNameTextBox.Text    = borrowerDataGridView.CurrentRow.Cells[1].Value.ToString();
            departmentTextBox.Text      = borrowerDataGridView.CurrentRow.Cells[2].Value.ToString();
            investmentTextBox.Text      = borrowerDataGridView.CurrentRow.Cells[3].Value.ToString();
            ifMemberCheckBox.Checked    = Boolean.Parse(borrowerDataGridView.CurrentRow.Cells[4].Value.ToString());

            btnSave.Enabled   = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void ClearTextboxex()
        {
            borrowerIDTextBox.Text      = "";
            borrowerNameTextBox.Text    = "";
            departmentTextBox.Text      = "";
            investmentTextBox.Text      = "";
            ifMemberCheckBox.Checked    = false;

            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextboxex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.MainPage MainPage = new Forms.MainPage();
            MainPage.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(investmentTextBox.Text) < 5000)
                {
                    MessageBox.Show("Capital Requirements minimum is less-than 5,000.00");
                    return;
                }
                else if (double.Parse(investmentTextBox.Text) >= 50000)
                {
                    MessageBox.Show("Capital Requirements is more than 50,000.00!");
                    return;
                }

                // *********************************************************
                // *** CreateUpdateDelete 2nd Parameter is the following ;**
                // **** 1.) Insert - Insert Data from Database
                // **** 2.) Update - Update Data from Database
                // **** 3.) Delete - Delete Data from Database
                // *********************************************************
                string query = "insert into Borrower(BorrowerID,BorrowerName,Department,Investment,IfMember) values ('" + borrowerIDTextBox.Text + "' , '" + borrowerNameTextBox.Text + "', '" + departmentTextBox.Text + "', '" + investmentTextBox.Text + "', " + ifMemberCheckBox.Checked + ")";
                string message = cmn.CreateUpdateDelete(query, "Insert");
                MessageBox.Show(message);
                // *********************************************************
                // *********************************************************

                LoadBorrower();
                ClearTextboxex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex.Message);
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(investmentTextBox.Text) < 5000)
                {
                    MessageBox.Show("Capital Requirements minimum is less-than 5,000.00");
                    return;
                }
                else if (double.Parse(investmentTextBox.Text) >= 50000)
                {
                    MessageBox.Show("Capital Requirements is more than 50,000.00!");
                    return;
                }

                // *********************************************************
                // *** CreateUpdateDelete 2nd Parameter is the following ;**
                // **** 1.) Insert - Insert Data from Database
                // **** 2.) Update - Update Data from Database
                // **** 3.) Delete - Delete Data from Database
                // *********************************************************
                string query = "update Borrower set BorrowerName='" + borrowerNameTextBox.Text + "',Department='" + departmentTextBox.Text + "',Investment='" + investmentTextBox.Text + "',IfMember=" + ifMemberCheckBox.Checked + " where BorrowerID='" + borrowerIDTextBox.Text + "'";
                string message = cmn.CreateUpdateDelete(query, "Update");
                MessageBox.Show(message);
                // *********************************************************
                // *********************************************************

                LoadBorrower();
                ClearTextboxex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // *********************************************************
                // *** CreateUpdateDelete 2nd Parameter is the following ;**
                // **** 1.) Insert - Insert Data from Database
                // **** 2.) Update - Update Data from Database
                // **** 3.) Delete - Delete Data from Database
                // *********************************************************
                string query = "delete from Borrower where BorrowerID='" + borrowerIDTextBox.Text + "'";
                string message = cmn.CreateUpdateDelete(query, "Delete");
                MessageBox.Show(message);
                // *********************************************************
                // *********************************************************

                LoadBorrower();
                ClearTextboxex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
        }

        
    }
}
