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
    public partial class FrmUnnormalAttendance : Form
    {
        AttendanceController controller;
        AttendanceCollection collection;

        private string attendanceId;
        private int lateDutyIn, earlyDutyOut;

        public FrmUnnormalAttendance()
        {
            InitializeComponent();
        }

        #region myMethod

        private void CboStaffNameBind()
        {
            StaffController staffcontroller = new StaffController();
            StaffCollection collection = staffcontroller.SelectController();

            cboStaffName.DataSource = collection;
            cboStaffName.DisplayMember = "Staffname";
            cboStaffName.ValueMember = "StaffId";

        }

        private void Clear()
        {
            attendanceId = string.Empty;
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
        }

        private void Duty_Check(int type) //0 late >> 1 both
        {
            controller = new AttendanceController();

            if (type == 0)
            {
                controller.UnNormalAttendanceUpdate(attendanceId, lateDutyIn, earlyDutyOut, "L"); //late 
            }
            else
            {
                controller.UnNormalAttendanceUpdate(attendanceId, lateDutyIn, earlyDutyOut, "LE"); //late + early
            }

            BindUnnormalAttendance();
            Clear();
        }

        private void AdminChecked()
        {
            controller = new AttendanceController();

            if (chbLatedutyin.Checked && chbEarlydutyout.Checked)
            {
                lateDutyIn = 0;
                earlyDutyOut = 0;
                //type >>
                //NL NE
                //NL
                //NE
                controller.UnNormalAttendanceUpdate(attendanceId, lateDutyIn, earlyDutyOut, "NLNE");
            }
            else if (chbLatedutyin.Checked)
            {
                lateDutyIn = 0; //he wasn't late
                controller.UnNormalAttendanceUpdate(attendanceId, lateDutyIn, earlyDutyOut, "NL");
            }
            else if (chbEarlydutyout.Checked)
            {
                earlyDutyOut = 0; // he wasn't early
                controller.UnNormalAttendanceUpdate(attendanceId, lateDutyIn, earlyDutyOut, "NE");
            }

            BindUnnormalAttendance();
            
            Clear();
            chbLatedutyin.Checked = false;
            chbEarlydutyout.Checked = false; 
        }

        private void BindUnnormalAttendance()
        {
            controller = new AttendanceController();

            collection = controller.UnNormalAttendanceSelect();
            dgvAttendanceCheckList.DataSource = collection;

            if (dgvAttendanceCheckList.RowCount == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာမွတ္တမ္း မရွိေသးပါ");
            }
        }

        #endregion

        private void FrmAttendanceCheckbyAdmin_Load(object sender, EventArgs e)
        {
            CboStaffNameBind();
            BindUnnormalAttendance();
        }

        private void dgvAttendanceCheckList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvAttendanceCheckList.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            switch (cell.OwningColumn.Name)
            {
                case "coledit":
                    attendanceId = row.Cells[colattid.Index].Value.ToString();
                    txtCode.Text = row.Cells[colstaffcode.Index].Value.ToString();
                    txtName.Text = row.Cells[colstaffname.Index].Value.ToString();

                    lateDutyIn = Convert.ToInt32(row.Cells[collatedutyin.Index].Value.ToString());
                    earlyDutyOut = Convert.ToInt32(row.Cells[colearlydutyout.Index].Value.ToString());

                    if (lateDutyIn == 0)
                    {
                        chbLatedutyin.Enabled = false;
                    }
                    else
                    {
                        chbLatedutyin.Enabled = true;
                    }

                    if (earlyDutyOut == 0)
                    {
                        chbEarlydutyout.Enabled = false;
                    }
                    else
                    {
                        chbEarlydutyout.Enabled = true;
                    }

                    break;

                case "colChecked":
                    attendanceId = row.Cells[colattid.Index].Value.ToString();

                    lateDutyIn = Convert.ToInt32(row.Cells[collatedutyin.Index].Value.ToString());
                    earlyDutyOut = Convert.ToInt32(row.Cells[colearlydutyout.Index].Value.ToString());

                    string for_checking = row.Cells[coldutyout.Index].Value.ToString();

                    if (for_checking.Equals("ရုံးတက္ေနစဲ"))
                    {
                         Duty_Check(0);//he is late in
                    }
                    else
                    {
                        Duty_Check(1);//both late in and early out
                    }
           
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(attendanceId))
            {
                if (Utilities.ShowMessage(Utilities.MessageType.Question, "ေသခ်ာပါသလား") == DialogResult.Yes)
                {
                    AdminChecked();
                }
            }
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            BindUnnormalAttendance();
        }

        private void FrmUnnormalAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboStaffName_DropDownClosed(object sender, EventArgs e)
        {
            if (cboStaffName.Items.Count > 0)
            {
                controller = new AttendanceController();
                dgvAttendanceCheckList.DataSource = controller.UnNormalAttendanceSelectbyStaffId(cboStaffName.SelectedValue.ToString());

                if (dgvAttendanceCheckList.RowCount == 0)
                {
                    Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာမွတ္တမ္း မရွိေသးပါ");
                }
            }
            else
            {
                Utilities.ToolTipControl("Sorry! There is no staff", cboStaffName);
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShowAll_Click(null, null);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOK_Click(null, null);
        }
    }
}