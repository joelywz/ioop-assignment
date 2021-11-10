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
        User LoggedInUser;

        public FormUpdateProfile(User user)
        {
            this.LoggedInUser = user;
            InitializeComponent();
        }

        // HELPER FUNCTIONS
        /// <summary>
        /// To load user info into corresponding text boxes
        /// </summary>
        private void Loader()
        {
            // Get the role name of logged in user
            String roleName = User.RoleToString(LoggedInUser.Role);

            //Initializing displayed data
            lblRole.Text = "Role: " + roleName;
            txtFullName.Text = LoggedInUser.FullName;
            txtUsername.Text = LoggedInUser.Username;
            txtPassword.Text = LoggedInUser.Password;
            txtEmail.Text = LoggedInUser.Email;
            txtPhoneNo.Text = LoggedInUser.PhoneNo;
            if (LoggedInUser.Role != User.Roles.Customer)
            {
                lblDateOfBirth.Show();
                dtpDateOfBirth.Show();
                dtpDateOfBirth.Value = Convert.ToDateTime(LoggedInUser.DateOfBirth);
            }
            else
            {
                lblDateOfBirth.Hide();
                dtpDateOfBirth.Hide();
            }
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void FormUpdateProfile_Load(object sender, EventArgs e)
        {
            Loader();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditEnabled(true);
            btnCancel.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetEditEnabled(false);
            Loader();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation of new details
                Validation.ValidateUsername(txtUsername.Text);
                Validation.ValidatePassword(txtPassword.Text);
                Validation.ValidateFullName(txtFullName.Text);
                Validation.ValidateEmail(txtEmail.Text);
                Validation.ValidatePhoneNo(txtPhoneNo.Text);

                // Checking if user exists
                User test = User.GetByUsername(txtUsername.Text);
                if (test != null && test.Id != LoggedInUser.Id) throw new Exception("Username taken.");  
                test = User.GetByEmail(txtEmail.Text);
                if (test != null && test.Id != LoggedInUser.Id) throw new Exception("Email taken.");

                // Updating user details
                this.LoggedInUser.Username = txtUsername.Text;
                this.LoggedInUser.Password = txtPassword.Text;
                this.LoggedInUser.FullName = txtFullName.Text;
                this.LoggedInUser.Email = txtEmail.Text;
                this.LoggedInUser.PhoneNo = txtPhoneNo.Text;
                if (LoggedInUser.Role != User.Roles.Customer)
                    this.LoggedInUser.DateOfBirth = dtpDateOfBirth.Value.Date;
                LoggedInUser.Update();
                MessageBox.Show("Profile successfully updated!");

                // Resetting form to default state
                SetEditEnabled(false);
                Loader();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Enable or Disable TextBoxes/DateTimePicker
        private void SetEditEnabled(bool b)
        {
            txtUsername.Enabled = b;
            txtPassword.Enabled = b;
            txtFullName.Enabled = b;
            txtEmail.Enabled = b;
            txtPhoneNo.Enabled = b;
            dtpDateOfBirth.Enabled = b;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Text changed or value changed events
        private void txt_TextChanges(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
    }
}
