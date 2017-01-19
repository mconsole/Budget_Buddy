using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Buddy
{
    public partial class ItemsManagement : Form
    {
        public string mgmtType = "";

        public ItemsManagement()
        {
            InitializeComponent();
        }

        public void refreshTable()
        {
            DataTable dt = new DataTable();
            DbConnectService dbcs = new DbConnectService();

            dt = dbcs.retrieveDbData("SELECT * FROM budget_items WHERE item_category = '" + mgmtType + "';");
            MgmtDataGrid.DataSource = dt;
            MgmtDataGrid.Columns["ID"].Visible = false;
            MgmtDataGrid.Columns["budget_table"].Visible = false;

        }

        private void IncMgmtAdd_Click(object sender, EventArgs e)
        {
            if (mgmtType == "Income")
            {
                IncomeAdd ia = new IncomeAdd();
                ia.Show();
            }
            else if (mgmtType == "Expense")
            {
                ExpenseAdd ea = new ExpenseAdd();
                ea.Show();
            }
            else if (mgmtType == "Savings")
            {
                SavingsAdd sa = new SavingsAdd();
                sa.Show();
            }
            
        }

        private void IncMgmtEdit_Click(object sender, EventArgs e)
        {
            if (mgmtType == "Income")
            {
                IncomeAdd ia = new IncomeAdd();
                ia.Text = "Edit Income Item";
                ia.IncAddLabel.Text = "Edit Income Item:";
                ia.newIncName.Text = MgmtDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                ia.newIncType.SelectedItem = MgmtDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                ia.newIncAmt.Text = MgmtDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                ia.newIncAmtUnit.SelectedItem = MgmtDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                ia.Tag = MgmtDataGrid.SelectedRows[0].Cells[0].Value;
                ia.Show();
            }
            else if (mgmtType == "Expense")
            {
                ExpenseAdd ea = new ExpenseAdd();
                ea.Text = "Edit Expense Item";
                ea.expAddLabel.Text = "Edit Expense Item:";
                ea.newExpName.Text = MgmtDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                ea.newExpType.SelectedItem = MgmtDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                ea.newExpAmt.Text = MgmtDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                ea.newExpUnit.SelectedItem = MgmtDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                ea.Tag = MgmtDataGrid.SelectedRows[0].Cells[0].Value;
                ea.newExpInt.Text = MgmtDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                ea.Show();
            }
            else if (mgmtType == "Savings")
            {
                SavingsAdd sa = new SavingsAdd();
                sa.Text = "Edit Income Item";
                sa.newSavLabel.Text = "Edit Income Item:";
                sa.newSavName.Text = MgmtDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                sa.newSavType.SelectedItem = MgmtDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                sa.newSavAmt.Text = MgmtDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                sa.newSavUnit.SelectedItem = MgmtDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                sa.Tag = MgmtDataGrid.SelectedRows[0].Cells[0].Value;
                sa.Show();
            }            
        }

        private void IncomeMgmt_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void IncMgmtRef_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void IncMgmtDelete_Click(object sender, EventArgs e)
        {
            if (MgmtDataGrid.SelectedRows != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    DbConnectService dbcs = new DbConnectService();
                    dbcs.deleteRow("DELETE * FROM budget_items WHERE ID = " + MgmtDataGrid.SelectedRows[0].Cells[0].Value + ";");
                    refreshTable();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete");
            }
        }
    }
}
