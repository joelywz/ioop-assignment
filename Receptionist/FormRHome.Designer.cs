
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
            this.button3 = new System.Windows.Forms.Button();
            this.listboxUsers = new System.Windows.Forms.ListBox();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.gbNewCustomer = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtboxRepeatPassword = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.gbViewUser = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbNewCustomer.SuspendLayout();
            this.gbViewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(360, 21);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(441, 21);
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
            this.txtboxSearch.Size = new System.Drawing.Size(161, 20);
            this.txtboxSearch.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listboxUsers
            // 
            this.listboxUsers.FormattingEnabled = true;
            this.listboxUsers.Location = new System.Drawing.Point(16, 52);
            this.listboxUsers.Name = "listboxUsers";
            this.listboxUsers.Size = new System.Drawing.Size(242, 173);
            this.listboxUsers.TabIndex = 3;
            // 
            // btnViewUser
            // 
            this.btnViewUser.Location = new System.Drawing.Point(16, 237);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(242, 30);
            this.btnViewUser.TabIndex = 4;
            this.btnViewUser.Text = "View Selected User";
            this.btnViewUser.UseVisualStyleBackColor = true;
            // 
            // gbNewCustomer
            // 
            this.gbNewCustomer.Controls.Add(this.txtboxRepeatPassword);
            this.gbNewCustomer.Controls.Add(this.btnNewCustomer);
            this.gbNewCustomer.Controls.Add(this.txtboxPassword);
            this.gbNewCustomer.Controls.Add(this.txtboxUsername);
            this.gbNewCustomer.Controls.Add(this.txtboxName);
            this.gbNewCustomer.Controls.Add(this.lblRepeatPassword);
            this.gbNewCustomer.Controls.Add(this.lblPassword);
            this.gbNewCustomer.Controls.Add(this.lblUsername);
            this.gbNewCustomer.Controls.Add(this.lblName);
            this.gbNewCustomer.Location = new System.Drawing.Point(303, 74);
            this.gbNewCustomer.Name = "gbNewCustomer";
            this.gbNewCustomer.Size = new System.Drawing.Size(261, 290);
            this.gbNewCustomer.TabIndex = 5;
            this.gbNewCustomer.TabStop = false;
            this.gbNewCustomer.Text = "New Customer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(10, 46);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(245, 20);
            this.txtboxName.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 78);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(10, 95);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(245, 20);
            this.txtboxUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(10, 146);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(245, 20);
            this.txtboxPassword.TabIndex = 1;
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Location = new System.Drawing.Point(7, 178);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(91, 13);
            this.lblRepeatPassword.TabIndex = 0;
            this.lblRepeatPassword.Text = "Repeat Password";
            // 
            // txtboxRepeatPassword
            // 
            this.txtboxRepeatPassword.Location = new System.Drawing.Point(10, 195);
            this.txtboxRepeatPassword.Name = "txtboxRepeatPassword";
            this.txtboxRepeatPassword.Size = new System.Drawing.Size(245, 20);
            this.txtboxRepeatPassword.TabIndex = 1;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(10, 237);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(245, 30);
            this.btnNewCustomer.TabIndex = 4;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // gbViewUser
            // 
            this.gbViewUser.Controls.Add(this.txtboxSearch);
            this.gbViewUser.Controls.Add(this.button3);
            this.gbViewUser.Controls.Add(this.btnViewUser);
            this.gbViewUser.Controls.Add(this.listboxUsers);
            this.gbViewUser.Location = new System.Drawing.Point(12, 74);
            this.gbViewUser.Name = "gbViewUser";
            this.gbViewUser.Size = new System.Drawing.Size(271, 290);
            this.gbViewUser.TabIndex = 6;
            this.gbViewUser.TabStop = false;
            this.gbViewUser.Text = "View User";
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
            // FormReceptionistHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 382);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbViewUser);
            this.Controls.Add(this.gbNewCustomer);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnLogOut);
            this.Name = "FormReceptionistHome";
            this.Text = "Receptionist Home";
            this.gbNewCustomer.ResumeLayout(false);
            this.gbNewCustomer.PerformLayout();
            this.gbViewUser.ResumeLayout(false);
            this.gbViewUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listboxUsers;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.GroupBox gbNewCustomer;
        private System.Windows.Forms.TextBox txtboxRepeatPassword;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbViewUser;
        private System.Windows.Forms.Label lblTitle;
    }
}