
namespace Assignment
{
    partial class FormRPaymentReceipt
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
            this.grpPayments = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.rdoSettled = new System.Windows.Forms.RadioButton();
            this.rdoOutstanding = new System.Windows.Forms.RadioButton();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.grpReceipt = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtServiceCompleted = new System.Windows.Forms.TextBox();
            this.txtServiceCreated = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblServiceId = new System.Windows.Forms.Label();
            this.btnPaid = new System.Windows.Forms.Button();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblServiceCompleted = new System.Windows.Forms.Label();
            this.lblServiceCreated = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpPayments.SuspendLayout();
            this.grpReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment and Receipt";
            // 
            // grpPayments
            // 
            this.grpPayments.Controls.Add(this.btnRefresh);
            this.grpPayments.Controls.Add(this.btnFilter);
            this.grpPayments.Controls.Add(this.rdoSettled);
            this.grpPayments.Controls.Add(this.rdoOutstanding);
            this.grpPayments.Controls.Add(this.lstPayments);
            this.grpPayments.Controls.Add(this.rdoAll);
            this.grpPayments.Location = new System.Drawing.Point(16, 59);
            this.grpPayments.Name = "grpPayments";
            this.grpPayments.Size = new System.Drawing.Size(388, 372);
            this.grpPayments.TabIndex = 1;
            this.grpPayments.TabStop = false;
            this.grpPayments.Text = "Payments";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(309, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(15, 92);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(142, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // rdoSettled
            // 
            this.rdoSettled.AutoSize = true;
            this.rdoSettled.Location = new System.Drawing.Point(15, 69);
            this.rdoSettled.Name = "rdoSettled";
            this.rdoSettled.Size = new System.Drawing.Size(82, 17);
            this.rdoSettled.TabIndex = 0;
            this.rdoSettled.TabStop = true;
            this.rdoSettled.Text = "Settled Only";
            this.rdoSettled.UseVisualStyleBackColor = true;
            // 
            // rdoOutstanding
            // 
            this.rdoOutstanding.AutoSize = true;
            this.rdoOutstanding.Location = new System.Drawing.Point(15, 46);
            this.rdoOutstanding.Name = "rdoOutstanding";
            this.rdoOutstanding.Size = new System.Drawing.Size(106, 17);
            this.rdoOutstanding.TabIndex = 0;
            this.rdoOutstanding.TabStop = true;
            this.rdoOutstanding.Text = "Outstanding Only";
            this.rdoOutstanding.UseVisualStyleBackColor = true;
            // 
            // lstPayments
            // 
            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.Location = new System.Drawing.Point(15, 123);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(358, 225);
            this.lstPayments.TabIndex = 0;
            this.lstPayments.SelectedIndexChanged += new System.EventHandler(this.lstPayments_SelectedIndexChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(15, 23);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(36, 17);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // grpReceipt
            // 
            this.grpReceipt.Controls.Add(this.txtDescription);
            this.grpReceipt.Controls.Add(this.txtTotal);
            this.grpReceipt.Controls.Add(this.txtCustomerName);
            this.grpReceipt.Controls.Add(this.txtServiceCompleted);
            this.grpReceipt.Controls.Add(this.txtServiceCreated);
            this.grpReceipt.Controls.Add(this.txtServiceName);
            this.grpReceipt.Controls.Add(this.txtServiceId);
            this.grpReceipt.Controls.Add(this.lblPaymentStatus);
            this.grpReceipt.Controls.Add(this.lblTotal);
            this.grpReceipt.Controls.Add(this.lblServiceId);
            this.grpReceipt.Controls.Add(this.btnPaid);
            this.grpReceipt.Controls.Add(this.lblServiceName);
            this.grpReceipt.Controls.Add(this.lblDescription);
            this.grpReceipt.Controls.Add(this.lblCustName);
            this.grpReceipt.Controls.Add(this.lblServiceCompleted);
            this.grpReceipt.Controls.Add(this.lblServiceCreated);
            this.grpReceipt.Location = new System.Drawing.Point(425, 59);
            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Size = new System.Drawing.Size(306, 427);
            this.grpReceipt.TabIndex = 2;
            this.grpReceipt.TabStop = false;
            this.grpReceipt.Text = "Receipt";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(22, 221);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 71);
            this.txtDescription.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(22, 315);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(265, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(22, 176);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(265, 20);
            this.txtCustomerName.TabIndex = 7;
            // 
            // txtServiceCompleted
            // 
            this.txtServiceCompleted.Enabled = false;
            this.txtServiceCompleted.Location = new System.Drawing.Point(177, 126);
            this.txtServiceCompleted.Name = "txtServiceCompleted";
            this.txtServiceCompleted.Size = new System.Drawing.Size(101, 20);
            this.txtServiceCompleted.TabIndex = 6;
            // 
            // txtServiceCreated
            // 
            this.txtServiceCreated.Enabled = false;
            this.txtServiceCreated.Location = new System.Drawing.Point(22, 126);
            this.txtServiceCreated.Name = "txtServiceCreated";
            this.txtServiceCreated.Size = new System.Drawing.Size(101, 20);
            this.txtServiceCreated.TabIndex = 6;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Enabled = false;
            this.txtServiceName.Location = new System.Drawing.Point(22, 79);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(265, 20);
            this.txtServiceName.TabIndex = 6;
            // 
            // txtServiceId
            // 
            this.txtServiceId.Enabled = false;
            this.txtServiceId.Location = new System.Drawing.Point(22, 40);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(265, 20);
            this.txtServiceId.TabIndex = 6;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(19, 350);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(69, 13);
            this.lblPaymentStatus.TabIndex = 3;
            this.lblPaymentStatus.Text = "Payment Info";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(19, 298);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Amount";
            // 
            // lblServiceId
            // 
            this.lblServiceId.AutoSize = true;
            this.lblServiceId.Location = new System.Drawing.Point(19, 23);
            this.lblServiceId.Name = "lblServiceId";
            this.lblServiceId.Size = new System.Drawing.Size(57, 13);
            this.lblServiceId.TabIndex = 4;
            this.lblServiceId.Text = "Service ID";
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(22, 381);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(265, 28);
            this.btnPaid.TabIndex = 1;
            this.btnPaid.Text = "Mark as Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(19, 63);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 204);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(19, 159);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(89, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer\'s Name";
            // 
            // lblServiceCompleted
            // 
            this.lblServiceCompleted.AutoSize = true;
            this.lblServiceCompleted.Location = new System.Drawing.Point(174, 110);
            this.lblServiceCompleted.Name = "lblServiceCompleted";
            this.lblServiceCompleted.Size = new System.Drawing.Size(96, 13);
            this.lblServiceCompleted.TabIndex = 0;
            this.lblServiceCompleted.Text = "Service Completed";
            // 
            // lblServiceCreated
            // 
            this.lblServiceCreated.AutoSize = true;
            this.lblServiceCreated.Location = new System.Drawing.Point(19, 110);
            this.lblServiceCreated.Name = "lblServiceCreated";
            this.lblServiceCreated.Size = new System.Drawing.Size(83, 13);
            this.lblServiceCreated.TabIndex = 0;
            this.lblServiceCreated.Text = "Service Created";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(16, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(388, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormRPaymentReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(742, 511);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpReceipt);
            this.Controls.Add(this.grpPayments);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRPaymentReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment and Receipt";
            this.Load += new System.EventHandler(this.FormRPaymentReceipt_Load);
            this.grpPayments.ResumeLayout(false);
            this.grpPayments.PerformLayout();
            this.grpReceipt.ResumeLayout(false);
            this.grpReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPayments;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.GroupBox grpReceipt;
        private System.Windows.Forms.Label lblServiceCreated;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.RadioButton rdoSettled;
        private System.Windows.Forms.RadioButton rdoOutstanding;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblServiceId;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblServiceCompleted;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtServiceCompleted;
        private System.Windows.Forms.TextBox txtServiceCreated;
    }
}