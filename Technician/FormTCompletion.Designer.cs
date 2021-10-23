
namespace IOOP___Technician
{
    partial class serComplete
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
            this.grpCollectionDate = new System.Windows.Forms.GroupBox();
            this.calCollectionDate = new System.Windows.Forms.DateTimePicker();
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
            this.txtID.Location = new System.Drawing.Point(88, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 22);
            this.txtID.TabIndex = 0;
            // 
            // grpID
            // 
            this.grpID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpID.Controls.Add(this.btnIDSearch);
            this.grpID.Controls.Add(this.btnIDClear);
            this.grpID.Controls.Add(this.lblID);
            this.grpID.Controls.Add(this.txtID);
            this.grpID.Location = new System.Drawing.Point(8, 50);
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
            // 
            // btnIDClear
            // 
            this.btnIDClear.Location = new System.Drawing.Point(400, 21);
            this.btnIDClear.Name = "btnIDClear";
            this.btnIDClear.Size = new System.Drawing.Size(103, 27);
            this.btnIDClear.TabIndex = 2;
            this.btnIDClear.Text = "Clear";
            this.btnIDClear.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Service ID:";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.rtxtDescription);
            this.grpDescription.Location = new System.Drawing.Point(8, 380);
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
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(257, 436);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(5);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(260, 100);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 16;
            this.lstServices.Location = new System.Drawing.Point(6, 21);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(497, 228);
            this.lstServices.TabIndex = 2;
            // 
            // grpServices
            // 
            this.grpServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpServices.Controls.Add(this.lstServices);
            this.grpServices.Location = new System.Drawing.Point(8, 115);
            this.grpServices.Margin = new System.Windows.Forms.Padding(5);
            this.grpServices.Name = "grpServices";
            this.grpServices.Size = new System.Drawing.Size(509, 255);
            this.grpServices.TabIndex = 3;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // grpCollectionDate
            // 
            this.grpCollectionDate.Controls.Add(this.calCollectionDate);
            this.grpCollectionDate.Location = new System.Drawing.Point(257, 380);
            this.grpCollectionDate.Margin = new System.Windows.Forms.Padding(5);
            this.grpCollectionDate.Name = "grpCollectionDate";
            this.grpCollectionDate.Size = new System.Drawing.Size(260, 50);
            this.grpCollectionDate.TabIndex = 5;
            this.grpCollectionDate.TabStop = false;
            this.grpCollectionDate.Text = "Collection Date";
            // 
            // calCollectionDate
            // 
            this.calCollectionDate.Location = new System.Drawing.Point(6, 21);
            this.calCollectionDate.Name = "calCollectionDate";
            this.calCollectionDate.Size = new System.Drawing.Size(248, 22);
            this.calCollectionDate.TabIndex = 0;
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
            this.btnViewServices.Location = new System.Drawing.Point(382, 15);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(129, 31);
            this.btnViewServices.TabIndex = 9;
            this.btnViewServices.Text = "View Services";
            this.btnViewServices.UseVisualStyleBackColor = true;
            this.btnViewServices.Click += new System.EventHandler(this.btnViewServices_Click);
            // 
            // serComplete
            // 
            this.AcceptButton = this.btnComplete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(525, 545);
            this.Controls.Add(this.btnViewServices);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.grpCollectionDate);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpID);
            this.MinimumSize = new System.Drawing.Size(543, 592);
            this.Name = "serComplete";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Completion";
            this.grpID.ResumeLayout(false);
            this.grpID.PerformLayout();
            this.grpDescription.ResumeLayout(false);
            this.grpServices.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker calCollectionDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewServices;
    }
}