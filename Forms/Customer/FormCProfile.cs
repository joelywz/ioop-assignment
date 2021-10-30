using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormCProfile : Form
    {
        public FormCProfile()
        {
            InitializeComponent();
        }

        private void btnCustProfChgProf_Click(object sender, EventArgs e)
        {
            FormUpdateProfile objUpdateProfile = new FormUpdateProfile();
            objUpdateProfile.Show();
            this.Hide();
        }

        private void btnCustProfServ_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetails = new FormCServiceDetails();
            objCServiceDetails.Show();
            this.Hide();
        }

        private void btnCustProfBack_Click(object sender, EventArgs e)
        {
            FormCHome objCHome = new FormCHome();
            objCHome.Show();
            this.Hide();
        }
    }
}
