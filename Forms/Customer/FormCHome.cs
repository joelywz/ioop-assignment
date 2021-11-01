using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormCHome : Form
    {
        //customer details
        User customer;
        public FormCHome(User user)
        {
            this.customer = user;
            InitializeComponent();
        }

        private void btnCustServ_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetais = new FormCServiceDetails();
            objCServiceDetais.ShowDialog();
            this.Hide();
        }

        private void btnCustProf_Click(object sender, EventArgs e)
        {
            FormCProfile objCProfile = new FormCProfile(customer);
            objCProfile.ShowDialog();
            this.Hide();
        }

        private void btnCustLogout_Click(object sender, EventArgs e)
        {
            //add loading animation
            this.Close();
        }
    }
}
