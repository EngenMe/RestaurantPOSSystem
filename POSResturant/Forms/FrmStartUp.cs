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
    public partial class FrmStartUp : Form
    {
        public FrmStartUp()
        {
            InitializeComponent();
        }

        private void tStartUp_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "Loading . . .";
            if (pbStartUp.Value >= 30 && pbStartUp.Value <= 40)
            {
                lblInfo.Text = "Loading System Options . . .";

                if (pbStartUp.Value == 30)
                    clsLog.systemOptions = clsDataAccess.ReadOption(1);
            }
            if (pbStartUp.Value == 100)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                pbStartUp.Value += 10;
                pbStartUp.Refresh();
            }
        }
    }
}
