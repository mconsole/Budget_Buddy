namespace Budget_Buddy
{
    partial class LoadTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadTable));
            this.selectSubmit = new System.Windows.Forms.Button();
            this.selectNew = new System.Windows.Forms.Button();
            this.selectBudgetDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectSubmit
            // 
            this.selectSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSubmit.Location = new System.Drawing.Point(44, 141);
            this.selectSubmit.Name = "selectSubmit";
            this.selectSubmit.Size = new System.Drawing.Size(90, 25);
            this.selectSubmit.TabIndex = 1;
            this.selectSubmit.Text = "Ok";
            this.selectSubmit.UseVisualStyleBackColor = true;
            // 
            // selectNew
            // 
            this.selectNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNew.Location = new System.Drawing.Point(242, 141);
            this.selectNew.Name = "selectNew";
            this.selectNew.Size = new System.Drawing.Size(90, 25);
            this.selectNew.TabIndex = 2;
            this.selectNew.Text = "New +";
            this.selectNew.UseVisualStyleBackColor = true;
            this.selectNew.Click += new System.EventHandler(this.selectNew_Click);
            // 
            // selectBudgetDrop
            // 
            this.selectBudgetDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBudgetDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBudgetDrop.FormattingEnabled = true;
            this.selectBudgetDrop.Location = new System.Drawing.Point(80, 83);
            this.selectBudgetDrop.Name = "selectBudgetDrop";
            this.selectBudgetDrop.Size = new System.Drawing.Size(217, 28);
            this.selectBudgetDrop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select A Budget:";
            // 
            // LoadTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectBudgetDrop);
            this.Controls.Add(this.selectNew);
            this.Controls.Add(this.selectSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoadTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Budget";
            this.Load += new System.EventHandler(this.LoadTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectSubmit;
        private System.Windows.Forms.Button selectNew;
        private System.Windows.Forms.ComboBox selectBudgetDrop;
        private System.Windows.Forms.Label label1;
    }
}