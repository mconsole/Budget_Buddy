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
    public partial class ExpenseAdd : Form
    {
        public ExpenseAdd()
        {
            InitializeComponent();
        }

        private void newExpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newExpClear_Click(object sender, EventArgs e)
        {
            newExpName.Text = "";
            newExpType.SelectedIndex = 0;
            newExpAmt.Text = "";
            newExpUnit.SelectedIndex = 0;
            newExpInt.Text = "";
        }

        private void newExpAdd_Click(object sender, EventArgs e)
        {
            DbConnectService dbcs = new DbConnectService();
            dbcs.submitData(Program.tableName, newExpName.Text, newExpType.Text, int.Parse(newExpAmt.Text), newExpUnit.Text, int.Parse(newExpInt.Text), "Expense");
            this.Close();
        }
    }
}
