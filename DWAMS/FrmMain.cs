using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserAccount_BLL;
using System.Threading;
using System.IO;
using DWAMS_BLL;

namespace DWAMS
{
    public partial class FrmMain : Form
    {
        private UserAccountInfo info;
        //private AttendanceController controller;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region myMethod


        private void BindAbsent()
        {
            AbsentController absentController = new AbsentController();

            dgvAbsent.AutoGenerateColumns = false;
            dgvAbsent.DataSource = absentController.SelectAbsent(System.DateTime.Today.Month, System.DateTime.Today.Year);

            if (dgvAbsent.RowCount == 0)
            {
                lblAbsentList.Text = "ရုံးတက္ပ်က္ကြက္သူမ်ား စာရင္း မရွိေသးပါ";
            }
            else
            {
                lblAbsentList.Text = "ရုံးတက္ပ်က္ကြက္သူမ်ား စာရင္းတြင္ ၀န္ထမ္း " + Utilities.BurmeseNumber(dgvAbsent.RowCount.ToString().ToCharArray()) + " ေယာက္ရွိ႔ပါသည္";
            }
        }

        private  void BindUnnormalAttendance()
        {
            dgvUnnormalAttendance.DataSource = null;

            AttendanceController attendanceController = new AttendanceController();
            dgvUnnormalAttendance.DataSource = attendanceController.UnNormalAttendanceSelect();

            if (dgvUnnormalAttendance.RowCount > 0)
            {
                lblUnnormalAttendance.Text = "ရုံးေနာက္က် / ေစာထြက္သူမ်ား စာရင္းတြင္ ၀န္ထမ္း " + Utilities.BurmeseNumber(dgvUnnormalAttendance.RowCount.ToString().ToCharArray()) + "ေယာက္ အတည္ျပဳရန္ ရွိပါသည္";
            }
            else
            {
                lblUnnormalAttendance.Text = "ရုံးေနာက္က် / ေစာထြက္သူမ်ား စာရင္း မရွိေသးပါ";
            }
            
        }

        //private void CheckUnnormalAttendance()
        //{
        //    controller = new AttendanceController();
        //    int total = controller.UnNormalAttendanceCount();
        //    if (total > 0)
        //    {
        //        string message = "Do you have free time?\n" +
        //            "There are " + total + " un-normal attendance to confirm";

        //        if (Globalizer.ShowMessage(Globalizer.MessageType.Question, message) == DialogResult.Yes)
        //        {
        //            FrmUnnormalAttendance aca = new FrmUnnormalAttendance();
        //            aca.ShowDialog();
        //        }
        //    }

        //}

        private void OpenNew(object obj)
        {
            FrmAttendanceEntry a = new FrmAttendanceEntry(false);
            Application.Run(a);
        }

        public void GetUserInfo(UserAccountInfo info)
        {
            this.info = info;
            Permission(info.Permission);
        }

        private void Permission(string permission)
        {
            if (permission.Equals("no"))
            {
                //entry
                staffInfomationToolStripMenuItem.Visible = false;

                //admin
                adminToolStripMenuItem.Visible = false;

                //setting
                accountListToolStripMenuItem.Visible = false;
                registerAccountToolStripMenuItem.Visible = false;
                dutyTimeToolStripMenuItem.Visible = false;

                btnAbsent.Visible = false;
                btnUnnormalAttendance.Visible = false;
                btnPayment.Visible = false;

            }
            
        }

        #endregion

        private void staffInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStaff s = new FrmStaff();
            s.ShowDialog();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPosition p = new FrmPosition();
            p.ShowDialog();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment d = new FrmDepartment();
            d.ShowDialog();
        }

        private void addressInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddress a = new FrmAddress();
            a.ShowDialog();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAttendanceEntry a = new FrmAttendanceEntry(true);
            a.ShowDialog();


            BindAbsent();
            BindUnnormalAttendance();
        }

        private void totalStaffMonthlyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAttendanceSummery t = new FrmAttendanceSummery();
            t.ShowDialog();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonthlyPayroll p = new FrmMonthlyPayroll();
            p.ShowDialog();
        }

        private void staffMonthlyAttendanceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAttendanceDetail s = new FrmAttendanceDetail();
            s.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutSoftware a = new FrmAboutSoftware();
            a.ShowDialog();
        }

        private void ourTearmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutUs a = new FrmAboutUs();
            a.ShowDialog();
        }

        private void FrmMainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = Globalizer.ShowMessage(Globalizer.MessageType.Question, "Logout ထြက္ခ်င္ပါသလား ?");
            if (result == DialogResult.Yes)
            {
                Thread th = new Thread(OpenNew);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FrmMainUI_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Duty Time.ams"))
            {
                System.IO.File.Create("Duty Time.ams");

                FrmDutyTime d = new FrmDutyTime();
                d.ShowDialog();
            }

            BindUnnormalAttendance();
            BindAbsent();
        }

        private void attendanceDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAttendanceDetail a = new FrmAttendanceDetail();
            a.ShowDialog();
        }

        private void attendanceSummeryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAttendanceSummery a = new FrmAttendanceSummery();
            a.ShowDialog();
        }


        private void unnormalAttendanceCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnnormalAttendance a = new FrmUnnormalAttendance();
            a.ShowDialog();

            BindUnnormalAttendance();
        }

        private void absentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAbsent a = new FrmAbsent();
            a.ShowDialog();

            BindAbsent();
        }

        private void salaryPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayrollEntry s = new FrmPayrollEntry();
            s.ShowDialog();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminMesssage am = new FrmAdminMesssage();
            am.ShowDialog();
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            FrmAbsent a = new FrmAbsent();
            a.ShowDialog();

            BindAbsent();
        }

        private void btnUnnormalAttendance_Click(object sender, EventArgs e)
        {
            FrmUnnormalAttendance u = new FrmUnnormalAttendance();
            u.ShowDialog();

            BindUnnormalAttendance();
        }

        private void btnAttendanceDetail_Click(object sender, EventArgs e)
        {
            FrmAttendanceDetail a = new FrmAttendanceDetail();
            a.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FrmPayrollEntry p = new FrmPayrollEntry();
            p.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            FrmAttendanceEntry a = new FrmAttendanceEntry(true);
            a.ShowDialog();

            BindAbsent();
            BindUnnormalAttendance();
        }

        private void pnlFoot_SizeChanged(object sender, EventArgs e)
        {
            Utilities.CenterMyControl(lblFooter);
        }

        private void staffReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Staff s = new Report_Staff();
            s.ShowDialog();
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Attendance a = new Report_Attendance();
            a.ShowDialog();
        }

        private void attendanceSummeryReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report_attendance_summery a = new Report_attendance_summery();
            a.ShowDialog();
        }

        private void payrollReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_monthly_payroll p = new Report_monthly_payroll();
            p.ShowDialog();
        }

        private void dutyTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDutyTime s = new FrmDutyTime();
            s.ShowDialog();
        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserAccount ua = new FrmUserAccount();
            ua.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword cp = new FrmChangePassword();
            //cp.UserInfo(info);
            cp.Username = info.Username;
            cp.ShowDialog();
        }

        private void registerAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegister reg = new FrmRegister();
            reg.ShowDialog();
        }

        private void btnAbsentList_Click(object sender, EventArgs e)
        {
            FrmAbsentList a = new FrmAbsentList();
            a.ShowDialog();
        }

        private void absentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbsentList a = new FrmAbsentList();
            a.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelp h = new FrmHelp();
            h.ShowDialog();
        }
    }
}