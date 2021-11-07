
namespace Assignment
{
    partial class FormTCusServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTCusServices));
            this.cboDisplay = new System.Windows.Forms.ComboBox();
            this.cboServiceStatus = new System.Windows.Forms.ComboBox();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnFilterApply = new System.Windows.Forms.Button();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.lblSerTypeContent = new System.Windows.Forms.Label();
            this.lblSerType = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCompleteServices = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            this.grpServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDisplay
            // 
            this.cboDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cboDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisplay.FormattingEnabled = true;
            this.cboDisplay.Items.AddRange(new object[] {
            "Date    --    User First Name",
            "Date    --    User ID",
            "Date    --    Service ID"});
            this.cboDisplay.Location = new System.Drawing.Point(86, 21);
            this.cboDisplay.Name = "cboDisplay";
            this.cboDisplay.Size = new System.Drawing.Size(310, 24);
            this.cboDisplay.TabIndex = 1;
            // 
            // cboServiceStatus
            // 
            this.cboServiceStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cboServiceStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Urgency",
            "Normal",
            "Urgent"});
            this.cboServiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceStatus.FormattingEnabled = true;
            this.cboServiceStatus.Items.AddRange(new object[] {
            "All",
            "Normal",
            "Urgent"});
            this.cboServiceStatus.Location = new System.Drawing.Point(86, 51);
            this.cboServiceStatus.Name = "cboServiceStatus";
            this.cboServiceStatus.Size = new System.Drawing.Size(310, 24);
            this.cboServiceStatus.TabIndex = 4;
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 16;
            this.lstServices.Location = new System.Drawing.Point(6, 21);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(493, 180);
            this.lstServices.TabIndex = 5;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // grpFilter
            // 
            this.grpFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.lblDisplay);
            this.grpFilter.Controls.Add(this.btnFilterApply);
            this.grpFilter.Controls.Add(this.cboServiceStatus);
            this.grpFilter.Controls.Add(this.btnFilterClear);
            this.grpFilter.Controls.Add(this.cboDisplay);
            this.grpFilter.Location = new System.Drawing.Point(10, 50);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(5);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(505, 125);
            this.grpFilter.TabIndex = 8;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Urgency:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(3, 24);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(3);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(77, 17);
            this.lblDisplay.TabIndex = 12;
            this.lblDisplay.Text = "Display by:";
            // 
            // btnFilterApply
            // 
            this.btnFilterApply.Location = new System.Drawing.Point(6, 81);
            this.btnFilterApply.Name = "btnFilterApply";
            this.btnFilterApply.Size = new System.Drawing.Size(493, 38);
            this.btnFilterApply.TabIndex = 11;
            this.btnFilterApply.Text = "Apply Filters";
            this.btnFilterApply.UseVisualStyleBackColor = true;
            this.btnFilterApply.Click += new System.EventHandler(this.btnFilterApply_Click);
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilterClear.Location = new System.Drawing.Point(402, 20);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(97, 58);
            this.btnFilterClear.TabIndex = 9;
            this.btnFilterClear.Text = "Clear Filters";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.lblSerTypeContent);
            this.grpServices.Controls.Add(this.lblSerType);
            this.grpServices.Controls.Add(this.btnComplete);
            this.grpServices.Controls.Add(this.lstServices);
            this.grpServices.Location = new System.Drawing.Point(10, 185);
            this.grpServices.Margin = new System.Windows.Forms.Padding(5);
            this.grpServices.Name = "grpServices";
            this.grpServices.Size = new System.Drawing.Size(505, 295);
            this.grpServices.TabIndex = 9;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // lblSerTypeContent
            // 
            this.lblSerTypeContent.AutoSize = true;
            this.lblSerTypeContent.Location = new System.Drawing.Point(8, 230);
            this.lblSerTypeContent.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lblSerTypeContent.Name = "lblSerTypeContent";
            this.lblSerTypeContent.Size = new System.Drawing.Size(0, 17);
            this.lblSerTypeContent.TabIndex = 8;
            // 
            // lblSerType
            // 
            this.lblSerType.AutoSize = true;
            this.lblSerType.Location = new System.Drawing.Point(3, 207);
            this.lblSerType.Margin = new System.Windows.Forms.Padding(3);
            this.lblSerType.Name = "lblSerType";
            this.lblSerType.Size = new System.Drawing.Size(95, 17);
            this.lblSerType.TabIndex = 7;
            this.lblSerType.Text = "Service Type:";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(6, 253);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(493, 36);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete Selected Service";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
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
            // btnCompleteServices
            // 
            this.btnCompleteServices.Location = new System.Drawing.Point(359, 15);
            this.btnCompleteServices.Name = "btnCompleteServices";
            this.btnCompleteServices.Size = new System.Drawing.Size(150, 31);
            this.btnCompleteServices.TabIndex = 11;
            this.btnCompleteServices.Text = "Complete Services";
            this.btnCompleteServices.UseVisualStyleBackColor = true;
            this.btnCompleteServices.Click += new System.EventHandler(this.btnCompleteServices_Click);
            // 
            // FormTCusServices
            // 
            this.AcceptButton = this.btnComplete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 490);
            this.Controls.Add(this.btnCompleteServices);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTCusServices";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brics Laptop Repair";
            this.Load += new System.EventHandler(this.cusServices_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDisplay;
        private System.Windows.Forms.ComboBox cboServiceStatus;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnFilterApply;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblSerTypeContent;
        private System.Windows.Forms.Label lblSerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnCompleteServices;
    }
}