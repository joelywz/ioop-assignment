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
    public partial class FormTCompletion : Form
    {
        //To store technician login details
        User technician;

        //To store selected service ID
        IncompleteService selectedService;

        public FormTCompletion(User user, IncompleteService selectedService)
        {
            this.technician = user;
            this.selectedService = selectedService;
            InitializeComponent();
        }

        private void btnViewServices_Click(object sender, EventArgs e)
        {
            FormTCusServices obj1 = new FormTCusServices(technician);
            this.Hide();
            obj1.ShowDialog();
            this.Close();
        }

        private void FormTCompletion_Load(object sender, EventArgs e)
        {
            if (selectedService != null)
                txtID.Text = Convert.ToString(selectedService.User.Id);
        }
    }
}
