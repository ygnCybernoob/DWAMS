namespace DWAMS
{
    partial class FrmPosition
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
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.colPositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.menuStrip1);
            this.pnlSide.Controls.Add(this.picboxLogo);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(150, 516);
            this.pnlSide.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortCutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(150, 26);
            this.menuStrip1.TabIndex = 7;
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
            // picboxLogo
            // 
            this.picboxLogo.Image = global::DWAMS.Properties.Resources.shake_hand_edit;
            this.picboxLogo.Location = new System.Drawing.Point(22, 12);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(100, 100);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 4;
            this.picboxLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_new);
            this.groupBox1.Controls.Add(this.cboDepartment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDesp);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 200);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ရာထူး";
            // 
            // btn_add_new
            // 
            this.btn_add_new.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add_new.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btn_add_new.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_add_new.Image = global::DWAMS.Properties.Resources.if_save_add_60015;
            this.btn_add_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_new.Location = new System.Drawing.Point(450, 19);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(115, 35);
            this.btn_add_new.TabIndex = 7;
            this.btn_add_new.Text = "အသစ္ထည့္ရန္";
            this.btn_add_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_new.UseVisualStyleBackColor = false;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Zawgyi-One", 11.25F);
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(144, 19);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(300, 33);
            this.cboDepartment.TabIndex = 1;
            this.cboDepartment.Text = "ဌာနကုိ ေရြးခ်ယ္ပါ . . .";
            this.cboDepartment.DropDownClosed += new System.EventHandler(this.cboDepartment_DropDownClosed);
            this.cboDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDepartment_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "ဌာန";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(144, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 32);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ရာထူး";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnShow.Image = global::DWAMS.Properties.Resources.if_Presentation_27867_32x32;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(382, 134);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 40);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "စာရင္းၾကည့္ရန္";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExit.Image = global::DWAMS.Properties.Resources.exit_32x32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(256, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ထြက္ရန္";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ရွင္းလင္းခ်က္";
            // 
            // txtDesp
            // 
            this.txtDesp.Font = new System.Drawing.Font("Zawgyi-One", 11.25F);
            this.txtDesp.Location = new System.Drawing.Point(144, 96);
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.Size = new System.Drawing.Size(300, 32);
            this.txtDesp.TabIndex = 3;
            this.txtDesp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesp_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.Image = global::DWAMS.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(144, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "သိမ္းရန္";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AllowUserToDeleteRows = false;
            this.dgvPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosition.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPositionId,
            this.colDepartmentid,
            this.colNo,
            this.colDepartment,
            this.colPosition,
            this.colDesp,
            this.colEdit,
            this.colDelete});
            this.dgvPosition.Location = new System.Drawing.Point(156, 231);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPosition.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPosition.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPosition.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvPosition.RowTemplate.Height = 30;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(666, 270);
            this.dgvPosition.TabIndex = 22;
            this.dgvPosition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosition_CellContentClick);
            // 
            // colPositionId
            // 
            this.colPositionId.DataPropertyName = "PositionId";
            this.colPositionId.HeaderText = "PositionId";
            this.colPositionId.Name = "colPositionId";
            this.colPositionId.ReadOnly = true;
            this.colPositionId.Visible = false;
            // 
            // colDepartmentid
            // 
            this.colDepartmentid.DataPropertyName = "Departmentid";
            this.colDepartmentid.HeaderText = "DepartmentId";
            this.colDepartmentid.Name = "colDepartmentid";
            this.colDepartmentid.ReadOnly = true;
            this.colDepartmentid.Visible = false;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "စဉ္";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 50;
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
            // colDesp
            // 
            this.colDesp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesp.DataPropertyName = "Positiondesp";
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
            // pnlHead
            // 
            this.pnlHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.pnlHead.Controls.Add(this.groupBox1);
            this.pnlHead.Location = new System.Drawing.Point(150, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(688, 225);
            this.pnlHead.TabIndex = 23;
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(834, 513);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.pnlSide);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "FrmPosition";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ရာထူးမ်ား";
            this.Load += new System.EventHandler(this.FrmPosition_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesp;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}