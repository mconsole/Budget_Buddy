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
    public partial class NewTable : Form
    {
        public NewTable()
        {
            InitializeComponent();
        }

        private void newTableSubmit_Click(object sender, EventArgs e)
        {
            string tableNm = newTableName.Text;

            DbConnectService dbcs = new DbConnectService();
            dbcs.submitData(tableNm);

            LoadTable lt = new LoadTable();
            lt.Show();
            this.Owner = lt;
            this.Hide();
        }

        private void newTableCancel_Click(object sender, EventArgs e)
        {
            LoadTable lt = new LoadTable();
            lt.Show();
            this.Owner = lt;
            this.Hide();
        }
    }
}
