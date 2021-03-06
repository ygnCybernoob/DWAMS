using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserAccount_BLL;
using System.Threading;

namespace DWAMS
{
    public partial class FrmChangePassword : Form
    {
        private string username, password;
        private bool new_user;

        public bool New_user
        {
            get { return new_user; }
            set { new_user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private ToolTip tooltip = new ToolTip();

        public FrmChangePassword()
        {
            InitializeComponent();
        }

        #region myMethod

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Utilities.ToolTipControl("Password must be fill", txtPassword);
                txtPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtConfirm.Text))
            {
                Utilities.ToolTipControl("Confirm password must be fill", txtConfirm);
                txtConfirm.Focus();
                return false;
            }
            return true;
        }

        private void clean()
        {
            txtPassword.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            txtPassword.Focus();
        }

        public void UserInfo(UserAccountInfo info)
        {
            Username = info.Username;
            Password = info.Password;
        }

        private void OpenNew(object obj)
        {
            FrmFlash m = new FrmFlash();

            Application.Run(m);
        }
        #endregion

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                if (txtPassword.Text.Equals(txtConfirm.Text))
                {
                    if (txtPassword.Text.Equals(Password))
                    {
                        Utilities.ShowMessage(Utilities.MessageType.Warning, "သင့္အေကာင္၏ လုံျခံဳေရးအရ ပိုမိုေကာင္းမြန္ေသာ လွ်ိဳ႕၀ွက္ကုဒ္ကို သတ္မွတ္ေပးပါ");
                        clean();
                    }
                    else
                    {
                        UserAccountController controller = new UserAccountController();
                        UserAccountInfo info = new UserAccountInfo();

                        info.Username = Username;
                        info.Password = txtPassword.Text;

                        controller.UpdateController(info);

                        Utilities.ShowMessage(Utilities.MessageType.Information, "လွ်ိဳ႕၀ွက္ကုဒ္ကို ေျပာင္းလဲျပီးပါျပီ");
                        clean();
                        btnBack.Focus();

                        if (new_user)
                        {
                            Utilities.ShowMessage(Utilities.MessageType.Information, "ေဆာ့ဖ္၀ဲလ္ကိုျပန္လည္စတင္ပါမည္");

                            Application.Exit();
                            Thread th = new Thread(OpenNew);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }

                }
                else
                {
                    Utilities.ShowMessage(Utilities.MessageType.Warning, "လွ်ိဳ႕၀ွက္ကုဒ္နွင့္ လွ်ိဳ႕၀ွက္ကုဒ္အတည္ျပဳခ်က္တို႕မွာ မတူပါသျဖင့္ ျပန္လည္ထည့္သြင္းေပးပါ");
                    clean();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Username;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChange_Click(null, null);
            }
        }
    }
}