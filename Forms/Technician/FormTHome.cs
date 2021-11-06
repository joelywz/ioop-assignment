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
        //To store technician login details
        User technician;

        public FormTHome(User user)
        {
            this.technician = user;
            InitializeComponent();
        }
        
        private void btnProceed_Click(object sender, EventArgs e)
        {
            Form menuForm = null;

            if (rdoService.Checked)
                menuForm = new FormTCusServices(technician);

            if (rdoComplete.Checked)
            {
                IncompleteService selectedService = null;
                menuForm = new FormTCompletion(technician, selectedService);
            }

            if (rdoUpdateProfile.Checked)
                menuForm = new FormUpdateProfile(technician);

            this.Hide();
            menuForm.ShowDialog();
            this.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
