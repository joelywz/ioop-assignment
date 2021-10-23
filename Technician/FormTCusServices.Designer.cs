
namespace IOOP___Technician
{
    partial class cusServices
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
            this.cboServiceType = new System.Windows.Forms.ComboBox();
            this.cboServiceStatus = new System.Windows.Forms.ComboBox();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilterApply = new System.Windows.Forms.Button();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFilter.SuspendLayout();
            this.grpServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboServiceType
            // 
            this.cboServiceType.FormattingEnabled = true;
            this.cboServiceType.Items.AddRange(new object[] {
            "Service Type",
            "1 - Remove virus, malware or spyware",
            "2 - Troubleshoot and fix computer running slow",
            "3 - Laptop screen replacement",
            "4 - Laptop keyboard replacement",
            "5 - Laptop battery replacement",
            "6 - Operating System format and Installation",
            "7 - Data backup and recovery",
            "8 - Internet connectivity issues"});
            this.cboServiceType.Location = new System.Drawing.Point(6, 21);
            this.cboServiceType.MinimumSize = new System.Drawing.Size(336, 0);
            this.cboServiceType.Name = "cboServiceType";
            this.cboServiceType.Size = new System.Drawing.Size(354, 24);
            this.cboServiceType.TabIndex = 1;
            // 
            // cboServiceStatus
            // 
            this.cboServiceStatus.FormattingEnabled = true;
            this.cboServiceStatus.Items.AddRange(new object[] {
            "Service Status",
            "Normal",
            "Urgent"});
            this.cboServiceStatus.Location = new System.Drawing.Point(6, 51);
            this.cboServiceStatus.MinimumSize = new System.Drawing.Size(139, 0);
            this.cboServiceStatus.Name = "cboServiceStatus";
            this.cboServiceStatus.Size = new System.Drawing.Size(157, 24);
            this.cboServiceStatus.TabIndex = 4;
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 16;
            this.lstServices.Location = new System.Drawing.Point(6, 21);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(354, 244);
            this.lstServices.TabIndex = 5;
            // 
            // grpFilter
            // 
            this.grpFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpFilter.Controls.Add(this.btnFilterApply);
            this.grpFilter.Controls.Add(this.cboServiceStatus);
            this.grpFilter.Controls.Add(this.btnFilterClear);
            this.grpFilter.Controls.Add(this.cboServiceType);
            this.grpFilter.Location = new System.Drawing.Point(10, 50);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(5);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(366, 125);
            this.grpFilter.TabIndex = 8;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter by:";
            // 
            // btnFilterApply
            // 
            this.btnFilterApply.Location = new System.Drawing.Point(6, 81);
            this.btnFilterApply.Name = "btnFilterApply";
            this.btnFilterApply.Size = new System.Drawing.Size(354, 38);
            this.btnFilterApply.TabIndex = 11;
            this.btnFilterApply.Text = "Apply Filters";
            this.btnFilterApply.UseVisualStyleBackColor = true;
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilterClear.Location = new System.Drawing.Point(169, 51);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(191, 27);
            this.btnFilterClear.TabIndex = 9;
            this.btnFilterClear.Text = "Clear Filters";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.btnComplete);
            this.grpServices.Controls.Add(this.lstServices);
            this.grpServices.Location = new System.Drawing.Point(10, 177);
            this.grpServices.Margin = new System.Windows.Forms.Padding(5);
            this.grpServices.Name = "grpServices";
            this.grpServices.Size = new System.Drawing.Size(366, 314);
            this.grpServices.TabIndex = 9;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(6, 272);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(354, 36);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete Selected Service";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 25);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Customer Services";
            // 
            // cusServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(386, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpFilter);
            this.Name = "cusServices";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Services";
            this.Load += new System.EventHandler(this.cusServices_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpServices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboServiceType;
        private System.Windows.Forms.ComboBox cboServiceStatus;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnFilterApply;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblTitle;
    }
}