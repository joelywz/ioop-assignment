﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormCServiceDetails : Form
    {
        public FormCServiceDetails()
        {
            InitializeComponent();
        }

        private void btnCustServChg_Click(object sender, EventArgs e)
        {
            //customer is going to change service themselves
            
        }

        private void btnCustServBack_Click(object sender, EventArgs e)
        {
            FormCHome objCHome = new FormCHome();
            objCHome.Show();
            this.Hide();
        }
    }
}
