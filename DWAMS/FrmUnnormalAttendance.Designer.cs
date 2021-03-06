namespace DWAMS
{
    partial class FrmUnnormalAttendance
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
            this.dgvAttendanceCheckList = new System.Windows.Forms.DataGridView();
            this.colattid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstaffcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstaffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldutyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldutyout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collatedutyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colearlydutyout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coledit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colChecked = new System.Windows.Forms.DataGridViewButtonColumn();
            this.unnormalAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DWAMS.DataSet1();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.chbLatedutyin = new System.Windows.Forms.CheckBox();
            this.chbEarlydutyout = new System.Windows.Forms.CheckBox();
            this.gboxConfirm = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxSearch = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cboStaffName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlHead = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceCheckList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unnormalAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gboxConfirm.SuspendLayout();
            this.gboxSearch.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttendanceCheckList
            // 
            this.dgvAttendanceCheckList.AllowUserToAddRows = false;
            this.dgvAttendanceCheckList.AllowUserToDeleteRows = false;
            this.dgvAttendanceCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendanceCheckList.AutoGenerateColumns = false;
            this.dgvAttendanceCheckList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendanceCheckList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendanceCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceCheckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colattid,
            this.colNo,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.colstaffcode,
            this.colstaffname,
            this.coldutyin,
            this.coldutyout,
            this.collatedutyin,
            this.colearlydutyout,
            this.remark1DataGridViewTextBoxColumn,
            this.remark2DataGridViewTextBoxColumn,
            this.coledit,
            this.colChecked});
            this.dgvAttendanceCheckList.DataSource = this.unnormalAttendanceBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendanceCheckList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendanceCheckList.Location = new System.Drawing.Point(206, 251);
            this.dgvAttendanceCheckList.Name = "dgvAttendanceCheckList";
            this.dgvAttendanceCheckList.ReadOnly = true;
            this.dgvAttendanceCheckList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAttendanceCheckList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvAttendanceCheckList.RowTemplate.Height = 30;
            this.dgvAttendanceCheckList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceCheckList.Size = new System.Drawing.Size(966, 400);
            this.dgvAttendanceCheckList.TabIndex = 0;
            this.dgvAttendanceCheckList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendanceCheckList_CellContentClick);
            // 
            // colattid
            // 
            this.colattid.DataPropertyName = "AttId";
            this.colattid.HeaderText = "AttId";
            this.colattid.Name = "colattid";
            this.colattid.ReadOnly = true;
            this.colattid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 50;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "ရက္စြဲ";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
            this.attendanceDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // coldutyin
            // 
            this.coldutyin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldutyin.DataPropertyName = "DutyIn";
            this.coldutyin.HeaderText = "ရုံးတက္ခ်ိန္";
            this.coldutyin.Name = "coldutyin";
            this.coldutyin.ReadOnly = true;
            // 
            // coldutyout
            // 
            this.coldutyout.DataPropertyName = "StrDutyOut";
            this.coldutyout.HeaderText = "ရုံးဆင္းခ်ိန္";
            this.coldutyout.Name = "coldutyout";
            this.coldutyout.ReadOnly = true;
            // 
            // collatedutyin
            // 
            this.collatedutyin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collatedutyin.DataPropertyName = "LateDutyIn";
            this.collatedutyin.HeaderText = "ေနာက္က်ခ်ိန္(မိနစ္)";
            this.collatedutyin.Name = "collatedutyin";
            this.collatedutyin.ReadOnly = true;
            // 
            // colearlydutyout
            // 
            this.colearlydutyout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colearlydutyout.DataPropertyName = "EarlyDutyOut";
            this.colearlydutyout.HeaderText = "ေစာထြက္ခ်ိန္(မိနစ္)";
            this.colearlydutyout.Name = "colearlydutyout";
            this.colearlydutyout.ReadOnly = true;
            // 
            // remark1DataGridViewTextBoxColumn
            // 
            this.remark1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remark1DataGridViewTextBoxColumn.DataPropertyName = "Remark1";
            this.remark1DataGridViewTextBoxColumn.HeaderText = "ရုံးတက္ခ်ိန္ မွတ္ခ်က္";
            this.remark1DataGridViewTextBoxColumn.Name = "remark1DataGridViewTextBoxColumn";
            this.remark1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remark2DataGridViewTextBoxColumn
            // 
            this.remark2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remark2DataGridViewTextBoxColumn.DataPropertyName = "Remark2";
            this.remark2DataGridViewTextBoxColumn.HeaderText = "ရုံးဆင္းခ်ိန္ မွတ္ခ်က္";
            this.remark2DataGridViewTextBoxColumn.Name = "remark2DataGridViewTextBoxColumn";
            this.remark2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coledit
            // 
            this.coledit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coledit.HeaderText = "ျပင္ဆင္ရန္";
            this.coledit.Name = "coledit";
            this.coledit.ReadOnly = true;
            this.coledit.Text = "ျပင္ဆင္ရန္";
            this.coledit.ToolTipText = " ";
            this.coledit.UseColumnTextForButtonValue = true;
            // 
            // colChecked
            // 
            this.colChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChecked.HeaderText = "စစ္ေဆးျပီး";
            this.colChecked.Name = "colChecked";
            this.colChecked.ReadOnly = true;
            this.colChecked.Text = "စစ္ေဆးျပီး";
            this.colChecked.ToolTipText = " ";
            this.colChecked.UseColumnTextForButtonValue = true;
            // 
            // unnormalAttendanceBindingSource
            // 
            this.unnormalAttendanceBindingSource.DataMember = "UnnormalAttendance";
            this.unnormalAttendanceBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.menuStrip1);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 666);
            this.pnlSide.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 26);
            this.menuStrip1.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ကုဒ္နံပါတ္";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.txtCode.Location = new System.Drawing.Point(142, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(250, 29);
            this.txtCode.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Zawgyi-One", 10F);
            this.txtName.Location = new System.Drawing.Point(142, 68);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(250, 29);
            this.txtName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "အမည္";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnOK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOK.Image = global::DWAMS.Properties.Resources.Check;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(197, 144);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(143, 40);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "အတည္ျပဳရန္";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chbLatedutyin
            // 
            this.chbLatedutyin.AutoSize = true;
            this.chbLatedutyin.Enabled = false;
            this.chbLatedutyin.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.chbLatedutyin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbLatedutyin.Location = new System.Drawing.Point(143, 113);
            this.chbLatedutyin.Name = "chbLatedutyin";
            this.chbLatedutyin.Size = new System.Drawing.Size(103, 25);
            this.chbLatedutyin.TabIndex = 1;
            this.chbLatedutyin.Text = "ေနာက္က်ျခင္း";
            this.chbLatedutyin.UseVisualStyleBackColor = true;
            // 
            // chbEarlydutyout
            // 
            this.chbEarlydutyout.AutoSize = true;
            this.chbEarlydutyout.Enabled = false;
            this.chbEarlydutyout.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.chbEarlydutyout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbEarlydutyout.Location = new System.Drawing.Point(302, 113);
            this.chbEarlydutyout.Name = "chbEarlydutyout";
            this.chbEarlydutyout.Size = new System.Drawing.Size(101, 25);
            this.chbEarlydutyout.TabIndex = 2;
            this.chbEarlydutyout.Text = "ေစာထြက္ျခင္း";
            this.chbEarlydutyout.UseVisualStyleBackColor = true;
            // 
            // gboxConfirm
            // 
            this.gboxConfirm.Controls.Add(this.label3);
            this.gboxConfirm.Controls.Add(this.txtCode);
            this.gboxConfirm.Controls.Add(this.label1);
            this.gboxConfirm.Controls.Add(this.chbEarlydutyout);
            this.gboxConfirm.Controls.Add(this.label2);
            this.gboxConfirm.Controls.Add(this.chbLatedutyin);
            this.gboxConfirm.Controls.Add(this.txtName);
            this.gboxConfirm.Controls.Add(this.btnOK);
            this.gboxConfirm.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.gboxConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxConfirm.Location = new System.Drawing.Point(18, 12);
            this.gboxConfirm.Name = "gboxConfirm";
            this.gboxConfirm.Size = new System.Drawing.Size(444, 200);
            this.gboxConfirm.TabIndex = 21;
            this.gboxConfirm.TabStop = false;
            this.gboxConfirm.Text = "ရုံးတာ၀န္နွင့္ ေနာက္က်ေၾကာင္း (သို႕မဟုတ္) ေစာထြက္ေၾကာင္း အတည္ျပဳရန္";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Admin ၏ခြင့္ျပဳခ်က္ျဖင့္";
            // 
            // gboxSearch
            // 
            this.gboxSearch.Controls.Add(this.btnExit);
            this.gboxSearch.Controls.Add(this.btnShowAll);
            this.gboxSearch.Controls.Add(this.cboStaffName);
            this.gboxSearch.Controls.Add(this.label4);
            this.gboxSearch.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.gboxSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxSearch.Location = new System.Drawing.Point(490, 12);
            this.gboxSearch.Name = "gboxSearch";
            this.gboxSearch.Size = new System.Drawing.Size(412, 200);
            this.gboxSearch.TabIndex = 22;
            this.gboxSearch.TabStop = false;
            this.gboxSearch.Text = "၀န္ထမ္းအမည္ ျဖင့္ရွာေဖြရန္";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExit.Image = global::DWAMS.Properties.Resources.exit_32x32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(269, 85);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 40);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "ထြက္ရန္";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowAll.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnShowAll.Image = global::DWAMS.Properties.Resources.if_Presentation_27867_32x32;
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(99, 85);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(145, 40);
            this.btnShowAll.TabIndex = 23;
            this.btnShowAll.Text = "စာရင္းကိုၾကည့္ရန္";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cboStaffName
            // 
            this.cboStaffName.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboStaffName.FormattingEnabled = true;
            this.cboStaffName.Location = new System.Drawing.Point(99, 33);
            this.cboStaffName.Name = "cboStaffName";
            this.cboStaffName.Size = new System.Drawing.Size(266, 29);
            this.cboStaffName.TabIndex = 21;
            this.cboStaffName.Text = "၀န္ထမ္းအမည္ကုိ ေရြးခ်ယ္ပါ . . .";
            this.cboStaffName.DropDownClosed += new System.EventHandler(this.cboStaffName_DropDownClosed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "၀န္ထမ္းအမည္";
            // 
            // pnlHead
            // 
            this.pnlHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.pnlHead.Controls.Add(this.gboxConfirm);
            this.pnlHead.Controls.Add(this.gboxSearch);
            this.pnlHead.Location = new System.Drawing.Point(200, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(986, 245);
            this.pnlHead.TabIndex = 23;
            // 
            // FrmUnnormalAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.dgvAttendanceCheckList);
            this.Name = "FrmUnnormalAttendance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ရုံးေနာက္က် / ေစာထြက္ သူမ်ားစာရင္း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAttendanceCheckbyAdmin_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUnnormalAttendance_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceCheckList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unnormalAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxConfirm.ResumeLayout(false);
            this.gboxConfirm.PerformLayout();
            this.gboxSearch.ResumeLayout(false);
            this.gboxSearch.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendanceCheckList;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chbLatedutyin;
        private System.Windows.Forms.CheckBox chbEarlydutyout;
        private DataSet1 dataSet1;
        private System.Windows.Forms.GroupBox gboxConfirm;
        private System.Windows.Forms.GroupBox gboxSearch;
        private System.Windows.Forms.ComboBox cboStaffName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource unnormalAttendanceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colattid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldutyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldutyout;
        private System.Windows.Forms.DataGridViewTextBoxColumn collatedutyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colearlydutyout;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn coledit;
        private System.Windows.Forms.DataGridViewButtonColumn colChecked;
    }
}