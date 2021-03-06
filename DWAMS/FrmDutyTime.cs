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
    public partial class FrmDutyTime : Form
    {
        SettingController controller;
        SettingInfo info;

        private DateTime DutyIn, DutyOut;

        public FrmDutyTime()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controller = new SettingController();
            controller.UpdateSetting(dtpkDutyin.Value, dtpkDutyout.Value);

            Utilities.ShowMessage(Utilities.MessageType.Information, "အလုပ္ခ်ိန္ ကိုေျပာင္းလဲလိုက္ပါျပီ");

            this.Close();
            //float basicSalary =200000F; // 2 labs
            //int day = 30;
            //int hour = 24;
            //int minute = 60;
            //int second = 60;

            //float avgSalaryforDay = basicSalary / day;
            //float avgSalaryforHour = (basicSalary / day) / hour;
            //float avgSalaryforMinute = ((basicSalary / day) / hour) / minute;
            //float avgSalaryforSecond = (((basicSalary / day) / hour) / minute) / second;

            //string txt = @"Average Salary for 1 day : " + avgSalaryforDay + " kyats\n" + 
            //    "Average Salary for 1 hour : " + avgSalaryforHour+ " kyats\n"+
            //    "Average Salary for 1 min : " + avgSalaryforMinute + " kyats\n"+
            //    "Average Salary for 1 second : " + avgSalaryforSecond + " kyats";

            //Globalizer.ShowMessage(Globalizer.MessageType.Information, txt);
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            controller = new SettingController();
            info = controller.SelectSetting();

            DutyIn = info.Dutyintime;
            DutyOut = info.Dutyouttime;

            dtpkDutyin.Value = DutyIn;
            dtpkDutyout.Value = DutyOut;
        }

        private void dtpkDutyin_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }

        private void dtpkDutyout_KeyDown(object sender, KeyEventArgs e)
        {
            Utilities.Tab(e);
        }
    }
}