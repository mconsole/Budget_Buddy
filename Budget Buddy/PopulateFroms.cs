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
            ExpenseAdd ea = new ExpenseAdd();
            SavingsAdd sa = new SavingsAdd();

            string[][] ja = new string[3][];            
            ja[0] = new string[7] {"Salary", "Bonus", "Disability", "Social Security", "Investments", "Inheritance", "Misc" };
            ja[1] = new string[10] {"Housing", "Utilities", "Groceries", "Transportation", "Eating Out", "Personal", "Entertainment", "Debt Payments", "Savings", "Child" };
            ja[2] = new string[3] { "Retirement", "Emergency Fund", "Other" };

            string[] amountTypes = new string[3] { "Income", "Expense", "Savings" };
            
            for (var i = 0; i < amountTypes.Length; i++)
            {
                foreach (string str in ja[i])
                {
                    sum = getValues(str, amountTypes[i], table);

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
                                            if (con1.Tag.ToString() == str)
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
        
        public void refreshControls(Home home, string tabType)
        {
            DataTable sum = new DataTable();
            IncomeAdd ia = new IncomeAdd();
            ExpenseAdd ea = new ExpenseAdd();
            SavingsAdd sa = new SavingsAdd();

            if (tabType == "Income")
            {
                foreach (string item in ia.newIncType.Items)
                {
                    sum = getValues(item, tabType, Program.tableName);

                    if (sum.Rows.Count > 0)
                    {
                        foreach (Control con in home.incomeTab.Controls)
                        {
                            if (sum.Rows[0][0] != null && sum.Rows[0][0].ToString() != "")
                            {
                                try
                                {
                                    if (con.Tag != null)
                                    {
                                        if (con.Tag.ToString() == item)
                                        {
                                            con.Text = sum.Rows[0][0].ToString();
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
            else if (tabType == "Expense")
            {
                foreach (string item in ea.newExpType.Items)
                {
                    sum = getValues(item, tabType, Program.tableName);

                    if (sum.Rows.Count > 0)
                    {
                        foreach (Control con in home.expenseTab.Controls)
                        { 
                            if (sum.Rows[0][0] != null && sum.Rows[0][0].ToString() != "")
                            {
                                try
                                {
                                    if (con.Tag != null)
                                    {
                                        if (con.Tag.ToString() == item)
                                        {
                                            con.Text = sum.Rows[0][0].ToString();
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
            else if (tabType == "Savings")
            {
                foreach (string item in sa.newSavType.Items)
                {
                    sum = getValues(item, tabType, Program.tableName);

                    if (sum.Rows.Count > 0)
                    {
                        foreach (Control con in home.savingsTab.Controls)
                        {
                            if (sum.Rows[0][0] != null && sum.Rows[0][0].ToString() != "")
                            {
                                try
                                {
                                    if (con.Tag != null)
                                    {
                                        if (con.Tag.ToString() == item)
                                        {
                                            con.Text = sum.Rows[0][0].ToString();
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

        public void fillControls(Home home, string type)
        {
            if (type == "Income")
            {
                refreshControls(home, "Income");
            }
            else if (type == "Expense")
            {
                refreshControls(home, "Expense");
            }
            else if (type == "Savings")
            {
                refreshControls(home, "Savings");
            }
            
        }

        public void calcNetIncome(Home e)
        {
            try
            {
                string sqlstr1 = "SELECT SUM(item_amount) AS item_amount FROM budget_items WHERE item_category LIKE '%Income%'";
                string sqlstr2 = "SELECT SUM(item_amount) AS item_amount FROM budget_items WHERE item_category LIKE '%Expense%'";

                DbConnectService dbcs = new DbConnectService();
                DataTable incVal = dbcs.retrieveDbData(sqlstr1);
                DataTable expVal = dbcs.retrieveDbData(sqlstr2);

                int inc = int.Parse(incVal.Rows[0][0].ToString());
                int exp = int.Parse(expVal.Rows[0][0].ToString());

                e.savNetIncome.Text = (inc - exp).ToString();

                if ((inc - exp) < 0)
                {
                    e.savNetIncome.BackColor = System.Drawing.Color.Red;
                }
                else if ((inc - exp) == 0)
                {
                    e.savNetIncome.BackColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    e.savNetIncome.BackColor = System.Drawing.Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
