namespace DWAMS
{
    partial class FrmAttendanceEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendanceEntry));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblFooter = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtStaffCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlClock = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.btnAttendanceForm = new System.Windows.Forms.Button();
            this.pnlAttendance = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.timerShutter_Login = new System.Windows.Forms.Timer(this.components);
            this.timerShutter_Attendance = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblRegistered = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlClock.SuspendLayout();
            this.pnlAttendance.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("OCR-B 10 BT", 15F);
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFooter.Location = new System.Drawing.Point(360, 593);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(273, 21);
            this.lblFooter.TabIndex = 34;
            this.lblFooter.Text = "Copyright © DATA WORLD";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemark.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.Color.White;
            this.txtRemark.Location = new System.Drawing.Point(136, 189);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(350, 90);
            this.txtRemark.TabIndex = 4;
            this.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRemark.SizeChanged += new System.EventHandler(this.pnllbl_SizeChanged);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Zawgyi-One", 13F);
            this.lblRemark.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRemark.Location = new System.Drawing.Point(222, 141);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(177, 29);
            this.lblRemark.TabIndex = 28;
            this.lblRemark.Text = "မွတ္ခ်က္ ထည့္သြင္းရန္";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(39)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Zawgyi-One", 13F);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.btnOK.Location = new System.Drawing.Point(249, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(142, 44);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "အတည္ျပဳသည္";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.txtStaffCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffCode.Font = new System.Drawing.Font("Zawgyi-One", 14F);
            this.txtStaffCode.ForeColor = System.Drawing.Color.White;
            this.txtStaffCode.Location = new System.Drawing.Point(136, 96);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Size = new System.Drawing.Size(350, 31);
            this.txtStaffCode.TabIndex = 1;
            this.txtStaffCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStaffCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStaffCode_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Zawgyi-One", 13F);
            this.lblCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCode.Location = new System.Drawing.Point(182, 48);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(286, 29);
            this.lblCode.TabIndex = 27;
            this.lblCode.Text = "၀န္ထမ္း၏ ကုဒ္နံပါတ္ကုိ ထည့္သြင္းရန္";
            // 
            // pnlClock
            // 
            this.pnlClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlClock.Controls.Add(this.lblClock);
            this.pnlClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnlClock.Location = new System.Drawing.Point(307, 0);
            this.pnlClock.Name = "pnlClock";
            this.pnlClock.Size = new System.Drawing.Size(343, 38);
            this.pnlClock.TabIndex = 29;
            this.pnlClock.SizeChanged += new System.EventHandler(this.pnllbl_SizeChanged);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("OCR-B 10 BT", 16F);
            this.lblClock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClock.Location = new System.Drawing.Point(9, 8);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(75, 22);
            this.lblClock.TabIndex = 27;
            this.lblClock.Text = "Clock";
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginForm.FlatAppearance.BorderSize = 0;
            this.btnLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginForm.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnLoginForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(59)))), ((int)(((byte)(41)))));
            this.btnLoginForm.Location = new System.Drawing.Point(196, 0);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(122, 37);
            this.btnLoginForm.TabIndex = 18;
            this.btnLoginForm.TabStop = false;
            this.btnLoginForm.Text = "စနစ္သို႕၀င္ရန္";
            this.btnLoginForm.UseVisualStyleBackColor = false;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // btnAttendanceForm
            // 
            this.btnAttendanceForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(39)))));
            this.btnAttendanceForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendanceForm.FlatAppearance.BorderSize = 0;
            this.btnAttendanceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceForm.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.btnAttendanceForm.ForeColor = System.Drawing.Color.White;
            this.btnAttendanceForm.Location = new System.Drawing.Point(0, 0);
            this.btnAttendanceForm.Name = "btnAttendanceForm";
            this.btnAttendanceForm.Size = new System.Drawing.Size(200, 37);
            this.btnAttendanceForm.TabIndex = 19;
            this.btnAttendanceForm.TabStop = false;
            this.btnAttendanceForm.Text = "႐ုံးတက္႐ုံးဆင္း မွတ္တမ္း";
            this.btnAttendanceForm.UseVisualStyleBackColor = false;
            this.btnAttendanceForm.Click += new System.EventHandler(this.btnAttendanceForm_Click);
            // 
            // pnlAttendance
            // 
            this.pnlAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlAttendance.Controls.Add(this.btnOK);
            this.pnlAttendance.Controls.Add(this.txtRemark);
            this.pnlAttendance.Controls.Add(this.lblRemark);
            this.pnlAttendance.Controls.Add(this.txtStaffCode);
            this.pnlAttendance.Controls.Add(this.lblCode);
            this.pnlAttendance.Location = new System.Drawing.Point(188, 147);
            this.pnlAttendance.Name = "pnlAttendance";
            this.pnlAttendance.Size = new System.Drawing.Size(650, 370);
            this.pnlAttendance.TabIndex = 17;
            this.pnlAttendance.Visible = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Zawgyi-One", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompanyName.Location = new System.Drawing.Point(262, 8);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(415, 98);
            this.lblCompanyName.TabIndex = 34;
            this.lblCompanyName.Text = "DATA WORLD";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.pnlClock);
            this.pnlHeader.Controls.Add(this.btnAttendanceForm);
            this.pnlHeader.Controls.Add(this.btnLoginForm);
            this.pnlHeader.Location = new System.Drawing.Point(188, 110);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(650, 38);
            this.pnlHeader.TabIndex = 33;
            // 
            // timerShutter_Login
            // 
            this.timerShutter_Login.Tick += new System.EventHandler(this.timerShutter_Login_Tick);
            // 
            // timerShutter_Attendance
            // 
            this.timerShutter_Attendance.Tick += new System.EventHandler(this.timerShutter_Attendance_Tick);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlLogin.Controls.Add(this.lblHelp);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUser_name);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtUserName);
            this.pnlLogin.Location = new System.Drawing.Point(188, 147);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(650, 370);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.Visible = false;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHelp.Location = new System.Drawing.Point(106, 272);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(473, 52);
            this.lblHelp.TabIndex = 20;
            this.lblHelp.Text = "အေကာင့္အမည္ကို admin ဟုထည့္ပါ။ လွ်ိဳ႕၀ွက္ကုဒ္ကို admin ဟုထည့္ပါ\r\nလွ်ိဳ႕၀ွက္ကုဒ္ ေ" +
                "ျပာင္းလည္းျပီးပါက ထိုလွ်ိဳ႕၀ွက္ကုဒ္ျဖင့္ျပန္၀င္ေပးပါ";
            this.lblHelp.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPassword.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(266, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(213, 26);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "သင္၏ လွ်ိဳ႕၀ွက္ကုဒ္ကို ထည့္ရန္";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblUser_name
            // 
            this.lblUser_name.AutoSize = true;
            this.lblUser_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.lblUser_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUser_name.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_name.ForeColor = System.Drawing.Color.Silver;
            this.lblUser_name.Location = new System.Drawing.Point(266, 82);
            this.lblUser_name.Name = "lblUser_name";
            this.lblUser_name.Size = new System.Drawing.Size(238, 26);
            this.lblUser_name.TabIndex = 18;
            this.lblUser_name.Text = "သင္၏ အေကာင့္အမည္ကို ထည့္ရန္";
            this.lblUser_name.Click += new System.EventHandler(this.lblUser_name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(127, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "လွ်ဳိ႕၀ွက္ကုဒ္ :";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Wingdings", 21F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(260, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'J';
            this.txtPassword.Size = new System.Drawing.Size(242, 32);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(86)))), ((int)(((byte)(39)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(307, 173);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 38);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "စနစ္သို႕၀င္ရန္";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(127, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "အေကာင့္အမည္ :";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Zawgyi-One", 14F);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(260, 80);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(242, 31);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
            // 
            // lblRegistered
            // 
            this.lblRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistered.AutoSize = true;
            this.lblRegistered.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistered.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistered.Location = new System.Drawing.Point(398, 546);
            this.lblRegistered.Name = "lblRegistered";
            this.lblRegistered.Size = new System.Drawing.Size(171, 21);
            this.lblRegistered.TabIndex = 35;
            this.lblRegistered.Text = "Registered by DATA WORLD";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 26);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shortCutToolStripMenuItem
            // 
            this.shortCutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.shortCutToolStripMenuItem.Name = "shortCutToolStripMenuItem";
            this.shortCutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.shortCutToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.shortCutToolStripMenuItem.Text = "Short Cut";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // FrmAttendanceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(994, 623);
            this.Controls.Add(this.lblRegistered);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.pnlAttendance);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAttendanceEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ေန႕စဥ္ ရံုးတက္ရံုးဆင္း မွတ္တမ္းထည့္သြင္းျခင္း";
            this.Load += new System.EventHandler(this.FrmAttendanceEntry_Load);
            this.pnlClock.ResumeLayout(false);
            this.pnlClock.PerformLayout();
            this.pnlAttendance.ResumeLayout(false);
            this.pnlAttendance.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtStaffCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlClock;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnLoginForm;
        private System.Windows.Forms.Button btnAttendanceForm;
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Timer timerShutter_Login;
        private System.Windows.Forms.Timer timerShutter_Attendance;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUser_name;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblRegistered;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}