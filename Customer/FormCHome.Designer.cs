
namespace Assignment
{
    partial class custMain
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
            this.lblCustMain = new System.Windows.Forms.Label();
            this.lblCustIntro = new System.Windows.Forms.Label();
            this.btnCustServ = new System.Windows.Forms.Button();
            this.btnCustProf = new System.Windows.Forms.Button();
            this.btnCustLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustMain
            // 
            this.lblCustMain.AutoSize = true;
            this.lblCustMain.Font = new System.Drawing.Font("Imprint MT Shadow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustMain.Location = new System.Drawing.Point(203, 26);
            this.lblCustMain.Name = "lblCustMain";
            this.lblCustMain.Size = new System.Drawing.Size(407, 75);
            this.lblCustMain.TabIndex = 0;
            this.lblCustMain.Text = "WELCOME!";
            // 
            // lblCustIntro
            // 
            this.lblCustIntro.AutoSize = true;
            this.lblCustIntro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustIntro.Location = new System.Drawing.Point(34, 118);
            this.lblCustIntro.Name = "lblCustIntro";
            this.lblCustIntro.Size = new System.Drawing.Size(364, 25);
            this.lblCustIntro.TabIndex = 1;
            this.lblCustIntro.Text = "Please choose from the following options:";
            // 
            // btnCustServ
            // 
            this.btnCustServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustServ.Location = new System.Drawing.Point(271, 188);
            this.btnCustServ.Name = "btnCustServ";
            this.btnCustServ.Size = new System.Drawing.Size(282, 39);
            this.btnCustServ.TabIndex = 2;
            this.btnCustServ.Text = "View Service";
            this.btnCustServ.UseVisualStyleBackColor = true;
            // 
            // btnCustProf
            // 
            this.btnCustProf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustProf.Location = new System.Drawing.Point(271, 258);
            this.btnCustProf.Name = "btnCustProf";
            this.btnCustProf.Size = new System.Drawing.Size(282, 39);
            this.btnCustProf.TabIndex = 3;
            this.btnCustProf.Text = "View Profile";
            this.btnCustProf.UseVisualStyleBackColor = true;
            // 
            // btnCustLogout
            // 
            this.btnCustLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustLogout.Location = new System.Drawing.Point(271, 332);
            this.btnCustLogout.Name = "btnCustLogout";
            this.btnCustLogout.Size = new System.Drawing.Size(282, 39);
            this.btnCustLogout.TabIndex = 4;
            this.btnCustLogout.Text = "Log out";
            this.btnCustLogout.UseVisualStyleBackColor = true;
            // 
            // custMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustLogout);
            this.Controls.Add(this.btnCustProf);
            this.Controls.Add(this.btnCustServ);
            this.Controls.Add(this.lblCustIntro);
            this.Controls.Add(this.lblCustMain);
            this.Name = "custMain";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustMain;
        private System.Windows.Forms.Label lblCustIntro;
        private System.Windows.Forms.Button btnCustServ;
        private System.Windows.Forms.Button btnCustProf;
        private System.Windows.Forms.Button btnCustLogout;
    }
}

