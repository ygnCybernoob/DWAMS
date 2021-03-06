namespace DWAMS
{
    partial class FrmAttendanceSummery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvMonthlyAttendance = new System.Windows.Forms.DataGridView();
            this.colStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLateDutyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyDutyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.menuStrip1);
            this.pnlSide.Controls.Add(this.label4);
            this.pnlSide.Controls.Add(this.dtpkDate);
            this.pnlSide.Controls.Add(this.btnShow);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(250, 663);
            this.pnlSide.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 26);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shortCutToolStripMenuItem
            // 
            this.shortCutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.showToolStripMenuItem});
            this.shortCutToolStripMenuItem.Name = "shortCutToolStripMenuItem";
            this.shortCutToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.shortCutToolStripMenuItem.Text = "Short Cut";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.showToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
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
            this.btnShow.Image = global::DWAMS.Properties.Resources.if_Presentation_27867_32x32;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(66, 112);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 37);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "စာရင္းၾကည့္ရန္";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvMonthlyAttendance
            // 
            this.dgvMonthlyAttendance.AllowUserToAddRows = false;
            this.dgvMonthlyAttendance.AllowUserToDeleteRows = false;
            this.dgvMonthlyAttendance.AllowUserToOrderColumns = true;
            this.dgvMonthlyAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonthlyAttendance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlyAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlyAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffId,
            this.colNo,
            this.colStaffCode,
            this.colStaffName,
            this.colLateDutyIn,
            this.colEarlyDutyOut,
            this.colPresent,
            this.colAbsent});
            this.dgvMonthlyAttendance.Location = new System.Drawing.Point(256, 12);
            this.dgvMonthlyAttendance.Name = "dgvMonthlyAttendance";
            this.dgvMonthlyAttendance.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonthlyAttendance.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthlyAttendance.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMonthlyAttendance.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvMonthlyAttendance.RowTemplate.Height = 30;
            this.dgvMonthlyAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthlyAttendance.Size = new System.Drawing.Size(916, 639);
            this.dgvMonthlyAttendance.TabIndex = 16;
            // 
            // colStaffId
            // 
            this.colStaffId.DataPropertyName = "Staffid";
            this.colStaffId.HeaderText = "StaffId";
            this.colStaffId.Name = "colStaffId";
            this.colStaffId.ReadOnly = true;
            this.colStaffId.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 50;
            // 
            // colStaffCode
            // 
            this.colStaffCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffCode.DataPropertyName = "Staffcode";
            this.colStaffCode.HeaderText = "ကုဒ္နံပါတ္";
            this.colStaffCode.Name = "colStaffCode";
            this.colStaffCode.ReadOnly = true;
            // 
            // colStaffName
            // 
            this.colStaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffName.DataPropertyName = "Staffname";
            this.colStaffName.HeaderText = "အမည္";
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.ReadOnly = true;
            // 
            // colLateDutyIn
            // 
            this.colLateDutyIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLateDutyIn.DataPropertyName = "Latedutyin";
            this.colLateDutyIn.HeaderText = "စုစုေပါင္းေနာက္က်ရက္";
            this.colLateDutyIn.Name = "colLateDutyIn";
            this.colLateDutyIn.ReadOnly = true;
            // 
            // colEarlyDutyOut
            // 
            this.colEarlyDutyOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEarlyDutyOut.DataPropertyName = "Earlydutyout";
            this.colEarlyDutyOut.HeaderText = "စုစုေပါင္းေစာထြက္ရက္";
            this.colEarlyDutyOut.Name = "colEarlyDutyOut";
            this.colEarlyDutyOut.ReadOnly = true;
            // 
            // colPresent
            // 
            this.colPresent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPresent.DataPropertyName = "PresentDay";
            this.colPresent.HeaderText = "စုစုေပါင္းရုံးတက္ရက္";
            this.colPresent.Name = "colPresent";
            this.colPresent.ReadOnly = true;
            // 
            // colAbsent
            // 
            this.colAbsent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAbsent.DataPropertyName = "Absentday";
            this.colAbsent.HeaderText = "စုစုေပါင္းရုံးပ်က္ရက္";
            this.colAbsent.Name = "colAbsent";
            this.colAbsent.ReadOnly = true;
            // 
            // FrmAttendanceSummery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.dgvMonthlyAttendance);
            this.Controls.Add(this.pnlSide);
            this.Name = "FrmAttendanceSummery";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "႐ုံးတက္႐ုံးဆင္း အႏွစ္ခ်ဳပ္မွတ္တမ္း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAttendanceSummeryReport_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.DataGridView dgvMonthlyAttendance;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLateDutyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyDutyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsent;
    }
}