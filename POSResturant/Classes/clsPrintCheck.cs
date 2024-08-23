using DataAccess;
using DataAccess.Objects;
using Microsoft.Reporting.WinForms;
using POSResturant.Forms;
using POSResturant.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSResturant.Classes
{
    public class clsPrintCheck
    {
        private dsChecks _dsCheck = new dsChecks();

        private void _FillDsCheck(int paymentID)
        {
            DataTable checkDataTable = clsDataAccess.GetCheckDataTable(paymentID);

            foreach (DataRow row in checkDataTable.Rows)
            {
                DataRow newRow = _dsCheck.Tables["dtChecks"].NewRow();
                newRow["ID"] = row["id"];
                newRow["checkDateAndTime"] = row["date_and_time"];
                newRow["checkTotal"] = row["amount_to_be_paid"];
                newRow["itemID"] = row["item_id"];
                newRow["itemName"] = row["name"];
                newRow["itemQTY"] = row["qty"];
                newRow["itemPrice"] = row["price"];
                newRow["itemTotalPrice"] = Convert.ToDecimal(row["price"]) * Convert.ToDecimal(row["qty"]);
                _dsCheck.Tables["dtChecks"].Rows.Add(newRow);
            }
        }
        public void RunPrintCheck(int paymentID)
        {
            _FillDsCheck(paymentID);
            FrmSalesReport frmSalesReport = new FrmSalesReport();

            frmSalesReport.rvSalesReport.LocalReport.ReportEmbeddedResource = 
                "POSResturant.Reports.rptCheck.rdlc";

            frmSalesReport.rvSalesReport.LocalReport.DataSources.Clear();
            frmSalesReport.rvSalesReport.LocalReport.DataSources.Add(new ReportDataSource("dsCheck",
                _dsCheck.Tables["dtChecks"]));

            Option option = clsDataAccess.ReadOption(1);
            ReportParameter[] reportParameters = new ReportParameter[3];
            reportParameters[0] = new ReportParameter("checkLine1", option.ReceiptLine1);

            if (string.IsNullOrWhiteSpace(option.ReceiptLine2))
                reportParameters[1] = new ReportParameter("checkLine2", string.Empty);
            else
                reportParameters[1] = new ReportParameter("checkLine2", option.ReceiptLine2);

            reportParameters[2] = new ReportParameter("logo",
                Convert.ToBase64String((byte[])clsImageByte.ImageToByte(option.Logo)));

            frmSalesReport.rvSalesReport.LocalReport.SetParameters(reportParameters);

            frmSalesReport.ShowDialog();
        }
    }
}
