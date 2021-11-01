
namespace Assignment
{
    partial class FormCProfile
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
            this.lblCustProfUser = new System.Windows.Forms.Label();
            this.lblCustProfServ = new System.Windows.Forms.Label();
            this.grpCustProfServ = new System.Windows.Forms.GroupBox();
            this.lblCustProfDispServ = new System.Windows.Forms.Label();
            this.grpCustProf = new System.Windows.Forms.GroupBox();
            this.lblCustProfDispPhone = new System.Windows.Forms.Label();
            this.lblCustProfPhone = new System.Windows.Forms.Label();
            this.lblCustProfDispEmail = new System.Windows.Forms.Label();
            this.lblCustProfEmail = new System.Windows.Forms.Label();
            this.lblCustProfDispDOB = new System.Windows.Forms.Label();
            this.lblCustProfDOB = new System.Windows.Forms.Label();
            this.lblCustProfDispName = new System.Windows.Forms.Label();
            this.lblCustProfName = new System.Windows.Forms.Label();
            this.btnCustProfServ = new System.Windows.Forms.Button();
            this.btnCustProfChgProf = new System.Windows.Forms.Button();
            this.btnCustProfBack = new System.Windows.Forms.Button();
            this.grpCustProfServ.SuspendLayout();
            this.grpCustProf.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustProfUser
            // 
            this.lblCustProfUser.AutoSize = true;
            this.lblCustProfUser.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblCustProfUser.Location = new System.Drawing.Point(29, 34);
            this.lblCustProfUser.Name = "lblCustProfUser";
            this.lblCustProfUser.Size = new System.Drawing.Size(103, 32);
            this.lblCustProfUser.TabIndex = 0;
            this.lblCustProfUser.Text = "chris123";
            // 
            // lblCustProfServ
            // 
            this.lblCustProfServ.AutoSize = true;
            this.lblCustProfServ.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblCustProfServ.Location = new System.Drawing.Point(377, 39);
            this.lblCustProfServ.Name = "lblCustProfServ";
            this.lblCustProfServ.Size = new System.Drawing.Size(231, 25);
            this.lblCustProfServ.TabIndex = 1;
            this.lblCustProfServ.Text = "Current/upcoming service";
            // 
            // grpCustProfServ
            // 
            this.grpCustProfServ.Controls.Add(this.lblCustProfDispServ);
            this.grpCustProfServ.Location = new System.Drawing.Point(394, 63);
            this.grpCustProfServ.Name = "grpCustProfServ";
            this.grpCustProfServ.Size = new System.Drawing.Size(260, 80);
            this.grpCustProfServ.TabIndex = 2;
            this.grpCustProfServ.TabStop = false;
            // 
            // lblCustProfDispServ
            // 
            this.lblCustProfDispServ.AutoSize = true;
            this.lblCustProfDispServ.Location = new System.Drawing.Point(11, 16);
            this.lblCustProfDispServ.Name = "lblCustProfDispServ";
            this.lblCustProfDispServ.Size = new System.Drawing.Size(72, 13);
            this.lblCustProfDispServ.TabIndex = 0;
            this.lblCustProfDispServ.Text = "Remove virus";
            // 
            // grpCustProf
            // 
            this.grpCustProf.Controls.Add(this.lblCustProfDispPhone);
            this.grpCustProf.Controls.Add(this.lblCustProfPhone);
            this.grpCustProf.Controls.Add(this.lblCustProfDispEmail);
            this.grpCustProf.Controls.Add(this.lblCustProfEmail);
            this.grpCustProf.Controls.Add(this.lblCustProfDispDOB);
            this.grpCustProf.Controls.Add(this.lblCustProfDOB);
            this.grpCustProf.Controls.Add(this.lblCustProfDispName);
            this.grpCustProf.Controls.Add(this.lblCustProfName);
            this.grpCustProf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpCustProf.Location = new System.Drawing.Point(44, 72);
            this.grpCustProf.Name = "grpCustProf";
            this.grpCustProf.Size = new System.Drawing.Size(291, 282);
            this.grpCustProf.TabIndex = 3;
            this.grpCustProf.TabStop = false;
            this.grpCustProf.Text = "Personal Info";
            // 
            // lblCustProfDispPhone
            // 
            this.lblCustProfDispPhone.AutoSize = true;
            this.lblCustProfDispPhone.Location = new System.Drawing.Point(63, 242);
            this.lblCustProfDispPhone.Name = "lblCustProfDispPhone";
            this.lblCustProfDispPhone.Size = new System.Drawing.Size(100, 21);
            this.lblCustProfDispPhone.TabIndex = 9;
            this.lblCustProfDispPhone.Text = "0123456789";
            // 
            // lblCustProfPhone
            // 
            this.lblCustProfPhone.AutoSize = true;
            this.lblCustProfPhone.Location = new System.Drawing.Point(18, 214);
            this.lblCustProfPhone.Name = "lblCustProfPhone";
            this.lblCustProfPhone.Size = new System.Drawing.Size(116, 21);
            this.lblCustProfPhone.TabIndex = 8;
            this.lblCustProfPhone.Text = "Phone Number";
            // 
            // lblCustProfDispEmail
            // 
            this.lblCustProfDispEmail.AutoSize = true;
            this.lblCustProfDispEmail.Location = new System.Drawing.Point(63, 177);
            this.lblCustProfDispEmail.Name = "lblCustProfDispEmail";
            this.lblCustProfDispEmail.Size = new System.Drawing.Size(145, 21);
            this.lblCustProfDispEmail.TabIndex = 7;
            this.lblCustProfDispEmail.Text = "johndoe@mail.com";
            // 
            // lblCustProfEmail
            // 
            this.lblCustProfEmail.AutoSize = true;
            this.lblCustProfEmail.Location = new System.Drawing.Point(18, 148);
            this.lblCustProfEmail.Name = "lblCustProfEmail";
            this.lblCustProfEmail.Size = new System.Drawing.Size(54, 21);
            this.lblCustProfEmail.TabIndex = 6;
            this.lblCustProfEmail.Text = "E-mail";
            // 
            // lblCustProfDispDOB
            // 
            this.lblCustProfDispDOB.AutoSize = true;
            this.lblCustProfDispDOB.Location = new System.Drawing.Point(63, 118);
            this.lblCustProfDispDOB.Name = "lblCustProfDispDOB";
            this.lblCustProfDispDOB.Size = new System.Drawing.Size(76, 21);
            this.lblCustProfDispDOB.TabIndex = 5;
            this.lblCustProfDispDOB.Text = "1/1/1991";
            // 
            // lblCustProfDOB
            // 
            this.lblCustProfDOB.AutoSize = true;
            this.lblCustProfDOB.Location = new System.Drawing.Point(18, 89);
            this.lblCustProfDOB.Name = "lblCustProfDOB";
            this.lblCustProfDOB.Size = new System.Drawing.Size(97, 21);
            this.lblCustProfDOB.TabIndex = 4;
            this.lblCustProfDOB.Text = "Date of birth";
            // 
            // lblCustProfDispName
            // 
            this.lblCustProfDispName.AutoSize = true;
            this.lblCustProfDispName.Location = new System.Drawing.Point(63, 53);
            this.lblCustProfDispName.Name = "lblCustProfDispName";
            this.lblCustProfDispName.Size = new System.Drawing.Size(75, 21);
            this.lblCustProfDispName.TabIndex = 1;
            this.lblCustProfDispName.Text = "John Doe";
            // 
            // lblCustProfName
            // 
            this.lblCustProfName.AutoSize = true;
            this.lblCustProfName.Location = new System.Drawing.Point(18, 31);
            this.lblCustProfName.Name = "lblCustProfName";
            this.lblCustProfName.Size = new System.Drawing.Size(52, 21);
            this.lblCustProfName.TabIndex = 0;
            this.lblCustProfName.Text = "Name";
            // 
            // btnCustProfServ
            // 
            this.btnCustProfServ.Location = new System.Drawing.Point(423, 178);
            this.btnCustProfServ.Name = "btnCustProfServ";
            this.btnCustProfServ.Size = new System.Drawing.Size(207, 24);
            this.btnCustProfServ.TabIndex = 4;
            this.btnCustProfServ.Text = "View service details";
            this.btnCustProfServ.UseVisualStyleBackColor = true;
            this.btnCustProfServ.Click += new System.EventHandler(this.btnCustProfServ_Click);
            // 
            // btnCustProfChgProf
            // 
            this.btnCustProfChgProf.Location = new System.Drawing.Point(423, 220);
            this.btnCustProfChgProf.Name = "btnCustProfChgProf";
            this.btnCustProfChgProf.Size = new System.Drawing.Size(207, 24);
            this.btnCustProfChgProf.TabIndex = 5;
            this.btnCustProfChgProf.Text = "Update profile details";
            this.btnCustProfChgProf.UseVisualStyleBackColor = true;
            this.btnCustProfChgProf.Click += new System.EventHandler(this.btnCustProfChgProf_Click);
            // 
            // btnCustProfBack
            // 
            this.btnCustProfBack.Location = new System.Drawing.Point(423, 314);
            this.btnCustProfBack.Name = "btnCustProfBack";
            this.btnCustProfBack.Size = new System.Drawing.Size(207, 24);
            this.btnCustProfBack.TabIndex = 7;
            this.btnCustProfBack.Text = "Back";
            this.btnCustProfBack.UseVisualStyleBackColor = true;
            this.btnCustProfBack.Click += new System.EventHandler(this.btnCustProfBack_Click);
            // 
            // FormCProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnCustProfBack);
            this.Controls.Add(this.btnCustProfChgProf);
            this.Controls.Add(this.btnCustProfServ);
            this.Controls.Add(this.grpCustProf);
            this.Controls.Add(this.grpCustProfServ);
            this.Controls.Add(this.lblCustProfServ);
            this.Controls.Add(this.lblCustProfUser);
            this.Name = "FormCProfile";
            this.Text = "Profile";
            this.grpCustProfServ.ResumeLayout(false);
            this.grpCustProfServ.PerformLayout();
            this.grpCustProf.ResumeLayout(false);
            this.grpCustProf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustProfUser;
        private System.Windows.Forms.Label lblCustProfServ;
        private System.Windows.Forms.GroupBox grpCustProfServ;
        private System.Windows.Forms.Label lblCustProfDispServ;
        private System.Windows.Forms.GroupBox grpCustProf;
        private System.Windows.Forms.Label lblCustProfDispPhone;
        private System.Windows.Forms.Label lblCustProfPhone;
        private System.Windows.Forms.Label lblCustProfDispEmail;
        private System.Windows.Forms.Label lblCustProfEmail;
        private System.Windows.Forms.Label lblCustProfDispDOB;
        private System.Windows.Forms.Label lblCustProfDOB;
        private System.Windows.Forms.Label lblCustProfDispName;
        private System.Windows.Forms.Label lblCustProfName;
        private System.Windows.Forms.Button btnCustProfServ;
        private System.Windows.Forms.Button btnCustProfChgProf;
        private System.Windows.Forms.Button btnCustProfBack;
    }
}