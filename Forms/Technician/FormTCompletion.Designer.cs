
namespace Assignment
{
    partial class FormTCompletion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTCompletion));
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpID = new System.Windows.Forms.GroupBox();
            this.btnIDSearch = new System.Windows.Forms.Button();
            this.btnIDClear = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.lblSerTypeContent = new System.Windows.Forms.Label();
            this.lblSerType = new System.Windows.Forms.Label();
            this.grpCollectionDate = new System.Windows.Forms.GroupBox();
            this.dtpCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.grpID.SuspendLayout();
            this.grpDescription.SuspendLayout();
            this.grpServices.SuspendLayout();
            this.grpCollectionDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 22);
            this.txtID.TabIndex = 0;
            // 
            // grpID
            // 
            this.grpID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpID.Controls.Add(this.btnIDSearch);
            this.grpID.Controls.Add(this.btnIDClear);
            this.grpID.Controls.Add(this.lblID);
            this.grpID.Controls.Add(this.txtID);
            this.grpID.Location = new System.Drawing.Point(10, 50);
            this.grpID.Margin = new System.Windows.Forms.Padding(5);
            this.grpID.Name = "grpID";
            this.grpID.Size = new System.Drawing.Size(509, 55);
            this.grpID.TabIndex = 1;
            this.grpID.TabStop = false;
            this.grpID.Text = "Search by ID";
            // 
            // btnIDSearch
            // 
            this.btnIDSearch.Location = new System.Drawing.Point(229, 21);
            this.btnIDSearch.Name = "btnIDSearch";
            this.btnIDSearch.Size = new System.Drawing.Size(167, 27);
            this.btnIDSearch.TabIndex = 3;
            this.btnIDSearch.Text = "Search";
            this.btnIDSearch.UseVisualStyleBackColor = true;
            this.btnIDSearch.Click += new System.EventHandler(this.btnIDSearch_Click);
            // 
            // btnIDClear
            // 
            this.btnIDClear.Location = new System.Drawing.Point(400, 21);
            this.btnIDClear.Name = "btnIDClear";
            this.btnIDClear.Size = new System.Drawing.Size(103, 27);
            this.btnIDClear.TabIndex = 2;
            this.btnIDClear.Text = "Clear";
            this.btnIDClear.UseVisualStyleBackColor = true;
            this.btnIDClear.Click += new System.EventHandler(this.btnIDClear_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "User ID:";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.rtxtDescription);
            this.grpDescription.Location = new System.Drawing.Point(10, 371);
            this.grpDescription.Margin = new System.Windows.Forms.Padding(5);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(239, 156);
            this.grpDescription.TabIndex = 4;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Service Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(6, 21);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(227, 129);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "Enter service description";
            this.rtxtDescription.Enter += new System.EventHandler(this.rtxtDescription_Enter);
            this.rtxtDescription.Leave += new System.EventHandler(this.rtxtDescription_Leave);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(257, 427);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(5);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(262, 100);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 16;
            this.lstServices.Location = new System.Drawing.Point(6, 44);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(497, 132);
            this.lstServices.TabIndex = 2;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // grpServices
            // 
            this.grpServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpServices.Controls.Add(this.lblFields);
            this.grpServices.Controls.Add(this.lblSerTypeContent);
            this.grpServices.Controls.Add(this.lblSerType);
            this.grpServices.Controls.Add(this.lstServices);
            this.grpServices.Location = new System.Drawing.Point(10, 115);
            this.grpServices.Margin = new System.Windows.Forms.Padding(5);
            this.grpServices.Name = "grpServices";
            this.grpServices.Size = new System.Drawing.Size(509, 246);
            this.grpServices.TabIndex = 3;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(3, 21);
            this.lblFields.Margin = new System.Windows.Forms.Padding(3);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(301, 17);
            this.lblFields.TabIndex = 5;
            this.lblFields.Text = "Date Time    --    User ID    --    User Full Name";
            // 
            // lblSerTypeContent
            // 
            this.lblSerTypeContent.AutoSize = true;
            this.lblSerTypeContent.Location = new System.Drawing.Point(9, 214);
            this.lblSerTypeContent.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lblSerTypeContent.Name = "lblSerTypeContent";
            this.lblSerTypeContent.Size = new System.Drawing.Size(0, 17);
            this.lblSerTypeContent.TabIndex = 4;
            // 
            // lblSerType
            // 
            this.lblSerType.AutoSize = true;
            this.lblSerType.Location = new System.Drawing.Point(3, 191);
            this.lblSerType.Margin = new System.Windows.Forms.Padding(3);
            this.lblSerType.Name = "lblSerType";
            this.lblSerType.Size = new System.Drawing.Size(95, 17);
            this.lblSerType.TabIndex = 3;
            this.lblSerType.Text = "Service Type:";
            // 
            // grpCollectionDate
            // 
            this.grpCollectionDate.Controls.Add(this.dtpCollectionDate);
            this.grpCollectionDate.Location = new System.Drawing.Point(257, 371);
            this.grpCollectionDate.Margin = new System.Windows.Forms.Padding(5);
            this.grpCollectionDate.Name = "grpCollectionDate";
            this.grpCollectionDate.Size = new System.Drawing.Size(262, 50);
            this.grpCollectionDate.TabIndex = 5;
            this.grpCollectionDate.TabStop = false;
            this.grpCollectionDate.Text = "Collection Date";
            // 
            // dtpCollectionDate
            // 
            this.dtpCollectionDate.Location = new System.Drawing.Point(6, 21);
            this.dtpCollectionDate.Name = "dtpCollectionDate";
            this.dtpCollectionDate.Size = new System.Drawing.Size(250, 22);
            this.dtpCollectionDate.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Service Completion";
            // 
            // btnViewServices
            // 
            this.btnViewServices.Location = new System.Drawing.Point(384, 15);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(129, 31);
            this.btnViewServices.TabIndex = 9;
            this.btnViewServices.Text = "View Services";
            this.btnViewServices.UseVisualStyleBackColor = true;
            this.btnViewServices.Click += new System.EventHandler(this.btnViewServices_Click);
            // 
            // FormTCompletion
            // 
            this.AcceptButton = this.btnComplete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 536);
            this.Controls.Add(this.btnViewServices);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.grpCollectionDate);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTCompletion";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brics Laptop Repair";
            this.Load += new System.EventHandler(this.FormTCompletion_Load);
            this.grpID.ResumeLayout(false);
            this.grpID.PerformLayout();
            this.grpDescription.ResumeLayout(false);
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            this.grpCollectionDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grpID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.Button btnIDSearch;
        private System.Windows.Forms.Button btnIDClear;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.GroupBox grpCollectionDate;
        private System.Windows.Forms.DateTimePicker dtpCollectionDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Label lblSerType;
        private System.Windows.Forms.Label lblSerTypeContent;
        private System.Windows.Forms.Label lblFields;
    }
}