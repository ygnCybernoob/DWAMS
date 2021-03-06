namespace DWAMS
{
    partial class FrmAbsentList
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.dgvAbsent = new System.Windows.Forms.DataGridView();
            this.colAbsentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbsentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.btnShow);
            this.pnlSide.Controls.Add(this.label4);
            this.pnlSide.Controls.Add(this.dtpkDate);
            this.pnlSide.Controls.Add(this.menuStrip1);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(250, 666);
            this.pnlSide.TabIndex = 17;
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
            this.label4.ForeColor = System.Drawing.Color.White;
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
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.showToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // presentListToolStripMenuItem
            // 
            this.presentListToolStripMenuItem.Name = "presentListToolStripMenuItem";
            this.presentListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.presentListToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.presentListToolStripMenuItem.Text = "Present List";
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.Controls.Add(this.dgvAbsent);
            this.pnlBack.Location = new System.Drawing.Point(256, 12);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(916, 639);
            this.pnlBack.TabIndex = 18;
            // 
            // dgvAbsent
            // 
            this.dgvAbsent.AllowUserToAddRows = false;
            this.dgvAbsent.AllowUserToDeleteRows = false;
            this.dgvAbsent.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAbsentid,
            this.colStaffid,
            this.colNO,
            this.colAbsentdate,
            this.colStaffcode,
            this.colStaffname,
            this.colPosition,
            this.colDeparment,
            this.colPhone});
            this.dgvAbsent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbsent.Location = new System.Drawing.Point(0, 0);
            this.dgvAbsent.Name = "dgvAbsent";
            this.dgvAbsent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAbsent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvAbsent.RowTemplate.Height = 30;
            this.dgvAbsent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsent.Size = new System.Drawing.Size(916, 639);
            this.dgvAbsent.TabIndex = 18;
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
            // colNO
            // 
            this.colNO.DataPropertyName = "No";
            this.colNO.HeaderText = "စဉ္";
            this.colNO.Name = "colNO";
            this.colNO.Width = 50;
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
            // FrmAbsentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1184, 663);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlSide);
            this.Name = "FrmAbsentList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ရုံးတက္ပ်က္ကြက္သူမ်ား မွတ္တမ္း";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAbsentList_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentListToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.DataGridView dgvAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    }
}