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
    public partial class FrmUserAccount : Form
    {
        UserAccountController controller;

        public FrmUserAccount()
        {
            InitializeComponent();
        }

        #region myMethod

        private void ShowUserList()
        {
            controller = new UserAccountController();
            dgvUserAccount.AutoGenerateColumns = false;
            dgvUserAccount.DataSource = controller.SelectUserListController();
        }

        #endregion

        private void FrmUserAccount_Load(object sender, EventArgs e)
        {
            ShowUserList();
        }

        private void dgvUserAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvUserAccount.Rows[e.RowIndex];

            FrmChangePassword change = new FrmChangePassword();
            change.Username = row.Cells["colUserName"].Value.ToString();
            change.Password = row.Cells["colPassword"].Value.ToString();
            change.ShowDialog();
            }

        private void dgvUserAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvUserAccount.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colDelete":

                    if (row.Cells["colPermission"].Value.ToString().Equals("yes"))
                    {
                        if (controller.SelectPermissionAccount() > 1)
                        {
                            DialogResult result = Globalizer.ShowMessage(Globalizer.MessageType.Question, "ဖ်က္ဖို႕ေသခ်ာပါသလား");

                            if (result == DialogResult.Yes)
                            {
                                UserAccountInfo info = new UserAccountInfo();
                                info.Userid = row.Cells["colUserId"].Value.ToString();
                                controller.DeleteController(info);

                                ShowUserList();
                            }
                        }
                        else
                        {
                            Utilities.ShowMessage(Utilities.MessageType.Warning, "ေဆာ့ဖ္၀ဲလ္တြင္ admin အေကာင့္တစ္ခု ထားရွိရပါမည္");
                        }
                    
                    }
                    else
                    {
                        DialogResult result = Globalizer.ShowMessage(Globalizer.MessageType.Question, "ဖ်က္ဖို႕ေသခ်ာပါသလား");

                        if (result == DialogResult.Yes)
                        {
                            UserAccountInfo info = new UserAccountInfo();
                            info.Userid = row.Cells["colUserId"].Value.ToString();
                            controller.DeleteController(info);

                            ShowUserList();
                        }
                    }
                    break;
            }
        }
    }
}