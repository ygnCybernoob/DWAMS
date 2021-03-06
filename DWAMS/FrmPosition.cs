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
    public partial class FrmPosition : Form
    {
        private string positionId;

        public FrmPosition()
        {
            InitializeComponent();
        }

        #region myMethod

        private void cboDepartmentBind()
        {
            DepartmentController controller = new DepartmentController();
            DepartmentCollection collection = controller.SelectController();

            cboDepartment.DataSource = collection;
            cboDepartment.DisplayMember = "Depname";
            cboDepartment.ValueMember = "DepId";
        }

        private void clear()
        {
            positionId = string.Empty;
            txtName.Text = string.Empty;
            txtDesp.Text = string.Empty;
            txtName.Focus();
        }

        private void dataShow()
        {
            dgvPosition.AutoGenerateColumns = false;

            PositionController controller = new PositionController();
            PositionCollection collection = controller.SelectController();

            dgvPosition.DataSource = collection;
        }

        private void BindPositionbyDepartment()
        {
            dgvPosition.AutoGenerateColumns = false;

            PositionController controller = new PositionController();
            PositionCollection collection = controller.SelectControllerbyDepartment(cboDepartment.SelectedValue.ToString());

            dgvPosition.DataSource = collection;
        }

        private bool CheckRequiredField()
        {
            if (cboDepartment.Items.Count < 1)
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "ဌာနမ်ားကို ဦးစြာထည့္ေပးပါ");
                cboDepartment.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "ရာထူးအမည္ ထည့္သြင္းပါ");
                txtName.Focus();
                return false;
            }
            return true;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                PositionController controller;
                PositionInfo info;

                switch (btnSave.Text)
                {
                    case "သိမ္းရန္":
                        controller = new PositionController();
                        info = new PositionInfo();

                        info.Departmentid = cboDepartment.SelectedValue.ToString();
                        info.Position = txtName.Text.Trim();
                        info.Positiondesp = txtDesp.Text.Trim();

                        controller.InsertController(info);

                        Globalizer.ShowMessage(Globalizer.MessageType.Information, "ထည့္သြင္းၿပီးပါၿပီ");
                        break;

                    case "ျပင္ဆင္ရန္":
                        controller = new PositionController();
                        info = new PositionInfo();

                        info.Departmentid = cboDepartment.SelectedValue.ToString();
                        info.PositionID = positionId;
                        info.Position = txtName.Text.Trim();
                        info.Positiondesp = txtDesp.Text.Trim();

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

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataShow();
        }

        private void dgvPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                DataGridViewRow row = dgvPosition.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];

                switch (cell.OwningColumn.Name)
                {
                    case "colEdit":
                        cboDepartment.SelectedValue = row.Cells["colDepartmentid"].Value;
                        positionId = row.Cells["colPositionId"].Value.ToString();
                        txtName.Text = row.Cells["colPosition"].Value.ToString();
                        txtDesp.Text = row.Cells["colDesp"].Value.ToString();

                        btnSave.Text = "ျပင္ဆင္ရန္";
                        btnExit.Text = "မလုပ္ေသးပါ";
                        break;

                    case "colDelete":
                        DialogResult res = Globalizer.ShowMessage(Globalizer.MessageType.Question, "ဖ်က္ဖုိ႔ ေသခ်ာၿပီလား ?");

                        positionId = row.Cells["colPositionId"].Value.ToString();

                        if (res == DialogResult.Yes)
                        {
                            PositionController controller = new PositionController();
                            controller.DeleteController(positionId);

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

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            cboDepartmentBind();
            dataShow();
        }

        private void cboDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            FrmDepartment d = new FrmDepartment();
            d.ShowDialog();
            cboDepartmentBind();
        }

        private void cboDepartment_DropDownClosed(object sender, EventArgs e)
        {
            BindPositionbyDepartment();
        }
    }
}