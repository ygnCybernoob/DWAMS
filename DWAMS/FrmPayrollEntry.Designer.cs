namespace DWAMS
{
    partial class FrmPayrollEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayrollEntry));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkSalaryfor = new System.Windows.Forms.DateTimePicker();
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.colstaffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstaffcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstaffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbasicsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtAbsent = new System.Windows.Forms.TextBox();
            this.txtEarlyOutMinute = new System.Windows.Forms.TextBox();
            this.txtDutyLateMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNetSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxCalculation = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPresentDay = new System.Windows.Forms.TextBox();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.panel1.SuspendLayout();
            this.gboxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.menuStrip1);
            this.pnlSide.Controls.Add(this.picboxLogo);
            this.pnlSide.Controls.Add(this.label4);
            this.pnlSide.Controls.Add(this.dtpkSalaryfor);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 663);
            this.pnlSide.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 26);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shortCutToolStripMenuItem
            // 
            this.shortCutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.showToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.shortCutToolStripMenuItem.Name = "shortCutToolStripMenuItem";
            this.shortCutToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.shortCutToolStripMenuItem.Text = "Short Cut";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.showToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::DWAMS.Properties.Resources.money_calculator;
            this.picboxLogo.Location = new System.Drawing.Point(49, 12);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(100, 100);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 44;
            this.picboxLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "ေပးရမည့္လ";
            // 
            // dtpkSalaryfor
            // 
            this.dtpkSalaryfor.CustomFormat = "MMMM , yyyy";
            this.dtpkSalaryfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpkSalaryfor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkSalaryfor.Location = new System.Drawing.Point(12, 160);
            this.dtpkSalaryfor.Name = "dtpkSalaryfor";
            this.dtpkSalaryfor.Size = new System.Drawing.Size(174, 26);
            this.dtpkSalaryfor.TabIndex = 49;
            this.dtpkSalaryfor.ValueChanged += new System.EventHandler(this.dtpkSalaryfor_ValueChanged);
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AllowUserToAddRows = false;
            this.dgvStaffList.AllowUserToDeleteRows = false;
            this.dgvStaffList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstaffid,
            this.colNo,
            this.colstaffcode,
            this.colstaffname,
            this.colDepartment,
            this.colPosition,
            this.colbasicsalary,
            this.colSelect});
            this.dgvStaffList.Location = new System.Drawing.Point(206, 351);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStaffList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaffList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvStaffList.RowTemplate.Height = 30;
            this.dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffList.Size = new System.Drawing.Size(966, 300);
            this.dgvStaffList.TabIndex = 18;
            this.dgvStaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffList_CellContentClick);
            // 
            // colstaffid
            // 
            this.colstaffid.DataPropertyName = "StaffId";
            this.colstaffid.HeaderText = "StaffId";
            this.colstaffid.Name = "colstaffid";
            this.colstaffid.ReadOnly = true;
            this.colstaffid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 50;
            // 
            // colstaffcode
            // 
            this.colstaffcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colstaffcode.DataPropertyName = "StaffCode";
            this.colstaffcode.HeaderText = "ကုဒ္နံပါတ္";
            this.colstaffcode.Name = "colstaffcode";
            this.colstaffcode.ReadOnly = true;
            // 
            // colstaffname
            // 
            this.colstaffname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colstaffname.DataPropertyName = "StaffName";
            this.colstaffname.HeaderText = "အမည္";
            this.colstaffname.Name = "colstaffname";
            this.colstaffname.ReadOnly = true;
            // 
            // colDepartment
            // 
            this.colDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartment.DataPropertyName = "Department";
            this.colDepartment.HeaderText = "ဌာန";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "ရာထူး";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colbasicsalary
            // 
            this.colbasicsalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colbasicsalary.DataPropertyName = "BasicSalary";
            this.colbasicsalary.HeaderText = "အေျခခံလစာ";
            this.colbasicsalary.Name = "colbasicsalary";
            this.colbasicsalary.ReadOnly = true;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "ေရြးခ်ယ္ရန္";
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Text = "ေရြးခ်ယ္ရန္";
            this.colSelect.ToolTipText = "Select to pay salary";
            this.colSelect.UseColumnTextForButtonValue = true;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCode.Location = new System.Drawing.Point(178, 77);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(300, 26);
            this.txtCode.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Zawgyi-One", 9F);
            this.txtName.Location = new System.Drawing.Point(178, 109);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(300, 27);
            this.txtName.TabIndex = 20;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSalary.Location = new System.Drawing.Point(143, 27);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.ReadOnly = true;
            this.txtBasicSalary.Size = new System.Drawing.Size(200, 26);
            this.txtBasicSalary.TabIndex = 26;
            // 
            // txtAbsent
            // 
            this.txtAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbsent.Location = new System.Drawing.Point(178, 237);
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.ReadOnly = true;
            this.txtAbsent.Size = new System.Drawing.Size(200, 26);
            this.txtAbsent.TabIndex = 25;
            // 
            // txtEarlyOutMinute
            // 
            this.txtEarlyOutMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtEarlyOutMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEarlyOutMinute.Location = new System.Drawing.Point(178, 174);
            this.txtEarlyOutMinute.Name = "txtEarlyOutMinute";
            this.txtEarlyOutMinute.ReadOnly = true;
            this.txtEarlyOutMinute.Size = new System.Drawing.Size(200, 26);
            this.txtEarlyOutMinute.TabIndex = 24;
            // 
            // txtDutyLateMinute
            // 
            this.txtDutyLateMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtDutyLateMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDutyLateMinute.Location = new System.Drawing.Point(178, 142);
            this.txtDutyLateMinute.Name = "txtDutyLateMinute";
            this.txtDutyLateMinute.ReadOnly = true;
            this.txtDutyLateMinute.Size = new System.Drawing.Size(200, 26);
            this.txtDutyLateMinute.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "ကုဒ္နံပါတ္";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "အမည္";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(34, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "အေျခခံလစာ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(31, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "စုစုေပါင္း ရုံးပ်က္ရက္";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(31, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 21);
            this.label20.TabIndex = 32;
            this.label20.Text = "စုစုေပါင္း ေစာထြက္ခ်ိန္";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(31, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "စုစုေပါင္း ေနာက္က်ခ်ိန္";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(34, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "ဒဏ္ေၾကးေငြ";
            // 
            // txtFine
            // 
            this.txtFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.Location = new System.Drawing.Point(143, 61);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(200, 26);
            this.txtFine.TabIndex = 35;
            this.txtFine.Text = "0";
            this.txtFine.Leave += new System.EventHandler(this.txtFine_Leave);
            this.txtFine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFine_KeyUp);
            this.txtFine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFine_KeyPress);
            this.txtFine.Enter += new System.EventHandler(this.txtFine_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(34, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 40;
            this.label10.Text = "အသားတင္လစာ";
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNetSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetSalary.Location = new System.Drawing.Point(143, 125);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.ReadOnly = true;
            this.txtNetSalary.Size = new System.Drawing.Size(200, 26);
            this.txtNetSalary.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(34, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "ရက္မွန္ေၾကး";
            // 
            // txtBonus
            // 
            this.txtBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Location = new System.Drawing.Point(143, 93);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(200, 26);
            this.txtBonus.TabIndex = 37;
            this.txtBonus.Text = "0";
            this.txtBonus.Leave += new System.EventHandler(this.txtBonus_Leave);
            this.txtBonus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBonus_KeyUp);
            this.txtBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBonus_KeyPress);
            this.txtBonus.Enter += new System.EventHandler(this.txtBonus_Enter);
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(178, 36);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(300, 29);
            this.cboDepartment.TabIndex = 43;
            this.cboDepartment.Text = "ဌာနကုိ ေရြးခ်ယ္ပါ . . .";
            this.cboDepartment.DropDownClosed += new System.EventHandler(this.cboDepartment_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "ဌာန";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.gboxCalculation);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPresentDay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAbsent);
            this.panel1.Controls.Add(this.txtEarlyOutMinute);
            this.panel1.Controls.Add(this.txtDutyLateMinute);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 345);
            this.panel1.TabIndex = 47;
            // 
            // gboxCalculation
            // 
            this.gboxCalculation.Controls.Add(this.label10);
            this.gboxCalculation.Controls.Add(this.txtNetSalary);
            this.gboxCalculation.Controls.Add(this.btnOk);
            this.gboxCalculation.Controls.Add(this.label11);
            this.gboxCalculation.Controls.Add(this.btnCancel);
            this.gboxCalculation.Controls.Add(this.txtBonus);
            this.gboxCalculation.Controls.Add(this.label9);
            this.gboxCalculation.Controls.Add(this.txtBasicSalary);
            this.gboxCalculation.Controls.Add(this.txtFine);
            this.gboxCalculation.Controls.Add(this.label5);
            this.gboxCalculation.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.gboxCalculation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxCalculation.Location = new System.Drawing.Point(526, 12);
            this.gboxCalculation.Name = "gboxCalculation";
            this.gboxCalculation.Size = new System.Drawing.Size(440, 283);
            this.gboxCalculation.TabIndex = 51;
            this.gboxCalculation.TabStop = false;
            this.gboxCalculation.Text = "လစာ တြက္ခ်က္ျခင္း";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Control;
            this.btnOk.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnOk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOk.Image = global::DWAMS.Properties.Resources.save1;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(132, 179);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 40);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "သိမ္းရန္";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancel.Image = global::DWAMS.Properties.Resources.gtk_cancel_32x32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(243, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 40);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "မလုပ္ေသးပါ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(31, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "စုစုေပါင္း ရုံးတက္ရက္";
            // 
            // txtPresentDay
            // 
            this.txtPresentDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPresentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentDay.Location = new System.Drawing.Point(178, 206);
            this.txtPresentDay.Name = "txtPresentDay";
            this.txtPresentDay.ReadOnly = true;
            this.txtPresentDay.Size = new System.Drawing.Size(200, 26);
            this.txtPresentDay.TabIndex = 46;
            // 
            // FrmPayrollEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStaffList);
            this.Controls.Add(this.pnlSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPayrollEntry";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "လစာေပးရန္";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSalaryPayment_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gboxCalculation.ResumeLayout(false);
            this.gboxCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtAbsent;
        private System.Windows.Forms.TextBox txtEarlyOutMinute;
        private System.Windows.Forms.TextBox txtDutyLateMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPresentDay;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.DateTimePicker dtpkSalaryfor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboxCalculation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbasicsalary;
        private System.Windows.Forms.DataGridViewButtonColumn colSelect;
    }
}