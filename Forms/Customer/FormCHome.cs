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
        public FormCHome()
        {
            InitializeComponent();
        }

        private void btnCustServ_Click(object sender, EventArgs e)
        {
            FormCServiceDetails objCServiceDetais = new FormCServiceDetails();
            objCServiceDetais.Show();
            this.Hide();
        }

        private void btnCustProf_Click(object sender, EventArgs e)
        {
            FormCProfile objCProfile = new FormCProfile();
            objCProfile.Show();
            this.Hide();
        }

        private void btnCustLogout_Click(object sender, EventArgs e)
        {
            //add loading animation
            this.Close();
        }
    }
}
