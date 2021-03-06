using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserAccount_BLL;

namespace DWAMS
{
    public partial class FrmRegister : Form
    {
        ToolTip tooltip = new ToolTip();
        public FrmRegister()
        {
            InitializeComponent();
        }

        #region myMethod

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                Utilities.ToolTipControl("User name must be fill", txtUserName);
                txtUserName.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
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
            chkboxPermission.Checked = false;
            txtPassword.Focus();
        }

        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                if (txtPassword.Text.Equals(txtConfirm.Text))
                {
                    UserAccountController controller = new UserAccountController();
                    UserAccountInfo info = new UserAccountInfo();

                    info.Username = txtUserName.Text.Trim();
                    info.Password = txtPassword.Text;
                    info.Permission = chkboxPermission.Checked ? "yes" : "no";

                    if (!controller.SelectUserListbyName(info.Username))
                    {
                        controller.InsertController(info);
                        Utilities.ShowMessage(Utilities.MessageType.Information, "အေကာင့္အသစ္ဖြင့္ျပီးပါျပီ");
                        clean();
                        txtUserName.Text = string.Empty;
                        btnBack.Focus();
                    }
                    else
                    {
                        Utilities.ShowMessage(Utilities.MessageType.Warning, "အေကာင့္အမည္တူ ရွိေနပါသည္");
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

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister_Click(null, null);
            }
        }

    }
}