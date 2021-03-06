namespace DWAMS
{
    partial class FrmAbsent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAbsent = new System.Windows.Forms.DataGridView();
            this.colAbsentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAbsentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHide = new System.Windows.Forms.Panel();
            this.dgvStaffMonthlyAttendance = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDutyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDutyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLateDutyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyDutyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPresent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsent)).BeginInit();
            this.pnlHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMonthlyAttendance)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.pictureBox1);
            this.pnlSide.Controls.Add(this.btnShow);
            this.pnlSide.Controls.Add(this.label4);
            this.pnlSide.Controls.Add(this.dtpkDate);
            this.pnlSide.Controls.Add(this.menuStrip1);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(250, 565);
            this.pnlSide.TabIndex = 16;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnShow.Image = global::DWAMS.Properties.Resources.if_Presentation_27867_32x32;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(66, 103);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(123, 37);
            this.btnShow.TabIndex = 42;
            this.btnShow.Text = "စာရင္းၾကည့္ရန္";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 40;
            this.label4.Text = "ရက္စြဲ";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "MMMM , yyyy";
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.Location = new System.Drawing.Point(12, 61);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(223, 26);
            this.dtpkDate.TabIndex = 39;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 26);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shortCutToolStripMenuItem
            // 
            this.shortCutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.showToolStripMenuItem,
            this.presentListToolStripMenuItem});
            this.shortCutToolStripMenuItem.Name = "shortCutToolStripMenuItem";
            this.shortCutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.shortCutToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.shortCutToolStripMenuItem.Text = "Short Cut";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.showToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // presentListToolStripMenuItem
            // 
            this.presentListToolStripMenuItem.Name = "presentListToolStripMenuItem";
            this.presentListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.presentListToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.presentListToolStripMenuItem.Text = "Present List";
            this.presentListToolStripMenuItem.Click += new System.EventHandler(this.presentListToolStripMenuItem_Click);
            // 
            // dgvAbsent
            // 
            this.dgvAbsent.AllowUserToAddRows = false;
            this.dgvAbsent.AllowUserToDeleteRows = false;
            this.dgvAbsent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbsent.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAbsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAbsentid,
            this.colStaffid,
            this.colNo2,
            this.colSelect,
            this.colAbsentdate,
            this.colStaffcode,
            this.colStaffname,
            this.colPosition,
            this.colDeparment,
            this.colPhone});
            this.dgvAbsent.Location = new System.Drawing.Point(259, 122);
            this.dgvAbsent.Name = "dgvAbsent";
            this.dgvAbsent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAbsent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvAbsent.RowTemplate.Height = 30;
            this.dgvAbsent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsent.Size = new System.Drawing.Size(816, 429);
            this.dgvAbsent.TabIndex = 17;
            // 
            // colAbsentid
            // 
            this.colAbsentid.DataPropertyName = "absentid";
            this.colAbsentid.HeaderText = "AbsentId";
            this.colAbsentid.Name = "colAbsentid";
            this.colAbsentid.Visible = false;
            // 
            // colStaffid
            // 
            this.colStaffid.DataPropertyName = "staffid";
            this.colStaffid.HeaderText = "Staffid";
            this.colStaffid.Name = "colStaffid";
            this.colStaffid.Visible = false;
            // 
            // colNo2
            // 
            this.colNo2.DataPropertyName = "No";
            this.colNo2.HeaderText = "စဉ္";
            this.colNo2.Name = "colNo2";
            this.colNo2.Width = 50;
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "ေရြးခ်ယ္ပါ";
            this.colSelect.Name = "colSelect";
            // 
            // colAbsentdate
            // 
            this.colAbsentdate.DataPropertyName = "absentdate";
            this.colAbsentdate.HeaderText = "ရက္စြဲ";
            this.colAbsentdate.Name = "colAbsentdate";
            this.colAbsentdate.Width = 150;
            // 
            // colStaffcode
            // 
            this.colStaffcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffcode.DataPropertyName = "staffcode";
            this.colStaffcode.HeaderText = "ကုဒ္နံပါတ္";
            this.colStaffcode.Name = "colStaffcode";
            // 
            // colStaffname
            // 
            this.colStaffname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffname.DataPropertyName = "staffname";
            this.colStaffname.HeaderText = "၀န္းထမ္းအမည္";
            this.colStaffname.Name = "colStaffname";
            // 
            // colPosition
            // 
            this.colPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPosition.DataPropertyName = "position";
            this.colPosition.HeaderText = "ရာထူး";
            this.colPosition.Name = "colPosition";
            // 
            // colDeparment
            // 
            this.colDeparment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDeparment.DataPropertyName = "department";
            this.colDeparment.HeaderText = "ဌာန";
            this.colDeparment.Name = "colDeparment";
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhone.DataPropertyName = "staffphone";
            this.colPhone.HeaderText = "ဖုန္းနံပါတ္";
            this.colPhone.Name = "colPhone";
            // 
            // pnlHide
            // 
            this.pnlHide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHide.Controls.Add(this.dgvStaffMonthlyAttendance);
            this.pnlHide.Location = new System.Drawing.Point(259, 122);
            this.pnlHide.Name = "pnlHide";
            this.pnlHide.Size = new System.Drawing.Size(816, 429);
            this.pnlHide.TabIndex = 20;
            this.pnlHide.Visible = false;
            // 
            // dgvStaffMonthlyAttendance
            // 
            this.dgvStaffMonthlyAttendance.AllowUserToAddRows = false;
            this.dgvStaffMonthlyAttendance.AllowUserToDeleteRows = false;
            this.dgvStaffMonthlyAttendance.AllowUserToOrderColumns = true;
            this.dgvStaffMonthlyAttendance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffMonthlyAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvStaffMonthlyAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMonthlyAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colNo,
            this.colDate,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colDutyIn,
            this.colDutyOut,
            this.colLateDutyIn,
            this.colEarlyDutyOut,
            this.colRemark1,
            this.colRemark2});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffMonthlyAttendance.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvStaffMonthlyAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaffMonthlyAttendance.Location = new System.Drawing.Point(0, 0);
            this.dgvStaffMonthlyAttendance.Name = "dgvStaffMonthlyAttendance";
            this.dgvStaffMonthlyAttendance.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffMonthlyAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaffMonthlyAttendance.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvStaffMonthlyAttendance.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvStaffMonthlyAttendance.RowTemplate.Height = 30;
            this.dgvStaffMonthlyAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffMonthlyAttendance.Size = new System.Drawing.Size(816, 429);
            this.dgvStaffMonthlyAttendance.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Staffid";
            this.dataGridViewTextBoxColumn1.HeaderText = "StaffId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle19;
            this.colDate.HeaderText = "ရက္စြဲ";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Staffcode";
            this.dataGridViewTextBoxColumn2.HeaderText = "ကုဒ္နံပါတ္";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Staffname";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn3.HeaderText = "၀န္ထမ္းအမည္";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // colDutyIn
            // 
            this.colDutyIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDutyIn.DataPropertyName = "Dutyin";
            this.colDutyIn.HeaderText = "ရုံးတက္ခ်ိန္";
            this.colDutyIn.Name = "colDutyIn";
            this.colDutyIn.ReadOnly = true;
            // 
            // colDutyOut
            // 
            this.colDutyOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDutyOut.DataPropertyName = "Strdutyout";
            this.colDutyOut.HeaderText = "ရုံဆင္းခ်ိန္";
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
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemark1.DefaultCellStyle = dataGridViewCellStyle21;
            this.colRemark1.HeaderText = "ရံုးတက္ခ်ိန္ မွတ္ခ်က္";
            this.colRemark1.Name = "colRemark1";
            this.colRemark1.ReadOnly = true;
            // 
            // colRemark2
            // 
            this.colRemark2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark2.DataPropertyName = "Remark2";
            this.colRemark2.HeaderText = "ရံုးဆင္းခ်ိန္ မွတ္ခ်က္";
            this.colRemark2.Name = "colRemark2";
            this.colRemark2.ReadOnly = true;
            // 
            // btnPresent
            // 
            this.btnPresent.BackColor = System.Drawing.SystemColors.Control;
            this.btnPresent.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnPresent.Image = global::DWAMS.Properties.Resources.if_Presentation_27867_32x32;
            this.btnPresent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPresent.Location = new System.Drawing.Point(246, 27);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(200, 57);
            this.btnPresent.TabIndex = 21;
            this.btnPresent.Text = "ယေန႕ ႐ုံးတက္သည့္ ၀န္ထမ္းမ်ားစာရင္း ၾကည့္ရန္";
            this.btnPresent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPresent.UseVisualStyleBackColor = false;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.btnPresent);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 116);
            this.panel1.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnSave.Image = global::DWAMS.Properties.Resources.Check;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 57);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "ေအာက္ဒုိးဂ်ဴတီျဖစ္ေၾကာင္း အတည္ျပဳရန္";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DWAMS.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(66, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAbsent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1084, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlHide);
            this.Controls.Add(this.dgvAbsent);
            this.Name = "FrmAbsent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ရုံးတက္ပ်က္ကြက္သူမ်ားစာရင္း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAbsentList_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAbsent_FormClosed);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsent)).EndInit();
            this.pnlHide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMonthlyAttendance)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        //private System.Windows.Forms.DataGridViewTextBoxColumn coldepartment;
        private System.Windows.Forms.DataGridView dgvAbsent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlHide;
        private System.Windows.Forms.DataGridView dgvStaffMonthlyAttendance;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ToolStripMenuItem presentListToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDutyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDutyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLateDutyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyDutyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}