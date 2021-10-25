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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
    
            // Check if fields are empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                showErrorMessageBox("Username or password is empty.");
                return;
            }

            // Fetch user from database
            User user = User.FromDb(txtUsername.Text);

            // Check if user exist
            if (user == null)
            {
                showErrorMessageBox("Invalid credentials.");
                return;
            }

            // Compare passwords
            if (txtPassword.Text != user.password)
            {
                showErrorMessageBox("Invalid credentials.");
                return;
            }

            // Redirect user to their corresponding home screen
            Form homeForm = null;
            switch (user.role)
            {
                case User.Roles.Customer:
                    homeForm = new FormCHome();
                    break;
                case User.Roles.Receptionist:
                    homeForm = new FormRHome();
                    break;
                case User.Roles.Technician:
                    homeForm = new FormTHome();
                    break;
                case User.Roles.Administrator:
                    homeForm = new FormAHome();
                    break;
            }

            if (homeForm == null) return;
            this.Hide();
            homeForm.ShowDialog();
            // Once Home Form is closed, the login form will reopen
            this.Show();

        }

        private void showErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
