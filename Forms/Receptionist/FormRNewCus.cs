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
                Validation.ValidateFullName(fullName);
                Validation.ValidateUsername(username);
                Validation.ValidatePassword(password, repeatPassword);
                Validation.ValidateEmail(email);
                Validation.ValidatePhoneNo(phoneNo);
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User(username, password, fullName, email, phoneNo, User.Roles.Customer);

            try
            {
                user.Save();
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Unable to create user.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
