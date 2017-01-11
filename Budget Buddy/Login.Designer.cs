namespace Budget_Buddy
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userLogin = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(30, 97);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 20);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(34, 120);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(293, 26);
            this.usernameBox.TabIndex = 1;
            // 
            // userLogin
            // 
            this.userLogin.AutoSize = true;
            this.userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogin.Location = new System.Drawing.Point(127, 33);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(117, 26);
            this.userLogin.TabIndex = 2;
            this.userLogin.Text = "User Login";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(34, 194);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(293, 26);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.WordWrap = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(30, 171);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Password:";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(56, 277);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(103, 23);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(190, 277);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(103, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.Color.Transparent;
            this.newUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUser.FlatAppearance.BorderSize = 0;
            this.newUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.newUser.Location = new System.Drawing.Point(221, 226);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(106, 25);
            this.newUser.TabIndex = 7;
            this.newUser.Text = "New User";
            this.newUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 329);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Buddy Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label userLogin;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button newUser;
    }
}