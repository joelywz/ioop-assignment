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
        List<User> Customers = new List<User>();

        // This is to hold customers that are being shown on the listbox customers
        List<User> ListedCustomers = new List<User>();

        // Save Selected Customer
        User SelectedCustomer = null;

        public FormRHome(User user)
        {
            InitializeComponent();
        }
        private void FormRHome_Load(object sender, EventArgs e)
        {
            lblPayment.Text = "";
            btnService.Enabled = false;
            btnViewPayment.Enabled = false;
            rdoFullName.Checked = true;
            RefreshContent();
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
                SelectedCustomer = ListedCustomers[selectedIndex];
                LoadDetails();
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
            if (SelectedCustomer == null) return;
            Form addServiceForm = new FormRAddService(SelectedCustomer);
            addServiceForm.ShowDialog();
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void chkNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnViewPayment_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer == null) return;
            Form form = new FormRPaymentReceipt(SelectedCustomer);
            form.ShowDialog();
            RefreshContent();
        }

        // Helper functions
        private void FetchCustomers()
        {
            Customers = User.GetByRole(User.Roles.Customer).ToList<User>();
        }
        
        private void ShowNewCustomerForm()
        {
            Form newCustomerForm = new FormRNewCus();
            newCustomerForm.ShowDialog();
            RefreshContent();
        }

        private void ClearListedCustomers()
        {
            ListedCustomers.Clear();
            lstCustomers.Items.Clear();
        }

        private void AddListedCustomer(User user)
        {
            ListedCustomers.Add(user);
            lstCustomers.Items.Add(user.FullName);
        }

        private void Search()
        {
            ClearListedCustomers();


            foreach (User user in Customers)
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
            foreach (User customer in Customers)
            {
                AddListedCustomer(customer);
            }
        }

        private void RefreshContent()
        {
            FetchCustomers();
            Search();
            LoadDetails();
        }

        // Customer Detail
        private void LoadDetails()
        {
            if (SelectedCustomer == null) return;

            txtFullName.Text = SelectedCustomer.FullName;
            txtUsername.Text = SelectedCustomer.Username;
            txtPhoneNo.Text = SelectedCustomer.PhoneNo;
            txtEmail.Text =  SelectedCustomer.Email;

            // Check if any service is active
            IncompleteService services = IncompleteService.GetByUser(SelectedCustomer);
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
            int paymentDue = CompletedService.GetUnpaidCount(SelectedCustomer);

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
