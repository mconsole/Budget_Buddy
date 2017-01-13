namespace Budget_Buddy
{
    partial class NewTable
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
            this.newTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newTableSubmit = new System.Windows.Forms.Button();
            this.newTableCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTableName
            // 
            this.newTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTableName.Location = new System.Drawing.Point(32, 62);
            this.newTableName.Name = "newTableName";
            this.newTableName.Size = new System.Drawing.Size(246, 26);
            this.newTableName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter table name:";
            // 
            // newTableSubmit
            // 
            this.newTableSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTableSubmit.Location = new System.Drawing.Point(32, 108);
            this.newTableSubmit.Name = "newTableSubmit";
            this.newTableSubmit.Size = new System.Drawing.Size(83, 26);
            this.newTableSubmit.TabIndex = 2;
            this.newTableSubmit.Text = "Ok";
            this.newTableSubmit.UseVisualStyleBackColor = true;
            this.newTableSubmit.Click += new System.EventHandler(this.newTableSubmit_Click);
            // 
            // newTableCancel
            // 
            this.newTableCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTableCancel.Location = new System.Drawing.Point(195, 108);
            this.newTableCancel.Name = "newTableCancel";
            this.newTableCancel.Size = new System.Drawing.Size(83, 26);
            this.newTableCancel.TabIndex = 3;
            this.newTableCancel.Text = "Cancel";
            this.newTableCancel.UseVisualStyleBackColor = true;
            this.newTableCancel.Click += new System.EventHandler(this.newTableCancel_Click);
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 164);
            this.Controls.Add(this.newTableCancel);
            this.Controls.Add(this.newTableSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newTableName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newTableSubmit;
        private System.Windows.Forms.Button newTableCancel;
    }
}