namespace DWAMS
{
    partial class FrmCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.btnSave.Image = global::DWAMS.Properties.Resources.Check;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(239, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 57);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "ေရြးခ်ယ္ရန္";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(384, 163);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "FrmCalendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "လစာရွင္းမည့္လ ကိုေရြးပါ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSave;
    }
}