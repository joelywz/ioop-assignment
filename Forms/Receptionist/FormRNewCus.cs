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
            bool hasError = false;

            // Clear Error
            errFullName.Clear();
            errUsername.Clear();
            errPassword.Clear();
            errRepeatPassword.Clear();
            errEmail.Clear();
            errPhoneNo.Clear();
            
            // Full Name Validation
            try
            {
                Validation.ValidateFullName(fullName);
            } catch (Exception exception)
            {
                errFullName.SetError(txtName, exception.Message);
                hasError = true;
            }

            // Username Validation
            try
            {
                Validation.ValidateUsername(username);
                User test = User.GetByUsername(username);
                if (test != null) throw new Exception("Username taken.");
            } catch (Exception exception)
            {
                errUsername.SetError(txtUsername, exception.Message);
                hasError = true;

            }

            // Password Validation
            try
            {
                Validation.ValidatePassword(password, repeatPassword);
            } catch (Exception exception)
            {
                errPassword.SetError(txtPassword, exception.Message);
                errRepeatPassword.SetError(txtRepeatPassword, exception.Message);
                hasError = true;

            }

            // Email Validation
            try
            {
                Validation.ValidateEmail(email);
                User test = User.GetByEmail(email);
                if (test != null) throw new Exception("Email taken.");
            } catch (Exception exception)
            {
                errEmail.SetError(txtEmail, exception.Message);
                hasError = true;

            }

            // Phone Validation
            try
            {
                Validation.ValidatePhoneNo(phoneNo);
            } catch (Exception exception)
            {
                errPhoneNo.SetError(txtPhoneNo, exception.Message);
                hasError = true;
            }

            if (hasError) return;


            try
            {
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

        private void FormRNewCus_Load(object sender, EventArgs e)
        {

        }
    }
}
