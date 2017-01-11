using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Budget_Buddy;

namespace Budget_Buddy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                var username = usernameBox.Text;
                var password = passwordBox.Text;

                Home home = new Home();
                home.Show();
                this.Owner = home;
                this.Hide();
            }            
            else
            {
                MessageBox.Show("Please enter a valid username and password!");
            }
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            this.Hide();
            this.Owner = newUser;
            newUser.Show();
        }
    }
}
