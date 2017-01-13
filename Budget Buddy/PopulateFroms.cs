using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Budget_Buddy
{
    class PopulateFroms
    {
        public DataTable getValues(string itemType, string category, string table)
        {
            string sqlStr = "SELECT SUM(item_amount) AS item_amount FROM budget_items WHERE item_type = '" + itemType + "' AND item_category = '"
                            + category + "' AND budget_table = '" + table + "'";

            DbConnectService dbcs = new DbConnectService();
            return dbcs.retrieveDbData(sqlStr);
        }

        public void fillControls(Form e, string table)
        {
            DataTable sum = new DataTable();
            Home home = new Home();
            IncomeAdd ia = new IncomeAdd();

            foreach (string item in ia.newIncType.Items)
            {
                string[] amountTypes = new string[3] { "Income", "Expense", "Savings" };

                foreach (string type in amountTypes)
                {
                    sum = getValues(item, type, table);

                    if (sum.Rows.Count > 0)
                    {
                        foreach (Control con in home.homeTabs.TabPages)
                        {
                            foreach (Control con1 in con.Controls)
                            {
                                if (sum.Rows[0][0] != null && sum.Rows[0][0].ToString() != "")
                                {
                                    try
                                    {
                                        if (con1.Tag != null)
                                        {
                                            if (con1.Tag.ToString() == item)
                                            {
                                                con1.Text = sum.Rows[0][0].ToString();
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }

                        }
                    }
                }                
            }

            e.Owner = home;
            e.Hide();
            home.Show();
        }

        public void refreshControls(Home home)
        {
            DataTable sum = new DataTable();
            IncomeAdd ia = new IncomeAdd();

            foreach (string item in ia.newIncType.Items)
            {
                string[] amountTypes = new string[3] { "Income", "Expense", "Savings" };

                foreach (string type in amountTypes)
                {
                    sum = getValues(item, type, Program.tableName);

                    if (sum.Rows.Count > 0)
                    {
                        foreach (Control con in home.homeTabs.TabPages)
                        {
                            foreach (Control con1 in con.Controls)
                            {
                                if (sum.Rows[0][0] != null && sum.Rows[0][0].ToString() != "")
                                {
                                    try
                                    {
                                        if (con1.Tag != null)
                                        {
                                            if (con1.Tag.ToString() == item)
                                            {
                                                con1.Text = sum.Rows[0][0].ToString();
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        public void fillControls(Home home, string type)
        {
            if (type == "Income")
            {
                refreshControls(home);
            }
            else if (type == "Expense")
            {

            }
            else if (type == "Savings")
            {

            }
            
        }
    }
}
