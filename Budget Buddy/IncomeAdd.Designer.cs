namespace Budget_Buddy
{
    partial class IncomeAdd
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
            this.newIncAdd = new System.Windows.Forms.Button();
            this.newIncClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newIncName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newIncCancel = new System.Windows.Forms.Button();
            this.newIncType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newIncAmt = new System.Windows.Forms.TextBox();
            this.newIncAmtUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newIncAdd
            // 
            this.newIncAdd.Location = new System.Drawing.Point(76, 316);
            this.newIncAdd.Name = "newIncAdd";
            this.newIncAdd.Size = new System.Drawing.Size(91, 23);
            this.newIncAdd.TabIndex = 2;
            this.newIncAdd.Text = "Add";
            this.newIncAdd.UseVisualStyleBackColor = true;
            // 
            // newIncClear
            // 
            this.newIncClear.Location = new System.Drawing.Point(76, 276);
            this.newIncClear.Name = "newIncClear";
            this.newIncClear.Size = new System.Drawing.Size(201, 23);
            this.newIncClear.TabIndex = 3;
            this.newIncClear.Text = "Clear";
            this.newIncClear.UseVisualStyleBackColor = true;
            this.newIncClear.Click += new System.EventHandler(this.newIncClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // newIncName
            // 
            this.newIncName.Location = new System.Drawing.Point(90, 106);
            this.newIncName.Name = "newIncName";
            this.newIncName.Size = new System.Drawing.Size(187, 20);
            this.newIncName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Income Item:";
            // 
            // newIncCancel
            // 
            this.newIncCancel.Location = new System.Drawing.Point(186, 316);
            this.newIncCancel.Name = "newIncCancel";
            this.newIncCancel.Size = new System.Drawing.Size(91, 23);
            this.newIncCancel.TabIndex = 7;
            this.newIncCancel.Text = "Cancel";
            this.newIncCancel.UseVisualStyleBackColor = true;
            this.newIncCancel.Click += new System.EventHandler(this.newIncCancel_Click);
            // 
            // newIncType
            // 
            this.newIncType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newIncType.FormattingEnabled = true;
            this.newIncType.Items.AddRange(new object[] {
            "",
            "Salary",
            "Bonus",
            "Disability",
            "Social Security",
            "Investments",
            "Inheritance",
            "Misc"});
            this.newIncType.Location = new System.Drawing.Point(90, 142);
            this.newIncType.Name = "newIncType";
            this.newIncType.Size = new System.Drawing.Size(187, 21);
            this.newIncType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount:";
            // 
            // newIncAmt
            // 
            this.newIncAmt.Location = new System.Drawing.Point(90, 182);
            this.newIncAmt.Name = "newIncAmt";
            this.newIncAmt.Size = new System.Drawing.Size(187, 20);
            this.newIncAmt.TabIndex = 10;
            // 
            // newIncAmtUnit
            // 
            this.newIncAmtUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newIncAmtUnit.FormattingEnabled = true;
            this.newIncAmtUnit.Items.AddRange(new object[] {
            "",
            "per year",
            "per month"});
            this.newIncAmtUnit.Location = new System.Drawing.Point(90, 220);
            this.newIncAmtUnit.Name = "newIncAmtUnit";
            this.newIncAmtUnit.Size = new System.Drawing.Size(187, 21);
            this.newIncAmtUnit.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Units:";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 375);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newIncAmtUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newIncAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newIncType);
            this.Controls.Add(this.newIncCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newIncName);
            this.Controls.Add(this.newIncClear);
            this.Controls.Add(this.newIncAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Income";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Income Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newIncAdd;
        private System.Windows.Forms.Button newIncClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newIncName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newIncCancel;
        private System.Windows.Forms.ComboBox newIncType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newIncAmt;
        private System.Windows.Forms.ComboBox newIncAmtUnit;
        private System.Windows.Forms.Label label5;
    }
}