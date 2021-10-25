﻿using System;
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
                ShowErrorMessageBox("Username or password is empty.");
                return;
            }

            // Fetch user from database
            User user = User.FromDb(txtUsername.Text);

            // Check if user exist
            if (user == null)
            {
                ShowErrorMessageBox("Invalid credentials.");
                return;
            }

            // Compare passwords
            if (txtPassword.Text != user.password)
            {
                ShowErrorMessageBox("Invalid credentials.");
                return;
            }

            // Redirect user to their home screen
            Form homeForm = null;
            switch (user.role)
            {
                case User.Role.Customer:
                    homeForm = new FormCHome();
                    break;
                case User.Role.Receptionist:
                    homeForm = new FormRHome(user);
                    break;
                case User.Role.Technician:
                    homeForm = new FormTHome();
                    break;
                case User.Role.Administrator:
                    homeForm = new FormAHome();
                    break;
            }

            if (homeForm == null) return;
            this.Hide(); // Hide login form
            homeForm.ShowDialog(); // Show home form
            this.Show(); // Show login form when home form is closed

        }

        private void ShowErrorMessageBox(string message)
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