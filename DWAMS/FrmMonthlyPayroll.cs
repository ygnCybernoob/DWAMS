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
    public partial class FrmMonthlyPayroll : Form
    {
        SalaryPaymentController controller;
	   
        public FrmMonthlyPayroll()
        {
            InitializeComponent();
        }

        #region myMethod

        private void BindPayroll()
        {
            controller = new SalaryPaymentController();
            dgvStaffMonthlyPayroll.DataSource = controller.SelectMonthlyPayment(dtpkDate.Value.Month, dtpkDate.Value.Year);

            if (dgvStaffMonthlyPayroll.RowCount == 0)
            {
                Utilities.ShowMessage(Utilities.MessageType.Information, "ေဒတာ မွတ္တမ္း မရွိပါ");
            }
        }

        #endregion

        private void btnShow_Click(object sender, EventArgs e)
        {
            BindPayroll();
        }

        private void FrmTotalStaffMonthlyPayroll_Load(object sender, EventArgs e)
        {
            BindPayroll();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShow_Click(null, null);
        }

    }
}