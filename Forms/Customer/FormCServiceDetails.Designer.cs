
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
            this.lblCustServDispTotal = new System.Windows.Forms.Label();
            this.lblCustServDispDesc = new System.Windows.Forms.Label();
            this.lblCustServDispID = new System.Windows.Forms.Label();
            this.lblCustServTotal = new System.Windows.Forms.Label();
            this.lblCustServDesc = new System.Windows.Forms.Label();
            this.lblCustServID = new System.Windows.Forms.Label();
            this.btnCustServChg = new System.Windows.Forms.Button();
            this.btnCustServBack = new System.Windows.Forms.Button();
            this.grpCustServ.SuspendLayout();
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
            this.grpCustServ.Controls.Add(this.lblCustServDispTotal);
            this.grpCustServ.Controls.Add(this.lblCustServDispDesc);
            this.grpCustServ.Controls.Add(this.lblCustServDispID);
            this.grpCustServ.Controls.Add(this.lblCustServTotal);
            this.grpCustServ.Controls.Add(this.lblCustServDesc);
            this.grpCustServ.Controls.Add(this.lblCustServID);
            this.grpCustServ.Location = new System.Drawing.Point(24, 70);
            this.grpCustServ.Name = "grpCustServ";
            this.grpCustServ.Size = new System.Drawing.Size(401, 201);
            this.grpCustServ.TabIndex = 1;
            this.grpCustServ.TabStop = false;
            // 
            // lblCustServDispTotal
            // 
            this.lblCustServDispTotal.AutoSize = true;
            this.lblCustServDispTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustServDispTotal.Location = new System.Drawing.Point(180, 135);
            this.lblCustServDispTotal.Name = "lblCustServDispTotal";
            this.lblCustServDispTotal.Size = new System.Drawing.Size(115, 21);
            this.lblCustServDispTotal.TabIndex = 7;
            this.lblCustServDispTotal.Text = "_______________";
            // 
            // lblCustServDispDesc
            // 
            this.lblCustServDispDesc.AutoSize = true;
            this.lblCustServDispDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustServDispDesc.Location = new System.Drawing.Point(180, 86);
            this.lblCustServDispDesc.Name = "lblCustServDispDesc";
            this.lblCustServDispDesc.Size = new System.Drawing.Size(115, 21);
            this.lblCustServDispDesc.TabIndex = 5;
            this.lblCustServDispDesc.Text = "_______________";
            // 
            // lblCustServDispID
            // 
            this.lblCustServDispID.AutoSize = true;
            this.lblCustServDispID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustServDispID.Location = new System.Drawing.Point(180, 43);
            this.lblCustServDispID.Name = "lblCustServDispID";
            this.lblCustServDispID.Size = new System.Drawing.Size(115, 21);
            this.lblCustServDispID.TabIndex = 4;
            this.lblCustServDispID.Text = "_______________";
            // 
            // lblCustServTotal
            // 
            this.lblCustServTotal.AutoSize = true;
            this.lblCustServTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustServTotal.Location = new System.Drawing.Point(10, 135);
            this.lblCustServTotal.Name = "lblCustServTotal";
            this.lblCustServTotal.Size = new System.Drawing.Size(69, 21);
            this.lblCustServTotal.TabIndex = 3;
            this.lblCustServTotal.Text = "Amount:";
            // 
            // lblCustServDesc
            // 
            this.lblCustServDesc.AutoSize = true;
            this.lblCustServDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustServDesc.Location = new System.Drawing.Point(10, 86);
            this.lblCustServDesc.Name = "lblCustServDesc";
            this.lblCustServDesc.Size = new System.Drawing.Size(92, 21);
            this.lblCustServDesc.TabIndex = 1;
            this.lblCustServDesc.Text = "Description:";
            // 
            // lblCustServID
            // 
            this.lblCustServID.AutoSize = true;
            this.lblCustServID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustServID.Location = new System.Drawing.Point(10, 43);
            this.lblCustServID.Name = "lblCustServID";
            this.lblCustServID.Size = new System.Drawing.Size(146, 21);
            this.lblCustServID.TabIndex = 0;
            this.lblCustServID.Text = "Service (Service ID):";
            // 
            // btnCustServChg
            // 
            this.btnCustServChg.Location = new System.Drawing.Point(144, 292);
            this.btnCustServChg.Name = "btnCustServChg";
            this.btnCustServChg.Size = new System.Drawing.Size(136, 23);
            this.btnCustServChg.TabIndex = 2;
            this.btnCustServChg.Text = "Change Service";
            this.btnCustServChg.UseVisualStyleBackColor = true;
            this.btnCustServChg.Click += new System.EventHandler(this.btnCustServChg_Click);
            // 
            // btnCustServBack
            // 
            this.btnCustServBack.Location = new System.Drawing.Point(144, 342);
            this.btnCustServBack.Name = "btnCustServBack";
            this.btnCustServBack.Size = new System.Drawing.Size(136, 23);
            this.btnCustServBack.TabIndex = 3;
            this.btnCustServBack.Text = "Back";
            this.btnCustServBack.UseVisualStyleBackColor = true;
            this.btnCustServBack.Click += new System.EventHandler(this.btnCustServBack_Click);
            // 
            // FormCServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 390);
            this.Controls.Add(this.btnCustServBack);
            this.Controls.Add(this.btnCustServChg);
            this.Controls.Add(this.grpCustServ);
            this.Controls.Add(this.lblCustServTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCServiceDetails";
            this.Text = "Brics Laptop Repair";
            this.grpCustServ.ResumeLayout(false);
            this.grpCustServ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustServTitle;
        private System.Windows.Forms.GroupBox grpCustServ;
        private System.Windows.Forms.Button btnCustServChg;
        private System.Windows.Forms.Button btnCustServBack;
        private System.Windows.Forms.Label lblCustServDispTotal;
        private System.Windows.Forms.Label lblCustServDispDesc;
        private System.Windows.Forms.Label lblCustServDispID;
        private System.Windows.Forms.Label lblCustServTotal;
        private System.Windows.Forms.Label lblCustServDesc;
        private System.Windows.Forms.Label lblCustServID;
    }
}