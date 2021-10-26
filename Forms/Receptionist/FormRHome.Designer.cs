
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.gbViewUser = new System.Windows.Forms.GroupBox();
            this.rdoEmail = new System.Windows.Forms.RadioButton();
            this.rdoUsername = new System.Windows.Forms.RadioButton();
            this.rdoFullName = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbViewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(208, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(289, 22);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(124, 23);
            this.btnUpdateProfile.TabIndex = 0;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(16, 24);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(210, 20);
            this.txtboxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(232, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(16, 92);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(369, 186);
            this.lstCustomers.TabIndex = 3;
            this.lstCustomers.SelectedValueChanged += new System.EventHandler(this.lstCustomers_SelectedValueChanged);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Location = new System.Drawing.Point(212, 291);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(173, 30);
            this.btnViewCustomer.TabIndex = 4;
            this.btnViewCustomer.Text = "View Customer";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // gbViewUser
            // 
            this.gbViewUser.Controls.Add(this.rdoEmail);
            this.gbViewUser.Controls.Add(this.rdoUsername);
            this.gbViewUser.Controls.Add(this.rdoFullName);
            this.gbViewUser.Controls.Add(this.txtboxSearch);
            this.gbViewUser.Controls.Add(this.btnReset);
            this.gbViewUser.Controls.Add(this.btnSearch);
            this.gbViewUser.Controls.Add(this.btnNewCustomer);
            this.gbViewUser.Controls.Add(this.btnViewCustomer);
            this.gbViewUser.Controls.Add(this.lstCustomers);
            this.gbViewUser.Location = new System.Drawing.Point(12, 74);
            this.gbViewUser.Name = "gbViewUser";
            this.gbViewUser.Size = new System.Drawing.Size(401, 343);
            this.gbViewUser.TabIndex = 6;
            this.gbViewUser.TabStop = false;
            this.gbViewUser.Text = "View Customers";
            // 
            // rdoEmail
            // 
            this.rdoEmail.AutoSize = true;
            this.rdoEmail.Location = new System.Drawing.Point(203, 60);
            this.rdoEmail.Name = "rdoEmail";
            this.rdoEmail.Size = new System.Drawing.Size(65, 17);
            this.rdoEmail.TabIndex = 5;
            this.rdoEmail.Text = "By Email";
            this.rdoEmail.UseVisualStyleBackColor = true;
            // 
            // rdoUsername
            // 
            this.rdoUsername.AutoSize = true;
            this.rdoUsername.Location = new System.Drawing.Point(109, 60);
            this.rdoUsername.Name = "rdoUsername";
            this.rdoUsername.Size = new System.Drawing.Size(88, 17);
            this.rdoUsername.TabIndex = 5;
            this.rdoUsername.Text = "By Username";
            this.rdoUsername.UseVisualStyleBackColor = true;
            // 
            // rdoFullName
            // 
            this.rdoFullName.AutoSize = true;
            this.rdoFullName.Location = new System.Drawing.Point(16, 60);
            this.rdoFullName.Name = "rdoFullName";
            this.rdoFullName.Size = new System.Drawing.Size(87, 17);
            this.rdoFullName.TabIndex = 5;
            this.rdoFullName.Text = "By Full Name";
            this.rdoFullName.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(315, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(16, 291);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(173, 30);
            this.btnNewCustomer.TabIndex = 4;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Receptionist Home";
            // 
            // FormRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 429);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbViewUser);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnLogOut);
            this.Name = "FormRHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist Home";
            this.Load += new System.EventHandler(this.FormRHome_Load);
            this.gbViewUser.ResumeLayout(false);
            this.gbViewUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.GroupBox gbViewUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdoUsername;
        private System.Windows.Forms.RadioButton rdoFullName;
        private System.Windows.Forms.RadioButton rdoEmail;
    }
}