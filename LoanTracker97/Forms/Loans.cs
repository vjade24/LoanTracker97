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
        public OleDbConnection con = new OleDbConnection();

        public Loans()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=loantrackerdb.accdb";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Borrower where BorrowerID = '"+ borrowerIDTextBox .Text+ "'";

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    borrowerNameTextBox.Text = dt.Rows[0]["BorrowerName"].ToString();
                    departmentTextBox.Text   = dt.Rows[0]["Department"].ToString();
                    investmentTextBox.Text   = dt.Rows[0]["Investment"].ToString();
                    ifMemberCheckBox.Checked = Boolean.Parse(dt.Rows[0]["IfMember"].ToString());
                }
                else
                {
                    MessageBox.Show("No Member Found!");
                }


                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("ERROR! " + ex.Message);
            }
        }

        private void Loans_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            con.Dispose();
            Forms.MainPage MainPage = new Forms.MainPage();
            MainPage.ShowDialog();
        }
    }
}
