using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Budget_Buddy
{
    class DbConnectService
    {
        public OleDbConnection DbConnection()
        {
            string connect = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BudgetBuddyTables.accdb;
                             Persist Security Info=False;";
            OleDbConnection con = new OleDbConnection(connect);

            try
            {                             
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return con;
            }
        }      

        public DataTable retrieveDbData(string sqlStr)
        {
            OleDbConnection con1 = DbConnection();
            DataTable tables = new DataTable();

            try
            {
                OleDbCommand cmd = new OleDbCommand(sqlStr, con1);
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);                
                da.Fill(tables);
                return tables;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return tables;
            }
            finally
            {
                con1.Close();
            }                         
        }


    }
}
