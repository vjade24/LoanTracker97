﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace LoanTracker97
{
    class CommonClass
    {

        OleDbConnection con      = new OleDbConnection();
        string connection_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\VJA\01 - Solutions\LoanTracker97\LoanTracker97\LoanTracker97\loantrackerdb.accdb";
        //string connection_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=loantrackerdb.accdb";

        public DataTable RetrieveData(String query)
        {
            try
            {
                con.ConnectionString = connection_string;
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public string CreateUpdateDelete(string query, string action)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                int ret_value = cmd.ExecuteNonQuery();
                if(ret_value != 0)
                {
                    con.Close();
                    if (action == "Insert")
                    {
                        return "Record Successfully Added!!";
                    }
                    else if (action == "Update")
                    {
                        return "Record Successfully Updated!";
                    }
                    else
                    {
                        return "Record Successfully Deleted";
                    }
                }
                else
                {
                    con.Close();
                    return "X-No data Inserted";
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return "X-" + ex;
            }
        }

        //private string GetLastRow(string tablename,string field_name)
        //{
        //    try
        //    {
        //        con.ConnectionString = connection_string;
        //        con.Open();
        //        OleDbCommand cmd = new OleDbCommand();
        //        cmd.Connection = con;
        //        cmd.CommandText = "SELECT TOP 1" + field_name + " FROM " + tablename + " ORDER BY " + field_name + " DESC";

        //        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        con.Close();
        //        return dt[0]['"+ +"'];
        //    }
        //    catch (Exception ex)
        //    {
        //        con.Close();
        //        return null;
        //    }
        //}


    }
}
