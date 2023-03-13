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
        public OleDbConnection con = new OleDbConnection();
        
        public Member()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=loantrackerdb.accdb";
            //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\VJA\01 - Solutions\LoanTracker97\LoanTracker97\LoanTracker97\loantrackerdb.accdb";
            InitializeComponent();
        }
        
        private void Member_Load(object sender, EventArgs e)
        {
            LoadBorrower();
        }
        private void LoadBorrower()
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Borrower";

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                borrowerDataGridView.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR! " + ex.Message);
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(investmentTextBox.Text) <= 5000)
                {
                    MessageBox.Show("Capital Requirements minimum is less-than 5,000.00");
                    return;
                }
                else if (double.Parse(investmentTextBox.Text) >= 50000)
                {
                    MessageBox.Show("Capital Requirements is more than 50,000.00!");
                    return;
                }

                con.Open();
                string sql = "insert into Borrower(BorrowerID,BorrowerName,Department,Investment,IfMember) values ('" + borrowerIDTextBox.Text + "' , '" + borrowerNameTextBox.Text + "', '" + departmentTextBox.Text + "', '" + investmentTextBox.Text + "', " + ifMemberCheckBox.Checked + ")";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Inserted");
                con.Close();

                LoadBorrower();
                ClearTextboxex();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR! " + ex.Message);
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(investmentTextBox.Text) <= 5000)
                {
                    MessageBox.Show("Capital Requirements minimum is less-than 5,000.00");
                    return;
                }
                else if (double.Parse(investmentTextBox.Text) >= 50000)
                {
                    MessageBox.Show("Capital Requirements is more than 50,000.00!");
                    return;
                }

                con.Open();
                string sql = "update Borrower set BorrowerName='" + borrowerNameTextBox.Text + "',Department='" + departmentTextBox.Text + "',Investment='" + investmentTextBox.Text + "',IfMember=" + ifMemberCheckBox.Checked + " where BorrowerID='" + borrowerIDTextBox.Text + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                con.Close();

                LoadBorrower();
                ClearTextboxex();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextboxex();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "delete from Borrower where BorrowerID='" + borrowerIDTextBox.Text + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                con.Close();

                LoadBorrower();
                ClearTextboxex();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR! " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            con.Dispose();
            Forms.MainPage MainPage = new Forms.MainPage();
            MainPage.ShowDialog();
        }
    }
}
