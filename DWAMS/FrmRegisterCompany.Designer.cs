namespace DWAMS
{
    partial class FrmRegisterCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterCompany));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.txtCompany_type = new System.Windows.Forms.TextBox();
            this.txtCompany_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDesp);
            this.groupBox1.Controls.Add(this.txtCompany_type);
            this.groupBox1.Controls.Add(this.txtCompany_name);
            this.groupBox1.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(156, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ကုမၸဏီ အခ်က္အလက္မ်ား";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(29, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "မွတ္ခ်က္";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "လုပ္ငန္း အမ်ိဳးအစား";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "ကုမၸဏီ အမည္";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.Control;
            this.btnClean.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnClean.Image = global::DWAMS.Properties.Resources.gtk_cancel_32x32;
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.Location = new System.Drawing.Point(261, 236);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(125, 40);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "ရွင္းလင္းရန္";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.Image = global::DWAMS.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(155, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "သိမ္းရန္";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDesp
            // 
            this.txtDesp.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtDesp.Location = new System.Drawing.Point(155, 120);
            this.txtDesp.Multiline = true;
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.Size = new System.Drawing.Size(350, 100);
            this.txtDesp.TabIndex = 2;
            // 
            // txtCompany_type
            // 
            this.txtCompany_type.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtCompany_type.Location = new System.Drawing.Point(155, 80);
            this.txtCompany_type.Name = "txtCompany_type";
            this.txtCompany_type.Size = new System.Drawing.Size(250, 34);
            this.txtCompany_type.TabIndex = 1;
            this.txtCompany_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompany_type_KeyDown);
            // 
            // txtCompany_name
            // 
            this.txtCompany_name.Font = new System.Drawing.Font("Zawgyi-One", 12F);
            this.txtCompany_name.Location = new System.Drawing.Point(155, 40);
            this.txtCompany_name.Name = "txtCompany_name";
            this.txtCompany_name.Size = new System.Drawing.Size(250, 34);
            this.txtCompany_name.TabIndex = 0;
            this.txtCompany_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompany_name_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.picboxLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 424);
            this.panel1.TabIndex = 1;
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::DWAMS.Properties.Resources.document_save;
            this.picboxLogo.Location = new System.Drawing.Point(26, 12);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(100, 100);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 6;
            this.picboxLogo.TabStop = false;
            // 
            // FrmRegisterCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(694, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegisterCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ကုမၸဏီ အခ်က္အလက္မ်ားထည့္သြင္းရန္";
            this.Load += new System.EventHandler(this.FrmRegisterCompany_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCompany_name;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.TextBox txtCompany_type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.PictureBox picboxLogo;
    }
}