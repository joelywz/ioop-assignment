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
        User[] customers = { };
        User[] listedCustomers = { };
        public FormRHome(User user)
        {
            InitializeComponent();

            // Check if user has the right role
            if (user.Role != User.Roles.Receptionist) Close();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            Form newCustomerForm = new FormRNewCus();
            newCustomerForm.ShowDialog();
            LoadCustomers();
        }

        private void FormRHome_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            rdoFullName.Checked = true;
        }

        private void LoadCustomers()
        {
            btnViewCustomer.Enabled = false;
            customers = User.GetByRole(User.Roles.Customer);
            ClearListedCustomers();
            foreach (User user in customers)
            {
                AddListedCustomer(user);
            }
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
            btnViewCustomer.Enabled = false;
            ClearListedCustomers();

            if (rdoFullName.Checked)
                foreach (User user in customers)
                {
                    if (user.FullName.ToLower().Contains(txtboxSearch.Text.ToLower()))
                    {
                        AddListedCustomer(user);
                    }
                }
            else if (rdoUsername.Checked)
                foreach (User user in customers)
                {
                    if (user.Username.ToLower().Contains(txtboxSearch.Text.ToLower()))
                    {
                        AddListedCustomer(user);
                    }
                }
            else if (rdoEmail.Checked)
                foreach (User user in customers)
                {
                    if (user.Email.ToLower().Contains(txtboxSearch.Text.ToLower()))
                    {
                        AddListedCustomer(user);
                    }
                }

        }

        private void ClearListedCustomers()
        {
            Array.Clear(listedCustomers, 0, listedCustomers.Length);
            Array.Resize(ref listedCustomers, 0);
            lstCustomers.Items.Clear();
        }

        private void AddListedCustomer(User user)
        {
            Array.Resize(ref listedCustomers, listedCustomers.Length + 1);
            listedCustomers[listedCustomers.Length - 1] = user;
            lstCustomers.Items.Add(user.FullName);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxSearch.Text = "";
            LoadCustomers();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            User selectedCustomer = listedCustomers[lstCustomers.SelectedIndex];
    
            Form form = new FormRCustomerDetails(selectedCustomer);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
