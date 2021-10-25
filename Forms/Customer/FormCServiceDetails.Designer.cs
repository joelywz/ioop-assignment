
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
            this.lblCustServTitle = new System.Windows.Forms.Label();
            this.grpCustServ = new System.Windows.Forms.GroupBox();
            this.btnCustServChg = new System.Windows.Forms.Button();
            this.btnCustServBack = new System.Windows.Forms.Button();
            this.lblCustServID = new System.Windows.Forms.Label();
            this.lblCustServDesc = new System.Windows.Forms.Label();
            this.lblCustServCol = new System.Windows.Forms.Label();
            this.lblCustServTotal = new System.Windows.Forms.Label();
            this.lblCustServDispID = new System.Windows.Forms.Label();
            this.lblCustServDispDesc = new System.Windows.Forms.Label();
            this.lblCustServDispCol = new System.Windows.Forms.Label();
            this.lblCustServDispTotal = new System.Windows.Forms.Label();
            this.grpCustServ.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustServTitle
            // 
            this.lblCustServTitle.AutoSize = true;
            this.lblCustServTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServTitle.Location = new System.Drawing.Point(36, 34);
            this.lblCustServTitle.Name = "lblCustServTitle";
            this.lblCustServTitle.Size = new System.Drawing.Size(169, 32);
            this.lblCustServTitle.TabIndex = 0;
            this.lblCustServTitle.Text = "Service Details";
            // 
            // grpCustServ
            // 
            this.grpCustServ.Controls.Add(this.lblCustServDispTotal);
            this.grpCustServ.Controls.Add(this.lblCustServDispCol);
            this.grpCustServ.Controls.Add(this.lblCustServDispDesc);
            this.grpCustServ.Controls.Add(this.lblCustServDispID);
            this.grpCustServ.Controls.Add(this.lblCustServTotal);
            this.grpCustServ.Controls.Add(this.lblCustServCol);
            this.grpCustServ.Controls.Add(this.lblCustServDesc);
            this.grpCustServ.Controls.Add(this.lblCustServID);
            this.grpCustServ.Location = new System.Drawing.Point(52, 82);
            this.grpCustServ.Name = "grpCustServ";
            this.grpCustServ.Size = new System.Drawing.Size(468, 336);
            this.grpCustServ.TabIndex = 1;
            this.grpCustServ.TabStop = false;
            // 
            // btnCustServChg
            // 
            this.btnCustServChg.Location = new System.Drawing.Point(581, 143);
            this.btnCustServChg.Name = "btnCustServChg";
            this.btnCustServChg.Size = new System.Drawing.Size(159, 27);
            this.btnCustServChg.TabIndex = 2;
            this.btnCustServChg.Text = "Change Service";
            this.btnCustServChg.UseVisualStyleBackColor = true;
            // 
            // btnCustServBack
            // 
            this.btnCustServBack.Location = new System.Drawing.Point(581, 214);
            this.btnCustServBack.Name = "btnCustServBack";
            this.btnCustServBack.Size = new System.Drawing.Size(159, 27);
            this.btnCustServBack.TabIndex = 3;
            this.btnCustServBack.Text = "Back";
            this.btnCustServBack.UseVisualStyleBackColor = true;
            // 
            // lblCustServID
            // 
            this.lblCustServID.AutoSize = true;
            this.lblCustServID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServID.Location = new System.Drawing.Point(24, 50);
            this.lblCustServID.Name = "lblCustServID";
            this.lblCustServID.Size = new System.Drawing.Size(146, 21);
            this.lblCustServID.TabIndex = 0;
            this.lblCustServID.Text = "Service (Service ID):";
            // 
            // lblCustServDesc
            // 
            this.lblCustServDesc.AutoSize = true;
            this.lblCustServDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServDesc.Location = new System.Drawing.Point(24, 99);
            this.lblCustServDesc.Name = "lblCustServDesc";
            this.lblCustServDesc.Size = new System.Drawing.Size(92, 21);
            this.lblCustServDesc.TabIndex = 1;
            this.lblCustServDesc.Text = "Description:";
            // 
            // lblCustServCol
            // 
            this.lblCustServCol.AutoSize = true;
            this.lblCustServCol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServCol.Location = new System.Drawing.Point(24, 150);
            this.lblCustServCol.Name = "lblCustServCol";
            this.lblCustServCol.Size = new System.Drawing.Size(165, 21);
            this.lblCustServCol.TabIndex = 2;
            this.lblCustServCol.Text = "Laptop collection date:";
            // 
            // lblCustServTotal
            // 
            this.lblCustServTotal.AutoSize = true;
            this.lblCustServTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServTotal.Location = new System.Drawing.Point(24, 201);
            this.lblCustServTotal.Name = "lblCustServTotal";
            this.lblCustServTotal.Size = new System.Drawing.Size(133, 21);
            this.lblCustServTotal.TabIndex = 3;
            this.lblCustServTotal.Text = "Total amount due:";
            // 
            // lblCustServDispID
            // 
            this.lblCustServDispID.AutoSize = true;
            this.lblCustServDispID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServDispID.Location = new System.Drawing.Point(255, 50);
            this.lblCustServDispID.Name = "lblCustServDispID";
            this.lblCustServDispID.Size = new System.Drawing.Size(115, 21);
            this.lblCustServDispID.TabIndex = 4;
            this.lblCustServDispID.Text = "_______________";
            // 
            // lblCustServDispDesc
            // 
            this.lblCustServDispDesc.AutoSize = true;
            this.lblCustServDispDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServDispDesc.Location = new System.Drawing.Point(255, 99);
            this.lblCustServDispDesc.Name = "lblCustServDispDesc";
            this.lblCustServDispDesc.Size = new System.Drawing.Size(115, 21);
            this.lblCustServDispDesc.TabIndex = 5;
            this.lblCustServDispDesc.Text = "_______________";
            // 
            // lblCustServDispCol
            // 
            this.lblCustServDispCol.AutoSize = true;
            this.lblCustServDispCol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServDispCol.Location = new System.Drawing.Point(255, 150);
            this.lblCustServDispCol.Name = "lblCustServDispCol";
            this.lblCustServDispCol.Size = new System.Drawing.Size(115, 21);
            this.lblCustServDispCol.TabIndex = 6;
            this.lblCustServDispCol.Text = "_______________";
            // 
            // lblCustServDispTotal
            // 
            this.lblCustServDispTotal.AutoSize = true;
            this.lblCustServDispTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustServDispTotal.Location = new System.Drawing.Point(255, 201);
            this.lblCustServDispTotal.Name = "lblCustServDispTotal";
            this.lblCustServDispTotal.Size = new System.Drawing.Size(115, 21);
            this.lblCustServDispTotal.TabIndex = 7;
            this.lblCustServDispTotal.Text = "_______________";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustServBack);
            this.Controls.Add(this.btnCustServChg);
            this.Controls.Add(this.grpCustServ);
            this.Controls.Add(this.lblCustServTitle);
            this.Name = "Form2";
            this.Text = "Service Details";
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
        private System.Windows.Forms.Label lblCustServDispCol;
        private System.Windows.Forms.Label lblCustServDispDesc;
        private System.Windows.Forms.Label lblCustServDispID;
        private System.Windows.Forms.Label lblCustServTotal;
        private System.Windows.Forms.Label lblCustServCol;
        private System.Windows.Forms.Label lblCustServDesc;
        private System.Windows.Forms.Label lblCustServID;
    }
}