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
    public partial class FormRCustomerDetails : Form
    {
        User customer;

        public FormRCustomerDetails(User user)
        {
            InitializeComponent();
            customer = user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRCustomerDetails_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Form addServiceForm = new FormRAddService(customer);
            addServiceForm.ShowDialog();
            LoadDetails();
        }

        // Helper Functions
        private void LoadDetails()
        {
            lblName.Text = "Full Name: " + customer.FullName;
            lblUsername.Text = "Username: " + customer.Username;
            lblPhoneNo.Text = "Phone Number: " + customer.PhoneNo;
            lblEmail.Text = "Email: " + customer.Email;

            // Check if any service is active
            IncompleteService services = IncompleteService.GetByUser(customer);

            if (services != null)
            {
                btnService.Enabled = false;
            }
            else
            {
                btnService.Enabled = true;
            }

            // Check for payments
            int paymentDue = CompletedService.GetUnpaidCount(customer);

            if (paymentDue > 0)
            {
                lblPayment.Text = paymentDue + " outstanding payment(s)";
                lblPayment.ForeColor = Color.Red;
            } else
            {
                lblPayment.Text = "No outstanding payment";
                lblPayment.ForeColor = Color.Green;
            }



        }
    }
}
