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
    public partial class FrmSales : Form
    {
        public delegate void ChildFormClosedEventHandler();
        public event ChildFormClosedEventHandler ChildFormClosed;

        public FrmSales()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            ChildFormClosed?.Invoke();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FrmPOS frmPOS = new FrmPOS();
            frmPOS.ShowDialog();
        }
    }
}
