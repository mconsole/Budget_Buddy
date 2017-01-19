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

        public void submitData(string table, string itemName, string itemType, int itemAmount, string itemUnit, int itemInterest, string itemCategory)
        {
            OleDbConnection con1 = DbConnection();

            try
            {
                string sqlStr = "INSERT INTO budget_items (budget_table, item_name, item_type, item_amount, item_unit, item_interest, item_category) VALUES ('" + table + "', " + "'" + itemName + "', " + "'" + itemType + "', " + "'" + itemAmount.ToString() + "', " + "'" + itemUnit + "', " + "'" + itemInterest.ToString() + "', " + "'" + itemCategory + "');";                
                OleDbCommand cmd = new OleDbCommand(sqlStr, con1);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }

        }

        public void submitData(string tableNm)
        {
            OleDbConnection con1 = DbConnection();

            try
            {
                string sqlStr = "INSERT INTO budget_tables (table_name) VALUES ('" + tableNm + "');";
                OleDbCommand cmd = new OleDbCommand(sqlStr, con1);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
        }

        public void deleteTable(string tableNm)
        {
            OleDbConnection con1 = DbConnection();

            try
            {                
                string sqlStr = "DELETE * FROM budget_tables WHERE table_name = '" + tableNm + "';";
                string sqlStr1 = "DELETE * FROM budget_items WHERE budget_table = '" + tableNm + "';";
                OleDbCommand cmd = new OleDbCommand(sqlStr, con1);
                OleDbCommand cmd1 = new OleDbCommand(sqlStr1, con1);
                cmd.CommandType = CommandType.Text;
                cmd1.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
            
        }

        public void updateTable(int id, string budgetTable, string itemName, string itemType, int itemAmount, string itemUnit, int interest, string itemCategory)
        {
            OleDbConnection con1 = DbConnection();

            try
            {
                string sqlStr = "UPDATE budget_items SET budget_table = '" + budgetTable + "', item_name = '" + itemName + "', item_type = '" + itemType + "', item_amount = " + itemAmount + ", item_unit = '" + itemUnit + "', item_interest = " + interest + ", item_category = '" + itemCategory + "' WHERE ID = " + id + ";";
                OleDbCommand cmd = new OleDbCommand(sqlStr, con1);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }
        }

        public void deleteRow(string sqlStr)
        {
            OleDbConnection con1 = DbConnection();

            try
            {                
                OleDbCommand cmd = new OleDbCommand(sqlStr, con1);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();
            }            
        }

    }
}
