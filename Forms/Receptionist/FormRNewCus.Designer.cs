﻿
namespace Assignment.Forms.Receptionist
{
    partial class FormRNewCus
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
            this.gbNewCustomer = new System.Windows.Forms.GroupBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewCustomer
            // 
            this.gbNewCustomer.Controls.Add(this.txtPhoneNo);
            this.gbNewCustomer.Controls.Add(this.txtEmail);
            this.gbNewCustomer.Controls.Add(this.txtRepeatPassword);
            this.gbNewCustomer.Controls.Add(this.btnNewCustomer);
            this.gbNewCustomer.Controls.Add(this.txtPassword);
            this.gbNewCustomer.Controls.Add(this.txtUsername);
            this.gbNewCustomer.Controls.Add(this.txtName);
            this.gbNewCustomer.Controls.Add(this.lblPhoneNo);
            this.gbNewCustomer.Controls.Add(this.lblEmail);
            this.gbNewCustomer.Controls.Add(this.lblRepeatPassword);
            this.gbNewCustomer.Controls.Add(this.lblPassword);
            this.gbNewCustomer.Controls.Add(this.lblUsername);
            this.gbNewCustomer.Controls.Add(this.lblName);
            this.gbNewCustomer.Location = new System.Drawing.Point(12, 58);
            this.gbNewCustomer.Name = "gbNewCustomer";
            this.gbNewCustomer.Size = new System.Drawing.Size(269, 404);
            this.gbNewCustomer.TabIndex = 6;
            this.gbNewCustomer.TabStop = false;
            this.gbNewCustomer.Text = "New Customer";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(10, 302);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(245, 20);
            this.txtPhoneNo.TabIndex = 6;
            this.txtPhoneNo.Text = "012-35896478";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(10, 195);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(245, 20);
            this.txtRepeatPassword.TabIndex = 4;
            this.txtRepeatPassword.Text = "samueljackson";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(10, 350);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(245, 30);
            this.btnNewCustomer.TabIndex = 7;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "samueljackson";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(10, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "samueljackson";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Samuel Jackson";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(7, 285);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNo.TabIndex = 0;
            this.lblPhoneNo.Text = "Phone Number";
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
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Customer";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(269, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "samueljackson@yahoo.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // FormRNewCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbNewCustomer);
            this.Controls.Add(this.btnClose);
            this.Name = "FormRNewCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.gbNewCustomer.ResumeLayout(false);
            this.gbNewCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewCustomer;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}