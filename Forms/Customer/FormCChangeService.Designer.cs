
namespace Assignment.Forms.Customer
{
    partial class FormCChangeService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCChangeService));
            this.grpCustChangeSelect = new System.Windows.Forms.GroupBox();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.rdo8 = new System.Windows.Forms.RadioButton();
            this.rdo7 = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rdo6 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.lblCustChangeSelect = new System.Windows.Forms.Label();
            this.btnChangeService = new System.Windows.Forms.Button();
            this.btnCustChangeBack = new System.Windows.Forms.Button();
            this.chkCustChangeConfirm = new System.Windows.Forms.CheckBox();
            this.lblCustChangeTitle = new System.Windows.Forms.Label();
            this.grpCustChangeSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustChangeSelect
            // 
            this.grpCustChangeSelect.Controls.Add(this.chkUrgent);
            this.grpCustChangeSelect.Controls.Add(this.rdo8);
            this.grpCustChangeSelect.Controls.Add(this.rdo7);
            this.grpCustChangeSelect.Controls.Add(this.lblTotal);
            this.grpCustChangeSelect.Controls.Add(this.rdo6);
            this.grpCustChangeSelect.Controls.Add(this.rdo5);
            this.grpCustChangeSelect.Controls.Add(this.rdo4);
            this.grpCustChangeSelect.Controls.Add(this.rdo3);
            this.grpCustChangeSelect.Controls.Add(this.rdo2);
            this.grpCustChangeSelect.Controls.Add(this.rdo1);
            this.grpCustChangeSelect.Controls.Add(this.lblCustChangeSelect);
            this.grpCustChangeSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustChangeSelect.Location = new System.Drawing.Point(25, 55);
            this.grpCustChangeSelect.Name = "grpCustChangeSelect";
            this.grpCustChangeSelect.Size = new System.Drawing.Size(286, 344);
            this.grpCustChangeSelect.TabIndex = 1;
            this.grpCustChangeSelect.TabStop = false;
            this.grpCustChangeSelect.Text = "Service Menu";
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUrgent.Location = new System.Drawing.Point(13, 281);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(62, 19);
            this.chkUrgent.TabIndex = 9;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            this.chkUrgent.CheckedChanged += new System.EventHandler(this.chkUrgent_CheckedChanged);
            // 
            // rdo8
            // 
            this.rdo8.AutoSize = true;
            this.rdo8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo8.Location = new System.Drawing.Point(13, 237);
            this.rdo8.Name = "rdo8";
            this.rdo8.Size = new System.Drawing.Size(168, 19);
            this.rdo8.TabIndex = 8;
            this.rdo8.TabStop = true;
            this.rdo8.Text = "Internet connectivity issues";
            this.rdo8.UseVisualStyleBackColor = true;
            this.rdo8.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // rdo7
            // 
            this.rdo7.AutoSize = true;
            this.rdo7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo7.Location = new System.Drawing.Point(13, 212);
            this.rdo7.Name = "rdo7";
            this.rdo7.Size = new System.Drawing.Size(162, 19);
            this.rdo7.TabIndex = 7;
            this.rdo7.TabStop = true;
            this.rdo7.Text = "Data backup and recovery";
            this.rdo7.UseVisualStyleBackColor = true;
            this.rdo7.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(10, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 15);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: ";
            // 
            // rdo6
            // 
            this.rdo6.AutoSize = true;
            this.rdo6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo6.Location = new System.Drawing.Point(13, 187);
            this.rdo6.Name = "rdo6";
            this.rdo6.Size = new System.Drawing.Size(244, 19);
            this.rdo6.TabIndex = 6;
            this.rdo6.TabStop = true;
            this.rdo6.Text = "Operating System Format and Installation";
            this.rdo6.UseVisualStyleBackColor = true;
            this.rdo6.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo5.Location = new System.Drawing.Point(13, 162);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(171, 19);
            this.rdo5.TabIndex = 5;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "Laptop battery replacement";
            this.rdo5.UseVisualStyleBackColor = true;
            this.rdo5.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo4.Location = new System.Drawing.Point(13, 137);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(183, 19);
            this.rdo4.TabIndex = 4;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "Laptop keyboard replacement";
            this.rdo4.UseVisualStyleBackColor = true;
            this.rdo4.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo3.Location = new System.Drawing.Point(13, 112);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(168, 19);
            this.rdo3.TabIndex = 3;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "Laptop screen replacement";
            this.rdo3.UseVisualStyleBackColor = true;
            this.rdo3.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo2.Location = new System.Drawing.Point(13, 87);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(253, 19);
            this.rdo2.TabIndex = 2;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "Troubleshot and fix computer running slow";
            this.rdo2.UseVisualStyleBackColor = true;
            this.rdo2.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1.Location = new System.Drawing.Point(13, 62);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(152, 19);
            this.rdo1.TabIndex = 1;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "Remove virus / malware";
            this.rdo1.UseVisualStyleBackColor = true;
            this.rdo1.CheckedChanged += new System.EventHandler(this.rdo_Change);
            // 
            // lblCustChangeSelect
            // 
            this.lblCustChangeSelect.AutoSize = true;
            this.lblCustChangeSelect.Location = new System.Drawing.Point(10, 31);
            this.lblCustChangeSelect.Name = "lblCustChangeSelect";
            this.lblCustChangeSelect.Size = new System.Drawing.Size(87, 17);
            this.lblCustChangeSelect.TabIndex = 0;
            this.lblCustChangeSelect.Text = "Select Service";
            // 
            // btnChangeService
            // 
            this.btnChangeService.Enabled = false;
            this.btnChangeService.Location = new System.Drawing.Point(25, 439);
            this.btnChangeService.Name = "btnChangeService";
            this.btnChangeService.Size = new System.Drawing.Size(286, 27);
            this.btnChangeService.TabIndex = 12;
            this.btnChangeService.Text = "Change service";
            this.btnChangeService.UseVisualStyleBackColor = true;
            this.btnChangeService.Click += new System.EventHandler(this.btnChangeService_Click);
            // 
            // btnCustChangeBack
            // 
            this.btnCustChangeBack.Location = new System.Drawing.Point(25, 472);
            this.btnCustChangeBack.Name = "btnCustChangeBack";
            this.btnCustChangeBack.Size = new System.Drawing.Size(286, 27);
            this.btnCustChangeBack.TabIndex = 14;
            this.btnCustChangeBack.Text = "Back";
            this.btnCustChangeBack.UseVisualStyleBackColor = true;
            this.btnCustChangeBack.Click += new System.EventHandler(this.btnCustChangeBack_Click);
            // 
            // chkCustChangeConfirm
            // 
            this.chkCustChangeConfirm.AutoSize = true;
            this.chkCustChangeConfirm.Location = new System.Drawing.Point(25, 416);
            this.chkCustChangeConfirm.Name = "chkCustChangeConfirm";
            this.chkCustChangeConfirm.Size = new System.Drawing.Size(209, 17);
            this.chkCustChangeConfirm.TabIndex = 15;
            this.chkCustChangeConfirm.Text = "I have confirmed to change my service";
            this.chkCustChangeConfirm.UseVisualStyleBackColor = true;
            this.chkCustChangeConfirm.CheckedChanged += new System.EventHandler(this.chkCustChangeConfirm_CheckedChanged);
            // 
            // lblCustChangeTitle
            // 
            this.lblCustChangeTitle.AutoSize = true;
            this.lblCustChangeTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustChangeTitle.Location = new System.Drawing.Point(20, 9);
            this.lblCustChangeTitle.Name = "lblCustChangeTitle";
            this.lblCustChangeTitle.Size = new System.Drawing.Size(155, 30);
            this.lblCustChangeTitle.TabIndex = 17;
            this.lblCustChangeTitle.Text = "Change Service";
            // 
            // FormCChangeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(340, 521);
            this.Controls.Add(this.lblCustChangeTitle);
            this.Controls.Add(this.chkCustChangeConfirm);
            this.Controls.Add(this.btnCustChangeBack);
            this.Controls.Add(this.btnChangeService);
            this.Controls.Add(this.grpCustChangeSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCChangeService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brics Laptop Repair";
            this.Load += new System.EventHandler(this.FormCChangeService_Load);
            this.grpCustChangeSelect.ResumeLayout(false);
            this.grpCustChangeSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCustChangeSelect;
        private System.Windows.Forms.Label lblCustChangeSelect;
        private System.Windows.Forms.RadioButton rdo8;
        private System.Windows.Forms.RadioButton rdo7;
        private System.Windows.Forms.RadioButton rdo6;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnChangeService;
        private System.Windows.Forms.Button btnCustChangeBack;
        private System.Windows.Forms.CheckBox chkCustChangeConfirm;
        private System.Windows.Forms.Label lblCustChangeTitle;
    }
}