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
            FormCServiceDetails objCServiceDetais = new FormCServiceDetails(customer);
            this.Hide();
            objCServiceDetais.ShowDialog();
            this.Show();
        }

        private void btnCustProf_Click(object sender, EventArgs e)
        {
            FormCProfile objCProfile = new FormCProfile(customer);
            this.Hide();
            objCProfile.ShowDialog();
            this.Show();
        }

        private void btnCustLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
