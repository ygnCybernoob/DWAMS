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
    public partial class FrmStaff : Form
    {
        private string staffId;
        StaffController controller;

        public FrmStaff()
        {
            InitializeComponent();
        }

        #region my methods

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "၀န္ထမ္း၏ ကုဒ္နံပါတ္ကို ထည့္သြင္းေပးပါ");
                txtCode.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "၀န္ထမ္း၏ အမည္ကို ထည့္သြင္းေပးပါ");
                txtName.Focus();
                return false;
            }
            else if (cboDepartment.Items.Count == 0)
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "ဌာနမ်ားကို ဦးစြာထည့္သြင္းေပးပါ");
                cboDepartment.Focus();
                return false;
            }
            else if (cboPosition.Items.Count == 0)
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "ရာထူးကို ဦးစြာထည့္သြင္းေပးပါ");
                cboPosition.Focus();
                return false;
            }
            else if (cboAddress.Items.Count == 0)
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "ၿမိဳ႕နယ္မ်ားကို ဦးစြာထည့္သြင္းေပးပါ");
                cboAddress.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(mtxtPhone.Text.Trim()))
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "၀န္ထမ္း၏ ဖုန္းနံပါတ္ကို ထည့္သြင္းေပးပါ");
                mtxtPhone.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(mtxtSalary.Text.Trim()))
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "၀န္ထမ္း၏ အေျခခံလစာ ကို ထည့္သြင္းေပးပါ");
                mtxtSalary.Focus();
                return false;
            }

            return true;
        }

        private void dataShow()
        {
            controller = new StaffController();
            dgvStaff.AutoGenerateColumns = false; 
            dgvStaff.DataSource = controller.SelectController();
        }

        private void dataShowbyCode()
        {
            controller = new StaffController();
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = controller.SelectController(txtCode.Text.Trim());
        }

        private void clear()
        {
            staffId = string.Empty; //clean the value 
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;

            cboAddressBind();
            cboDepartmentBind();
            cboPositionBind();

            mtxtPhone.Text = string.Empty;
            mtxtSalary.Text = string.Empty;
            txtDesp.Text = string.Empty;

            txtCode.Focus();
        }

        #region combos databind

        private void cboDepartmentBind()
        {
            DepartmentController controller = new DepartmentController();
            DepartmentCollection collection = controller.SelectController();

            cboDepartment.DataSource = collection;
            cboDepartment.DisplayMember = "Depname";
            cboDepartment.ValueMember = "DepId";
        }

        private void cboPositionBind()
        {
            if (cboDepartment.Items.Count > 0)
            {
                PositionController controller = new PositionController();
                PositionCollection collection = controller.SelectController(cboDepartment.SelectedValue.ToString());

                cboPosition.Text = string.Empty; // becase there will be remained txt in cbo

                cboPosition.DataSource = collection;
                cboPosition.DisplayMember = "Position";
                cboPosition.ValueMember = "PositionID";
            }
        }

        private void cboAddressBind()
        {
            AddressController controller = new AddressController();
            AddressCollection collection = controller.SelectController();

            cboAddress.DataSource = collection;
            cboAddress.DisplayMember = "Addname";
            cboAddress.ValueMember = "Addid";
        }

        #endregion

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                StaffInfo info = new StaffInfo();

                switch (btnSave.Text)
                {
                    case "သိမ္းရန္":
                        dataShowbyCode();
                        if (dgvStaff.RowCount > 0)
                        {
                            Utilities.ShowMessage(Utilities.MessageType.Warning, "၀န္ထမ္း၏ ကုဒ္နံပါတ္တူညီေနပါသည္။ ကုဒ္နံပါတ္အသစ္ကို ထည့္သြင္းေပးပါ။");
                            return;
                        }

                        controller = new StaffController();

                        info.PositionID = cboPosition.SelectedValue.ToString();
                        info.AddID = cboAddress.SelectedValue.ToString();
                        info.DepID = cboDepartment.SelectedValue.ToString();
                        info.StaffCode = txtCode.Text.Trim();
                        info.StaffName = txtName.Text.Trim();
                        info.StaffPhone = mtxtPhone.Text.Trim();
                        info.BasicSalary = Convert.ToInt64(Utilities.RemoveChar(mtxtSalary.Text, ' '));
                        info.HireDate = dtpHiredDate.Value;
                        info.StaffDesp = txtDesp.Text.Trim();

                        controller.InsertController(info);

                        Globalizer.ShowMessage(Globalizer.MessageType.Information, "ထည့္သြင္းျပီးပါျပီ");
                        break;

                    case "ျပင္ဆင္ရန္":
                        controller = new StaffController();

                        info.StaffId = staffId;
                        info.PositionID = cboPosition.SelectedValue.ToString();
                        info.AddID = cboAddress.SelectedValue.ToString();
                        info.DepID = cboDepartment.SelectedValue.ToString();
                        info.StaffCode = txtCode.Text.Trim();
                        info.StaffName = txtName.Text.Trim();
                        info.StaffPhone = mtxtPhone.Text.Trim();
                        info.BasicSalary = Convert.ToInt64(Utilities.RemoveChar(mtxtSalary.Text, ' '));
                        info.HireDate = dtpHiredDate.Value;
                        info.StaffDesp = txtDesp.Text.Trim();

                        controller.UpdateController(info);

                        Globalizer.ShowMessage(Globalizer.MessageType.Information, "ျပင္ဆင္ၿပီးပါၿပီ");

                        txtCode.Enabled = true;
                        btnSave.Text = "သိမ္းရန္";
                        btnExit.Text = "ထြက္ရန္";
                        break;
                }
                clear();
                dataShow();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            switch (btnExit.Text)
            {
                case "ထြက္ရန္":
                    this.Close();
                    break;

                case "မလုပ္ေသးပါ":
                    btnSave.Text = "သိမ္းရန္";
                    btnExit.Text = "ထြက္ရန္";
                    txtCode.Enabled = true;

                    clear();
                    break;
            }
        }

        private void FrmStaffInfo_Load(object sender, EventArgs e)
        {
            cboDepartmentBind();
            cboPositionBind();
            cboAddressBind();
            dataShow();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataShow();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colEdit":
                    txtCode.Enabled = false;
                    btnSave.Text = "ျပင္ဆင္ရန္";
                    btnExit.Text = "မလုပ္ေသးပါ";

                    staffId = row.Cells["colStaffId"].Value.ToString();
                    txtCode.Text = row.Cells["colStaffCode"].Value.ToString();
                    txtName.Text = row.Cells["colStaffName"].Value.ToString();

                    cboDepartmentBind();
                    cboDepartment.SelectedValue = row.Cells["colDepartmentId"].Value.ToString();

                    cboPositionBind();
                    cboPosition.SelectedValue = row.Cells["colPositionId"].Value.ToString();

                    cboAddress.SelectedValue = row.Cells["colAddressId"].Value.ToString();
                    mtxtPhone.Text = row.Cells["colPhone"].Value.ToString();
                    mtxtSalary.Text = row.Cells["colBasicSalary"].Value.ToString();
                    dtpHiredDate.Value = (DateTime)row.Cells["colHiredDate"].Value;
                    txtDesp.Text = row.Cells["colDesp"].Value.ToString();

                    break;

                case "colDelete":
                    if (Globalizer.ShowMessage(Globalizer.MessageType.Question, "ဖ်က္ဖို႕ ေသခ်ာၿပီလား?") == DialogResult.Yes)
                    {
                        controller = new StaffController();

                        staffId = row.Cells["colStaffId"].Value.ToString();
                        controller.DeleteController(staffId);

                        Globalizer.ShowMessage(Globalizer.MessageType.Information, "ဖ်က္ၿပီးပါျပီ");
                        dataShow();

                        txtCode.Enabled = true;
                        btnSave.Text = "သိမ္းရန္";
                        btnExit.Text = "ထြက္ရန္";

                        clear();
                    }
                    break;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if (!((i >= '0' && i <= '9') || i==8 ))
            {
                e.Handled = true;
                mtxtSalary.ForeColor = Color.Red;
            }
            else
            {
                mtxtSalary.ForeColor = Color.Black;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboPosition_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboAddress_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void dtpHiredDate_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtDesp_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void mtxtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void mtxtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                dataShow();
            }
            else
            {
                dataShowbyCode();
            }
        }

        private void cboDepartment_DropDownClosed(object sender, EventArgs e)
        {
            cboPositionBind();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow.Focus();
            btnShow_Click(null, null);
        }

        private void btn_add_department_Click(object sender, EventArgs e)
        {
            FrmDepartment d = new FrmDepartment();
            d.ShowDialog();
            cboDepartmentBind();
        }

        private void btn_add_position_Click(object sender, EventArgs e)
        {
            FrmPosition p = new FrmPosition();
            p.ShowDialog();
            cboPositionBind();
        }

        private void btn_add_address_Click(object sender, EventArgs e)
        {
            FrmAddress a = new FrmAddress();
            a.ShowDialog();
            cboAddressBind();
        }

        private void cboDepartment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboPositionBind();
        }
    }
}