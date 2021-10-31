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
    public partial class FormAHome : Form
    {
        public FormAHome()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            cmbRoles.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtic.Text = String.Empty;
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtConfirmpass.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            cmbRoles.Text = " - Select Roles -";
            txtName.Text = "Enter full name in this field";
            txtEmail.Text = "Enter email in this field";
            txtPhone.Text = "Enter phone number in this field";
            txtic.Text = "Enter IC number in this field";
            txtUsername.Text = "Enter Username";
            txtPassword.Text = "Enter Password";
            txtConfirmpass.Text = "Re enter your password for confirmation";
            txtName.ForeColor = Color.Gray;
            cmbRoles.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtPhone.ForeColor = Color.Gray;
            txtic.ForeColor = Color.Gray;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            txtConfirmpass.ForeColor = Color.Gray;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("text");
            if (txtName.Text == "Enter full name in this field")
            {
                txtName.ForeColor = Color.Black;
                txtName.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.ForeColor = Color.Gray;
                txtName.Text = "Enter full name in this field";
            }
        }

        private void cmbRoles_Enter(object sender, EventArgs e)
        {
            cmbRoles.ForeColor = Color.Black;
        }

        private void cmbRoles_Leave(object sender, EventArgs e)
        {
            if ((cmbRoles.Text == "") || (cmbRoles.Text == " - Select Roles -"))
            {
                cmbRoles.ForeColor = Color.Gray;
                cmbRoles.Text = " - Select Roles -";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("text");
            if (txtEmail.Text == "Enter email in this field")
            {
                txtEmail.ForeColor = Color.Black;
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.ForeColor = Color.Gray;
                txtEmail.Text = "Enter email in this field";
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("text");
            if (txtPhone.Text == "Enter phone number in this field")
            {
                txtPhone.ForeColor = Color.Black;
                txtPhone.Text = "";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.ForeColor = Color.Gray;
                txtPhone.Text = "Enter phone number in this field";
            }
        }

        private void txtic_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("text");
            if (txtic.Text == "Enter IC number in this field")
            {
                txtic.ForeColor = Color.Black;
                txtic.Text = "";
            }
        }

        private void txtic_Leave(object sender, EventArgs e)
        {
            if (txtic.Text == "")
            {
                txtic.ForeColor = Color.Gray;
                txtic.Text = "Enter IC number in this field";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("text");
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = "Enter Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("text");
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.ForeColor = Color.Black;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text = "Enter Password";
            }
        }

        private void txtConfirmpass_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("text");
            if (txtConfirmpass.Text == "Re-enter your password for confirmation")
            {
                txtConfirmpass.ForeColor = Color.Black;
                txtConfirmpass.Text = "";
            }
        }

        private void txtConfirmpass_Leave(object sender, EventArgs e)
        {
            if (txtConfirmpass.Text == "")
            {
                txtConfirmpass.ForeColor = Color.Gray;
                txtConfirmpass.Text = "Re-enter your password for confirmation";
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            errRoles.SetError(cmbRoles, null);
            errName.SetError(txtName, null);
            errEmail.SetError(txtEmail, null);
            errPhone.SetError(txtPhone, null);
            erric.SetError(txtic, null);
            errUsername.SetError(txtUsername, null);
            errPassword.SetError(txtPassword, null);
            errConfirmpass.SetError(txtConfirmpass, null);
            tmrAdmin.Start();
            if (cmbRoles.Text == " - Select Roles -")
            {
                errRoles.SetError(cmbRoles, "Field is required!");
            }
            else if (txtName.Text == "Enter full name in this field")
            {
                errName.SetError(txtName, "Field is required!");
            }
            else if (txtEmail.Text == "Enter email in this field")
            {
                errEmail.SetError(txtEmail, "Field is required!");
            }
            else if (txtPhone.Text == "Enter phone number in this field")
            {
                errPhone.SetError(txtPhone, "Field is required!");
            }
            else if (txtic.Text == "Enter IC number in this field")
            {
                erric.SetError(txtic, "Field is required!");
            }
            else if (txtUsername.Text == "Enter Username")
            {
                errUsername.SetError(txtUsername, "Field is required!");
            }
            else if (txtPassword.Text == "Enter Password")
            {
                errPassword.SetError(txtPassword, "Field is required!");
            }
            else if (txtConfirmpass.Text != txtPassword.Text)
            {
                errConfirmpass.SetError(txtConfirmpass, "Passwords entered are not the same!");
            }
            else
            {
                User newUser = User.Save(txtUsername.Text, txtName.Text, txtEmail.Text, txtPassword.Text, txtPhone.Text, txtic.Text, dtpAge.Value, (User.Roles)cmbRoles.SelectedIndex + 2);
                System.Windows.Forms.MessageBox.Show(txtName.Text + " has been successfully registered!", (User.Roles)cmbRoles.SelectedIndex + 2 + " registered");
                errRoles.SetError(cmbRoles, null);
                errName.SetError(txtName, null);
                errEmail.SetError(txtEmail, null);
                errPhone.SetError(txtPhone, null);
                erric.SetError(txtic, null);
                errUsername.SetError(txtUsername, null);
                errPassword.SetError(txtPassword, null);
                errConfirmpass.SetError(txtConfirmpass, null);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void prgAdmin_Click(object sender, EventArgs e)
        {

        }

        private void tmrAdmin_Tick(object sender, EventArgs e)
        {
            prgAdmin.Increment(10);
            if (prgAdmin.Value == 100)
            {
                tmrAdmin.Stop();
                prgAdmin.Value = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tmrAdmin.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tmrAdmin.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tmrAdmin.Start();
        }
    }
}
