﻿
namespace Assignment
{
    partial class FormTHome
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFunctions = new System.Windows.Forms.GroupBox();
            this.rdpUpdateProfile = new System.Windows.Forms.RadioButton();
            this.rdoComplete = new System.Windows.Forms.RadioButton();
            this.rdoService = new System.Windows.Forms.RadioButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grpFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Technician Home\r\n";
            // 
            // grpFunctions
            // 
            this.grpFunctions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpFunctions.Controls.Add(this.rdpUpdateProfile);
            this.grpFunctions.Controls.Add(this.rdoComplete);
            this.grpFunctions.Controls.Add(this.rdoService);
            this.grpFunctions.Location = new System.Drawing.Point(10, 50);
            this.grpFunctions.Margin = new System.Windows.Forms.Padding(5);
            this.grpFunctions.MinimumSize = new System.Drawing.Size(294, 117);
            this.grpFunctions.Name = "grpFunctions";
            this.grpFunctions.Size = new System.Drawing.Size(387, 117);
            this.grpFunctions.TabIndex = 1;
            this.grpFunctions.TabStop = false;
            this.grpFunctions.Text = "Functions";
            // 
            // rdpUpdateProfile
            // 
            this.rdpUpdateProfile.AutoSize = true;
            this.rdpUpdateProfile.Location = new System.Drawing.Point(6, 75);
            this.rdpUpdateProfile.Name = "rdpUpdateProfile";
            this.rdpUpdateProfile.Size = new System.Drawing.Size(119, 21);
            this.rdpUpdateProfile.TabIndex = 2;
            this.rdpUpdateProfile.TabStop = true;
            this.rdpUpdateProfile.Text = "Update Profile";
            this.rdpUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // rdoComplete
            // 
            this.rdoComplete.AutoSize = true;
            this.rdoComplete.Location = new System.Drawing.Point(6, 48);
            this.rdoComplete.Name = "rdoComplete";
            this.rdoComplete.Size = new System.Drawing.Size(146, 21);
            this.rdoComplete.TabIndex = 1;
            this.rdoComplete.TabStop = true;
            this.rdoComplete.Text = "Complete Services";
            this.rdoComplete.UseVisualStyleBackColor = true;
            // 
            // rdoService
            // 
            this.rdoService.AutoSize = true;
            this.rdoService.Location = new System.Drawing.Point(6, 21);
            this.rdoService.Name = "rdoService";
            this.rdoService.Size = new System.Drawing.Size(116, 21);
            this.rdoService.TabIndex = 0;
            this.rdoService.TabStop = true;
            this.rdoService.Text = "View Services";
            this.rdoService.UseVisualStyleBackColor = true;
            // 
            // btnProceed
            // 
            this.btnProceed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProceed.Location = new System.Drawing.Point(10, 175);
            this.btnProceed.MinimumSize = new System.Drawing.Size(294, 27);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(387, 27);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Location = new System.Drawing.Point(10, 208);
            this.btnLogOut.MinimumSize = new System.Drawing.Size(294, 27);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(387, 27);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // techHome
            // 
            this.AcceptButton = this.btnProceed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(407, 245);
            this.Controls.Add(this.grpFunctions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnLogOut);
            this.MinimumSize = new System.Drawing.Size(425, 292);
            this.Name = "techHome";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technician Homepage";
            this.grpFunctions.ResumeLayout(false);
            this.grpFunctions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFunctions;
        private System.Windows.Forms.RadioButton rdpUpdateProfile;
        private System.Windows.Forms.RadioButton rdoComplete;
        private System.Windows.Forms.RadioButton rdoService;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnLogOut;
    }
}

