using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Assignment.Forms.Customer;

namespace Assignment
{
    public partial class FormCServiceDetails : Form
    {
        //customer details
        User customer;
        IncompleteService IncompleteService = null;


        public FormCServiceDetails(User user)
        {
            this.customer = user;
            InitializeComponent();
        }

        private void btnCustServChg_Click(object sender, EventArgs e)
        {
            //customer is going to change service themselves
            // (lblCustServDispID.Text != "-")
            if (this.IncompleteService == null) return;

            FormCChangeService objCChangeService = new FormCChangeService(this.IncompleteService);
            this.Hide();
            objCChangeService.ShowDialog();
            LoadInfo();
            this.Show();
        }

        private void btnCustServBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCServiceDetails_Load(object sender, EventArgs e)
        {
            // Load details
            LoadInfo();
        }

        private void LoadInfo()
        {

            // Check if there is any unpaid completed service
            if (CompletedService.GetUnpaidCount(customer) > 0)
            {
                // Show ready to be collected info
                CompletedService completedService = CompletedService.GetLatestByUser(customer);
                this.txtServiceId.Text = completedService.Id.ToString();
                this.txtServiceName.Text = completedService.Service.Name.ToString();
                this.txtServiceCreated.Text = completedService.DateTimeCreated.ToString("dd-MM-yyyy");
                this.txtServiceCompleted.Text = completedService.DateTimeCompleted.ToString("dd-MM-yyyy");
                this.txtDescription.Text = completedService.Description;
                this.txtTotal.Text = "RM "  + completedService.Price;
            }
            else
            {
                // Show incomplete service info
                this.IncompleteService = IncompleteService.GetByUser(customer);

                if (IncompleteService == null) return;
                txtCurServiceName.Text = this.IncompleteService.Service.Name;
                txtCurServiceCreated.Text = this.IncompleteService.DateTimeCreated.ToString("dd-MM-yyyy");
                chkUrgent.Checked = this.IncompleteService.Urgent;
                double price = this.IncompleteService.Urgent ? this.IncompleteService.Service.UrgentPrice : this.IncompleteService.Service.Price;
                txtCurTotal.Text = "RM " + price;
                btnChangeService.Enabled = true;
            }

        }
    }
}
