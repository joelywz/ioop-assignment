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

        public FormRHome(User user)
        {
            InitializeComponent();
        }
        private void FormRHome_Load(object sender, EventArgs e)
        {
            FetchCustomers();
            rdoFullName.Checked = true;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            ShowNewCustomerForm();
        }

        private void lstCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex >= 0)
            {
                btnViewCustomer.Enabled = true;
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

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            ShowCustomerDetailsForm();
        }

        // Helper functions
        private void FetchCustomers()
        {
            btnViewCustomer.Enabled = false;
            customers = User.GetByRole(User.Roles.Customer).ToList<User>();
            ClearListedCustomers();
            foreach (User user in customers)
            {
                AddListedCustomer(user);
            }
        }
        
        private void ShowNewCustomerForm()
        {
            Form newCustomerForm = new FormRNewCus();
            newCustomerForm.ShowDialog();
            FetchCustomers();
        }

        private void ShowCustomerDetailsForm()
        {
            User selectedCustomer = listedCustomers[lstCustomers.SelectedIndex];

            Form form = new FormRCustomerDetails(selectedCustomer);
            this.Hide();
            form.ShowDialog();
            this.Show();
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
            btnViewCustomer.Enabled = false;
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
                    CompletedService[] services = CompletedService.GetByUser(user);
                    if (services.Length == 0) continue;

                    foreach (CompletedService service in services)
                    {
                        if (service.HasPaid) continue;
                    }

                }

                AddListedCustomer(user);
            }

        }

        private void Reset()
        {
            txtboxSearch.Text = "";
            chkNotPaid.Checked = false;
            FetchCustomers();
        }
    }
}
