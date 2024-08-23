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
    public partial class FrmReports : Form
    {
        public delegate void ChildFormClosedEventHandler();
        public event ChildFormClosedEventHandler ChildFormClosed;

        public FrmReports()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            ChildFormClosed?.Invoke();
        }

        private void SalesReport(DateTime from, DateTime to)
        {
            clsSalesReport clsSalesReport = new clsSalesReport();
            clsSalesReport.RunSalesReport(from, to, btnSalesReport.Image);
        }
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            FrmSalesReportFromTo frmSalesReportFromTo = new FrmSalesReportFromTo();
            frmSalesReportFromTo.BtnOkClicked += SalesReport;
            frmSalesReportFromTo.ShowDialog();
        }

        private void SalesReportDetailed(DateTime from, DateTime to)
        {
            clsSalesReport clsSalesReport = new clsSalesReport();
            clsSalesReport.RunSalesReportDetailed(from, to, btnSalesReportDetailed.Image);
        }
        private void btnSalesReportDetailed_Click(object sender, EventArgs e)
        {
            FrmSalesReportFromTo frmSalesReportFromTo = new FrmSalesReportFromTo();
            frmSalesReportFromTo.BtnOkClicked += SalesReportDetailed;
            frmSalesReportFromTo.ShowDialog();
        }
    }
}
