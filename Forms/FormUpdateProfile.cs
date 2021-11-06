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
    public partial class FormUpdateProfile : Form
    {
        //To store logged in user details
        User loggedInUser;



        //HELPER FUNCTIONS
        private void loader()
        {
            //Sorting roles
            String roleName;
            if (Convert.ToInt32(loggedInUser.Role) == 0)
                roleName = "Customer";
            else if (Convert.ToInt32(loggedInUser.Role) == 1)
                roleName = "Administrator";
            else if (Convert.ToInt32(loggedInUser.Role) == 2)
                roleName = "Receptionist";
            else
                roleName = "Technician";

            //Initializing displayed data
            lblFullName.Text = "Full Name: " + loggedInUser.FullName;
            lblRole.Text = "Role: " + roleName;
            txtUsername.Text = loggedInUser.Username;
            txtPassword.Text = loggedInUser.Password;
            txtEmail.Text = loggedInUser.Email;
            txtPhoneNo.Text = loggedInUser.PhoneNo;
            if (loggedInUser.Role != 0)
                dtpDateOfBirth.Value = Convert.ToDateTime(loggedInUser.DateOfBirth);

            btnSave.Enabled = false;
        }



        //EVENTS
        public FormUpdateProfile(User user)
        {
            this.loggedInUser = user;
            InitializeComponent();
        }

        private void FormUpdateProfile_Load(object sender, EventArgs e)
        {
            loader();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNo.Enabled = true;
            if (Convert.ToInt32(loggedInUser.Role) != 0)
                dtpDateOfBirth.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNo.Enabled = false;
            dtpDateOfBirth.Enabled = false;

            loader();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Validation of new details
                Validation.ValidateUsername(txtUsername.Text);
                Validation.ValidatePassword(txtPassword.Text);
                Validation.ValidateEmail(txtEmail.Text);
                Validation.ValidatePhoneNo(txtPhoneNo.Text);

                //Checking if user exists
                User test = User.GetByUsername(txtUsername.Text);
                if (test != null && test.Id != loggedInUser.Id) throw new Exception("Username taken.");  
                test = User.GetByEmail(txtEmail.Text);
                if (test != null && test.Id != loggedInUser.Id) throw new Exception("Email taken.");

                //Updating user details
                this.loggedInUser.Username = txtUsername.Text;
                this.loggedInUser.Password = txtPassword.Text;
                this.loggedInUser.Email = txtEmail.Text;
                this.loggedInUser.PhoneNo = txtPhoneNo.Text;
                if (Convert.ToInt32(loggedInUser.Role) != 0)
                    this.loggedInUser.DateOfBirth = dtpDateOfBirth.Value.Date;
                loggedInUser.Update();
                MessageBox.Show("Profile successfully updated!");

                //Resetting form to default state
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtEmail.Enabled = false;
                txtPhoneNo.Enabled = false;
                dtpDateOfBirth.Enabled = false;
                loader();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        //Text changed or value changed events
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
                btnSave.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
                btnSave.Enabled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
                btnSave.Enabled = true;
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text != "")
                btnSave.Enabled = true;
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
