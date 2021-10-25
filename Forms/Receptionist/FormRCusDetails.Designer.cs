
namespace Assignment
{
    partial class FormRCustomerDetails
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
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.checkboxUrgent = new System.Windows.Forms.CheckBox();
            this.rbtn8 = new System.Windows.Forms.RadioButton();
            this.rbtn7 = new System.Windows.Forms.RadioButton();
            this.rbtn6 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnViewPayment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbCustomer.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblPayment);
            this.gbCustomer.Controls.Add(this.lblUsername);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Location = new System.Drawing.Point(17, 45);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(307, 92);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Selected Customer";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPayment.Location = new System.Drawing.Point(6, 65);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(99, 13);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment: Unsettled";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblUsername.Location = new System.Drawing.Point(6, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: johndoe123";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: John Doe";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Customer\'s Detail";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.btnOrder);
            this.gbOrder.Controls.Add(this.lblPrice);
            this.gbOrder.Controls.Add(this.checkboxUrgent);
            this.gbOrder.Controls.Add(this.rbtn8);
            this.gbOrder.Controls.Add(this.rbtn7);
            this.gbOrder.Controls.Add(this.rbtn6);
            this.gbOrder.Controls.Add(this.rbtn5);
            this.gbOrder.Controls.Add(this.rbtn4);
            this.gbOrder.Controls.Add(this.rbtn3);
            this.gbOrder.Controls.Add(this.rbtn2);
            this.gbOrder.Controls.Add(this.rbtn1);
            this.gbOrder.Location = new System.Drawing.Point(17, 155);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(307, 295);
            this.gbOrder.TabIndex = 2;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order Service";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(214, 224);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(75, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price: RM 100";
            // 
            // checkboxUrgent
            // 
            this.checkboxUrgent.AutoSize = true;
            this.checkboxUrgent.Location = new System.Drawing.Point(9, 220);
            this.checkboxUrgent.Name = "checkboxUrgent";
            this.checkboxUrgent.Size = new System.Drawing.Size(58, 17);
            this.checkboxUrgent.TabIndex = 1;
            this.checkboxUrgent.Text = "Urgent";
            this.checkboxUrgent.UseVisualStyleBackColor = true;
            // 
            // rbtn8
            // 
            this.rbtn8.AutoSize = true;
            this.rbtn8.Location = new System.Drawing.Point(9, 180);
            this.rbtn8.Name = "rbtn8";
            this.rbtn8.Size = new System.Drawing.Size(153, 17);
            this.rbtn8.TabIndex = 0;
            this.rbtn8.TabStop = true;
            this.rbtn8.Text = "Internet connectivity issues";
            this.rbtn8.UseVisualStyleBackColor = true;
            // 
            // rbtn7
            // 
            this.rbtn7.AutoSize = true;
            this.rbtn7.Location = new System.Drawing.Point(9, 157);
            this.rbtn7.Name = "rbtn7";
            this.rbtn7.Size = new System.Drawing.Size(152, 17);
            this.rbtn7.TabIndex = 0;
            this.rbtn7.TabStop = true;
            this.rbtn7.Text = "Data backup and recovery";
            this.rbtn7.UseVisualStyleBackColor = true;
            // 
            // rbtn6
            // 
            this.rbtn6.AutoSize = true;
            this.rbtn6.Location = new System.Drawing.Point(9, 134);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Size = new System.Drawing.Size(211, 17);
            this.rbtn6.TabIndex = 0;
            this.rbtn6.TabStop = true;
            this.rbtn6.Text = "Operating system format and installation";
            this.rbtn6.UseVisualStyleBackColor = true;
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(9, 111);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(154, 17);
            this.rbtn5.TabIndex = 0;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "Laptop battery replacement";
            this.rbtn5.UseVisualStyleBackColor = true;
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.Location = new System.Drawing.Point(9, 88);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(166, 17);
            this.rbtn4.TabIndex = 0;
            this.rbtn4.TabStop = true;
            this.rbtn4.Text = "Laptop keyboard replacement";
            this.rbtn4.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(9, 65);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(154, 17);
            this.rbtn3.TabIndex = 0;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "Laptop screen replacement";
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(9, 42);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(230, 17);
            this.rbtn2.TabIndex = 0;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "Troubleshoot and fix computer running slow";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(9, 19);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(134, 17);
            this.rbtn1.TabIndex = 0;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Remove virus/malware";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(9, 254);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(292, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Service";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnViewPayment
            // 
            this.btnViewPayment.Location = new System.Drawing.Point(17, 470);
            this.btnViewPayment.Name = "btnViewPayment";
            this.btnViewPayment.Size = new System.Drawing.Size(307, 23);
            this.btnViewPayment.TabIndex = 3;
            this.btnViewPayment.Text = "View Payment and Receipt";
            this.btnViewPayment.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(307, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FormRCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 555);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewPayment);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbCustomer);
            this.Name = "FormRCustomerDetails";
            this.Text = "Customer Details";
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox checkboxUrgent;
        private System.Windows.Forms.RadioButton rbtn8;
        private System.Windows.Forms.RadioButton rbtn7;
        private System.Windows.Forms.RadioButton rbtn6;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnViewPayment;
        private System.Windows.Forms.Button btnClose;
    }
}