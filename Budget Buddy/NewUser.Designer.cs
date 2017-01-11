namespace Budget_Buddy
{
    partial class NewUser
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
            this.userLogin = new System.Windows.Forms.Label();
            this.newUserName = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.newUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserRePass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newUserSubmit = new System.Windows.Forms.Button();
            this.newUserCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLogin
            // 
            this.userLogin.AutoSize = true;
            this.userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogin.Location = new System.Drawing.Point(103, 25);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(108, 26);
            this.userLogin.TabIndex = 3;
            this.userLogin.Text = "New User";
            // 
            // newUserName
            // 
            this.newUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserName.Location = new System.Drawing.Point(12, 104);
            this.newUserName.Name = "newUserName";
            this.newUserName.Size = new System.Drawing.Size(293, 26);
            this.newUserName.TabIndex = 5;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(8, 81);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 20);
            this.username.TabIndex = 4;
            this.username.Text = "Username:";
            // 
            // newUserPassword
            // 
            this.newUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserPassword.Location = new System.Drawing.Point(12, 173);
            this.newUserPassword.Name = "newUserPassword";
            this.newUserPassword.Size = new System.Drawing.Size(293, 26);
            this.newUserPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // newUserRePass
            // 
            this.newUserRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserRePass.Location = new System.Drawing.Point(12, 247);
            this.newUserRePass.Name = "newUserRePass";
            this.newUserRePass.Size = new System.Drawing.Size(293, 26);
            this.newUserRePass.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Re-Type Password:";
            // 
            // newUserSubmit
            // 
            this.newUserSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserSubmit.Location = new System.Drawing.Point(42, 311);
            this.newUserSubmit.Name = "newUserSubmit";
            this.newUserSubmit.Size = new System.Drawing.Size(108, 23);
            this.newUserSubmit.TabIndex = 10;
            this.newUserSubmit.Text = "Submit";
            this.newUserSubmit.UseVisualStyleBackColor = true;
            // 
            // newUserCancel
            // 
            this.newUserCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserCancel.Location = new System.Drawing.Point(167, 311);
            this.newUserCancel.Name = "newUserCancel";
            this.newUserCancel.Size = new System.Drawing.Size(108, 23);
            this.newUserCancel.TabIndex = 11;
            this.newUserCancel.Text = "Cancel";
            this.newUserCancel.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 352);
            this.Controls.Add(this.newUserCancel);
            this.Controls.Add(this.newUserSubmit);
            this.Controls.Add(this.newUserRePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newUserPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserName);
            this.Controls.Add(this.username);
            this.Controls.Add(this.userLogin);
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLogin;
        private System.Windows.Forms.TextBox newUserName;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox newUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUserRePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newUserSubmit;
        private System.Windows.Forms.Button newUserCancel;
    }
}