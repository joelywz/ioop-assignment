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
        // Variable for storing selected month in MonthCalendar control
        int selectedMonth = DateTime.Now.Date.Month;

        // Variable for storing CompletedService table
        List<CompletedService> retrievedServices = CompletedService.GetAll().ToList();

        //Store a list
        List<CompletedService> ListedStatistics = new List<CompletedService>();

        /// <summary>
        ///  To display statistics in the listbox compared with filter combobox and dates selected
        /// </summary>
        public void Display_statistics()
        {
            var cnt = 0;
            if (cmbFilterby.SelectedIndex == 0)
            {
                lstStatistics.Items.Clear();
                foreach (var item in retrievedServices)
                {
                    if (selectedMonth == item.DateTimeCompleted.Date.Month)
                    {
                        cnt += 1;
                        lstStatistics.Items.Add(cnt + ". [Service ID: " + item.Id + "]   [User ID: " + item.User.Id + "]   [Technician ID: " + item.CompletedBy.Id + "]   [Service type: " + item.Service.Name + "]   [Urgency: " + item.Urgent + "]   [Price: " + item.Price + "]   [Description: " + item.Description + "]   [Paid: " + item.HasPaid + "]   [Date of service requested: " + item.DateTimeCreated + "]   [Service completion date: " + item.DateTimeCompleted + "]");
                    }
                }
            }
            else if (cmbFilterby.SelectedIndex == 1)
            {
                double sum = 0;
                lstStatistics.Items.Clear();
                foreach (var item in retrievedServices)
                {
                    if (selectedMonth == item.DateTimeCompleted.Date.Month)
                    {
                        sum = sum + item.Price;
                    }
                }
                lstStatistics.Items.Add("Total Income Of Selected Month: " + sum);
            }
        }

        private void AddListedService(CompletedService service)
        {
            lstStatistics.Items.Add(
                "[Service ID: " + service.Id +
                "][User ID: " + service.User.Id +
                "][Technician ID: " + service.CompletedBy.Id +
                "][Service type: " + service.Service.Name +
                "][Urgency: " + service.Urgent +
                "][Price: " + service.Price +
                "][Description: " + service.Description +
                "][Paid: " + service.HasPaid +
                "][Date of service requested: " + service.DateTimeCreated +
                "][Service completion date: " + service.DateTimeCompleted + "]");
            //lstStatistics.Items.Add(service.Id + " | " + service.DateTimeCompleted.ToString("dd-MM-yyyy") + " | " + service.Service.Name);
            ListedStatistics.Add(service);
        }

        private void ClearListedServices()
        {
            lstStatistics.Items.Clear();
            ListedStatistics.Clear();
        }

        /// <summary>
        /// To match technician's user profile in User.db from listbox items and display them
        /// </summary>
        public void FindUserFromlst()
        {
            CompletedService selectedService = ListedStatistics[lstStatistics.SelectedIndex];
            User technician = selectedService.CompletedBy;
            txtName_display.Text = technician.FullName;
            txtUserID_display.Text = technician.Id.ToString();
            txtAge_display.Text = technician.DateOfBirth.ToString();
            txtEmail_display.Text = technician.Email;
            txtPhone_display.Text = technician.PhoneNo;
            txtic_display.Text = technician.Ic;
        }

        /// <summary>
        /// Clearing displaying technician's profile
        /// </summary>
        public void ClearTechProfile()
        {
            txtName_display.Clear();
            txtUserID_display.Clear();
            txtAge_display.Clear();
            txtEmail_display.Clear();
            txtPhone_display.Clear();
            txtic_display.Clear();
        }

        /// <summary>
        /// Verify if existing entry is already in database and save them if available
        /// </summary>
        public void VerifyCredential()
        {
            if (User.GetByEmail(txtEmail.Text) != null)
            {
                errEmail.SetError(txtEmail, "Existing email! Please enter a different email");
            }
            else if (User.GetByUsername(txtUsername.Text) != null)
            {
                errUsername.SetError(txtUsername, "Existing user! Please enter a different username");
            }
            else if (User.GetByPhoneNo(txtPhone.Text) != null)
            {
                errPhone.SetError(txtPhone, "Existing phone no! Please enter a different phone no");
            }
            else if (User.GetByIc(txtic.Text) != null)
            {
                erric.SetError(txtic, "Existing IC! Please enter a different IC no");
            }
            else
            {
                User user_save = User.Save(txtUsername.Text, txtName.Text, txtEmail.Text, txtPassword.Text, txtPhone.Text, (User.Roles)cmbRoles.SelectedIndex + 2);
                user_save.Ic = txtic.Text;
                user_save.DateOfBirth = dtpAge.Value;
                user_save.Update();
                System.Windows.Forms.MessageBox.Show(txtName.Text + " has been successfully registered!", (User.Roles)cmbRoles.SelectedIndex + 2 + " registered");
                ClearFields();
                ClearErrors();
            }
        }

        /// <summary>
        /// Clear error lists
        /// </summary>
        public void ClearErrors()
        {
            errRoles.SetError(cmbRoles, null);
            errName.SetError(txtName, null);
            errEmail.SetError(txtEmail, null);
            errPhone.SetError(txtPhone, null);
            erric.SetError(txtic, null);
            errUsername.SetError(txtUsername, null);
            errPassword.SetError(txtPassword, null);
            errConfirmpass.SetError(txtConfirmpass, null);
        }

        /// <summary>
        /// Clear fields for registration's textboxes
        /// </summary>
        public void ClearFields()
        {
            txtName.ForeColor = Color.Gray;
            txtName.Text = "Enter full name in this field";
            cmbRoles.ForeColor = Color.Gray;
            cmbRoles.Text = " - Select Roles -";
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Text = "Enter email in this field";
            txtPhone.ForeColor = Color.Gray;
            txtPhone.Text = "Enter phone number in this field";
            txtic.ForeColor = Color.Gray;
            txtic.Text = "Enter IC number in this field";
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Text = "Enter Username";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Text = "Enter Password";
            txtConfirmpass.ForeColor = Color.Gray;
            txtConfirmpass.Text = "Re-enter your password for confirmation";
        }

        public FormAHome()
        {
            InitializeComponent();

            // Activate scrollbar for listbox
            lstStatistics.HorizontalScrollbar = true;
            lstStatistics.ScrollAlwaysVisible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Limiting selections to the current month in MonthCalendar control
            cdrStatistics.MaxDate = DateTime.Now;

            // Set default selected index upon form load
            cmbFilterby.SelectedIndex = 0;  

            // Set default description in each textbox's field to instruct users
            cmbRoles.Text = " - Select Roles -";
            txtName.Text = "Enter full name in this field";
            txtEmail.Text = "Enter email in this field";
            txtPhone.Text = "Enter phone number in this field";
            txtic.Text = "Enter IC number in this field";
            txtUsername.Text = "Enter Username";
            txtPassword.Text = "Enter Password";
            txtConfirmpass.Text = "Re-enter your password for confirmation";
            txtName.ForeColor = Color.Gray;
            cmbRoles.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtPhone.ForeColor = Color.Gray;
            txtic.ForeColor = Color.Gray;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            txtConfirmpass.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Reintroducing default descriptions upon entering/leaving textbox's fields
        /// </summary>
        private void txtName_Enter(object sender, EventArgs e)
        {
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
            ClearTechProfile();
            Display_statistics();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Stop executing when index becomes -1 from clicking anywhere else in the listbox
            if (lstStatistics.SelectedIndex == -1) return;

            // To limit tech profile display when filter "view monthly total income" is chosen as index changes activates FindUserFromlst()
            if (cmbFilterby.SelectedIndex == 0)
            {
                FindUserFromlst();
            }
            else if (cmbFilterby.SelectedIndex == 1)
            {
                ClearTechProfile();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            ClearErrors();

            // To limit character data type within textbox fields
            foreach (char a in txtPhone.Text)
            foreach (char c in txtic.Text)
            
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
            else if (!txtEmail.Text.Contains("@"))
            {
                errEmail.SetError(txtEmail, "Invalid email!");
            }
            else if (txtPhone.Text == "Enter phone number in this field")
            {
                errPhone.SetError(txtPhone, "Field is required!");
            }
            else if (char.IsDigit(a) == false)
            {
                if (a == '-') continue;    
                errPhone.SetError(txtPhone, "Only numeric digits and dashes are allowed!");    
            }
            else if (txtic.Text == "Enter IC number in this field")
            {
                erric.SetError(txtic, "Field is required!");
            }
            else if (char.IsDigit(c) == false)
            {
                erric.SetError(txtic, "Only numeric digits are allowed!");
            }
            else if (txtUsername.Text == "Enter Username")
            {
                errUsername.SetError(txtUsername, "Field is required!");
            }
            else if (txtUsername.Text.Contains(" ") )
            {
                errUsername.SetError(txtUsername, "Spaces are not allowed!");
            }
            else if (txtUsername.Text.Length <= 6 || txtUsername.Text.Length >= 50)
            {
                errUsername.SetError(txtUsername, "Username must be atleast 6 characters and not more than 50 characters");
            }
            else if (txtPassword.Text == "Enter Password")
            {
                errPassword.SetError(txtPassword, "Field is required!");
            }
            else if (txtPassword.Text.Contains(" ") )
            {
                errPassword.SetError(txtPassword, "Spaces are not allowed!");
            }
            else if (txtPassword.Text.Length <= 6 || txtPassword.Text.Length >= 128)
            {
                errPassword.SetError(txtPassword, "Password must be atleast 6 characters and not more than 128 characters");
            }
            else if (txtConfirmpass.Text != txtPassword.Text)
            {
                errConfirmpass.SetError(txtConfirmpass, "Passwords entered are not the same!");
            }
            else
            {
                VerifyCredential();            
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
            // Set progressbar's increment
            prgAdmin.Increment(10);
            if (prgAdmin.Value == 100)
            {
                tmrAdmin.Stop();
                prgAdmin.Value = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Start timer for progressbar
            tmrAdmin.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Start timer for progressbar
            tmrAdmin.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Start timer for progressbar
            tmrAdmin.Start();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoles_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disable combobox editing
            e.Handled = true;
        }

        private void cmbFilterby_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disable combobox editing
            e.Handled = true;
        }

        private void cdrStatistics_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Clearing tech profile and display new statistic in listbox if available
            ClearTechProfile();
            selectedMonth = cdrStatistics.SelectionRange.Start.Date.Month;
            Display_statistics();
        }
    }
}
