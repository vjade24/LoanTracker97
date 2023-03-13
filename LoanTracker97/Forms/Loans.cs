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
        CommonClass cmd = new CommonClass();
        public Loans()
        {
            InitializeComponent();
        }
        private void Loans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loantrackerdbDataSet.LoanDetails' table. You can move, or remove it, as needed.
            this.loanDetailsTableAdapter.Fill(this.loantrackerdbDataSet.LoanDetails);

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "select * from Borrower where BorrowerID = '" + borrowerIDTextBox.Text + "'";
                DataTable dt = cmd.RetrieveData(query);
                if (dt.Rows.Count > 0)
                {
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
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ifMemberCheckBox.Checked == false && double.Parse(loanAmountTextBox.Text) > 10000)
            {
                MessageBox.Show("Loanable Amount for non-member shall be up to Php 10,000.00 only !");
                return;
            }


        }

        private void loanDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loanDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loantrackerdbDataSet);

        }
    }
}
