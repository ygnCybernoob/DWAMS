namespace DWAMS
{
    partial class FrmMonthlyPayroll
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
            this.dgvStaffMonthlyPayroll = new System.Windows.Forms.DataGridView();
            this.totalStaffMonthlyPayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DWAMS.DataSet1();
            this.colStaffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpaymentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmonthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstaffcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstaffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpaymentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbasicsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnetsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMonthlyPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalStaffMonthlyPayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.pnlSide.TabIndex = 16;
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
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "ရက္စြဲ";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "MMMM , yyyy";
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.Location = new System.Drawing.Point(12, 63);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(223, 26);
            this.dtpkDate.TabIndex = 40;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnShow.Location = new System.Drawing.Point(68, 105);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 37);
            this.btnShow.TabIndex = 39;
            this.btnShow.Text = "စာရင္းၾကည့္ရန္";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvStaffMonthlyPayroll
            // 
            this.dgvStaffMonthlyPayroll.AllowUserToAddRows = false;
            this.dgvStaffMonthlyPayroll.AllowUserToDeleteRows = false;
            this.dgvStaffMonthlyPayroll.AllowUserToOrderColumns = true;
            this.dgvStaffMonthlyPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffMonthlyPayroll.AutoGenerateColumns = false;
            this.dgvStaffMonthlyPayroll.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffMonthlyPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffMonthlyPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMonthlyPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffid,
            this.colpaymentid,
            this.colNo,
            this.colmonthdate,
            this.colstaffcode,
            this.colstaffname,
            this.colpaymentdate,
            this.colbasicsalary,
            this.colbonus,
            this.colfine,
            this.colnetsalary});
            this.dgvStaffMonthlyPayroll.DataSource = this.totalStaffMonthlyPayrollBindingSource;
            this.dgvStaffMonthlyPayroll.Location = new System.Drawing.Point(256, 12);
            this.dgvStaffMonthlyPayroll.Name = "dgvStaffMonthlyPayroll";
            this.dgvStaffMonthlyPayroll.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaffMonthlyPayroll.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaffMonthlyPayroll.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStaffMonthlyPayroll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvStaffMonthlyPayroll.RowTemplate.Height = 30;
            this.dgvStaffMonthlyPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffMonthlyPayroll.Size = new System.Drawing.Size(916, 639);
            this.dgvStaffMonthlyPayroll.TabIndex = 18;
            // 
            // totalStaffMonthlyPayrollBindingSource
            // 
            this.totalStaffMonthlyPayrollBindingSource.DataMember = "TotalStaffMonthlyPayroll";
            this.totalStaffMonthlyPayrollBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colStaffid
            // 
            this.colStaffid.DataPropertyName = "StaffId";
            this.colStaffid.HeaderText = "StaffId";
            this.colStaffid.Name = "colStaffid";
            this.colStaffid.ReadOnly = true;
            this.colStaffid.Visible = false;
            // 
            // colpaymentid
            // 
            this.colpaymentid.DataPropertyName = "PaymentId";
            this.colpaymentid.HeaderText = "PaymentId";
            this.colpaymentid.Name = "colpaymentid";
            this.colpaymentid.ReadOnly = true;
            this.colpaymentid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 55;
            // 
            // colmonthdate
            // 
            this.colmonthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colmonthdate.DataPropertyName = "MonthDate";
            this.colmonthdate.FillWeight = 28.76579F;
            this.colmonthdate.HeaderText = "ရက္စြဲ";
            this.colmonthdate.Name = "colmonthdate";
            this.colmonthdate.ReadOnly = true;
            // 
            // colstaffcode
            // 
            this.colstaffcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colstaffcode.DataPropertyName = "StaffCode";
            this.colstaffcode.FillWeight = 28.76579F;
            this.colstaffcode.HeaderText = "ကုဒ္နံပါတ္";
            this.colstaffcode.Name = "colstaffcode";
            this.colstaffcode.ReadOnly = true;
            // 
            // colstaffname
            // 
            this.colstaffname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colstaffname.DataPropertyName = "StaffName";
            this.colstaffname.FillWeight = 28.76579F;
            this.colstaffname.HeaderText = "အမည္";
            this.colstaffname.Name = "colstaffname";
            this.colstaffname.ReadOnly = true;
            // 
            // colpaymentdate
            // 
            this.colpaymentdate.DataPropertyName = "PaymentDate";
            this.colpaymentdate.FillWeight = 110F;
            this.colpaymentdate.HeaderText = "လစာေပးသည့္ ရက္စြဲ";
            this.colpaymentdate.Name = "colpaymentdate";
            this.colpaymentdate.ReadOnly = true;
            this.colpaymentdate.Width = 110;
            // 
            // colbasicsalary
            // 
            this.colbasicsalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbasicsalary.DataPropertyName = "BasicSalary";
            this.colbasicsalary.FillWeight = 28.76579F;
            this.colbasicsalary.HeaderText = "အေျခခံလစာ";
            this.colbasicsalary.Name = "colbasicsalary";
            this.colbasicsalary.ReadOnly = true;
            // 
            // colbonus
            // 
            this.colbonus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbonus.DataPropertyName = "Bonus";
            this.colbonus.FillWeight = 28.76579F;
            this.colbonus.HeaderText = "ရက္မွန္ေၾကး";
            this.colbonus.Name = "colbonus";
            this.colbonus.ReadOnly = true;
            // 
            // colfine
            // 
            this.colfine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colfine.DataPropertyName = "Fine";
            this.colfine.FillWeight = 28.76579F;
            this.colfine.HeaderText = "ဒဏ္ေၾကး";
            this.colfine.Name = "colfine";
            this.colfine.ReadOnly = true;
            // 
            // colnetsalary
            // 
            this.colnetsalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colnetsalary.DataPropertyName = "NetSalary";
            this.colnetsalary.FillWeight = 28.76579F;
            this.colnetsalary.HeaderText = "အသားတင္ လစာ";
            this.colnetsalary.Name = "colnetsalary";
            this.colnetsalary.ReadOnly = true;
            // 
            // FrmMonthlyPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.dgvStaffMonthlyPayroll);
            this.Controls.Add(this.pnlSide);
            this.Name = "FrmMonthlyPayroll";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "၀န္ထမ္းလစာမွတ္တမ္း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTotalStaffMonthlyPayroll_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMonthlyPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalStaffMonthlyPayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.DataGridView dgvStaffMonthlyPayroll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.BindingSource totalStaffMonthlyPayrollBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpaymentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmonthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpaymentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbasicsalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnetsalary;
    }
}