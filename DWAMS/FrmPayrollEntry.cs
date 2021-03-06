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
    public partial class FrmPayrollEntry : Form
    {
        UnPaidListController unpaidController;
        UnPaidListCollection unpaidCollection;  

        private string staffid;

        private double fine, bonus, netsalary;

        private double basicSalary;
        private int latedutyin, 
                        earlydutyout, 
                        absentday;

        private DateTime DUTY_IN_TIME;
        private DateTime DUTY_OUT_TIME;

        public FrmPayrollEntry()
        {
            InitializeComponent();
        }

        #region myMethod

        private void SelectDutyInformation()
        {
            unpaidController = new UnPaidListController();
            UnPaidListInfo unpaidInfo = unpaidController.SelectDutyInformation(staffid, System.DateTime.Today, dtpkSalaryfor.Value.Month, dtpkSalaryfor.Value.Year);

            absentday = unpaidInfo.Totalabsent;
            presentDay = unpaidInfo.Totalpresent;
            latedutyin = unpaidInfo.Totallatedutyin;
            earlydutyout = unpaidInfo.Totalearlydutyout;

            txtAbsent.Text = Convert.ToString(absentday);
            txtPresentDay.Text = Convert.ToString(presentDay);
            txtDutyLateMinute.Text = Convert.ToString(latedutyin);
            txtEarlyOutMinute.Text = Convert.ToString(earlydutyout);

        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(staffid))
            {
                Utilities.ShowMessage(Utilities.MessageType.Warning, "၀န္ထမ္းကို ဦးစြာေရြးခ်ယ္ ေပးပါ");
                return false;
            }
            return true;
        }

        private void Clear()
        {
            btnCancel.Enabled = false;
            staffid = string.Empty;

            fine = 0; 
            netsalary = 0;
            basicSalary = 0;
            latedutyin = 0;
            earlydutyout = 0; 
            absentday = 0;

            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDutyLateMinute.Text = string.Empty;
            txtEarlyOutMinute.Text = string.Empty;
            txtPresentDay.Text = string.Empty;
            txtAbsent.Text = string.Empty;

            txtBasicSalary.Text = string.Empty;
            txtFine.Text = "0";
            txtBonus.Text = "0";
            txtNetSalary.Text = string.Empty;
        }

        private void CalculateSalary()
        {
            fine = Convert.ToDouble(txtFine.Text.Trim());
            bonus = Convert.ToDouble(txtBonus.Text.Trim());
            presentDay = Convert.ToInt16(txtPresentDay.Text.Trim());
            //************
            netsalary = ((presentDay*avgSalaryforDay) + bonus) - fine;//

            if (netsalary >= 0)
            {
                txtNetSalary.Text = Convert.ToString(netsalary);
            }
            else
            {
                txtNetSalary.Text = "0";
            }
            
        }

        double avgSalaryPerMin;
        double avgSalaryPerHour;
        double avgSalaryforDay;

        int presentDay;

        int hour;
        int day;
        int minute;

        private void CalculateFine()
        {
            TimeSpan different = DUTY_OUT_TIME.Subtract(DUTY_IN_TIME);
            hour = different.Hours;

            //day = System.DateTime.DaysInMonth(dtpkSalaryfor.Value.Year, dtpkSalaryfor.Value.Month);
            day = 30;
            minute = 60;

            avgSalaryforDay= basicSalary / day;
            avgSalaryPerHour = avgSalaryforDay / hour;
            avgSalaryPerMin = avgSalaryPerHour / minute;

            fine = ((latedutyin + earlydutyout) * avgSalaryPerMin) + (absentday * avgSalaryforDay);

            txtFine.Text = Convert.ToString(fine);
        }

        private void GetDutyTime()
        {
            SettingController controller = new SettingController();
            SettingInfo info = controller.SelectSetting();

            DUTY_IN_TIME = DateTime.Parse(info.Dutyintime.ToShortTimeString());
            DUTY_OUT_TIME = DateTime.Parse(info.Dutyouttime.ToShortTimeString());
        }

        private void BindStaffList(bool IsWithDepartment)
        {
            unpaidController = new UnPaidListController();

            dgvStaffList.AutoGenerateColumns = false;

            if (IsWithDepartment)
            {
                dgvStaffList.DataSource = unpaidController.SelectUnPaidList(cboDepartment.SelectedValue.ToString(), dtpkSalaryfor.Value.Month, dtpkSalaryfor.Value.Year);
            }
            else
            {
                dgvStaffList.DataSource = unpaidController.SelectUnPaidList(dtpkSalaryfor.Value.Month, dtpkSalaryfor.Value.Year);
            }
                if (dgvStaffList.RowCount == 0)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "လစာ မရွင္းရေသးသူမ်ား မရွိေသးပါ");
                }

        }

        private void cboDepartmentBind()
        {
            DepartmentController controller = new DepartmentController();
            DepartmentCollection collection = controller.SelectController();

            cboDepartment.DataSource = collection;
            cboDepartment.DisplayMember = "Depname";
            cboDepartment.ValueMember = "DepId";
        }

        #endregion

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if (!((i >= '0' && i <= '9') || i == 8 || i == '.'))
            {
                e.Handled = true;
            }


        }

        private void txtFine_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if (!((i >= '0' && i <= '9') || i == 8 || i=='.'))
            {
                e.Handled = true;
            }


        }

        private void FrmSalaryPayment_Load(object sender, EventArgs e)
        {
            BindStaffList(false);
            cboDepartmentBind();

            GetDutyTime();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                if (!string.IsNullOrEmpty(txtNetSalary.Text.Trim()))
                {
                    SalaryPaymentController controller = new SalaryPaymentController();
                    controller.InsertMonthlyPayment(staffid, System.DateTime.Now, dtpkSalaryfor.Value.Date, fine, bonus, netsalary);

                    unpaidController = new UnPaidListController();
                    unpaidController.UpdatePaidStatus(staffid, dtpkSalaryfor.Value.Month, dtpkSalaryfor.Value.Year);

                    Clear();
                    BindStaffList(false);
                }
               
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            BindStaffList(false);
        }

        private void dgvStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvStaffList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "colSelect":
                    staffid = row.Cells["colstaffid"].Value.ToString();
                    txtCode.Text = row.Cells["colstaffcode"].Value.ToString();
                    txtName.Text = row.Cells["colstaffname"].Value.ToString();
                    txtBasicSalary.Text = row.Cells["colbasicsalary"].Value.ToString();

                    basicSalary = Convert.ToDouble(row.Cells["colbasicsalary"].Value);

                    txtBonus.Text = "0";
                    txtNetSalary.Text = "0";

                    SelectDutyInformation();

                    CalculateFine();

                    if (CheckRequiredField())
                    {
                        CalculateSalary();
                    }

                    btnCancel.Enabled = true;

                    break;
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnCancel.Enabled = false; 
        }

        private void txtFine_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFine_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFine.Text.Trim()))
            {
                txtFine.Text = "0";
            }
            if (!string.IsNullOrEmpty(txtFine.Text))
            {
                if (CheckRequiredField())
                {
                    CalculateSalary();
                }
            }
        }

        private void txtBonus_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBonus.Text.Trim()))
            {
                txtBonus.Text = "0";
            }
            if (!string.IsNullOrEmpty(txtBonus.Text))
            {
                if (CheckRequiredField())
                {
                    CalculateSalary();
                }
            }
        }

        private void cboDepartment_DropDownClosed(object sender, EventArgs e)
        {
            if (cboDepartment.Items.Count > 0)
            {
                BindStaffList(true);
            }
            else
            {
                Utilities.ToolTipControl("Sorry! There is no department", cboDepartment);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnCancel.Enabled)
            {
                btnCancel_Click(null, null);
            }
        }

        private void dtpkSalaryfor_ValueChanged(object sender, EventArgs e)
        {
            BindStaffList(false);
        }

        private void txtFine_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFine.Text))
            {
                if (CheckRequiredField())
                {
                    CalculateSalary();
                }
            }
        }

        private void txtBonus_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBonus.Text))
            {
                if (CheckRequiredField())
                {
                    CalculateSalary();
                }
            }
        }

        private void txtFine_Enter(object sender, EventArgs e)
        {
            if (txtFine.Text.Trim().Equals("0"))
            {
                txtFine.Text = string.Empty;
            }

        }

        private void txtBonus_Enter(object sender, EventArgs e)
        {
            if (txtBonus.Text.Trim().Equals("0"))
            {
                txtBonus.Text = string.Empty;
            }
        }
    }
}