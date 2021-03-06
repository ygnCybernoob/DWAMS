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
    public partial class FrmDepartment : Form
    {
        private string departmentId;

        DepartmentController controller;
        DepartmentCollection collection;
        DepartmentInfo info;

        public FrmDepartment()
        {
            InitializeComponent();
        }

        #region myMethod

        private void clear()
        {
            departmentId = string.Empty;
            txtName.Text = string.Empty;
            txtDesp.Text = string.Empty;
            txtName.Focus();
        }

        private void dataShow()
        {
            dgvDepartment.AutoGenerateColumns = false;

            controller = new DepartmentController();
            collection = controller.SelectController();

            dgvDepartment.DataSource = collection;
        }

        private void BindDepartmentbyDepartment()
        {
            dgvDepartment.AutoGenerateColumns = false;

            controller = new DepartmentController();
            collection = controller.SelectControllerbyDepartment(txtName.Text);

            dgvDepartment.DataSource = collection;
        }

        private bool checkReq()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                Globalizer.ShowMessage(Globalizer.MessageType.Warning, "ဌာနအမည္ကုိ ထည့္သြင္းပါ");
                txtName.Focus();
                return false;
            }
            return true;
        }

        #endregion


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkReq())
            {

                switch (btnSave.Text)
                {
                    case "သိမ္းရန္":
                        controller = new DepartmentController();
                        info = new DepartmentInfo();

                        info.Depname = txtName.Text.Trim();
                        info.Depdesp = txtDesp.Text.Trim();

                        controller.InsertController(info);

                        Globalizer.ShowMessage(Globalizer.MessageType.Information, "ထည့္သြင္းၿပီးပါၿပီ");
                        break;

                    case "ျပင္ဆင္ရန္":
                        controller = new DepartmentController();
                        info = new DepartmentInfo();

                        info.DepId = departmentId;
                        info.Depname = txtName.Text.Trim();
                        info.Depdesp = txtDesp.Text.Trim();

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

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                DataGridViewRow row = dgvDepartment.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];

                switch (cell.OwningColumn.Name)
                {
                    case "colEdit":
                        departmentId = row.Cells["colDepId"].Value.ToString();
                        txtName.Text = row.Cells["colDep"].Value.ToString();
                        txtDesp.Text = row.Cells["colDesp"].Value.ToString();

                        btnSave.Text = "ျပင္ဆင္ရန္";
                        btnExit.Text = "မလုပ္ေသးပါ";
                        break;

                    case "colDelete":
                        DialogResult res = Globalizer.ShowMessage(Globalizer.MessageType.Question, "ဖ်က္ဖုိ႔ ေသခ်ာၿပီလား ?");

                        departmentId = row.Cells["colDepId"].Value.ToString();

                        if (res == DialogResult.Yes)
                        {
                            controller = new DepartmentController();
                            controller.DeleteController(departmentId);

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
            BindDepartmentbyDepartment();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            dataShow();
        }
    }
}