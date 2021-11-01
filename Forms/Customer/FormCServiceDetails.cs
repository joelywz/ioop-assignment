using System;
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
        //customer details
        User customer;

        public FormCServiceDetails(User user)
        {
            InitializeComponent();
        }

        private void btnCustServChg_Click(object sender, EventArgs e)
        {
            //customer is going to change service themselves
            Form obj1 = new FormCChangeService();
        }

        private void btnCustServBack_Click(object sender, EventArgs e)
        {
            FormCHome objCHome = new FormCHome(customer);
            objCHome.ShowDialog();
            this.Hide();
        }
    }
}
