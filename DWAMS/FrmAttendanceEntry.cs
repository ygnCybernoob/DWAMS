using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DWAMS_BLL;
using System.IO;
using UserAccount_BLL;
using System.Threading;

namespace DWAMS
{
    public partial class FrmAttendanceEntry : Form
    {
        private string DATE = @"DATE.ams";
        private string company_name;
        private DateTime fileDate;
        private bool new_user;

        private UserAccountInfo info;
        AttendanceController attendancecontroller;

        SettingController controller; //to collect duty time

        private string staffId;
        private DateTime attendanceDate;

        private DateTime DUTY_IN_TIME;
        private DateTime DUTY_OUT_TIME;

        public FrmAttendanceEntry(bool loged_in)
        {
            InitializeComponent();
            if (loged_in)
            {
                btnLoginForm.Enabled = false;
            }
        }

        #region myMethod

        public void ShowHelp()
        {
            Utilities.CenterMyControl(lblHelp);
            lblHelp.Visible = true;
            new_user = true;
        }

        private void OpenNew(object obj)
        {
            FrmMain m = new FrmMain();
            m.GetUserInfo(info);

            Application.Run(m);
        }

        private bool CheckRequiredField()
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                Utilities.ToolTipControl("User name must be fill", txtUserName);
                txtUserName.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Utilities.ToolTipControl("Password must be fill", txtPassword);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void clean()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Focus();

            lblUser_name.Visible = true;
            lblPassword.Visible = true;
        }


        #region DateFile
        private void DateFileReader()
        {
            if (File.Exists(DATE))
            {
                using (StreamReader streamReader = new StreamReader(DATE))
                {
                    fileDate = Convert.ToDateTime(streamReader.ReadLine());
                }

                TimeSpan ts = System.DateTime.Today.Subtract(fileDate);

                if (ts.TotalDays > 0)
                {
                    DateFileWriter();
                }
            }
            else
            {
                DateFileWriter();
            }
        }
        private void DateFileWriter()
        {
            using (StreamWriter streamWriter = new StreamWriter(DATE))
            {
                streamWriter.WriteLine(DateTime.Today.ToShortDateString());
            }

            InsertDataToAbsent();
        }
        #endregion

        private void InsertDataToAbsent()
        {
            //Inserting Absent Status to TblAbsent for all staff
            AbsentController absentController = new AbsentController();
            absentController.InsertToAbsent(attendanceDate.Date);
        }

        private void InitComponent()
        {
            lblCompanyName.Text = company_name;
            lblRegistered.Text = "Registered by : " + company_name;

            Utilities.CenterMyControl(lblRegistered);

            Utilities.CenterMyControl(lblCompanyName);
            Utilities.CenterMyControl(pnlAttendance);
            Utilities.CenterMyControl(pnlLogin);
            Utilities.CenterMyControl(pnlHeader);

            Utilities.CenterMyControl(lblCode);
            Utilities.CenterMyControl(txtStaffCode);
            Utilities.CenterMyControl(btnOK);
            Utilities.CenterMyControl(lblRemark);
            Utilities.CenterMyControl(txtRemark);
            
            Utilities.CenterMyControl(lblFooter);
        }

        private void Clear()
        {
            txtStaffCode.Text = string.Empty;
            txtRemark.Text = string.Empty;
            staffId = string.Empty;

            txtStaffCode.Focus();
        }

        private void CheckAttendance()
        {
            /**
             *read the file date and compare to current date
             * if they are different 
             * over-write current date to file and 
             * insert data to Absent for all staff
             * if file is not exists create new file and
             * write the current date and insert data to Absent
             */
            DateFileReader();

            attendancecontroller = new AttendanceController();
            AttendanceStatus status = attendancecontroller.AttendanceCheckStatus(staffId, attendanceDate.Date);

            switch (status)
            {
                case AttendanceStatus.DutyIn:
                    DutyIn();
                    Globalizer.ShowMessage(Globalizer.MessageType.Information, "မဂၤလာပါ");
                    break;

                case AttendanceStatus.DutyOut:
                    DutyOut();
                    Globalizer.ShowMessage(Globalizer.MessageType.Information, "မဂၤလာရွိေသာ ညေနခင္းျဖစ္ပါေစ");
                    break;
            }
            Clear();
        }

        private void DutyIn()
        {
            attendancecontroller = new AttendanceController();
            TimeSpan ts = attendanceDate - DUTY_IN_TIME;

            AbsentController absentController = new AbsentController();
            absentController.UpdateAbsent(staffId, attendanceDate.Date);

            if (ts.TotalMinutes > 0)
            {
                attendancecontroller.DutyIn(staffId, attendanceDate.Date, attendanceDate, ts.TotalMinutes, txtRemark.Text.Trim(), 'Y'); // he is  late so >> Y (yes)
            }
            else
            {
                attendancecontroller.DutyIn(staffId, attendanceDate.Date, attendanceDate, 0, txtRemark.Text.Trim(), 'N'); //he is not late >> N (no) 
            }
         
        }

        private void DutyOut()
        {
            //bug found
            attendancecontroller = new AttendanceController();
            TimeSpan ts = DUTY_OUT_TIME - attendanceDate;

            if (ts.TotalMinutes > 0)
            {
                attendancecontroller.DutyOut(staffId, attendanceDate.Date, attendanceDate, ts.TotalMinutes, txtRemark.Text.Trim(), 'Y');
            }
            else
            {
                // if not early out replace 0 to his/her dutyout
                attendancecontroller.DutyOut(staffId, attendanceDate.Date, attendanceDate, 0, txtRemark.Text.Trim(), 'N');
            }//end of inner if else

        }

        #endregion


        private void FrmAttendanceEntry_Load(object sender, EventArgs e)
        {
            company_name = Utilities.CompanyFileReader();

            InitComponent();

            timer.Interval = 1;
            timer.Start();

            if (new_user)
            {
                if (!pnlLogin.Visible)
                {
                    btnAttendanceForm.ForeColor = Color.FromArgb(88, 59, 41);
                    btnAttendanceForm.BackColor = Color.FromArgb(209, 210, 212);

                    btnLoginForm.BackColor = Color.FromArgb(232, 86, 39);
                    btnLoginForm.ForeColor = Color.FromArgb(255, 255, 255);

                    pnlLogin.Height = 0;
                    pnlLogin.Visible = true;
                    pnlAttendance.Visible = false;
                    timerShutter_Login.Interval = 1;
                    timerShutter_Login.Start();
                }
            }
            else
            {
                if (!pnlAttendance.Visible)
                {
                    pnlAttendance.Height = 0;
                    pnlAttendance.Visible = true;
                    pnlLogin.Visible = false;
                    timerShutter_Attendance.Interval = 1;
                    timerShutter_Attendance.Start();
                }
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = System.DateTime.Now.ToString();
            Utilities.CenterMyControl(lblClock);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStaffCode.Text.Trim()))
            {
                StaffController staffcontroller = new StaffController();
                StaffInfo staffinfo = staffcontroller.StaffSelectbyStaffCode(txtStaffCode.Text.Trim());

                if (string.IsNullOrEmpty(staffinfo.StaffId))
                {
                    Globalizer.ShowMessage(Globalizer.MessageType.Warning, "သင္၏ ကုဒ္နံပါတ္မွာ မွားယြင္းေနပါသည္");
                    txtStaffCode.Focus();
                }
                else
                {

                    attendancecontroller = new AttendanceController();
                    AttendanceStatus status = attendancecontroller.AttendanceCheckStatus(staffinfo.StaffId, System.DateTime.Today);
                    string status_string = "";

                    switch (status)
                    {
                        case AttendanceStatus.DutyIn:
                            status_string = "ရုံးတက္ရန္";
                            break;

                        case AttendanceStatus.DutyOut:
                            status_string = "ရုံးဆင္းရန္";
                            break;

                        case AttendanceStatus.Full:
                            Utilities.ShowMessage(Utilities.MessageType.Information, staffinfo.StaffName+"\n"+"သင္၏ တစ္ေန႕တာအလုပ္ခ်ိန္ ျပီးဆုံးသြားပါျပီ");
                            Clear();
                            return;
                    }

                    string txt = "\t"+status_string + "\n"
                               + "သင္ဟုတ္ မဟုတ္ အတည္ျပဳပါ\n\n" + "ကုဒ္နံပါတ္ :\t"
                               + staffinfo.StaffCode + "\nအမည္ :\t\t"
                               + staffinfo.StaffName + "\nဌာန :\t\t"
                               + staffinfo.Depname + "\nရာထူး :\t\t"
                               + staffinfo.Position + "\nၿမဳိ႕နယ္ :\t\t"
                               + staffinfo.Addressname;

                    DialogResult result = Globalizer.ShowMessage(Globalizer.MessageType.Question, txt);

                    if (result == DialogResult.Yes)
                    {
                        #region Select_Dutytime
                        //select duty time from database >> setting table
                        //why i put this code here is if user changed the datetime before attendance (it will occur logic error)
                        controller = new SettingController(); 
                        SettingInfo info = controller.SelectSetting();

                        DUTY_IN_TIME = DateTime.Parse(info.Dutyintime.ToShortTimeString());
                        DUTY_OUT_TIME = DateTime.Parse(info.Dutyouttime.ToShortTimeString());
                        #endregion

                        staffId = staffinfo.StaffId;
                        attendanceDate = System.DateTime.Now;

                        CheckAttendance(); //check wherether duty in or out or full
                    }
                    else
                    {
                        txtStaffCode.Text = string.Empty;
                        txtStaffCode.Focus();
                    }

                }

            }
            else
            {
                Utilities.ToolTipControl("Please enter you code number here!", txtStaffCode);
                txtStaffCode.Focus();
            }
        }

        private void txtStaffCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }

        private void pnllbl_SizeChanged(object sender, EventArgs e)
        {
            InitComponent();
        }


        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            if (!pnlLogin.Visible)
            {
                btnAttendanceForm.ForeColor = Color.FromArgb(88, 59, 41);
                btnAttendanceForm.BackColor = Color.FromArgb(209, 210, 212);

                btnLoginForm.BackColor = Color.FromArgb(232, 86, 39);
                btnLoginForm.ForeColor = Color.FromArgb(255, 255, 255);

                pnlLogin.Height = 0;
                pnlLogin.Visible = true;
                pnlAttendance.Visible = false;
                timerShutter_Login.Interval = 1;
                timerShutter_Login.Start();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                UserAccountController controller = new UserAccountController();
                info = new UserAccountInfo();

                info.Username = txtUserName.Text.Trim();
                info.Password = txtPassword.Text;

                UserAccountController.SelectType type = controller.SelectController(info);

                if (type == UserAccountController.SelectType.ActiveTrueAdmin)
                {
                    info.Permission = "yes";

                    this.Close();
                    Thread th = new Thread(OpenNew);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (type == UserAccountController.SelectType.ActiveTrue)
                {
                    info.Permission = "no";

                    this.Close();
                    Thread th = new Thread(OpenNew);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (type == UserAccountController.SelectType.Active_False)
                {
                    FrmChangePassword c = new FrmChangePassword();
                    c.New_user = true;
                    c.UserInfo(info);
                    c.ShowDialog();

                }
                else if (type == UserAccountController.SelectType.NotExist)
                {
                    Globalizer.ShowMessage(Globalizer.MessageType.Warning, "သင္၏ အေကာင့္အမည္ (သို႕) လွ်ဳိ႕၀ွက္ကုဒ္ မွာ မွားယြင္းေနပါသည္");
                }
                clean();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void timerShutter_Attendance_Tick(object sender, EventArgs e)
        {
            if (pnlAttendance.Height <= 370)
            {
                pnlAttendance.Height += 10;
            }
            else
            {
                timerShutter_Attendance.Stop();
                txtStaffCode.Focus();
                this.Refresh();
            }
        }

        private void btnAttendanceForm_Click(object sender, EventArgs e)
        {
            if (!pnlAttendance.Visible)
            {
                btnAttendanceForm.ForeColor = Color.FromArgb(255, 255, 255);
                btnAttendanceForm.BackColor = Color.FromArgb(232, 86, 39);

                btnLoginForm.BackColor = Color.FromArgb(209, 210, 212);
                btnLoginForm.ForeColor = Color.FromArgb(88, 59, 41);

                pnlAttendance.Height = 0;
                pnlAttendance.Visible = true;
                pnlLogin.Visible = false;
                timerShutter_Attendance.Interval = 1;
                timerShutter_Attendance.Start();
            }

        }

        private void timerShutter_Login_Tick(object sender, EventArgs e)
        {
            if (pnlLogin.Height <= 370)
            {
                pnlLogin.Height += 10;
            }
            else
            {
                timerShutter_Login.Stop();
                txtUserName.Focus();
                this.Refresh();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPassword.Visible = true;
            }
            else
            {
                lblPassword.Visible = false;
            }
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                lblUser_name.Visible = true;
            }
            else
            {
                lblUser_name.Visible = false;
            }
        }

        private void lblUser_name_Click(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoginForm_Click(null, null);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAttendanceForm_Click(null, null);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutUs obj = new FrmAboutUs();
            obj.ShowDialog();
        }

    }
}