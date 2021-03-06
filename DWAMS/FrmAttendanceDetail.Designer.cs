namespace DWAMS
{
    partial class FrmAttendanceDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dgvStaffMonthlyAttendance = new System.Windows.Forms.DataGridView();
            this.colStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDutyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDutyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLateDutyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyDutyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMonthlyAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.menuStrip1);
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
            this.pnlSide.Size = new System.Drawing.Size(250, 663);
            this.pnlSide.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 26);
            this.menuStrip1.TabIndex = 32;
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
            this.btnShow.Image = global::DWAMS.Properties.Resources.if_Presentation_27867_32x32;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(65, 357);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 37);
            this.btnShow.TabIndex = 21;
            this.btnShow.Text = "စာရင္းၾကည့္ရန္";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // dgvStaffMonthlyAttendance
            // 
            this.dgvStaffMonthlyAttendance.AllowUserToAddRows = false;
            this.dgvStaffMonthlyAttendance.AllowUserToDeleteRows = false;
            this.dgvStaffMonthlyAttendance.AllowUserToOrderColumns = true;
            this.dgvStaffMonthlyAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffMonthlyAttendance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffMonthlyAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffMonthlyAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMonthlyAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffId,
            this.colNo,
            this.colDate,
            this.colStaffCode,
            this.colStaffName,
            this.colDutyIn,
            this.colDutyOut,
            this.colLateDutyIn,
            this.colEarlyDutyOut,
            this.colRemark1,
            this.colRemark2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffMonthlyAttendance.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStaffMonthlyAttendance.Location = new System.Drawing.Point(256, 12);
            this.dgvStaffMonthlyAttendance.Name = "dgvStaffMonthlyAttendance";
            this.dgvStaffMonthlyAttendance.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffMonthlyAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaffMonthlyAttendance.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStaffMonthlyAttendance.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvStaffMonthlyAttendance.RowTemplate.Height = 30;
            this.dgvStaffMonthlyAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffMonthlyAttendance.Size = new System.Drawing.Size(916, 639);
            this.dgvStaffMonthlyAttendance.TabIndex = 17;
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
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.DataPropertyName = "Attendancedate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDate.HeaderText = "ရက္စြဲ";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStaffName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colStaffName.HeaderText = "အမည္";
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.ReadOnly = true;
            // 
            // colDutyIn
            // 
            this.colDutyIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDutyIn.DataPropertyName = "Dutyin";
            this.colDutyIn.HeaderText = "ရံုးတက္ခ်ိန္";
            this.colDutyIn.Name = "colDutyIn";
            this.colDutyIn.ReadOnly = true;
            // 
            // colDutyOut
            // 
            this.colDutyOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDutyOut.DataPropertyName = "Strdutyout";
            this.colDutyOut.HeaderText = "ရံုးဆင္းခ်ိန္";
            this.colDutyOut.Name = "colDutyOut";
            this.colDutyOut.ReadOnly = true;
            // 
            // colLateDutyIn
            // 
            this.colLateDutyIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLateDutyIn.DataPropertyName = "Latedutyin";
            this.colLateDutyIn.HeaderText = "ေနာက္က်ခ်ိန္(မိနစ္)";
            this.colLateDutyIn.Name = "colLateDutyIn";
            this.colLateDutyIn.ReadOnly = true;
            // 
            // colEarlyDutyOut
            // 
            this.colEarlyDutyOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEarlyDutyOut.DataPropertyName = "Strearlydutyout";
            this.colEarlyDutyOut.HeaderText = "ေစာထြက္ခ်ိန္(မိနစ္)";
            this.colEarlyDutyOut.Name = "colEarlyDutyOut";
            this.colEarlyDutyOut.ReadOnly = true;
            // 
            // colRemark1
            // 
            this.colRemark1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark1.DataPropertyName = "Remark1";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemark1.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRemark1.HeaderText = "ရုံးတက္ခ်ိန္ မွတ္ခ်က္";
            this.colRemark1.Name = "colRemark1";
            this.colRemark1.ReadOnly = true;
            // 
            // colRemark2
            // 
            this.colRemark2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark2.DataPropertyName = "Remark2";
            this.colRemark2.HeaderText = "ရုံးဆင္းခ်ိန္ မွတ္ခ်က္";
            this.colRemark2.Name = "colRemark2";
            this.colRemark2.ReadOnly = true;
            // 
            // FrmAttendanceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.dgvStaffMonthlyAttendance);
            this.Controls.Add(this.pnlSide);
            this.Name = "FrmAttendanceDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "႐ုံးတက္႐ုံဆင္း အေသးစိတ္မွတ္တမ္း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStaffMonthlyAttendanceRecord_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMonthlyAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.DataGridView dgvStaffMonthlyAttendance;
        private System.Windows.Forms.TextBox txtStaffCode;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cboStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkEnd;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private System.Windows.Forms.CheckBox chkboxStaffName;
        private System.Windows.Forms.CheckBox chkboxDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDutyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDutyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLateDutyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyDutyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark2;
    }
}