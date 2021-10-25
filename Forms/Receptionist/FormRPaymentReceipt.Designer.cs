
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
            this.gbPayments = new System.Windows.Forms.GroupBox();
            this.btnViewReceipt = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.checkboxSettled = new System.Windows.Forms.CheckBox();
            this.checkboxIncomplete = new System.Windows.Forms.CheckBox();
            this.checkboxUnsettled = new System.Windows.Forms.CheckBox();
            this.checkboxCompleted = new System.Windows.Forms.CheckBox();
            this.listboxPayments = new System.Windows.Forms.ListBox();
            this.gbReceipt = new System.Windows.Forms.GroupBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.listboxReceipt = new System.Windows.Forms.ListBox();
            this.btnMarkSettled = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.gbPayments.SuspendLayout();
            this.gbReceipt.SuspendLayout();
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
            // gbPayments
            // 
            this.gbPayments.Controls.Add(this.btnViewReceipt);
            this.gbPayments.Controls.Add(this.btnFilter);
            this.gbPayments.Controls.Add(this.checkboxSettled);
            this.gbPayments.Controls.Add(this.checkboxIncomplete);
            this.gbPayments.Controls.Add(this.checkboxUnsettled);
            this.gbPayments.Controls.Add(this.checkboxCompleted);
            this.gbPayments.Controls.Add(this.listboxPayments);
            this.gbPayments.Location = new System.Drawing.Point(16, 59);
            this.gbPayments.Name = "gbPayments";
            this.gbPayments.Size = new System.Drawing.Size(366, 285);
            this.gbPayments.TabIndex = 1;
            this.gbPayments.TabStop = false;
            this.gbPayments.Text = "Payments";
            // 
            // btnViewReceipt
            // 
            this.btnViewReceipt.Location = new System.Drawing.Point(15, 233);
            this.btnViewReceipt.Name = "btnViewReceipt";
            this.btnViewReceipt.Size = new System.Drawing.Size(242, 30);
            this.btnViewReceipt.TabIndex = 2;
            this.btnViewReceipt.Text = "View Receipt";
            this.btnViewReceipt.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(275, 123);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // checkboxSettled
            // 
            this.checkboxSettled.AutoSize = true;
            this.checkboxSettled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkboxSettled.Location = new System.Drawing.Point(275, 69);
            this.checkboxSettled.Name = "checkboxSettled";
            this.checkboxSettled.Size = new System.Drawing.Size(59, 17);
            this.checkboxSettled.TabIndex = 1;
            this.checkboxSettled.Text = "Settled";
            this.checkboxSettled.UseVisualStyleBackColor = true;
            // 
            // checkboxIncomplete
            // 
            this.checkboxIncomplete.AutoSize = true;
            this.checkboxIncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkboxIncomplete.Location = new System.Drawing.Point(275, 46);
            this.checkboxIncomplete.Name = "checkboxIncomplete";
            this.checkboxIncomplete.Size = new System.Drawing.Size(78, 17);
            this.checkboxIncomplete.TabIndex = 1;
            this.checkboxIncomplete.Text = "Incomplete";
            this.checkboxIncomplete.UseVisualStyleBackColor = true;
            // 
            // checkboxUnsettled
            // 
            this.checkboxUnsettled.AutoSize = true;
            this.checkboxUnsettled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkboxUnsettled.Location = new System.Drawing.Point(275, 92);
            this.checkboxUnsettled.Name = "checkboxUnsettled";
            this.checkboxUnsettled.Size = new System.Drawing.Size(71, 17);
            this.checkboxUnsettled.TabIndex = 1;
            this.checkboxUnsettled.Text = "Unsettled";
            this.checkboxUnsettled.UseVisualStyleBackColor = true;
            // 
            // checkboxCompleted
            // 
            this.checkboxCompleted.AutoSize = true;
            this.checkboxCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkboxCompleted.Location = new System.Drawing.Point(275, 23);
            this.checkboxCompleted.Name = "checkboxCompleted";
            this.checkboxCompleted.Size = new System.Drawing.Size(76, 17);
            this.checkboxCompleted.TabIndex = 1;
            this.checkboxCompleted.Text = "Completed";
            this.checkboxCompleted.UseVisualStyleBackColor = true;
            // 
            // listboxPayments
            // 
            this.listboxPayments.FormattingEnabled = true;
            this.listboxPayments.Location = new System.Drawing.Point(15, 23);
            this.listboxPayments.Name = "listboxPayments";
            this.listboxPayments.Size = new System.Drawing.Size(242, 199);
            this.listboxPayments.TabIndex = 0;
            // 
            // gbReceipt
            // 
            this.gbReceipt.Controls.Add(this.lblPaymentStatus);
            this.gbReceipt.Controls.Add(this.labelTotal);
            this.gbReceipt.Controls.Add(this.btnMarkSettled);
            this.gbReceipt.Controls.Add(this.lblCustomer);
            this.gbReceipt.Controls.Add(this.lblCreatedAt);
            this.gbReceipt.Controls.Add(this.listboxReceipt);
            this.gbReceipt.Location = new System.Drawing.Point(414, 59);
            this.gbReceipt.Name = "gbReceipt";
            this.gbReceipt.Size = new System.Drawing.Size(259, 341);
            this.gbReceipt.TabIndex = 2;
            this.gbReceipt.TabStop = false;
            this.gbReceipt.Text = "Receipt";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(19, 23);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(116, 13);
            this.lblCreatedAt.TabIndex = 0;
            this.lblCreatedAt.Text = "Created at: 01-10-2021";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(366, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(19, 46);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(103, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer: John Doe";
            // 
            // listboxReceipt
            // 
            this.listboxReceipt.FormattingEnabled = true;
            this.listboxReceipt.Location = new System.Drawing.Point(22, 66);
            this.listboxReceipt.Name = "listboxReceipt";
            this.listboxReceipt.Size = new System.Drawing.Size(213, 186);
            this.listboxReceipt.TabIndex = 0;
            // 
            // btnMarkSettled
            // 
            this.btnMarkSettled.Location = new System.Drawing.Point(128, 301);
            this.btnMarkSettled.Name = "btnMarkSettled";
            this.btnMarkSettled.Size = new System.Drawing.Size(107, 23);
            this.btnMarkSettled.TabIndex = 1;
            this.btnMarkSettled.Text = "Mark as Settled";
            this.btnMarkSettled.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(19, 272);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(75, 13);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total: RM 100";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(19, 306);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(52, 13);
            this.lblPaymentStatus.TabIndex = 3;
            this.lblPaymentStatus.Text = "Unsettled";
            // 
            // FormRPaymentReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 423);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbReceipt);
            this.Controls.Add(this.gbPayments);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormRPaymentReceipt";
            this.Text = "Payment and Receipt";
            this.gbPayments.ResumeLayout(false);
            this.gbPayments.PerformLayout();
            this.gbReceipt.ResumeLayout(false);
            this.gbReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbPayments;
        private System.Windows.Forms.Button btnViewReceipt;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox checkboxSettled;
        private System.Windows.Forms.CheckBox checkboxIncomplete;
        private System.Windows.Forms.CheckBox checkboxUnsettled;
        private System.Windows.Forms.CheckBox checkboxCompleted;
        private System.Windows.Forms.ListBox listboxPayments;
        private System.Windows.Forms.GroupBox gbReceipt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnMarkSettled;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ListBox listboxReceipt;
    }
}