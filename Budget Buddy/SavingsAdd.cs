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
    public partial class SavingsAdd : Form
    {
        public SavingsAdd()
        {
            InitializeComponent();
        }

        private void newSavAdd_Click(object sender, EventArgs e)
        {
            DbConnectService dbcs = new DbConnectService();
            dbcs.submitData(Program.tableName, newSavName.Text, newSavType.Text, int.Parse(newSavAmt.Text), newSavUnit.Text, 0, "Savings");
            this.Close();
        }
    }
}
