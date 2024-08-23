using DataAccess;
using DataAccess.Objects;
using Microsoft.Reporting.WinForms;
using POSResturant.Forms;
using POSResturant.Tools;
using System;
using System.Data;
using System.Drawing;

namespace POSResturant.Classes
{
    public class clsSalesReport
    {
        private dsSalesReport _dsSalesReport = new dsSalesReport();

        private void _FillDsSalesReport(DateTime from, DateTime to)
        {
            DataTable salesReportDataTable = clsDataAccess.GetSalesReportDataTableBetweenFromAndTo(from, to);

            foreach (DataRow row in salesReportDataTable.Rows)
            {
                DataRow newRow = _dsSalesReport.Tables["dtSalesReport"].NewRow();

                newRow["ID"] = row["id"];
                newRow["dateAndTime"] = row["date_and_time"];
                newRow["paymentStatus"] = row["payment_status"];
                newRow["paymentAmount"] = row["payment_amount"];
                newRow["paymentMethod"] = row["payment_method"];
                newRow["username"] = row["username"];

                _dsSalesReport.Tables["dtSalesReport"].Rows.Add(newRow);
            }
        }
        public void RunSalesReport(DateTime from, DateTime to, Image salesReportLogo)
        {
            _FillDsSalesReport(from, to);
            FrmSalesReport frmSalesReport = new FrmSalesReport();

            frmSalesReport.rvSalesReport.LocalReport.ReportEmbeddedResource =
                "POSResturant.Reports.rptSalesReport.rdlc";

            frmSalesReport.rvSalesReport.LocalReport.DataSources.Clear();
            frmSalesReport.rvSalesReport.LocalReport.DataSources.Add(new ReportDataSource("dsSalesReport",
                _dsSalesReport.Tables["dtSalesReport"]));

            Option option = clsDataAccess.ReadOption(1);

            ReportParameter[] reportParameters = new ReportParameter[5];

            reportParameters[0] = new ReportParameter("restaurantName", option.Name);

            reportParameters[1] = new ReportParameter("logo",
                Convert.ToBase64String((byte[])clsImageByte.ImageToByte(option.Logo)));

            reportParameters[2] = new ReportParameter("salesReportLogo",
                Convert.ToBase64String((byte[])clsImageByte.ImageToByte(salesReportLogo)));

            reportParameters[3] = new ReportParameter("dateFrom", from.ToString("dd/MM/yyyy"));
            reportParameters[4] = new ReportParameter("dateTo", to.ToString("dd/MM/yyyy"));

            frmSalesReport.rvSalesReport.LocalReport.SetParameters(reportParameters);

            frmSalesReport.ShowDialog();
        }

        private void _FillDsSalesReportDetailed(DateTime from, DateTime to)
        {
            DataTable salesReportDetailedDataTable =
                clsDataAccess.GetSalesReportDetailedDataTableBetweenFromAndTo(from, to);

            foreach (DataRow row in salesReportDetailedDataTable.Rows)
            {
                DataRow newRow = _dsSalesReport.Tables["dtSalesReportDetailed"].NewRow();

                newRow["ID"] = row["ID"];
                newRow["status"] = row["status"];
                newRow["date_and_time"] = row["date_and_time"];

                newRow["category"] = row["category"];
                newRow["item"] = row["item"];
                newRow["price"] = row["price"];
                newRow["qty"] = row["qty"];

                _dsSalesReport.Tables["dtSalesReportDetailed"].Rows.Add(newRow);
            }
        }
        public void RunSalesReportDetailed(DateTime from, DateTime to, Image salesReportDetailedLogo)
        {
            _FillDsSalesReportDetailed(from, to);
            FrmSalesReportDetailed frmSalesReportDetailed = new FrmSalesReportDetailed();

            frmSalesReportDetailed.rvSalesReportDetailed.LocalReport.ReportEmbeddedResource =
                "POSResturant.Reports.rptSalesReportDetailed.rdlc";

            frmSalesReportDetailed.rvSalesReportDetailed.LocalReport.DataSources.Clear();
            frmSalesReportDetailed.rvSalesReportDetailed.LocalReport.DataSources.Add(
                new ReportDataSource("dsSalesReport", _dsSalesReport.Tables["dtSalesReportDetailed"]));

            Option option = clsDataAccess.ReadOption(1);

            ReportParameter[] reportParameters = new ReportParameter[5];

            reportParameters[0] = new ReportParameter("restaurantName", option.Name);

            reportParameters[1] = new ReportParameter("logo",
                Convert.ToBase64String((byte[])clsImageByte.ImageToByte(option.Logo)));

            reportParameters[2] = new ReportParameter("salesReportDetailedLogo",
                Convert.ToBase64String((byte[])clsImageByte.ImageToByte(salesReportDetailedLogo)));

            reportParameters[3] = new ReportParameter("dateFrom", from.ToString("dd/MM/yyyy"));
            reportParameters[4] = new ReportParameter("dateTo", to.ToString("dd/MM/yyyy"));

            frmSalesReportDetailed.rvSalesReportDetailed.LocalReport.SetParameters(reportParameters);

            frmSalesReportDetailed.ShowDialog();
        }
    }
}
