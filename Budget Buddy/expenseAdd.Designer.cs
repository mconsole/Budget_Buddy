namespace Budget_Buddy
{
    partial class ExpenseAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseAdd));
            this.label4 = new System.Windows.Forms.Label();
            this.newExpType = new System.Windows.Forms.ComboBox();
            this.newExpCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newExpName = new System.Windows.Forms.TextBox();
            this.newExpClear = new System.Windows.Forms.Button();
            this.newExpAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newExpUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newExpAmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newExpInt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Type:";
            // 
            // newExpType
            // 
            this.newExpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newExpType.FormattingEnabled = true;
            this.newExpType.Items.AddRange(new object[] {
            "",
            "Housing",
            "Utilities",
            "Groceries",
            "Transportation",
            "Eating Out",
            "Personal",
            "Entertainment",
            "Debt Payments",
            "Savings",
            "Child"});
            this.newExpType.Location = new System.Drawing.Point(84, 139);
            this.newExpType.Name = "newExpType";
            this.newExpType.Size = new System.Drawing.Size(187, 21);
            this.newExpType.TabIndex = 16;
            // 
            // newExpCancel
            // 
            this.newExpCancel.Location = new System.Drawing.Point(180, 356);
            this.newExpCancel.Name = "newExpCancel";
            this.newExpCancel.Size = new System.Drawing.Size(91, 23);
            this.newExpCancel.TabIndex = 15;
            this.newExpCancel.Text = "Cancel";
            this.newExpCancel.UseVisualStyleBackColor = true;
            this.newExpCancel.Click += new System.EventHandler(this.newExpCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Expense Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // newExpName
            // 
            this.newExpName.Location = new System.Drawing.Point(84, 103);
            this.newExpName.Name = "newExpName";
            this.newExpName.Size = new System.Drawing.Size(187, 20);
            this.newExpName.TabIndex = 12;
            // 
            // newExpClear
            // 
            this.newExpClear.Location = new System.Drawing.Point(70, 316);
            this.newExpClear.Name = "newExpClear";
            this.newExpClear.Size = new System.Drawing.Size(201, 23);
            this.newExpClear.TabIndex = 11;
            this.newExpClear.Text = "Clear";
            this.newExpClear.UseVisualStyleBackColor = true;
            this.newExpClear.Click += new System.EventHandler(this.newExpClear_Click);
            // 
            // newExpAdd
            // 
            this.newExpAdd.Location = new System.Drawing.Point(70, 356);
            this.newExpAdd.Name = "newExpAdd";
            this.newExpAdd.Size = new System.Drawing.Size(91, 23);
            this.newExpAdd.TabIndex = 10;
            this.newExpAdd.Text = "Add";
            this.newExpAdd.UseVisualStyleBackColor = true;
            this.newExpAdd.Click += new System.EventHandler(this.newExpAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Units:";
            // 
            // newExpUnit
            // 
            this.newExpUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newExpUnit.FormattingEnabled = true;
            this.newExpUnit.Items.AddRange(new object[] {
            "",
            "per year",
            "per month"});
            this.newExpUnit.Location = new System.Drawing.Point(84, 216);
            this.newExpUnit.Name = "newExpUnit";
            this.newExpUnit.Size = new System.Drawing.Size(187, 21);
            this.newExpUnit.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Amount:";
            // 
            // newExpAmt
            // 
            this.newExpAmt.Location = new System.Drawing.Point(84, 178);
            this.newExpAmt.Name = "newExpAmt";
            this.newExpAmt.Size = new System.Drawing.Size(187, 20);
            this.newExpAmt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Interest:";
            // 
            // newExpInt
            // 
            this.newExpInt.Location = new System.Drawing.Point(84, 257);
            this.newExpInt.Name = "newExpInt";
            this.newExpInt.Size = new System.Drawing.Size(187, 20);
            this.newExpInt.TabIndex = 22;
            // 
            // ExpenseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 408);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newExpInt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newExpAmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newExpUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newExpType);
            this.Controls.Add(this.newExpCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newExpName);
            this.Controls.Add(this.newExpClear);
            this.Controls.Add(this.newExpAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpenseAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expense Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newExpCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newExpClear;
        private System.Windows.Forms.Button newExpAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox newExpType;
        public System.Windows.Forms.TextBox newExpName;
        public System.Windows.Forms.ComboBox newExpUnit;
        public System.Windows.Forms.TextBox newExpAmt;
        public System.Windows.Forms.TextBox newExpInt;
    }
}