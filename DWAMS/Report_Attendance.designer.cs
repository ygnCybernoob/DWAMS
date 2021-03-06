namespace DWAMS
{
    partial class Report_Attendance
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Attendance));
            this.Attendance_selectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_attendance = new DWAMS.DataSet_attendance();
            this.Attendance_select_by_dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Attendance_by_staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Attendance_by_staff_and_dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvAttendance = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.rpvAttendance_by_date = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvAttendance_by_staff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvAttendance_by_staff_date = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkStart = new System.Windows.Forms.DateTimePicker();
            this.dtpkEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkboxDate = new System.Windows.Forms.CheckBox();
            this.chkboxStaffName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffCode = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.cboStaffName = new System.Windows.Forms.ComboBox();
            this.Attendance_selectTableAdapter = new DWAMS.DataSet_attendanceTableAdapters.Attendance_selectTableAdapter();
            this.Attendance_by_staff_and_dateTableAdapter = new DWAMS.DataSet_attendanceTableAdapters.Attendance_by_staff_and_dateTableAdapter();
            this.Attendance_by_staffTableAdapter = new DWAMS.DataSet_attendanceTableAdapters.Attendance_by_staffTableAdapter();
            this.Attendance_select_by_dateTableAdapter = new DWAMS.DataSet_attendanceTableAdapters.Attendance_select_by_dateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_selectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_select_by_dateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_by_staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_by_staff_and_dateBindingSource)).BeginInit();
            this.pnlBack.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Attendance_selectBindingSource
            // 
            this.Attendance_selectBindingSource.DataMember = "Attendance_select";
            this.Attendance_selectBindingSource.DataSource = this.DataSet_attendance;
            // 
            // DataSet_attendance
            // 
            this.DataSet_attendance.DataSetName = "DataSet_attendance";
            this.DataSet_attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Attendance_select_by_dateBindingSource
            // 
            this.Attendance_select_by_dateBindingSource.DataMember = "Attendance_select_by_date";
            this.Attendance_select_by_dateBindingSource.DataSource = this.DataSet_attendance;
            // 
            // Attendance_by_staffBindingSource
            // 
            this.Attendance_by_staffBindingSource.DataMember = "Attendance_by_staff";
            this.Attendance_by_staffBindingSource.DataSource = this.DataSet_attendance;
            // 
            // Attendance_by_staff_and_dateBindingSource
            // 
            this.Attendance_by_staff_and_dateBindingSource.DataMember = "Attendance_by_staff_and_date";
            this.Attendance_by_staff_and_dateBindingSource.DataSource = this.DataSet_attendance;
            // 
            // rpvAttendance
            // 
            this.rpvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_attendance_Attendance_select";
            reportDataSource1.Value = this.Attendance_selectBindingSource;
            this.rpvAttendance.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAttendance.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_Attendance.rdlc";
            this.rpvAttendance.Location = new System.Drawing.Point(0, 0);
            this.rpvAttendance.Name = "rpvAttendance";
            this.rpvAttendance.Size = new System.Drawing.Size(916, 730);
            this.rpvAttendance.TabIndex = 0;
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.Controls.Add(this.rpvAttendance_by_date);
            this.pnlBack.Controls.Add(this.rpvAttendance_by_staff);
            this.pnlBack.Controls.Add(this.rpvAttendance);
            this.pnlBack.Controls.Add(this.rpvAttendance_by_staff_date);
            this.pnlBack.Location = new System.Drawing.Point(256, 9);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(916, 730);
            this.pnlBack.TabIndex = 1;
            // 
            // rpvAttendance_by_date
            // 
            this.rpvAttendance_by_date.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_attendance_Attendance_select_by_date";
            reportDataSource2.Value = this.Attendance_select_by_dateBindingSource;
            this.rpvAttendance_by_date.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvAttendance_by_date.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_Attendance_select_by_date.rdlc";
            this.rpvAttendance_by_date.Location = new System.Drawing.Point(0, 0);
            this.rpvAttendance_by_date.Name = "rpvAttendance_by_date";
            this.rpvAttendance_by_date.Size = new System.Drawing.Size(916, 730);
            this.rpvAttendance_by_date.TabIndex = 2;
            // 
            // rpvAttendance_by_staff
            // 
            this.rpvAttendance_by_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet_attendance_Attendance_by_staff";
            reportDataSource3.Value = this.Attendance_by_staffBindingSource;
            this.rpvAttendance_by_staff.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvAttendance_by_staff.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_Attendance_by_staff.rdlc";
            this.rpvAttendance_by_staff.Location = new System.Drawing.Point(0, 0);
            this.rpvAttendance_by_staff.Name = "rpvAttendance_by_staff";
            this.rpvAttendance_by_staff.Size = new System.Drawing.Size(916, 730);
            this.rpvAttendance_by_staff.TabIndex = 1;
            // 
            // rpvAttendance_by_staff_date
            // 
            this.rpvAttendance_by_staff_date.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet_attendance_Attendance_by_staff_and_date";
            reportDataSource4.Value = this.Attendance_by_staff_and_dateBindingSource;
            this.rpvAttendance_by_staff_date.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvAttendance_by_staff_date.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_Attendance_by_staff_and_date.rdlc";
            this.rpvAttendance_by_staff_date.Location = new System.Drawing.Point(0, 0);
            this.rpvAttendance_by_staff_date.Name = "rpvAttendance_by_staff_date";
            this.rpvAttendance_by_staff_date.Size = new System.Drawing.Size(916, 730);
            this.rpvAttendance_by_staff_date.TabIndex = 3;
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.groupBox1);
            this.pnlSide.Controls.Add(this.chkboxDate);
            this.pnlSide.Controls.Add(this.chkboxStaffName);
            this.pnlSide.Controls.Add(this.label2);
            this.pnlSide.Controls.Add(this.label1);
            this.pnlSide.Controls.Add(this.txtStaffCode);
            this.pnlSide.Controls.Add(this.btnShow);
            this.pnlSide.Controls.Add(this.cboStaffName);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(250, 751);
            this.pnlSide.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkStart);
            this.groupBox1.Controls.Add(this.dtpkEnd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(4, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 173);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ရက္စြဲျဖင့္ ရွာရန္";
            // 
            // dtpkStart
            // 
            this.dtpkStart.Enabled = false;
            this.dtpkStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkStart.Location = new System.Drawing.Point(13, 41);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(223, 26);
            this.dtpkStart.TabIndex = 25;
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.Enabled = false;
            this.dtpkEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkEnd.Location = new System.Drawing.Point(13, 104);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.Size = new System.Drawing.Size(223, 26);
            this.dtpkEnd.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(10, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "မွ . . . . .";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(172, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = ". . . . . ထိ";
            // 
            // chkboxDate
            // 
            this.chkboxDate.AutoSize = true;
            this.chkboxDate.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.chkboxDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkboxDate.Location = new System.Drawing.Point(9, 141);
            this.chkboxDate.Name = "chkboxDate";
            this.chkboxDate.Size = new System.Drawing.Size(77, 25);
            this.chkboxDate.TabIndex = 30;
            this.chkboxDate.Text = "ရက္စြဲျဖင့္";
            this.chkboxDate.UseVisualStyleBackColor = true;
            this.chkboxDate.CheckStateChanged += new System.EventHandler(this.chkboxDate_CheckStateChanged);
            // 
            // chkboxStaffName
            // 
            this.chkboxStaffName.AutoSize = true;
            this.chkboxStaffName.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.chkboxStaffName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkboxStaffName.Location = new System.Drawing.Point(163, 34);
            this.chkboxStaffName.Name = "chkboxStaffName";
            this.chkboxStaffName.Size = new System.Drawing.Size(82, 25);
            this.chkboxStaffName.TabIndex = 29;
            this.chkboxStaffName.Text = "အမည္ျဖင့္";
            this.chkboxStaffName.UseVisualStyleBackColor = true;
            this.chkboxStaffName.CheckStateChanged += new System.EventHandler(this.chkboxStaffName_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "၀န္ထမ္းကုဒ္";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "၀န္ထမ္းအမည္";
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.Enabled = false;
            this.txtStaffCode.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffCode.Location = new System.Drawing.Point(12, 88);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Size = new System.Drawing.Size(145, 29);
            this.txtStaffCode.TabIndex = 22;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnShow.Location = new System.Drawing.Point(65, 357);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 37);
            this.btnShow.TabIndex = 21;
            this.btnShow.Text = "စာရင္းကုိ ျပပါ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cboStaffName
            // 
            this.cboStaffName.Enabled = false;
            this.cboStaffName.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffName.FormattingEnabled = true;
            this.cboStaffName.Location = new System.Drawing.Point(12, 32);
            this.cboStaffName.Name = "cboStaffName";
            this.cboStaffName.Size = new System.Drawing.Size(145, 29);
            this.cboStaffName.TabIndex = 20;
            this.cboStaffName.DropDownClosed += new System.EventHandler(this.cboStaffName_DropDownClosed);
            // 
            // Attendance_selectTableAdapter
            // 
            this.Attendance_selectTableAdapter.ClearBeforeFill = true;
            // 
            // Attendance_by_staff_and_dateTableAdapter
            // 
            this.Attendance_by_staff_and_dateTableAdapter.ClearBeforeFill = true;
            // 
            // Attendance_by_staffTableAdapter
            // 
            this.Attendance_by_staffTableAdapter.ClearBeforeFill = true;
            // 
            // Attendance_select_by_dateTableAdapter
            // 
            this.Attendance_select_by_dateTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 751);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_Attendance";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "႐ုံးတက္႐ုံဆင္း အေသးစိတ္ အစီအရင္ခံစာ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_selectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_select_by_dateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_by_staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_by_staff_and_dateBindingSource)).EndInit();
            this.pnlBack.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAttendance;
        private System.Windows.Forms.Panel pnlBack;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAttendance_by_staff;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private System.Windows.Forms.DateTimePicker dtpkEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkboxDate;
        private System.Windows.Forms.CheckBox chkboxStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffCode;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cboStaffName;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAttendance_by_date;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAttendance_by_staff_date;
        private DataSet_attendance DataSet_attendance;
        private System.Windows.Forms.BindingSource Attendance_selectBindingSource;
        private DWAMS.DataSet_attendanceTableAdapters.Attendance_selectTableAdapter Attendance_selectTableAdapter;
        private System.Windows.Forms.BindingSource Attendance_by_staff_and_dateBindingSource;
        private DWAMS.DataSet_attendanceTableAdapters.Attendance_by_staff_and_dateTableAdapter Attendance_by_staff_and_dateTableAdapter;
        private System.Windows.Forms.BindingSource Attendance_by_staffBindingSource;
        private DWAMS.DataSet_attendanceTableAdapters.Attendance_by_staffTableAdapter Attendance_by_staffTableAdapter;
        private System.Windows.Forms.BindingSource Attendance_select_by_dateBindingSource;
        private DWAMS.DataSet_attendanceTableAdapters.Attendance_select_by_dateTableAdapter Attendance_select_by_dateTableAdapter;
    }
}