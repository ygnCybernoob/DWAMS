namespace DWAMS
{
    partial class FrmAboutUs
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
            this.linkNayTunLin = new System.Windows.Forms.LinkLabel();
            this.linkCKK = new System.Windows.Forms.LinkLabel();
            this.linkKNP = new System.Windows.Forms.LinkLabel();
            this.linkSWP = new System.Windows.Forms.LinkLabel();
            this.lnklblVisit = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkNayTunLin
            // 
            this.linkNayTunLin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkNayTunLin.AutoSize = true;
            this.linkNayTunLin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNayTunLin.Location = new System.Drawing.Point(12, 569);
            this.linkNayTunLin.Name = "linkNayTunLin";
            this.linkNayTunLin.Size = new System.Drawing.Size(123, 24);
            this.linkNayTunLin.TabIndex = 16;
            this.linkNayTunLin.TabStop = true;
            this.linkNayTunLin.Text = "Nay Tun Linn";
            this.linkNayTunLin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNayTunLin_LinkClicked);
            // 
            // linkCKK
            // 
            this.linkCKK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkCKK.AutoSize = true;
            this.linkCKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCKK.Location = new System.Drawing.Point(150, 569);
            this.linkCKK.Name = "linkCKK";
            this.linkCKK.Size = new System.Drawing.Size(98, 24);
            this.linkCKK.TabIndex = 17;
            this.linkCKK.TabStop = true;
            this.linkCKK.Text = "Chit Ko Ko";
            this.linkCKK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCKK_LinkClicked);
            // 
            // linkKNP
            // 
            this.linkKNP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkKNP.AutoSize = true;
            this.linkKNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkKNP.Location = new System.Drawing.Point(260, 569);
            this.linkKNP.Name = "linkKNP";
            this.linkKNP.Size = new System.Drawing.Size(157, 24);
            this.linkKNP.TabIndex = 18;
            this.linkKNP.TabStop = true;
            this.linkKNP.Text = "Kyaw Nyein Phyo";
            this.linkKNP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKNP_LinkClicked);
            // 
            // linkSWP
            // 
            this.linkSWP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkSWP.AutoSize = true;
            this.linkSWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSWP.Location = new System.Drawing.Point(438, 569);
            this.linkSWP.Name = "linkSWP";
            this.linkSWP.Size = new System.Drawing.Size(150, 24);
            this.linkSWP.TabIndex = 19;
            this.linkSWP.TabStop = true;
            this.linkSWP.Text = "Saung Wai Phyo";
            this.linkSWP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSWP_LinkClicked);
            // 
            // lnklblVisit
            // 
            this.lnklblVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnklblVisit.AutoSize = true;
            this.lnklblVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblVisit.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnklblVisit.Location = new System.Drawing.Point(629, 569);
            this.lnklblVisit.Name = "lnklblVisit";
            this.lnklblVisit.Size = new System.Drawing.Size(160, 20);
            this.lnklblVisit.TabIndex = 9;
            this.lnklblVisit.TabStop = true;
            this.lnklblVisit.Text = "Visit to our page ->>>";
            this.lnklblVisit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblVisit_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DWAMS.Properties.Resources.OurGroup;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(911, 623);
            this.Controls.Add(this.linkSWP);
            this.Controls.Add(this.lnklblVisit);
            this.Controls.Add(this.linkKNP);
            this.Controls.Add(this.linkCKK);
            this.Controls.Add(this.linkNayTunLin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAboutUs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ေဆာ့ဖ္၀ဲလ္ေရးသားသူမ်ား";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkNayTunLin;
        private System.Windows.Forms.LinkLabel linkCKK;
        private System.Windows.Forms.LinkLabel linkKNP;
        private System.Windows.Forms.LinkLabel linkSWP;
        private System.Windows.Forms.LinkLabel lnklblVisit;
    }
}