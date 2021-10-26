using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Forms.Receptionist;

namespace Assignment
{
    public partial class FormRHome : Form
    {
        // This is to hold all customers
        List<User> customers = new List<User>();

        // This is to hold customers that are being shown on the listbox customers
        List<User> listedCustomers = new List<User>();

        // Save Selected Customer
        User selectedCustomer = null;

        public FormRHome(User user)
        {
            InitializeComponent();
        }
        private void FormRHome_Load(object sender, EventArgs e)
        {
            FetchCustomers();
            rdoFullName.Checked = true;
            Search();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            ShowNewCustomerForm();
        }

        private void lstCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstCustomers.SelectedIndex;
            if (selectedIndex >= 0)
            {
                selectedCustomer = listedCustomers[selectedIndex];
                LoadDetails(selectedCustomer);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null) return;
            Form addServiceForm = new FormRAddService(selectedCustomer);
            addServiceForm.ShowDialog();
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            FetchCustomers();
            Search();
        }

        // Helper functions
        private void FetchCustomers()
        {
            customers = User.GetByRole(User.Roles.Customer).ToList<User>();
        }
        
        private void ShowNewCustomerForm()
        {
            Form newCustomerForm = new FormRNewCus();
            newCustomerForm.ShowDialog();
            FetchCustomers();
        }

        private void ClearListedCustomers()
        {
            listedCustomers.Clear();
            lstCustomers.Items.Clear();
        }

        private void AddListedCustomer(User user)
        {
            listedCustomers.Add(user);
            lstCustomers.Items.Add(user.FullName);
        }

        private void Search()
        {
            ClearListedCustomers();


            foreach (User user in customers)
            {
                // Radiobox filter
                if (rdoFullName.Checked && !user.FullName.ToLower().Contains(txtboxSearch.Text.ToLower())) continue;
                else if (rdoUsername.Checked && !user.Username.ToLower().Contains(txtboxSearch.Text.ToLower())) continue;
                else if (rdoEmail.Checked && !user.Email.ToLower().Contains(txtboxSearch.Text.ToLower())) continue;

                // Checkbox not paid filter
                if (chkNotPaid.Checked)
                {
                    int paymentDue = CompletedService.GetUnpaidCount(user);
                    if (paymentDue == 0) continue;
                }

                AddListedCustomer(user);
            }

        }

        private void Reset()
        {
            txtboxSearch.Text = "";
            chkNotPaid.Checked = false;
            ClearListedCustomers();
            foreach (User customer in customers)
            {
                AddListedCustomer(customer);
            }
        }

        // Customer Detail
        private void LoadDetails(User customer)
        {
            txtFullName.Text = customer.FullName;
            txtUsername.Text = customer.Username;
            txtPhoneNo.Text = customer.PhoneNo;
            txtEmail.Text =  customer.Email;

            // Check if any service is active
            IncompleteService services = IncompleteService.GetByUser(customer);
            btnViewPayment.Enabled = true;
            btnService.Enabled = services == null ? false : true;

            if(services == null)
            {
                btnService.Enabled = true;
                btnService.Text = "Add Service";
            } else
            {
                btnService.Enabled = false;
                btnService.Text = "A Service is Active";
            }

            // Check for payments
            int paymentDue = CompletedService.GetUnpaidCount(customer);

            if (paymentDue > 0)
            {
                lblPayment.Text = paymentDue + " outstanding payment(s)";
                lblPayment.ForeColor = Color.Red;
            }
            else
            {
                lblPayment.Text = "No outstanding payment";
                lblPayment.ForeColor = Color.Green;
            }
        }


    }
}
