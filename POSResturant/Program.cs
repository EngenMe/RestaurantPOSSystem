using POSResturant.Classes;
using POSResturant.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSResturant
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);

            FrmStartUp frmStartUp = new FrmStartUp();
            if (frmStartUp.ShowDialog() == DialogResult.OK)
            {
                FrmLogin frmLogin = new FrmLogin();
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.EnableVisualStyles();
                    Application.Run(new FrmMain());
                }
            }
        }
    }
}
