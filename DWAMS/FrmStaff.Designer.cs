namespace DWAMS
{
    partial class FrmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShow = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHiredDate = new System.Windows.Forms.DateTimePicker();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.colStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSalary = new System.Windows.Forms.MaskedTextBox();
            this.btn_add_address = new System.Windows.Forms.Button();
            this.btn_add_position = new System.Windows.Forms.Button();
            this.btn_add_department = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.picboxLogo);
            this.pnlSide.Controls.Add(this.menuStrip1);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(168, 669);
            this.pnlSide.TabIndex = 14;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::DWAMS.Properties.Resources.if_User_27887;
            this.picboxLogo.Location = new System.Drawing.Point(31, 25);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(100, 100);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 5;
            this.picboxLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(168, 26);
            this.menuStrip1.TabIndex = 6;
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.showToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = global::DWAMS.Properties.Resources.if_Presentation_27867_32x32;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(908, 201);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 40);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "စာရင္းၾကည့္ရန္";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(680, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "အလုပ္ခန္႔သည့္ရက္";
            // 
            // txtDesp
            // 
            this.txtDesp.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.txtDesp.Location = new System.Drawing.Point(797, 90);
            this.txtDesp.Multiline = true;
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.Size = new System.Drawing.Size(350, 98);
            this.txtDesp.TabIndex = 9;
            this.txtDesp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesp_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(680, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "ရွင္းလင္းခ်က္";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(682, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "အေျခခံလစာ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(212, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "ဖုန္းနံပါတ္";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(212, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "လိပ္စာ";
            // 
            // cboAddress
            // 
            this.cboAddress.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboAddress.Location = new System.Drawing.Point(300, 166);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(237, 29);
            this.cboAddress.TabIndex = 5;
            this.cboAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAddress_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(212, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "ရာထူး";
            // 
            // cboPosition
            // 
            this.cboPosition.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboPosition.Location = new System.Drawing.Point(300, 132);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(237, 29);
            this.cboPosition.TabIndex = 4;
            this.cboPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPosition_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(300, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 29);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(212, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "အမည္";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(212, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "ဌာန";
            // 
            // dtpHiredDate
            // 
            this.dtpHiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHiredDate.Location = new System.Drawing.Point(797, 58);
            this.dtpHiredDate.Name = "dtpHiredDate";
            this.dtpHiredDate.Size = new System.Drawing.Size(237, 26);
            this.dtpHiredDate.TabIndex = 8;
            this.dtpHiredDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpHiredDate_KeyDown);
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboDepartment.Location = new System.Drawing.Point(300, 98);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(237, 29);
            this.cboDepartment.TabIndex = 3;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged_1);
            this.cboDepartment.DropDownClosed += new System.EventHandler(this.cboDepartment_DropDownClosed);
            this.cboDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDepartment_KeyDown);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.txtCode.Location = new System.Drawing.Point(300, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(237, 29);
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(212, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "ကုဒ္နံပါတ္";
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToOrderColumns = true;
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffId,
            this.colPositionId,
            this.colDepartmentId,
            this.colAddressId,
            this.colNo,
            this.colStaffCode,
            this.colStaffName,
            this.colPosition,
            this.colDepartment,
            this.colAddress,
            this.colPhone,
            this.colBasicSalary,
            this.colHiredDate,
            this.colDesp,
            this.colEdit,
            this.colDelete});
            this.dgvStaff.Location = new System.Drawing.Point(174, 267);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStaff.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvStaff.RowTemplate.Height = 30;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(998, 284);
            this.dgvStaff.TabIndex = 13;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // colStaffId
            // 
            this.colStaffId.DataPropertyName = "StaffId";
            this.colStaffId.HeaderText = "StaffId";
            this.colStaffId.Name = "colStaffId";
            this.colStaffId.ReadOnly = true;
            this.colStaffId.Visible = false;
            // 
            // colPositionId
            // 
            this.colPositionId.DataPropertyName = "PositionID";
            this.colPositionId.HeaderText = "PositionId";
            this.colPositionId.Name = "colPositionId";
            this.colPositionId.ReadOnly = true;
            this.colPositionId.Visible = false;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.DataPropertyName = "DepID";
            this.colDepartmentId.HeaderText = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.ReadOnly = true;
            this.colDepartmentId.Visible = false;
            // 
            // colAddressId
            // 
            this.colAddressId.DataPropertyName = "AddID";
            this.colAddressId.HeaderText = "AddressId";
            this.colAddressId.Name = "colAddressId";
            this.colAddressId.ReadOnly = true;
            this.colAddressId.Visible = false;
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
            this.colStaffCode.DataPropertyName = "StaffCode";
            this.colStaffCode.HeaderText = "ကုဒ္နံပါတ္";
            this.colStaffCode.Name = "colStaffCode";
            this.colStaffCode.ReadOnly = true;
            this.colStaffCode.Width = 75;
            // 
            // colStaffName
            // 
            this.colStaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffName.DataPropertyName = "StaffName";
            this.colStaffName.HeaderText = "အမည္";
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "ရာထူး";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colDepartment
            // 
            this.colDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartment.DataPropertyName = "Depname";
            this.colDepartment.HeaderText = "ဌာန";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.DataPropertyName = "Addressname";
            this.colAddress.HeaderText = "ၿမိဳ႕နယ္";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhone.DataPropertyName = "StaffPhone";
            this.colPhone.HeaderText = "ဖုန္းနံပါတ္";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colBasicSalary
            // 
            this.colBasicSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBasicSalary.DataPropertyName = "BasicSalary";
            this.colBasicSalary.HeaderText = "အေျခခံလစာ";
            this.colBasicSalary.Name = "colBasicSalary";
            this.colBasicSalary.ReadOnly = true;
            // 
            // colHiredDate
            // 
            this.colHiredDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHiredDate.DataPropertyName = "HireDate";
            this.colHiredDate.HeaderText = "အလုပ္ခန္႕သည့္ရက္";
            this.colHiredDate.Name = "colHiredDate";
            this.colHiredDate.ReadOnly = true;
            // 
            // colDesp
            // 
            this.colDesp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesp.DataPropertyName = "StaffDesp";
            this.colDesp.HeaderText = "ရွင္းလင္းခ်က္";
            this.colDesp.Name = "colDesp";
            this.colDesp.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "ျပင္ဆင္ရန္";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "ျပင္ဆင္ရန္";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "ဖ်က္ရန္";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "ဖ်က္ရန္";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.mtxtPhone.Location = new System.Drawing.Point(300, 201);
            this.mtxtPhone.Mask = "09   0000  000  000  000  000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.PromptChar = ' ';
            this.mtxtPhone.Size = new System.Drawing.Size(237, 29);
            this.mtxtPhone.TabIndex = 6;
            this.mtxtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtPhone_KeyDown);
            // 
            // mtxtSalary
            // 
            this.mtxtSalary.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.mtxtSalary.Location = new System.Drawing.Point(797, 23);
            this.mtxtSalary.Mask = "000 000 000 000 000 000";
            this.mtxtSalary.Name = "mtxtSalary";
            this.mtxtSalary.PromptChar = ' ';
            this.mtxtSalary.Size = new System.Drawing.Size(237, 29);
            this.mtxtSalary.TabIndex = 7;
            this.mtxtSalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtSalary_KeyDown);
            // 
            // btn_add_address
            // 
            this.btn_add_address.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add_address.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btn_add_address.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_address.Image")));
            this.btn_add_address.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_address.Location = new System.Drawing.Point(543, 165);
            this.btn_add_address.Name = "btn_add_address";
            this.btn_add_address.Size = new System.Drawing.Size(110, 35);
            this.btn_add_address.TabIndex = 48;
            this.btn_add_address.Text = "အသစ္ထည့္ရန္";
            this.btn_add_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_address.UseVisualStyleBackColor = false;
            this.btn_add_address.Click += new System.EventHandler(this.btn_add_address_Click);
            // 
            // btn_add_position
            // 
            this.btn_add_position.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add_position.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btn_add_position.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_position.Image")));
            this.btn_add_position.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_position.Location = new System.Drawing.Point(543, 130);
            this.btn_add_position.Name = "btn_add_position";
            this.btn_add_position.Size = new System.Drawing.Size(110, 35);
            this.btn_add_position.TabIndex = 47;
            this.btn_add_position.Text = "အသစ္ထည့္ရန္";
            this.btn_add_position.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_position.UseVisualStyleBackColor = false;
            this.btn_add_position.Click += new System.EventHandler(this.btn_add_position_Click);
            // 
            // btn_add_department
            // 
            this.btn_add_department.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add_department.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btn_add_department.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_department.Image")));
            this.btn_add_department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_department.Location = new System.Drawing.Point(543, 94);
            this.btn_add_department.Name = "btn_add_department";
            this.btn_add_department.Size = new System.Drawing.Size(110, 35);
            this.btn_add_department.TabIndex = 46;
            this.btn_add_department.Text = "အသစ္ထည့္ရန္";
            this.btn_add_department.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_department.UseVisualStyleBackColor = false;
            this.btn_add_department.Click += new System.EventHandler(this.btn_add_department_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::DWAMS.Properties.Resources.exit_32x32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1040, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "ထြက္ရန္";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DWAMS.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(797, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "သိမ္းရန္";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 563);
            this.Controls.Add(this.btn_add_address);
            this.Controls.Add(this.btn_add_position);
            this.Controls.Add(this.btn_add_department);
            this.Controls.Add(this.mtxtSalary);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDesp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHiredDate);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.pnlSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 464);
            this.Name = "FrmStaff";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "၀န္ထမ္း၏ အခ်က္အလက္မ်ား";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStaffInfo_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHiredDate;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.MaskedTextBox mtxtSalary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Button btn_add_department;
        private System.Windows.Forms.Button btn_add_position;
        private System.Windows.Forms.Button btn_add_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesp;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}