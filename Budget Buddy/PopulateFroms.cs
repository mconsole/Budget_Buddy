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
            string sqlStr = "SELECT SUM(item_amount) FROM budget_items WHERE item_type = '" + itemType + "' AND item_category = '"
                            + category + "' AND budget_table = '" + table + "'";

            DbConnectService dbcs = new DbConnectService();
            DataTable dt = dbcs.retrieveDbData(sqlStr);

            return dt;
        }

        public void fillControls(Form e, string table)
        {
            DataTable sum = new DataTable();
            Home home = new Home();
            IncomeAdd ia = new IncomeAdd();

            sum = getValues("Salary", "Income", table);
            home.avgSalary.Text = sum.Rows[0][0].ToString();

            //FIX THIS SHIT
            //foreach (string item in ia.newIncType.Items)
            //{
            //    sum = getValues(item, "Income", table);

            //    if (sum.Rows.Count > 0)
            //    {
            //        foreach (Control con in home.Controls)
            //        {
            //            if (con.Tag.ToString() == item && con.Tag != null)
            //            {
            //                con.Text = sum.Rows[0][0].ToString();
            //            }                        
            //        }
            //    }
            //}

            e.Owner = home;
            e.Hide();
            home.Show();
        }
    }
}
