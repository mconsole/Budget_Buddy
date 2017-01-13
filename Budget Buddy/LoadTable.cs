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
        public void popTableList()
        {
            selectBudgetDrop.Items.Clear();

            string strSql = "SELECT table_name FROM budget_tables";
            DbConnectService dbcs = new DbConnectService();
            DataTable dt = dbcs.retrieveDbData(strSql);

            foreach (DataRow item in dt.Rows)
            {
                selectBudgetDrop.Items.Add(item.Field<string>("table_name"));
            }
        }

        public LoadTable()
        {
            InitializeComponent();
        }

        private void selectNew_Click(object sender, EventArgs e)
        {
            NewTable nt = new NewTable();
            nt.Show();
            this.Owner = nt;
            this.Hide();
        }

        private void LoadTable_Load(object sender, EventArgs e)
        {
            popTableList();                  
        }

        private void selectSubmit_Click(object sender, EventArgs e)
        {
            string table = selectBudgetDrop.Text;            

            if (table == "")
            {
                MessageBox.Show("Please select a budget");
            }
            else
            {
                Program.tableName = table;
                PopulateFroms pf = new PopulateFroms();
                pf.fillControls(this, table);
            }
        }

        private void loadTableDel_Click(object sender, EventArgs e)
        {
            if (selectBudgetDrop.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this budget?", "Delete Budget", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    string budgetNm = selectBudgetDrop.Text;

                    DbConnectService dbcs = new DbConnectService();
                    dbcs.deleteTable(budgetNm);

                    popTableList();
                }
            }
            else
            {
                MessageBox.Show("Please select a budget to delete");
            }            
        }
    }
}
