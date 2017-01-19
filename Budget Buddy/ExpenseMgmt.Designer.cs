namespace Budget_Buddy
{
    partial class IncomeMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeMgmt));
            this.IncMgmtDataGrid = new System.Windows.Forms.DataGridView();
            this.IncMgmtAdd = new System.Windows.Forms.Button();
            this.IncMgmtEdit = new System.Windows.Forms.Button();
            this.IncMgmtDelete = new System.Windows.Forms.Button();
            this.IncMgmtRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IncMgmtDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IncMgmtDataGrid
            // 
            this.IncMgmtDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncMgmtDataGrid.Location = new System.Drawing.Point(12, 12);
            this.IncMgmtDataGrid.MultiSelect = false;
            this.IncMgmtDataGrid.Name = "IncMgmtDataGrid";
            this.IncMgmtDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IncMgmtDataGrid.Size = new System.Drawing.Size(936, 388);
            this.IncMgmtDataGrid.TabIndex = 0;
            // 
            // IncMgmtAdd
            // 
            this.IncMgmtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncMgmtAdd.Location = new System.Drawing.Point(13, 411);
            this.IncMgmtAdd.Name = "IncMgmtAdd";
            this.IncMgmtAdd.Size = new System.Drawing.Size(99, 27);
            this.IncMgmtAdd.TabIndex = 1;
            this.IncMgmtAdd.Text = "Add";
            this.IncMgmtAdd.UseVisualStyleBackColor = true;
            this.IncMgmtAdd.Click += new System.EventHandler(this.IncMgmtAdd_Click);
            // 
            // IncMgmtEdit
            // 
            this.IncMgmtEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncMgmtEdit.Location = new System.Drawing.Point(118, 411);
            this.IncMgmtEdit.Name = "IncMgmtEdit";
            this.IncMgmtEdit.Size = new System.Drawing.Size(99, 27);
            this.IncMgmtEdit.TabIndex = 2;
            this.IncMgmtEdit.Text = "Edit";
            this.IncMgmtEdit.UseVisualStyleBackColor = true;
            this.IncMgmtEdit.Click += new System.EventHandler(this.IncMgmtEdit_Click);
            // 
            // IncMgmtDelete
            // 
            this.IncMgmtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncMgmtDelete.Location = new System.Drawing.Point(223, 411);
            this.IncMgmtDelete.Name = "IncMgmtDelete";
            this.IncMgmtDelete.Size = new System.Drawing.Size(99, 27);
            this.IncMgmtDelete.TabIndex = 3;
            this.IncMgmtDelete.Text = "Delete";
            this.IncMgmtDelete.UseVisualStyleBackColor = true;
            // 
            // IncMgmtRef
            // 
            this.IncMgmtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncMgmtRef.Location = new System.Drawing.Point(849, 411);
            this.IncMgmtRef.Name = "IncMgmtRef";
            this.IncMgmtRef.Size = new System.Drawing.Size(99, 27);
            this.IncMgmtRef.TabIndex = 4;
            this.IncMgmtRef.Text = "Refresh";
            this.IncMgmtRef.UseVisualStyleBackColor = true;
            this.IncMgmtRef.Click += new System.EventHandler(this.IncMgmtRef_Click);
            // 
            // IncomeMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.IncMgmtRef);
            this.Controls.Add(this.IncMgmtDelete);
            this.Controls.Add(this.IncMgmtEdit);
            this.Controls.Add(this.IncMgmtAdd);
            this.Controls.Add(this.IncMgmtDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncomeMgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Item Management";
            this.Load += new System.EventHandler(this.IncomeMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IncMgmtDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IncMgmtDataGrid;
        private System.Windows.Forms.Button IncMgmtAdd;
        private System.Windows.Forms.Button IncMgmtEdit;
        private System.Windows.Forms.Button IncMgmtDelete;
        private System.Windows.Forms.Button IncMgmtRef;
    }
}