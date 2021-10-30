using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Forms.Receptionist
{
    public partial class FormRNewCus : Form
    {
        public FormRNewCus()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;
            string email = txtEmail.Text;
            string phoneNo = txtPhoneNo.Text;


            try
            {
                // Validate Fields
                Validation.ValidateFullName(fullName);
                Validation.ValidateUsername(username);
                Validation.ValidatePassword(password, repeatPassword);
                Validation.ValidateEmail(email);
                Validation.ValidatePhoneNo(phoneNo);

                // Check if user already exist
                User test = null;
                test = User.GetByUsername(username);
                if (test != null) throw new Exception("Username taken.");
                test = User.GetByEmail(email);
                if (test != null) throw new Exception("Email taken.");

                // Attempt to create and save user
                User user = User.Save(username, fullName, email, password, phoneNo, User.Roles.Customer);
                MessageBox.Show("User sucessfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
