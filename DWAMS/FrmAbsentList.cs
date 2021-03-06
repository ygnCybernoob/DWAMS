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
    public partial class FrmAbsentList : Form
    {
        public FrmAbsentList()
        {
            InitializeComponent();
        }

        #region myMethod

        private void BindAbsent()
        {
            AbsentController absentController = new AbsentController();

            dgvAbsent.AutoGenerateColumns = false;
            dgvAbsent.DataSource = absentController.SelectAbsent(dtpkDate.Value.Month, dtpkDate.Value.Year);

            if (dgvAbsent.RowCount == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ပ်က္ကြက္သူ မရွိပါ");
            }
        }

        #endregion

        private void btnShow_Click(object sender, EventArgs e)
        {
            BindAbsent();
        }

        private void FrmAbsentList_Load(object sender, EventArgs e)
        {
            BindAbsent();
        }
    }
}