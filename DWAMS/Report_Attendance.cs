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
    public partial class Report_Attendance : Form
    {
        StaffController staffController;
        StaffInfo staffInfo;
        StaffCollection staffCollection;

        public Report_Attendance()
        {
            InitializeComponent();
        }

        #region myMethod

        private void StaffNameCboBind()
        {
            staffController = new StaffController();
            staffCollection = staffController.SelectController();

            cboStaffName.DataSource = staffCollection;
            cboStaffName.DisplayMember = "StaffName";
            cboStaffName.ValueMember = "StaffId";
        }


        #endregion

        private void Report_Attendance_Load(object sender, EventArgs e)
        {
            rpvAttendance.Visible = false;
            rpvAttendance_by_staff.Visible = false;
            rpvAttendance_by_date.Visible = true;
            rpvAttendance_by_staff_date.Visible = false;
            //ShowAttendancebyDate();

            this.Attendance_select_by_dateTableAdapter.Fill(this.DataSet_attendance.Attendance_select_by_date, dtpkStart.Value.Date, dtpkEnd.Value.Date);
            this.rpvAttendance_by_date.RefreshReport();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!chkboxStaffName.Checked && !chkboxDate.Checked)
            {
                rpvAttendance.Visible = true;
                rpvAttendance_by_staff.Visible = false;
                rpvAttendance_by_date.Visible = false;
                rpvAttendance_by_staff_date.Visible = false;

                this.Attendance_selectTableAdapter.Fill(this.DataSet_attendance.Attendance_select);
                rpvAttendance.RefreshReport();
            }
            else if (chkboxStaffName.Checked && chkboxDate.Checked)
            {
                if (cboStaffName.Items.Count > 0)
                {
                    rpvAttendance.Visible = false;
                    rpvAttendance_by_staff.Visible = false;
                    rpvAttendance_by_date.Visible = false;
                    rpvAttendance_by_staff_date.Visible = true;
                    //ShowAttendancebyStaffIdDate();

                    this.Attendance_by_staff_and_dateTableAdapter.Fill(this.DataSet_attendance.Attendance_by_staff_and_date, cboStaffName.SelectedValue.ToString(), dtpkStart.Value.Date, dtpkEnd.Value.Date);
                    rpvAttendance_by_staff_date.RefreshReport();
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
                    rpvAttendance.Visible = false;
                    rpvAttendance_by_staff.Visible = true;
                    rpvAttendance_by_date.Visible = false;
                    rpvAttendance_by_staff_date.Visible = false;

                    this.Attendance_by_staffTableAdapter.Fill(this.DataSet_attendance.Attendance_by_staff, cboStaffName.SelectedValue.ToString());
                    rpvAttendance_by_staff.RefreshReport();
                }
                else
                {
                    Utilities.ShowMessage(Utilities.MessageType.Warning, "၀န္ထမ္းအမည္မ်ား မရွိေသးပါ");
                }

            }
            else if (chkboxDate.Checked)
            {
                rpvAttendance.Visible = false;
                rpvAttendance_by_staff.Visible = false;
                rpvAttendance_by_date.Visible = true;
                rpvAttendance_by_staff_date.Visible = false;
                //ShowAttendancebyDate();

                this.Attendance_select_by_dateTableAdapter.Fill(this.DataSet_attendance.Attendance_select_by_date,dtpkStart.Value.Date, dtpkEnd.Value.Date);
                this.rpvAttendance_by_date.RefreshReport();
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
    }
}