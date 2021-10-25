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
            if (user.role != User.Role.Receptionist) Close();
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
        }

        private void LoadCustomers()
        {
            btnViewCustomer.Enabled = false;
            customers = User.GetUsersByRole(User.Role.Customer);
            ClearListedCustomers();
            foreach (User user in customers)
            {
                AddListedCustomer(user);
            }
        }

        private void lstCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            btnViewCustomer.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnViewCustomer.Enabled = false;
            ClearListedCustomers();

            if (rdoFullName.Checked)
                foreach (User user in customers)
                {
                    if (user.fullName.ToLower().Contains(txtboxSearch.Text.ToLower()))
                    {
                        AddListedCustomer(user);
                    }
                }
            else if (rdoUsername.Checked)
                foreach (User user in customers)
                {
                    if (user.username.ToLower().Contains(txtboxSearch.Text.ToLower()))
                    {
                        AddListedCustomer(user);
                    }
                }
            else if (rdoEmail.Checked)
                foreach (User user in customers)
                {
                    if (user.email.ToLower().Contains(txtboxSearch.Text.ToLower()))
                    {
                        AddListedCustomer(user);
                    }
                }

        }

        private void ClearListedCustomers()
        {
            Array.Clear(listedCustomers, 0, listedCustomers.Length);
            lstCustomers.Items.Clear();
        }

        private void AddListedCustomer(User user)
        {
            Array.Resize(ref listedCustomers, listedCustomers.Length + 1);
            listedCustomers[listedCustomers.Length - 1] = user;
            lstCustomers.Items.Add(user.fullName);
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
    }
}
