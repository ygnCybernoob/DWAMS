namespace DWAMS
{
    partial class Report_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Staff));
            this.staff_by_departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Report_Viewer = new DWAMS.DataSet_Report_Viewer();
            this.spdStaffSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staff_by_positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.spdStaffSelectTableAdapter = new DWAMS.DataSet_Report_ViewerTableAdapters.spdStaffSelectTableAdapter();
            this.staff_by_departmentTableAdapter = new DWAMS.DataSet_Report_ViewerTableAdapters.staff_by_departmentTableAdapter();
            this.staff_by_positionTableAdapter = new DWAMS.DataSet_Report_ViewerTableAdapters.staff_by_positionTableAdapter();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.rpvStaff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvStaff_by_department = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvStaff_position = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.staff_by_departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Report_Viewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdStaffSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_by_positionBindingSource)).BeginInit();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // staff_by_departmentBindingSource
            // 
            this.staff_by_departmentBindingSource.DataMember = "staff_by_department";
            this.staff_by_departmentBindingSource.DataSource = this.DataSet_Report_Viewer;
            // 
            // DataSet_Report_Viewer
            // 
            this.DataSet_Report_Viewer.DataSetName = "DataSet_Report_Viewer";
            this.DataSet_Report_Viewer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spdStaffSelectBindingSource
            // 
            this.spdStaffSelectBindingSource.DataMember = "spdStaffSelect";
            this.spdStaffSelectBindingSource.DataSource = this.DataSet_Report_Viewer;
            // 
            // staff_by_positionBindingSource
            // 
            this.staff_by_positionBindingSource.DataMember = "staff_by_position";
            this.staff_by_positionBindingSource.DataSource = this.DataSet_Report_Viewer;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(44, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "ရာထူး";
            // 
            // cboPosition
            // 
            this.cboPosition.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(112, 64);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(237, 29);
            this.cboPosition.TabIndex = 42;
            this.cboPosition.SelectedIndexChanged += new System.EventHandler(this.cboPosition_SelectedIndexChanged);
            this.cboPosition.DropDownClosed += new System.EventHandler(this.cboPosition_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(44, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "ဌာန";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(112, 30);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(237, 29);
            this.cboDepartment.TabIndex = 41;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            this.cboDepartment.DropDownClosed += new System.EventHandler(this.cboDepartment_DropDownClosed);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(379, 30);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(200, 29);
            this.btnShow.TabIndex = 45;
            this.btnShow.Text = "၀န္ထမ္း အားလုံးကို ၾကည့္မည္";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // spdStaffSelectTableAdapter
            // 
            this.spdStaffSelectTableAdapter.ClearBeforeFill = true;
            // 
            // staff_by_departmentTableAdapter
            // 
            this.staff_by_departmentTableAdapter.ClearBeforeFill = true;
            // 
            // staff_by_positionTableAdapter
            // 
            this.staff_by_positionTableAdapter.ClearBeforeFill = true;
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.Controls.Add(this.rpvStaff);
            this.pnlBack.Controls.Add(this.rpvStaff_by_department);
            this.pnlBack.Controls.Add(this.rpvStaff_position);
            this.pnlBack.Location = new System.Drawing.Point(0, 184);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(982, 380);
            this.pnlBack.TabIndex = 46;
            // 
            // rpvStaff
            // 
            this.rpvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Report_Viewer_spdStaffSelect";
            reportDataSource1.Value = this.spdStaffSelectBindingSource;
            this.rpvStaff.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvStaff.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_Staff.rdlc";
            this.rpvStaff.Location = new System.Drawing.Point(0, 0);
            this.rpvStaff.Name = "rpvStaff";
            this.rpvStaff.Size = new System.Drawing.Size(982, 380);
            this.rpvStaff.TabIndex = 0;
            // 
            // rpvStaff_by_department
            // 
            this.rpvStaff_by_department.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_Report_Viewer_staff_by_department";
            reportDataSource2.Value = this.staff_by_departmentBindingSource;
            this.rpvStaff_by_department.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvStaff_by_department.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_Staff_by_department.rdlc";
            this.rpvStaff_by_department.Location = new System.Drawing.Point(0, 0);
            this.rpvStaff_by_department.Name = "rpvStaff_by_department";
            this.rpvStaff_by_department.Size = new System.Drawing.Size(982, 380);
            this.rpvStaff_by_department.TabIndex = 1;
            // 
            // rpvStaff_position
            // 
            this.rpvStaff_position.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet_Report_Viewer_staff_by_position";
            reportDataSource3.Value = this.staff_by_positionBindingSource;
            this.rpvStaff_position.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvStaff_position.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_Staff_by_position.rdlc";
            this.rpvStaff_position.Location = new System.Drawing.Point(0, 0);
            this.rpvStaff_position.Name = "rpvStaff_position";
            this.rpvStaff_position.Size = new System.Drawing.Size(982, 380);
            this.rpvStaff_position.TabIndex = 2;
            // 
            // Report_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(984, 563);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_Staff";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "၀န္ထမ္း အခ်က္အလက္ အစီရင္ခံစာ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStaffReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_by_departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Report_Viewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdStaffSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_by_positionBindingSource)).EndInit();
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.BindingSource spdStaffSelectBindingSource;
        private DataSet_Report_Viewer DataSet_Report_Viewer;
        private DWAMS.DataSet_Report_ViewerTableAdapters.spdStaffSelectTableAdapter spdStaffSelectTableAdapter;
        private System.Windows.Forms.BindingSource staff_by_departmentBindingSource;
        private DWAMS.DataSet_Report_ViewerTableAdapters.staff_by_departmentTableAdapter staff_by_departmentTableAdapter;
        private System.Windows.Forms.BindingSource staff_by_positionBindingSource;
        private DWAMS.DataSet_Report_ViewerTableAdapters.staff_by_positionTableAdapter staff_by_positionTableAdapter;
        private System.Windows.Forms.Panel pnlBack;
        private Microsoft.Reporting.WinForms.ReportViewer rpvStaff;
        private Microsoft.Reporting.WinForms.ReportViewer rpvStaff_by_department;
        private Microsoft.Reporting.WinForms.ReportViewer rpvStaff_position;
    }
}