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
            FormUpdateProfile objUpProf = new FormUpdateProfile();
            objUpProf.Show();
            this.Hide();
        }
    }
}
