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
    public partial class Home : Form
    {
        Control activePanel;

        public Home()
        {
            InitializeComponent();
        }

        public void changePanels(Control panelName)
        {
            activePanel.Visible = false;
            activePanel = panelName;
            activePanel.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            this.Owner = login;
            login.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mitchell Console 2017 \n Version 1.0.0");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeAdd incomeAdd = new IncomeAdd();
            incomeAdd.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpenseAdd expenseAdd = new ExpenseAdd();
            expenseAdd.Show();
        }
    }
}
