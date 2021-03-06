namespace DWAMS
{
    partial class FrmDutyTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDutyTime));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.dtpkDutyin = new System.Windows.Forms.DateTimePicker();
            this.dtpkDutyout = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.pnlSide.Controls.Add(this.picboxLogo);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 365);
            this.pnlSide.TabIndex = 15;
            // 
            // dtpkDutyin
            // 
            this.dtpkDutyin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDutyin.CustomFormat = "h:mm tt";
            this.dtpkDutyin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDutyin.Location = new System.Drawing.Point(329, 61);
            this.dtpkDutyin.Name = "dtpkDutyin";
            this.dtpkDutyin.ShowUpDown = true;
            this.dtpkDutyin.Size = new System.Drawing.Size(200, 20);
            this.dtpkDutyin.TabIndex = 1;
            this.dtpkDutyin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpkDutyin_KeyDown);
            // 
            // dtpkDutyout
            // 
            this.dtpkDutyout.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDutyout.CustomFormat = "h:mm tt";
            this.dtpkDutyout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDutyout.Location = new System.Drawing.Point(329, 102);
            this.dtpkDutyout.Name = "dtpkDutyout";
            this.dtpkDutyout.ShowUpDown = true;
            this.dtpkDutyout.Size = new System.Drawing.Size(200, 20);
            this.dtpkDutyout.TabIndex = 2;
            this.dtpkDutyout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpkDutyout_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(232, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "႐ုံးတက္ခ်ိန္";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(232, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "႐ုံးဆင္းခ်ိန္";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnSave.Image = global::DWAMS.Properties.Resources.Check;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(372, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "အတည္ျပဳရန္";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::DWAMS.Properties.Resources.if_MB__clock_81054;
            this.picboxLogo.Location = new System.Drawing.Point(48, 22);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(100, 100);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 4;
            this.picboxLogo.TabStop = false;
            // 
            // FrmDutyTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(584, 363);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpkDutyin);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpkDutyout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDutyTime";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "အလုပ္ခ်ိန္ သတ္မွတ္ရန္";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.DateTimePicker dtpkDutyin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkDutyout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picboxLogo;
    }
}