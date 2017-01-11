﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Buddy
{
    public partial class IncomeAdd : Form
    {
        public IncomeAdd()
        {
            InitializeComponent();
        }

        private void newIncCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newIncClear_Click(object sender, EventArgs e)
        {
            newIncAmt.Text = "";
            newIncName.Text = "";
            newIncType.SelectedIndex = 0;
            newIncAmtUnit.SelectedIndex = 0;
        }
    }
}