using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DWAMS
{
    public partial class FrmRegisterCompany : Form
    {
        private string FILE_NAME = "Register.ams";

        public FrmRegisterCompany()
        {
            InitializeComponent();
        }

        #region myMethod

        private bool Check_Required_Field()
        {
            if (string.IsNullOrEmpty(txtCompany_name.Text.Trim()))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "ကုမၸဏီအမည္ကို ထည့္သြင္းေပးပါ");
                txtCompany_name.Focus();
                return false;
            }

            return true;
        }

        private void File_wirter()
        {
            using (StreamWriter streamWriter = new StreamWriter(FILE_NAME))
            {
                streamWriter.WriteLine(txtCompany_name.Text.Trim());
                streamWriter.WriteLine(txtCompany_type.Text.Trim());
                streamWriter.WriteLine(txtDesp.Text.Trim());
            }
            Utilities.ShowMessage(Utilities.MessageType.Information, "ကုမၸဏီိအခ်က္အလက္မ်ားကို ထည့္သြင္းျပီးပါျပီ");
            btnSave.Enabled = false;
            btnClean.Enabled = false;
        }

        private void Open_attendance_entry(object obj)
        {
            FrmAttendanceEntry a = new FrmAttendanceEntry(false);
            a.ShowHelp();
            Application.Run(a);
        }


        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check_Required_Field())
            {
                if (Utilities.ShowMessage(Utilities.MessageType.Question, "အခ်က္အလက္မ်ားကို သိမ္းမည္") == DialogResult.Yes)
                {
                    File_wirter();

                    this.Close();
                    Thread th = new Thread(Open_attendance_entry);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
        }

        private void txtCompany_name_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtCompany_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCompany_name.Text = string.Empty;
            txtCompany_type.Text = string.Empty;
            txtDesp.Text = string.Empty;

            txtCompany_name.Focus();
        }

        private void FrmRegisterCompany_Load(object sender, EventArgs e)
        {
        }
    }
}