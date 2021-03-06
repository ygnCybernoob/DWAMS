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
    public partial class FrmAttendanceSummery : Form
    {
        AttendanceSummeryController summeryController;
        AttendanceSummeryCollection summeryCollection;

        public FrmAttendanceSummery()
        {
            InitializeComponent();
        }

        #region myMethod

        private void ShowAttendanceSummerybyDate()
        {

            summeryController  = new AttendanceSummeryController();
            summeryCollection = summeryController.AttendanceSummerySelect(dtpkDate.Value.Month, dtpkDate.Value.Year);

            dgvMonthlyAttendance.AutoGenerateColumns = false;
            dgvMonthlyAttendance.DataSource = summeryCollection;

            if (dgvMonthlyAttendance.RowCount == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာ မွတ္တမ္း မရွိပါ");
            }
        }

        #endregion


        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowAttendanceSummerybyDate();
        }

        private void FrmAttendanceSummeryReport_Load(object sender, EventArgs e)
        {
            ShowAttendanceSummerybyDate();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }

    }
}