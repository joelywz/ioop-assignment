
namespace Assignment
{
    partial class FormCHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCHome));
            this.lblCustIntro = new System.Windows.Forms.Label();
            this.btnCustServ = new System.Windows.Forms.Button();
            this.btnCustProf = new System.Windows.Forms.Button();
            this.btnCustLogout = new System.Windows.Forms.Button();
            this.picCustHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCustHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustIntro
            // 
            this.lblCustIntro.AutoSize = true;
            this.lblCustIntro.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblCustIntro.Location = new System.Drawing.Point(20, 156);
            this.lblCustIntro.Name = "lblCustIntro";
            this.lblCustIntro.Size = new System.Drawing.Size(278, 25);
            this.lblCustIntro.TabIndex = 1;
            this.lblCustIntro.Text = "Welcome to Brics Laptop Repair";
            // 
            // btnCustServ
            // 
            this.btnCustServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustServ.Location = new System.Drawing.Point(39, 206);
            this.btnCustServ.Name = "btnCustServ";
            this.btnCustServ.Size = new System.Drawing.Size(242, 39);
            this.btnCustServ.TabIndex = 2;
            this.btnCustServ.Text = "View Service";
            this.btnCustServ.UseVisualStyleBackColor = true;
            this.btnCustServ.Click += new System.EventHandler(this.btnCustServ_Click);
            // 
            // btnCustProf
            // 
            this.btnCustProf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustProf.Location = new System.Drawing.Point(39, 261);
            this.btnCustProf.Name = "btnCustProf";
            this.btnCustProf.Size = new System.Drawing.Size(242, 34);
            this.btnCustProf.TabIndex = 3;
            this.btnCustProf.Text = "View Profile";
            this.btnCustProf.UseVisualStyleBackColor = true;
            this.btnCustProf.Click += new System.EventHandler(this.btnCustProf_Click);
            // 
            // btnCustLogout
            // 
            this.btnCustLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustLogout.Location = new System.Drawing.Point(39, 314);
            this.btnCustLogout.Name = "btnCustLogout";
            this.btnCustLogout.Size = new System.Drawing.Size(242, 34);
            this.btnCustLogout.TabIndex = 4;
            this.btnCustLogout.Text = "Log out";
            this.btnCustLogout.UseVisualStyleBackColor = true;
            this.btnCustLogout.Click += new System.EventHandler(this.btnCustLogout_Click);
            // 
            // picCustHome
            // 
            this.picCustHome.Image = ((System.Drawing.Image)(resources.GetObject("picCustHome.Image")));
            this.picCustHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCustHome.InitialImage")));
            this.picCustHome.Location = new System.Drawing.Point(12, 12);
            this.picCustHome.Name = "picCustHome";
            this.picCustHome.Size = new System.Drawing.Size(295, 132);
            this.picCustHome.TabIndex = 5;
            this.picCustHome.TabStop = false;
            // 
            // FormCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(323, 390);
            this.Controls.Add(this.picCustHome);
            this.Controls.Add(this.btnCustLogout);
            this.Controls.Add(this.btnCustProf);
            this.Controls.Add(this.btnCustServ);
            this.Controls.Add(this.lblCustIntro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brics Laptop Repair";
            ((System.ComponentModel.ISupportInitialize)(this.picCustHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustIntro;
        private System.Windows.Forms.Button btnCustServ;
        private System.Windows.Forms.Button btnCustProf;
        private System.Windows.Forms.Button btnCustLogout;
        private System.Windows.Forms.PictureBox picCustHome;
    }
}

