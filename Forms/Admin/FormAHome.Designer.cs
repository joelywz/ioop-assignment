
namespace Assignment
{
    partial class FormAHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAHome));
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtic = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmpass = new System.Windows.Forms.TextBox();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblConfirmpass = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblic = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbFilterby = new System.Windows.Forms.ComboBox();
            this.cdrStatistics = new System.Windows.Forms.MonthCalendar();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.hscStatistics = new System.Windows.Forms.HScrollBar();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstStatistics = new System.Windows.Forms.ListBox();
            this.lblFilterby = new System.Windows.Forms.Label();
            this.lblPhone_display = new System.Windows.Forms.Label();
            this.lblic_display = new System.Windows.Forms.Label();
            this.lblEmail_display = new System.Windows.Forms.Label();
            this.txtPhone_display = new System.Windows.Forms.TextBox();
            this.txtic_display = new System.Windows.Forms.TextBox();
            this.txtEmail_display = new System.Windows.Forms.TextBox();
            this.txtAge_display = new System.Windows.Forms.TextBox();
            this.lblName_display = new System.Windows.Forms.Label();
            this.lblAge_display = new System.Windows.Forms.Label();
            this.lblUserID_display = new System.Windows.Forms.Label();
            this.txtUserID_display = new System.Windows.Forms.TextBox();
            this.txtName_display = new System.Windows.Forms.TextBox();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.picBrics = new System.Windows.Forms.PictureBox();
            this.prgAdmin = new System.Windows.Forms.ProgressBar();
            this.errConfirmpass = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrAdmin = new System.Windows.Forms.Timer(this.components);
            this.errRoles = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erric = new System.Windows.Forms.ErrorProvider(this.components);
            this.errUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpRegister.SuspendLayout();
            this.grpStatistics.SuspendLayout();
            this.grpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRoles
            // 
            this.cmbRoles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Items.AddRange(new object[] {
            "Receptionist",
            "Technician"});
            this.cmbRoles.Location = new System.Drawing.Point(119, 36);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(199, 21);
            this.cmbRoles.TabIndex = 0;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            this.cmbRoles.Enter += new System.EventHandler(this.cmbRoles_Enter);
            this.cmbRoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRoles_KeyPress);
            this.cmbRoles.Leave += new System.EventHandler(this.cmbRoles_Leave);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoles.Location = new System.Drawing.Point(21, 39);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(37, 13);
            this.lblRoles.TabIndex = 2;
            this.lblRoles.Text = "Roles:";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(119, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtic
            // 
            this.txtic.Location = new System.Drawing.Point(119, 280);
            this.txtic.Name = "txtic";
            this.txtic.Size = new System.Drawing.Size(199, 20);
            this.txtic.TabIndex = 5;
            this.txtic.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtic.Enter += new System.EventHandler(this.txtic_Enter);
            this.txtic.Leave += new System.EventHandler(this.txtic_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(119, 229);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 20);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(119, 332);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 20);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 384);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtConfirmpass
            // 
            this.txtConfirmpass.Location = new System.Drawing.Point(119, 436);
            this.txtConfirmpass.Name = "txtConfirmpass";
            this.txtConfirmpass.Size = new System.Drawing.Size(199, 20);
            this.txtConfirmpass.TabIndex = 9;
            this.txtConfirmpass.TextChanged += new System.EventHandler(this.txtConfirmpass_TextChanged);
            this.txtConfirmpass.Enter += new System.EventHandler(this.txtConfirmpass_Enter);
            this.txtConfirmpass.Leave += new System.EventHandler(this.txtConfirmpass_Leave);
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.dtpAge);
            this.grpRegister.Controls.Add(this.btnClear);
            this.grpRegister.Controls.Add(this.btnRegister);
            this.grpRegister.Controls.Add(this.txtConfirmpass);
            this.grpRegister.Controls.Add(this.txtPassword);
            this.grpRegister.Controls.Add(this.lblAge);
            this.grpRegister.Controls.Add(this.lblConfirmpass);
            this.grpRegister.Controls.Add(this.lblPassword);
            this.grpRegister.Controls.Add(this.lblUsername);
            this.grpRegister.Controls.Add(this.lblPhone);
            this.grpRegister.Controls.Add(this.lblic);
            this.grpRegister.Controls.Add(this.lblEmail);
            this.grpRegister.Controls.Add(this.lblName);
            this.grpRegister.Controls.Add(this.txtUsername);
            this.grpRegister.Controls.Add(this.txtPhone);
            this.grpRegister.Controls.Add(this.txtic);
            this.grpRegister.Controls.Add(this.txtEmail);
            this.grpRegister.Controls.Add(this.txtName);
            this.grpRegister.Controls.Add(this.lblRoles);
            this.grpRegister.Controls.Add(this.cmbRoles);
            this.grpRegister.Location = new System.Drawing.Point(12, 12);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(341, 576);
            this.grpRegister.TabIndex = 10;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Registration";
            this.grpRegister.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpAge
            // 
            this.dtpAge.Location = new System.Drawing.Point(119, 128);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.Size = new System.Drawing.Size(199, 20);
            this.dtpAge.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 47);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(193, 500);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(113, 47);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAge.Location = new System.Drawing.Point(21, 134);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(68, 13);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Date of birth:";
            // 
            // lblConfirmpass
            // 
            this.lblConfirmpass.AutoSize = true;
            this.lblConfirmpass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmpass.Location = new System.Drawing.Point(21, 439);
            this.lblConfirmpass.Name = "lblConfirmpass";
            this.lblConfirmpass.Size = new System.Drawing.Size(93, 13);
            this.lblConfirmpass.TabIndex = 16;
            this.lblConfirmpass.Text = "Confirm password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(21, 387);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(21, 335);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhone.Location = new System.Drawing.Point(21, 232);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone no:";
            // 
            // lblic
            // 
            this.lblic.AutoSize = true;
            this.lblic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblic.Location = new System.Drawing.Point(21, 283);
            this.lblic.Name = "lblic";
            this.lblic.Size = new System.Drawing.Size(93, 13);
            this.lblic.TabIndex = 12;
            this.lblic.Text = "Social security no:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(21, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(21, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Full name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(537, 541);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 47);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbFilterby
            // 
            this.cmbFilterby.FormattingEnabled = true;
            this.cmbFilterby.Items.AddRange(new object[] {
            "",
            "View Monthly Total Income",
            "View Monthly Service Reports"});
            this.cmbFilterby.Location = new System.Drawing.Point(27, 40);
            this.cmbFilterby.Name = "cmbFilterby";
            this.cmbFilterby.Size = new System.Drawing.Size(227, 21);
            this.cmbFilterby.TabIndex = 24;
            this.cmbFilterby.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cmbFilterby.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFilterby_KeyPress);
            // 
            // cdrStatistics
            // 
            this.cdrStatistics.Location = new System.Drawing.Point(27, 73);
            this.cdrStatistics.Name = "cdrStatistics";
            this.cdrStatistics.TabIndex = 25;
            // 
            // grpStatistics
            // 
            this.grpStatistics.Controls.Add(this.hscStatistics);
            this.grpStatistics.Controls.Add(this.btnDelete);
            this.grpStatistics.Controls.Add(this.btnEdit);
            this.grpStatistics.Controls.Add(this.lstStatistics);
            this.grpStatistics.Controls.Add(this.lblFilterby);
            this.grpStatistics.Controls.Add(this.cdrStatistics);
            this.grpStatistics.Controls.Add(this.cmbFilterby);
            this.grpStatistics.Location = new System.Drawing.Point(892, 12);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(275, 576);
            this.grpStatistics.TabIndex = 26;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics";
            // 
            // hscStatistics
            // 
            this.hscStatistics.Location = new System.Drawing.Point(27, 462);
            this.hscStatistics.Name = "hscStatistics";
            this.hscStatistics.Size = new System.Drawing.Size(227, 19);
            this.hscStatistics.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 47);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(27, 512);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 47);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lstStatistics
            // 
            this.lstStatistics.FormattingEnabled = true;
            this.lstStatistics.Location = new System.Drawing.Point(27, 234);
            this.lstStatistics.Name = "lstStatistics";
            this.lstStatistics.Size = new System.Drawing.Size(227, 225);
            this.lstStatistics.TabIndex = 26;
            this.lstStatistics.SelectedIndexChanged += new System.EventHandler(this.lstStatistics_SelectedIndexChanged);
            // 
            // lblFilterby
            // 
            this.lblFilterby.AutoSize = true;
            this.lblFilterby.Location = new System.Drawing.Point(24, 24);
            this.lblFilterby.Name = "lblFilterby";
            this.lblFilterby.Size = new System.Drawing.Size(46, 13);
            this.lblFilterby.TabIndex = 24;
            this.lblFilterby.Text = "Filter by:";
            // 
            // lblPhone_display
            // 
            this.lblPhone_display.AutoSize = true;
            this.lblPhone_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhone_display.Location = new System.Drawing.Point(14, 229);
            this.lblPhone_display.Name = "lblPhone_display";
            this.lblPhone_display.Size = new System.Drawing.Size(56, 13);
            this.lblPhone_display.TabIndex = 29;
            this.lblPhone_display.Text = "Phone no:";
            // 
            // lblic_display
            // 
            this.lblic_display.AutoSize = true;
            this.lblic_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblic_display.Location = new System.Drawing.Point(14, 278);
            this.lblic_display.Name = "lblic_display";
            this.lblic_display.Size = new System.Drawing.Size(93, 13);
            this.lblic_display.TabIndex = 28;
            this.lblic_display.Text = "Social security no:";
            // 
            // lblEmail_display
            // 
            this.lblEmail_display.AutoSize = true;
            this.lblEmail_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail_display.Location = new System.Drawing.Point(14, 183);
            this.lblEmail_display.Name = "lblEmail_display";
            this.lblEmail_display.Size = new System.Drawing.Size(35, 13);
            this.lblEmail_display.TabIndex = 27;
            this.lblEmail_display.Text = "Email:";
            // 
            // txtPhone_display
            // 
            this.txtPhone_display.Location = new System.Drawing.Point(113, 226);
            this.txtPhone_display.Name = "txtPhone_display";
            this.txtPhone_display.ReadOnly = true;
            this.txtPhone_display.Size = new System.Drawing.Size(243, 20);
            this.txtPhone_display.TabIndex = 26;
            // 
            // txtic_display
            // 
            this.txtic_display.Location = new System.Drawing.Point(113, 275);
            this.txtic_display.Name = "txtic_display";
            this.txtic_display.ReadOnly = true;
            this.txtic_display.Size = new System.Drawing.Size(243, 20);
            this.txtic_display.TabIndex = 25;
            // 
            // txtEmail_display
            // 
            this.txtEmail_display.Location = new System.Drawing.Point(113, 180);
            this.txtEmail_display.Name = "txtEmail_display";
            this.txtEmail_display.ReadOnly = true;
            this.txtEmail_display.Size = new System.Drawing.Size(243, 20);
            this.txtEmail_display.TabIndex = 24;
            // 
            // txtAge_display
            // 
            this.txtAge_display.Location = new System.Drawing.Point(113, 131);
            this.txtAge_display.Name = "txtAge_display";
            this.txtAge_display.ReadOnly = true;
            this.txtAge_display.Size = new System.Drawing.Size(243, 20);
            this.txtAge_display.TabIndex = 24;
            // 
            // lblName_display
            // 
            this.lblName_display.AutoSize = true;
            this.lblName_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName_display.Location = new System.Drawing.Point(14, 36);
            this.lblName_display.Name = "lblName_display";
            this.lblName_display.Size = new System.Drawing.Size(55, 13);
            this.lblName_display.TabIndex = 24;
            this.lblName_display.Text = "Full name:";
            // 
            // lblAge_display
            // 
            this.lblAge_display.AutoSize = true;
            this.lblAge_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAge_display.Location = new System.Drawing.Point(14, 134);
            this.lblAge_display.Name = "lblAge_display";
            this.lblAge_display.Size = new System.Drawing.Size(68, 13);
            this.lblAge_display.TabIndex = 24;
            this.lblAge_display.Text = "Date of birth:";
            // 
            // lblUserID_display
            // 
            this.lblUserID_display.AutoSize = true;
            this.lblUserID_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserID_display.Location = new System.Drawing.Point(14, 85);
            this.lblUserID_display.Name = "lblUserID_display";
            this.lblUserID_display.Size = new System.Drawing.Size(46, 13);
            this.lblUserID_display.TabIndex = 24;
            this.lblUserID_display.Text = "User ID:";
            // 
            // txtUserID_display
            // 
            this.txtUserID_display.Location = new System.Drawing.Point(113, 82);
            this.txtUserID_display.Name = "txtUserID_display";
            this.txtUserID_display.ReadOnly = true;
            this.txtUserID_display.Size = new System.Drawing.Size(243, 20);
            this.txtUserID_display.TabIndex = 30;
            // 
            // txtName_display
            // 
            this.txtName_display.Location = new System.Drawing.Point(113, 33);
            this.txtName_display.Name = "txtName_display";
            this.txtName_display.ReadOnly = true;
            this.txtName_display.Size = new System.Drawing.Size(243, 20);
            this.txtName_display.TabIndex = 31;
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.txtName_display);
            this.grpProfile.Controls.Add(this.txtUserID_display);
            this.grpProfile.Controls.Add(this.lblUserID_display);
            this.grpProfile.Controls.Add(this.lblAge_display);
            this.grpProfile.Controls.Add(this.lblName_display);
            this.grpProfile.Controls.Add(this.txtAge_display);
            this.grpProfile.Controls.Add(this.lblPhone_display);
            this.grpProfile.Controls.Add(this.lblic_display);
            this.grpProfile.Controls.Add(this.lblEmail_display);
            this.grpProfile.Controls.Add(this.txtPhone_display);
            this.grpProfile.Controls.Add(this.txtEmail_display);
            this.grpProfile.Controls.Add(this.txtic_display);
            this.grpProfile.Location = new System.Drawing.Point(401, 214);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(374, 312);
            this.grpProfile.TabIndex = 32;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Selected Technician\'s Profile";
            // 
            // picBrics
            // 
            this.picBrics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBrics.BackgroundImage")));
            this.picBrics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBrics.Location = new System.Drawing.Point(430, 12);
            this.picBrics.Name = "picBrics";
            this.picBrics.Size = new System.Drawing.Size(318, 185);
            this.picBrics.TabIndex = 33;
            this.picBrics.TabStop = false;
            // 
            // prgAdmin
            // 
            this.prgAdmin.Location = new System.Drawing.Point(0, 594);
            this.prgAdmin.Name = "prgAdmin";
            this.prgAdmin.Size = new System.Drawing.Size(1175, 9);
            this.prgAdmin.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgAdmin.TabIndex = 34;
            this.prgAdmin.Click += new System.EventHandler(this.prgAdmin_Click);
            // 
            // errConfirmpass
            // 
            this.errConfirmpass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errConfirmpass.ContainerControl = this;
            // 
            // tmrAdmin
            // 
            this.tmrAdmin.Tick += new System.EventHandler(this.tmrAdmin_Tick);
            // 
            // errRoles
            // 
            this.errRoles.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errRoles.ContainerControl = this;
            // 
            // errName
            // 
            this.errName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errName.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errEmail.ContainerControl = this;
            // 
            // errPhone
            // 
            this.errPhone.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPhone.ContainerControl = this;
            // 
            // erric
            // 
            this.erric.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erric.ContainerControl = this;
            // 
            // errUsername
            // 
            this.errUsername.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errUsername.ContainerControl = this;
            // 
            // errPassword
            // 
            this.errPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPassword.ContainerControl = this;
            // 
            // FormAHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1175, 603);
            this.Controls.Add(this.prgAdmin);
            this.Controls.Add(this.picBrics);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.grpStatistics);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAHome";
            this.Text = "Admin\'s Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtic;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmpass;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Label lblConfirmpass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblic;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbFilterby;
        private System.Windows.Forms.MonthCalendar cdrStatistics;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox lstStatistics;
        private System.Windows.Forms.Label lblFilterby;
        private System.Windows.Forms.HScrollBar hscStatistics;
        private System.Windows.Forms.Label lblPhone_display;
        private System.Windows.Forms.Label lblic_display;
        private System.Windows.Forms.Label lblEmail_display;
        private System.Windows.Forms.TextBox txtPhone_display;
        private System.Windows.Forms.TextBox txtic_display;
        private System.Windows.Forms.TextBox txtEmail_display;
        private System.Windows.Forms.TextBox txtAge_display;
        private System.Windows.Forms.Label lblName_display;
        private System.Windows.Forms.Label lblAge_display;
        private System.Windows.Forms.Label lblUserID_display;
        private System.Windows.Forms.TextBox txtUserID_display;
        private System.Windows.Forms.TextBox txtName_display;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.PictureBox picBrics;
        private System.Windows.Forms.ProgressBar prgAdmin;
        private System.Windows.Forms.DateTimePicker dtpAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errConfirmpass;
        private System.Windows.Forms.Timer tmrAdmin;
        private System.Windows.Forms.ErrorProvider errRoles;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errPhone;
        private System.Windows.Forms.ErrorProvider erric;
        private System.Windows.Forms.ErrorProvider errUsername;
        private System.Windows.Forms.ErrorProvider errPassword;
    }
}

