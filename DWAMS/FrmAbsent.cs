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
    public partial class FrmAbsent : Form
    {
        AttendanceController attendanceController;

        AbsentController absentController;

        private string staffId;
        private DateTime absentDate;

        public FrmAbsent()
        {
            InitializeComponent();
        }

        #region myMethod

        private void BindAttendance()
        {
            attendanceController = new AttendanceController();
            AttendanceCollection attendanceCollection = attendanceController.DailyAttendanceSelectbyDate(System.DateTime.Today.Date, System.DateTime.Today.Date);

            dgvStaffMonthlyAttendance.AutoGenerateColumns = false;
            dgvStaffMonthlyAttendance.DataSource = attendanceCollection;
        }

        private void BindAbsent()
        {
            absentController = new AbsentController();

            dgvAbsent.AutoGenerateColumns = false;
            dgvAbsent.DataSource = absentController.SelectAbsent(dtpkDate.Value.Month, dtpkDate.Value.Year);

            if (dgvAbsent.RowCount == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ပ်က္ကြက္သူ မရွိပါ");
            }
        }

        private void UpdateToAbsent()
        {
            absentController = new AbsentController();
            absentController.UpdateAbsent(staffId, absentDate);

            //insert to attendance with default values
            attendanceController = new AttendanceController();
            attendanceController.InsertOutdoorStaff(staffId, absentDate);
        }

        #endregion

        private void FrmAbsentList_Load(object sender, EventArgs e)
        {
            BindAbsent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Utilities.ShowMessage(Utilities.MessageType.Question, "ျပဳလုပ္ရန္ေသခ်ာပါသလား?") == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvAbsent.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["colSelect"].Value))
                    {
                        staffId = row.Cells["colStaffid"].Value.ToString();
                        absentDate = Convert.ToDateTime(row.Cells["colAbsentdate"].Value);

                        //update the status of tblabsent to A to P
                        UpdateToAbsent();
                    }
                }
                BindAbsent();
            }
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            switch (btnPresent.Text)
            {
                case "ယေန႕ ႐ုံးတက္သည့္ ၀န္ထမ္းမ်ားစာရင္း ၾကည့္ရန္":
                    BindAttendance();

                    pnlHide.Visible = true;
                    btnPresent.Text = "ပ်က္ကြက္စာရင္း ၾကည့္ရန္";

                    btnSave.Enabled = false;
                    dtpkDate.Enabled = false;
                    btnShow.Enabled = false;
                    break;

                case "ပ်က္ကြက္စာရင္း ၾကည့္ရန္":
                    pnlHide.Visible = false;
                    btnPresent.Text = "ယေန႕ ႐ုံးတက္သည့္ ၀န္ထမ္းမ်ားစာရင္း ၾကည့္ရန္";

                    btnSave.Enabled = true;
                    dtpkDate.Enabled = true;
                    btnShow.Enabled = true;
                    break;
            }
        }

        private void FrmAbsent_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            BindAbsent();
        }

        private void presentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPresent_Click(null, null);
        }

    }
}