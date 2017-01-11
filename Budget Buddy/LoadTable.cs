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
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=U:\My Documents\BudgetBuddy.accdb;
            Persist Security Info=False;";
            
            try
            {
                connect.Open();
                MessageBox.Show("Connection is now open");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }            
        }
    }
}
