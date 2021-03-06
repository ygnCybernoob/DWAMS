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
    public partial class FrmAttendanceDetail : Form
    {
        AttendanceController attendanceController;
        AttendanceCollection attendanceCollection;

        StaffController staffController;
        StaffCollection staffCollection;
        StaffInfo staffInfo;

        public FrmAttendanceDetail()
        {
            InitializeComponent();
        }

        #region myMethod

        private void ShowAttendance()
        {
            attendanceController = new AttendanceController();
            attendanceCollection = attendanceController.DailyAttendanceSelect();

            dgvStaffMonthlyAttendance.AutoGenerateColumns = false;
            dgvStaffMonthlyAttendance.DataSource = attendanceCollection;

            if (dgvStaffMonthlyAttendance.RowCount == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာ မွတ္တမ္း မရွိပါ");
            }
        }

        private void ShowAttendancebyStaffId()
        {
            if(cboStaffName.Items.Count > 0)
            {
                attendanceController = new AttendanceController();
                attendanceCollection = attendanceController.DailyAttendanceSelectbyStaffId(cboStaffName.SelectedValue.ToString());

                dgvStaffMonthlyAttendance.AutoGenerateColumns = false;
                dgvStaffMonthlyAttendance.DataSource = attendanceCollection;

                if (dgvStaffMonthlyAttendance.RowCount == 0)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာ မွတ္တမ္း မရွိပါ");
                }
            }
            else
            {
                Utilities.ToolTipControl("Sorry! There is no staff", cboStaffName);
            }
        }

        private void ShowAttendancebyDate()
        {
            attendanceController = new AttendanceController();
            attendanceCollection = attendanceController.DailyAttendanceSelectbyDate(dtpkStart.Value.Date, dtpkEnd.Value.Date);

            dgvStaffMonthlyAttendance.AutoGenerateColumns = false;
            dgvStaffMonthlyAttendance.DataSource = attendanceCollection;

            if (dgvStaffMonthlyAttendance.RowCount == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာ မွတ္တမ္း မရွိပါ");
            }
        }

        private void ShowAttendancebyStaffIdDate()
        {
            if (cboStaffName.Items.Count > 0)
            {
                attendanceController = new AttendanceController();
                attendanceCollection = attendanceController.DailyAttendanceSelectbyStaffIdDate(cboStaffName.SelectedValue.ToString(), dtpkStart.Value.Date, dtpkEnd.Value.Date);

                dgvStaffMonthlyAttendance.AutoGenerateColumns = false;
                dgvStaffMonthlyAttendance.DataSource = attendanceCollection;

                if (dgvStaffMonthlyAttendance.RowCount == 0)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာ မွတ္တမ္း မရွိပါ");
                }
            }
            else
            {
                Utilities.ToolTipControl("Sorry! There is no staff", cboStaffName);
            }
        }

        private void StaffNameCboBind()
        {
            staffController = new StaffController();
            staffCollection = staffController.SelectController();

            cboStaffName.DataSource = staffCollection;
            cboStaffName.DisplayMember = "StaffName";
            cboStaffName.ValueMember = "StaffId";
        }

        #endregion

        private void cboStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmStaffMonthlyAttendanceRecord_Load(object sender, EventArgs e)
        {
            ShowAttendancebyDate();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!chkboxStaffName.Checked && !chkboxDate.Checked)
            {
                 ShowAttendance();     
            }
            else if (chkboxStaffName.Checked && chkboxDate.Checked)
            {
                if (cboStaffName.Items.Count > 0)
                {
                    ShowAttendancebyStaffIdDate();
                }
                else
                {
                    Utilities.ShowMessage(Utilities.MessageType.Warning, "၀န္ထမ္းအမည္မ်ား မရွိေသးပါ");
                }

            }
            else if (chkboxStaffName.Checked)
            {
                if (cboStaffName.Items.Count > 0)
                {
                    ShowAttendancebyStaffId();
                }
                else
                {
                    Utilities.ShowMessage(Utilities.MessageType.Warning, "၀န္ထမ္းအမည္မ်ား မရွိေသးပါ");
                }
                
            }
            else if (chkboxDate.Checked)
            {
                ShowAttendancebyDate();
            }
        }

        private void chkboxStaffName_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkboxStaffName.Checked)
            {
                cboStaffName.Enabled = true;
                txtStaffCode.Enabled = true;

                StaffNameCboBind();
            }
            else
            {
                cboStaffName.Enabled = false;
                txtStaffCode.Enabled = false;

            }
        }

        private void chkboxDate_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkboxDate.Checked)
            {
                dtpkStart.Enabled = true;
                dtpkEnd.Enabled = true;
            }
            else
            {
                dtpkStart.Enabled = false;
                dtpkEnd.Enabled = false;
            }
        }

        private void cboStaffName_DropDownClosed(object sender, EventArgs e)
        {
            if (cboStaffName.Items.Count > 0)
            {
                staffController = new StaffController();
                staffInfo = staffController.StaffSelectbyStaffId(cboStaffName.SelectedValue.ToString());
                txtStaffCode.Text = staffInfo.StaffCode;

                btnShow_Click(null, null);
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }
    }
}