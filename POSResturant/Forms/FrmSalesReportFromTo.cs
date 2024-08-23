using DataAccess;
using POSResturant.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSResturant.Forms
{
    public partial class FrmSalesReportFromTo : Form
    {
        public delegate void BtnOkClickedEventHandler(DateTime from, DateTime to);
        public event BtnOkClickedEventHandler BtnOkClicked;

        public FrmSalesReportFromTo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BtnOkClicked?.Invoke(dtpFrom.Value, dtpTo.Value);
        }

        private void FrmSalesReportFromTo_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddDays(-1);
            dtpTo.Value = DateTime.Now;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dtpFrom.MaxDate = dtpTo.Value;
        }
    }
}
