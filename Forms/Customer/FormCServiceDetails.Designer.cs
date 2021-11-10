
namespace Assignment
{
    partial class FormCServiceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCServiceDetails));
            this.lblCustServTitle = new System.Windows.Forms.Label();
            this.grpCustServ = new System.Windows.Forms.GroupBox();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.btnChangeService = new System.Windows.Forms.Button();
            this.lblCurServiceName = new System.Windows.Forms.Label();
            this.txtCurTotal = new System.Windows.Forms.TextBox();
            this.txtCurServiceCreated = new System.Windows.Forms.TextBox();
            this.txtCurServiceName = new System.Windows.Forms.TextBox();
            this.lblCurTotal = new System.Windows.Forms.Label();
            this.lblCurServiceCreated = new System.Windows.Forms.Label();
            this.btnCustServBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServiceCompleted = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtServiceCreated = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblServiceCompleted = new System.Windows.Forms.Label();
            this.lblServiceCreated = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServiceId = new System.Windows.Forms.Label();
            this.grpCustServ.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustServTitle
            // 
            this.lblCustServTitle.AutoSize = true;
            this.lblCustServTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblCustServTitle.Location = new System.Drawing.Point(18, 26);
            this.lblCustServTitle.Name = "lblCustServTitle";
            this.lblCustServTitle.Size = new System.Drawing.Size(170, 32);
            this.lblCustServTitle.TabIndex = 0;
            this.lblCustServTitle.Text = "Service Details";
            // 
            // grpCustServ
            // 
            this.grpCustServ.Controls.Add(this.chkUrgent);
            this.grpCustServ.Controls.Add(this.btnChangeService);
            this.grpCustServ.Controls.Add(this.lblCurServiceName);
            this.grpCustServ.Controls.Add(this.txtCurTotal);
            this.grpCustServ.Controls.Add(this.txtCurServiceCreated);
            this.grpCustServ.Controls.Add(this.txtCurServiceName);
            this.grpCustServ.Controls.Add(this.lblCurTotal);
            this.grpCustServ.Controls.Add(this.lblCurServiceCreated);
            this.grpCustServ.Location = new System.Drawing.Point(24, 71);
            this.grpCustServ.Name = "grpCustServ";
            this.grpCustServ.Size = new System.Drawing.Size(352, 159);
            this.grpCustServ.TabIndex = 1;
            this.grpCustServ.TabStop = false;
            this.grpCustServ.Text = "Current Service";
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Enabled = false;
            this.chkUrgent.Location = new System.Drawing.Point(279, 76);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(58, 17);
            this.chkUrgent.TabIndex = 3;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // btnChangeService
            // 
            this.btnChangeService.Enabled = false;
            this.btnChangeService.Location = new System.Drawing.Point(201, 116);
            this.btnChangeService.Name = "btnChangeService";
            this.btnChangeService.Size = new System.Drawing.Size(136, 23);
            this.btnChangeService.TabIndex = 2;
            this.btnChangeService.Text = "Change Service";
            this.btnChangeService.UseVisualStyleBackColor = true;
            this.btnChangeService.Click += new System.EventHandler(this.btnCustServChg_Click);
            // 
            // lblCurServiceName
            // 
            this.lblCurServiceName.AutoSize = true;
            this.lblCurServiceName.Location = new System.Drawing.Point(8, 16);
            this.lblCurServiceName.Name = "lblCurServiceName";
            this.lblCurServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblCurServiceName.TabIndex = 0;
            this.lblCurServiceName.Text = "Service Name";
            // 
            // txtCurTotal
            // 
            this.txtCurTotal.Enabled = false;
            this.txtCurTotal.Location = new System.Drawing.Point(10, 116);
            this.txtCurTotal.Name = "txtCurTotal";
            this.txtCurTotal.Size = new System.Drawing.Size(123, 20);
            this.txtCurTotal.TabIndex = 1;
            // 
            // txtCurServiceCreated
            // 
            this.txtCurServiceCreated.Enabled = false;
            this.txtCurServiceCreated.Location = new System.Drawing.Point(11, 76);
            this.txtCurServiceCreated.Name = "txtCurServiceCreated";
            this.txtCurServiceCreated.Size = new System.Drawing.Size(122, 20);
            this.txtCurServiceCreated.TabIndex = 1;
            // 
            // txtCurServiceName
            // 
            this.txtCurServiceName.Enabled = false;
            this.txtCurServiceName.Location = new System.Drawing.Point(11, 32);
            this.txtCurServiceName.Name = "txtCurServiceName";
            this.txtCurServiceName.Size = new System.Drawing.Size(326, 20);
            this.txtCurServiceName.TabIndex = 1;
            // 
            // lblCurTotal
            // 
            this.lblCurTotal.AutoSize = true;
            this.lblCurTotal.Location = new System.Drawing.Point(7, 100);
            this.lblCurTotal.Name = "lblCurTotal";
            this.lblCurTotal.Size = new System.Drawing.Size(31, 13);
            this.lblCurTotal.TabIndex = 0;
            this.lblCurTotal.Text = "Total";
            // 
            // lblCurServiceCreated
            // 
            this.lblCurServiceCreated.AutoSize = true;
            this.lblCurServiceCreated.Location = new System.Drawing.Point(6, 60);
            this.lblCurServiceCreated.Name = "lblCurServiceCreated";
            this.lblCurServiceCreated.Size = new System.Drawing.Size(83, 13);
            this.lblCurServiceCreated.TabIndex = 0;
            this.lblCurServiceCreated.Text = "Service Created";
            // 
            // btnCustServBack
            // 
            this.btnCustServBack.Location = new System.Drawing.Point(24, 507);
            this.btnCustServBack.Name = "btnCustServBack";
            this.btnCustServBack.Size = new System.Drawing.Size(352, 23);
            this.btnCustServBack.TabIndex = 3;
            this.btnCustServBack.Text = "Back";
            this.btnCustServBack.UseVisualStyleBackColor = true;
            this.btnCustServBack.Click += new System.EventHandler(this.btnCustServBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServiceCompleted);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtServiceCreated);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtServiceName);
            this.groupBox1.Controls.Add(this.txtServiceId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblServiceCompleted);
            this.groupBox1.Controls.Add(this.lblServiceCreated);
            this.groupBox1.Controls.Add(this.lblServiceName);
            this.groupBox1.Controls.Add(this.lblServiceId);
            this.groupBox1.Location = new System.Drawing.Point(24, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ready to be Collected";
            // 
            // txtServiceCompleted
            // 
            this.txtServiceCompleted.Enabled = false;
            this.txtServiceCompleted.Location = new System.Drawing.Point(237, 43);
            this.txtServiceCompleted.Name = "txtServiceCompleted";
            this.txtServiceCompleted.Size = new System.Drawing.Size(100, 20);
            this.txtServiceCompleted.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(11, 214);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(98, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtServiceCreated
            // 
            this.txtServiceCreated.Enabled = false;
            this.txtServiceCreated.Location = new System.Drawing.Point(123, 43);
            this.txtServiceCreated.Name = "txtServiceCreated";
            this.txtServiceCreated.Size = new System.Drawing.Size(100, 20);
            this.txtServiceCreated.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(9, 128);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(328, 58);
            this.txtDescription.TabIndex = 1;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Enabled = false;
            this.txtServiceName.Location = new System.Drawing.Point(9, 85);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(328, 20);
            this.txtServiceName.TabIndex = 1;
            // 
            // txtServiceId
            // 
            this.txtServiceId.Enabled = false;
            this.txtServiceId.Location = new System.Drawing.Point(9, 43);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(100, 20);
            this.txtServiceId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 112);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblServiceCompleted
            // 
            this.lblServiceCompleted.AutoSize = true;
            this.lblServiceCompleted.Location = new System.Drawing.Point(234, 27);
            this.lblServiceCompleted.Name = "lblServiceCompleted";
            this.lblServiceCompleted.Size = new System.Drawing.Size(96, 13);
            this.lblServiceCompleted.TabIndex = 0;
            this.lblServiceCompleted.Text = "Service Completed";
            // 
            // lblServiceCreated
            // 
            this.lblServiceCreated.AutoSize = true;
            this.lblServiceCreated.Location = new System.Drawing.Point(120, 27);
            this.lblServiceCreated.Name = "lblServiceCreated";
            this.lblServiceCreated.Size = new System.Drawing.Size(83, 13);
            this.lblServiceCreated.TabIndex = 0;
            this.lblServiceCreated.Text = "Service Created";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(8, 69);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblServiceId
            // 
            this.lblServiceId.AutoSize = true;
            this.lblServiceId.Location = new System.Drawing.Point(6, 27);
            this.lblServiceId.Name = "lblServiceId";
            this.lblServiceId.Size = new System.Drawing.Size(57, 13);
            this.lblServiceId.TabIndex = 0;
            this.lblServiceId.Text = "Service ID";
            // 
            // FormCServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(392, 551);
            this.Controls.Add(this.btnCustServBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCustServ);
            this.Controls.Add(this.lblCustServTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCServiceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brics Laptop Repair";
            this.Load += new System.EventHandler(this.FormCServiceDetails_Load);
            this.grpCustServ.ResumeLayout(false);
            this.grpCustServ.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustServTitle;
        private System.Windows.Forms.GroupBox grpCustServ;
        private System.Windows.Forms.Button btnChangeService;
        private System.Windows.Forms.Button btnCustServBack;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.Label lblCurServiceName;
        private System.Windows.Forms.TextBox txtCurTotal;
        private System.Windows.Forms.TextBox txtCurServiceCreated;
        private System.Windows.Forms.TextBox txtCurServiceName;
        private System.Windows.Forms.Label lblCurTotal;
        private System.Windows.Forms.Label lblCurServiceCreated;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServiceCompleted;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtServiceCreated;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblServiceCompleted;
        private System.Windows.Forms.Label lblServiceCreated;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceId;
    }
}