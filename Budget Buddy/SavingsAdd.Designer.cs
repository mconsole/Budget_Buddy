namespace Budget_Buddy
{
    partial class SavingsAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAdd));
            this.label5 = new System.Windows.Forms.Label();
            this.newSavUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newSavAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newSavType = new System.Windows.Forms.ComboBox();
            this.newSavCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newSavName = new System.Windows.Forms.TextBox();
            this.newSavClear = new System.Windows.Forms.Button();
            this.newSavAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Units:";
            // 
            // newSavUnit
            // 
            this.newSavUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newSavUnit.FormattingEnabled = true;
            this.newSavUnit.Items.AddRange(new object[] {
            "",
            "per year",
            "per month"});
            this.newSavUnit.Location = new System.Drawing.Point(90, 216);
            this.newSavUnit.Name = "newSavUnit";
            this.newSavUnit.Size = new System.Drawing.Size(187, 21);
            this.newSavUnit.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Amount:";
            // 
            // newSavAmt
            // 
            this.newSavAmt.Location = new System.Drawing.Point(90, 178);
            this.newSavAmt.Name = "newSavAmt";
            this.newSavAmt.Size = new System.Drawing.Size(187, 20);
            this.newSavAmt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Type:";
            // 
            // newSavType
            // 
            this.newSavType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newSavType.FormattingEnabled = true;
            this.newSavType.Items.AddRange(new object[] {
            "",
            "Retirement",
            "Emergency Fund",
            "Other"});
            this.newSavType.Location = new System.Drawing.Point(90, 138);
            this.newSavType.Name = "newSavType";
            this.newSavType.Size = new System.Drawing.Size(187, 21);
            this.newSavType.TabIndex = 20;
            // 
            // newSavCancel
            // 
            this.newSavCancel.Location = new System.Drawing.Point(186, 312);
            this.newSavCancel.Name = "newSavCancel";
            this.newSavCancel.Size = new System.Drawing.Size(91, 23);
            this.newSavCancel.TabIndex = 19;
            this.newSavCancel.Text = "Cancel";
            this.newSavCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "New Savings Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name:";
            // 
            // newSavName
            // 
            this.newSavName.Location = new System.Drawing.Point(90, 102);
            this.newSavName.Name = "newSavName";
            this.newSavName.Size = new System.Drawing.Size(187, 20);
            this.newSavName.TabIndex = 16;
            // 
            // newSavClear
            // 
            this.newSavClear.Location = new System.Drawing.Point(76, 272);
            this.newSavClear.Name = "newSavClear";
            this.newSavClear.Size = new System.Drawing.Size(201, 23);
            this.newSavClear.TabIndex = 15;
            this.newSavClear.Text = "Clear";
            this.newSavClear.UseVisualStyleBackColor = true;
            // 
            // newSavAdd
            // 
            this.newSavAdd.Location = new System.Drawing.Point(76, 312);
            this.newSavAdd.Name = "newSavAdd";
            this.newSavAdd.Size = new System.Drawing.Size(91, 23);
            this.newSavAdd.TabIndex = 14;
            this.newSavAdd.Text = "Add";
            this.newSavAdd.UseVisualStyleBackColor = true;
            this.newSavAdd.Click += new System.EventHandler(this.newSavAdd_Click);
            // 
            // SavingsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 375);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newSavUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newSavAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newSavType);
            this.Controls.Add(this.newSavCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newSavName);
            this.Controls.Add(this.newSavClear);
            this.Controls.Add(this.newSavAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavingsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Savings Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox newSavUnit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox newSavAmt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox newSavType;
        public System.Windows.Forms.Button newSavCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox newSavName;
        public System.Windows.Forms.Button newSavClear;
        public System.Windows.Forms.Button newSavAdd;
    }
}