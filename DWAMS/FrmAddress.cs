using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DWAMS_BLL;

namespace DWAMS
{
    public partial class FrmAddress : Form
    {
        AddressController controller;
        AddressCollection collection;
        AddressInfo info;

        private string addressId;

        public FrmAddress()
        {
            InitializeComponent();
        }

        #region myMethod



        private void clear()
        {
            addressId = string.Empty;
            txtName.Text = string.Empty;
            txtDesp.Text = string.Empty;
            txtName.Focus();
        }

        private void dataShow()
        {
            dgvAddress.AutoGenerateColumns = false;

            controller = new AddressController();
            collection = controller.SelectController();

            dgvAddress.DataSource = collection;
        }

        private void BindAddressbyAddress()
        {
            dgvAddress.AutoGenerateColumns = false;

            controller = new AddressController();
            collection = controller.SelectControllerbyAddress(txtName.Text.Trim() );

            dgvAddress.DataSource = collection;
        }

        private bool checkReq()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "ၿမဳိ႕အမည္ကုိ ထည့္သြင္းပါ");
                txtName.Focus();
                return false;
            }
            return true;
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            switch (btnExit.Text)
            {
                case "ထြက္ရန္":
                    this.Close();
                    break;

                case "မလုပ္ေသးပါ":
                    clear();
                    btnSave.Text = "သိမ္းရန္";
                    btnExit.Text = "ထြက္ရန္";
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkReq())
            {

                switch (btnSave.Text)
                {
                    case "သိမ္းရန္":
                        controller = new AddressController();
                        info = new AddressInfo();

                        info.Addname = txtName.Text.Trim();
                        info.Adddesp = txtDesp.Text.Trim();

                        controller.InsertController(info);

                        Globalizer.ShowMessage(Globalizer.MessageType.Information, "ထည့္သြင္းၿပီးပါၿပီ");
                        break;

                    case "ျပင္ဆင္ရန္":
                        controller = new AddressController();
                        info = new AddressInfo();

                        info.Addid = addressId;
                        info.Addname = txtName.Text.Trim();
                        info.Adddesp = txtDesp.Text.Trim();

                        controller.UpdateController(info);

                        Globalizer.ShowMessage(Globalizer.MessageType.Information, "ျပင္ဆင္ၿပီးပါၿပီ");
                        btnSave.Text = "သိမ္းရန္";
                        btnExit.Text = "ထြက္ရန္";
                        break;
                }

                clear();
                dataShow();  //data rebind
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataShow();
        }

        private void dgvAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                DataGridViewRow row = dgvAddress.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];

                switch (cell.OwningColumn.Name)
                {
                    case "colEdit":
                        addressId = row.Cells["colAddId"].Value.ToString();
                        txtName.Text = row.Cells["colAdd"].Value.ToString();
                        txtDesp.Text = row.Cells["colDesp"].Value.ToString();

                        btnSave.Text = "ျပင္ဆင္ရန္";
                        btnExit.Text = "မလုပ္ေသးပါ";
                        break;

                    case "colDelete":
                        DialogResult res = Globalizer.ShowMessage(Globalizer.MessageType.Question, "ဖ်က္ရန္ ေသခ်ာသလား?");

                        addressId = row.Cells["colAddId"].Value.ToString();

                        if (res == DialogResult.Yes)
                        {
                            controller = new AddressController();
                            controller.DeleteController(addressId);

                            Globalizer.ShowMessage(Globalizer.MessageType.Information, "ဖ်က္ၿပီးပါၿပီ");
                            btnSave.Text = "သိမ္းရန္";
                            btnExit.Text = "ထြက္ရန္";

                            clear();
                            dataShow();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Error, ex.ToString());
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtDesp_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
             BindAddressbyAddress();
         }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }

        private void FrmAddress_Load(object sender, EventArgs e)
        {
            dataShow();
        }

    }
}