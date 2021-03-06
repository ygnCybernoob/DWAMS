namespace DWAMS
{
    partial class Report_attendance_summery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_attendance_summery));
            this.spdAttendanceSummeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Report_Viewer = new DWAMS.DataSet_Report_Viewer();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.rpvAttendance_summery = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spdAttendanceSummeryTableAdapter = new DWAMS.DataSet_Report_ViewerTableAdapters.spdAttendanceSummeryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spdAttendanceSummeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Report_Viewer)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // spdAttendanceSummeryBindingSource
            // 
            this.spdAttendanceSummeryBindingSource.DataMember = "spdAttendanceSummery";
            this.spdAttendanceSummeryBindingSource.DataSource = this.DataSet_Report_Viewer;
            // 
            // DataSet_Report_Viewer
            // 
            this.DataSet_Report_Viewer.DataSetName = "DataSet_Report_Viewer";
            this.DataSet_Report_Viewer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.label4);
            this.pnlSide.Controls.Add(this.dtpkDate);
            this.pnlSide.Controls.Add(this.btnShow);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(250, 663);
            this.pnlSide.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "ရက္စြဲ";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "MMMM , yyyy";
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.Location = new System.Drawing.Point(15, 70);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(223, 26);
            this.dtpkDate.TabIndex = 36;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnShow.Location = new System.Drawing.Point(71, 112);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 37);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "စာရင္းကုိ ျပပါ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.Controls.Add(this.rpvAttendance_summery);
            this.pnlBack.Location = new System.Drawing.Point(256, 12);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(916, 639);
            this.pnlBack.TabIndex = 17;
            // 
            // rpvAttendance_summery
            // 
            this.rpvAttendance_summery.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Report_Viewer_spdAttendanceSummery";
            reportDataSource1.Value = this.spdAttendanceSummeryBindingSource;
            this.rpvAttendance_summery.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAttendance_summery.LocalReport.ReportEmbeddedResource = "DWAMS.rdlc_attendance_summery.rdlc";
            this.rpvAttendance_summery.Location = new System.Drawing.Point(0, 0);
            this.rpvAttendance_summery.Name = "rpvAttendance_summery";
            this.rpvAttendance_summery.Size = new System.Drawing.Size(916, 639);
            this.rpvAttendance_summery.TabIndex = 0;
            // 
            // spdAttendanceSummeryTableAdapter
            // 
            this.spdAttendanceSummeryTableAdapter.ClearBeforeFill = true;
            // 
            // Report_attendance_summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_attendance_summery";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "႐ုံးတက္႐ုံးဆင္း အႏွစ္ခ်ဳပ္မွတ္တမ္း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_attendance_summery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spdAttendanceSummeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Report_Viewer)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel pnlBack;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAttendance_summery;
        private System.Windows.Forms.BindingSource spdAttendanceSummeryBindingSource;
        private DataSet_Report_Viewer DataSet_Report_Viewer;
        private DWAMS.DataSet_Report_ViewerTableAdapters.spdAttendanceSummeryTableAdapter spdAttendanceSummeryTableAdapter;
    }
}