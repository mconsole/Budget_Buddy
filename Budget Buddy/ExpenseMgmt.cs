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
    public partial class IncomeMgmt : Form
    {
        public IncomeMgmt()
        {
            InitializeComponent();
        }

        private void IncMgmtAdd_Click(object sender, EventArgs e)
        {
            IncomeAdd ia = new IncomeAdd();
            ia.Show();
        }

        private void IncMgmtEdit_Click(object sender, EventArgs e)
        {
            IncomeAdd ia = new IncomeAdd();
            ia.Text = "Edit Income Item";
            ia.IncAddLabel.Text = "Edit Income Item:";
            ia.newIncName.Text = IncMgmtDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            ia.newIncType.SelectedItem = IncMgmtDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            ia.newIncAmt.Text = IncMgmtDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            ia.newIncAmtUnit.SelectedItem = IncMgmtDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            ia.Tag = IncMgmtDataGrid.SelectedRows[0].Cells[0].Value;
            ia.Show();
        }

        private void IncomeMgmt_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DbConnectService dbcs = new DbConnectService();

            dt = dbcs.retrieveDbData("SELECT * FROM budget_items WHERE item_category = 'Income';");
            IncMgmtDataGrid.DataSource = dt;
        }

        private void IncMgmtRef_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DbConnectService dbcs = new DbConnectService();

            dt = dbcs.retrieveDbData("SELECT * FROM budget_items WHERE item_category = 'Income';");
            IncMgmtDataGrid.DataSource = dt;
        }
    }
}
