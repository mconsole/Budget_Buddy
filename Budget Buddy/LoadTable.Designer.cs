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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectSubmit = new System.Windows.Forms.Button();
            this.selectNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // selectSubmit
            // 
            this.selectSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSubmit.Location = new System.Drawing.Point(13, 256);
            this.selectSubmit.Name = "selectSubmit";
            this.selectSubmit.Size = new System.Drawing.Size(90, 25);
            this.selectSubmit.TabIndex = 1;
            this.selectSubmit.Text = "Ok";
            this.selectSubmit.UseVisualStyleBackColor = true;
            // 
            // selectNew
            // 
            this.selectNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNew.Location = new System.Drawing.Point(326, 256);
            this.selectNew.Name = "selectNew";
            this.selectNew.Size = new System.Drawing.Size(90, 25);
            this.selectNew.TabIndex = 2;
            this.selectNew.Text = "New +";
            this.selectNew.UseVisualStyleBackColor = true;
            this.selectNew.Click += new System.EventHandler(this.selectNew_Click);
            // 
            // LoadTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 291);
            this.Controls.Add(this.selectNew);
            this.Controls.Add(this.selectSubmit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoadTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Budget";
            this.Load += new System.EventHandler(this.LoadTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selectSubmit;
        private System.Windows.Forms.Button selectNew;
    }
}