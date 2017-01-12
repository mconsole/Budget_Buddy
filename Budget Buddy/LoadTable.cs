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

namespace Budget_Buddy
{
    public partial class LoadTable : Form
    {
        public LoadTable()
        {
            InitializeComponent();
        }

        private void selectNew_Click(object sender, EventArgs e)
        {

        }

        private void LoadTable_Load(object sender, EventArgs e)
        {          
            string strSql = "SELECT table_name FROM budget_tables";
            DbConnectService dbcs = new DbConnectService();                
            DataTable dt = dbcs.retrieveDbData(strSql);
            
            foreach (DataRow item in dt.Rows) {
                selectBudgetDrop.Items.Add(item.Field<string>("table_name"));
            }                   
        }
    }
}
