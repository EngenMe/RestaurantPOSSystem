using DataAccess;
using DataAccess.Objects;
using POSResturant.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POSResturant.Forms
{
    public partial class FrmSalesReportDetailed : Form
    {
        public FrmSalesReportDetailed()
        {
            InitializeComponent();
        }

        private void FrmSalesReport_Load(object sender, EventArgs e)
        {
            this.rvSalesReportDetailed.RefreshReport();
        }
    }
}
