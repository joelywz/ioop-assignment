
namespace Assignment
{
    partial class FormRHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRHome));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstCust = new System.Windows.Forms.ListBox();
            this.grpViewCust = new System.Windows.Forms.GroupBox();
            this.chkNotPaid = new System.Windows.Forms.CheckBox();
            this.rdoEmail = new System.Windows.Forms.RadioButton();
            this.rdoUsername = new System.Windows.Forms.RadioButton();
            this.rdoFullName = new System.Windows.Forms.RadioButton();
            this.btnRefersh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnService = new System.Windows.Forms.Button();
            this.btnViewPayment = new System.Windows.Forms.Button();
            this.grpSelectedCust = new System.Windows.Forms.GroupBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpViewCust.SuspendLayout();
            this.grpSelectedCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(437, 18);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(518, 18);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(124, 23);
            this.btnUpdateProfile.TabIndex = 0;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(233, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstCust
            // 
            this.lstCust.FormattingEnabled = true;
            this.lstCust.Location = new System.Drawing.Point(13, 105);
            this.lstCust.Margin = new System.Windows.Forms.Padding(2);
            this.lstCust.Name = "lstCust";
            this.lstCust.Size = new System.Drawing.Size(369, 199);
            this.lstCust.TabIndex = 3;
            this.lstCust.SelectedValueChanged += new System.EventHandler(this.lstCustomers_SelectedValueChanged);
            // 
            // grpViewCust
            // 
            this.grpViewCust.Controls.Add(this.chkNotPaid);
            this.grpViewCust.Controls.Add(this.rdoEmail);
            this.grpViewCust.Controls.Add(this.rdoUsername);
            this.grpViewCust.Controls.Add(this.rdoFullName);
            this.grpViewCust.Controls.Add(this.txtSearch);
            this.grpViewCust.Controls.Add(this.btnRefersh);
            this.grpViewCust.Controls.Add(this.btnReset);
            this.grpViewCust.Controls.Add(this.btnSearch);
            this.grpViewCust.Controls.Add(this.btnNewCustomer);
            this.grpViewCust.Controls.Add(this.lstCust);
            this.grpViewCust.Location = new System.Drawing.Point(11, 50);
            this.grpViewCust.Margin = new System.Windows.Forms.Padding(2);
            this.grpViewCust.Name = "grpViewCust";
            this.grpViewCust.Padding = new System.Windows.Forms.Padding(2);
            this.grpViewCust.Size = new System.Drawing.Size(392, 375);
            this.grpViewCust.TabIndex = 6;
            this.grpViewCust.TabStop = false;
            this.grpViewCust.Text = "View Customers";
            // 
            // chkNotPaid
            // 
            this.chkNotPaid.AutoSize = true;
            this.chkNotPaid.Location = new System.Drawing.Point(18, 83);
            this.chkNotPaid.Name = "chkNotPaid";
            this.chkNotPaid.Size = new System.Drawing.Size(162, 17);
            this.chkNotPaid.TabIndex = 6;
            this.chkNotPaid.Text = "Outstanding Payment(s) Only";
            this.chkNotPaid.UseVisualStyleBackColor = true;
            this.chkNotPaid.CheckedChanged += new System.EventHandler(this.chkNotPaid_CheckedChanged);
            // 
            // rdoEmail
            // 
            this.rdoEmail.AutoSize = true;
            this.rdoEmail.Location = new System.Drawing.Point(204, 53);
            this.rdoEmail.Name = "rdoEmail";
            this.rdoEmail.Size = new System.Drawing.Size(65, 17);
            this.rdoEmail.TabIndex = 5;
            this.rdoEmail.Text = "By Email";
            this.rdoEmail.UseVisualStyleBackColor = true;
            // 
            // rdoUsername
            // 
            this.rdoUsername.AutoSize = true;
            this.rdoUsername.Location = new System.Drawing.Point(110, 53);
            this.rdoUsername.Name = "rdoUsername";
            this.rdoUsername.Size = new System.Drawing.Size(88, 17);
            this.rdoUsername.TabIndex = 5;
            this.rdoUsername.Text = "By Username";
            this.rdoUsername.UseVisualStyleBackColor = true;
            // 
            // rdoFullName
            // 
            this.rdoFullName.AutoSize = true;
            this.rdoFullName.Location = new System.Drawing.Point(17, 53);
            this.rdoFullName.Name = "rdoFullName";
            this.rdoFullName.Size = new System.Drawing.Size(87, 17);
            this.rdoFullName.TabIndex = 5;
            this.rdoFullName.Text = "By Full Name";
            this.rdoFullName.UseVisualStyleBackColor = true;
            // 
            // btnRefersh
            // 
            this.btnRefersh.Location = new System.Drawing.Point(316, 50);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(70, 23);
            this.btnRefersh.TabIndex = 2;
            this.btnRefersh.Text = "Refresh";
            this.btnRefersh.UseVisualStyleBackColor = true;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(316, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 22);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(13, 326);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(369, 30);
            this.btnNewCustomer.TabIndex = 4;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Receptionist Home";
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(9, 290);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(206, 30);
            this.btnService.TabIndex = 10;
            this.btnService.Text = "Add Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnViewPayment
            // 
            this.btnViewPayment.Location = new System.Drawing.Point(10, 326);
            this.btnViewPayment.Name = "btnViewPayment";
            this.btnViewPayment.Size = new System.Drawing.Size(206, 30);
            this.btnViewPayment.TabIndex = 11;
            this.btnViewPayment.Text = "View Payment and Receipt";
            this.btnViewPayment.UseVisualStyleBackColor = true;
            this.btnViewPayment.Click += new System.EventHandler(this.btnViewPayment_Click);
            // 
            // grpSelectedCust
            // 
            this.grpSelectedCust.Controls.Add(this.txtPhoneNo);
            this.grpSelectedCust.Controls.Add(this.txtEmail);
            this.grpSelectedCust.Controls.Add(this.txtUsername);
            this.grpSelectedCust.Controls.Add(this.txtFullName);
            this.grpSelectedCust.Controls.Add(this.btnService);
            this.grpSelectedCust.Controls.Add(this.lblEmail);
            this.grpSelectedCust.Controls.Add(this.btnViewPayment);
            this.grpSelectedCust.Controls.Add(this.lblPhoneNo);
            this.grpSelectedCust.Controls.Add(this.lblPaymentStatus);
            this.grpSelectedCust.Controls.Add(this.lblUsername);
            this.grpSelectedCust.Controls.Add(this.lblName);
            this.grpSelectedCust.Location = new System.Drawing.Point(414, 50);
            this.grpSelectedCust.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelectedCust.Name = "grpSelectedCust";
            this.grpSelectedCust.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelectedCust.Size = new System.Drawing.Size(228, 375);
            this.grpSelectedCust.TabIndex = 8;
            this.grpSelectedCust.TabStop = false;
            this.grpSelectedCust.Text = "Selected Customer";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Enabled = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(9, 157);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(206, 20);
            this.txtPhoneNo.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(9, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(9, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 20);
            this.txtUsername.TabIndex = 12;
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(9, 36);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(206, 20);
            this.txtFullName.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEmail.Location = new System.Drawing.Point(6, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPhoneNo.Location = new System.Drawing.Point(6, 141);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNo.TabIndex = 0;
            this.lblPhoneNo.Text = "Phone Number:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPaymentStatus.Location = new System.Drawing.Point(6, 202);
            this.lblPaymentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(54, 13);
            this.lblPaymentStatus.TabIndex = 0;
            this.lblPaymentStatus.Text = "Payment: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblUsername.Location = new System.Drawing.Point(6, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment.Properties.Resources.Group_3brics;
            this.pictureBox1.Location = new System.Drawing.Point(163, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(654, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpSelectedCust);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpViewCust);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brics Laptop Repair";
            this.Load += new System.EventHandler(this.FormRHome_Load);
            this.grpViewCust.ResumeLayout(false);
            this.grpViewCust.PerformLayout();
            this.grpSelectedCust.ResumeLayout(false);
            this.grpSelectedCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstCust;
        private System.Windows.Forms.GroupBox grpViewCust;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdoUsername;
        private System.Windows.Forms.RadioButton rdoFullName;
        private System.Windows.Forms.RadioButton rdoEmail;
        private System.Windows.Forms.CheckBox chkNotPaid;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnViewPayment;
        private System.Windows.Forms.GroupBox grpSelectedCust;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRefersh;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}