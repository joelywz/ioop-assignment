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
    public partial class FormTHome : Form
    {
        public FormTHome()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Form menuForm = null;

            if (rdoService.Checked)
                menuForm = new FormTCusServices();

            if (rdoComplete.Checked)
                menuForm = new FormTCompletion();

            if (rdoUpdateProfile.Checked)
                menuForm = new FormUpdateProfile();

            this.Hide();
            menuForm.ShowDialog();
            this.Show();

        }
    }
}
