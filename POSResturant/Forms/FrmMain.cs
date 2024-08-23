using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Objects;
using POSResturant.Classes;
using POSResturant.Forms;

namespace POSResturant
{
    public partial class FrmMain : Form
    {
        private Button _currentButton;
        private Form _activeForm;
        private Size _oldSize;
        private Point _oldLocation;
        private int _userPermission;

        public FrmMain()
        {
            InitializeComponent();
        }

        private Color SelectTheme()
        {
            switch (_currentButton.Text)
            {
                case "Sales":
                    return Color.FromArgb(255, 191, 0); // Amber Yellow (#FFBF00)
                case "Setup":
                    return Color.FromArgb(0, 128, 128); // Teal Green (#008080)
                case "Reports":
                    return Color.FromArgb(65, 105, 225); // Royal Blue (#4169E1)
                case "Options":
                    return Color.FromArgb(220, 20, 60); // Crimson Red (#DC143C)
                default:
                    return pnlMenu.BackColor;
            }
        }
        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                UnselectButton();
                _currentButton = (Button)sender;
                Color color = SelectTheme();
                _currentButton.BackColor = color;
                _currentButton.ForeColor = Color.White;
                _currentButton.Font = new Font("Roboto", 12F, FontStyle.Bold);

                pnlTitle.BackColor = color;
                lblTitle.Text = _currentButton.Text;
            }
        }
        private void UnselectButton()
        {
            foreach (Control ctrl in pnlMenu.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = pnlMenu.BackColor;
                    ctrl.ForeColor = Color.Ivory;
                    ctrl.Font = new Font("Roboto", 12F, FontStyle.Regular);
                }
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new FrmSales(), sender);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            FrmSetup frmSetup = new FrmSetup(_userPermission);
            frmSetup.PermissionUpdated += _LoadPermissions;
            OpenChiledForm(frmSetup, sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new FrmReports(), sender);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new FrmOptions(), sender);
        }

        private bool _SalesEnable()
        {
            bool posEnable = (_userPermission & (int)clsStaticLibrary.enPermission.pos) ==
                (int)clsStaticLibrary.enPermission.pos;

            return posEnable;
        }
        private bool _SetupEnable()
        {
            bool usersEnable = (_userPermission & (int)clsStaticLibrary.enPermission.users) ==
                (int)clsStaticLibrary.enPermission.users;

            bool categoriesEnable = (_userPermission & (int)clsStaticLibrary.enPermission.categories) ==
                (int)clsStaticLibrary.enPermission.categories;

            bool itemsEnable = (_userPermission & (int)clsStaticLibrary.enPermission.items) ==
                (int)clsStaticLibrary.enPermission.items;

            bool paymentsEnable = (_userPermission & (int)clsStaticLibrary.enPermission.payments) ==
                (int)clsStaticLibrary.enPermission.payments;

            return usersEnable || categoriesEnable || itemsEnable || paymentsEnable;
        }
        private bool _ReportsEnable()
        {
            bool salesReportEnable = (_userPermission & (int)clsStaticLibrary.enPermission.salesReport) ==
                (int)clsStaticLibrary.enPermission.salesReport;

            return salesReportEnable;
        }
        private bool _OptionsEnable()
        {
            bool optionsEnable = (_userPermission & (int)clsStaticLibrary.enPermission.options) ==
                (int)clsStaticLibrary.enPermission.options;

            return optionsEnable;
        }
        private void _LoadPermissions()
        {
            _userPermission = clsDataAccess.ReadUser(clsLog.username).Permission;

            if (!_SalesEnable())
                btnSales.Enabled = false;
            else
                btnSales.Enabled = true;

            if (!_SetupEnable())
                btnSetup.Enabled = false;
            else
                btnSetup.Enabled = true;

            if (!_ReportsEnable())
                btnReports.Enabled = false;
            else
                btnReports.Enabled = true;

            if (!_OptionsEnable())
                btnOptions.Enabled = false;
            else
                btnOptions.Enabled = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lblTimer.Text = DateTime.Now.ToString();
            lblUsername.Text = clsLog.username;
            _LoadPermissions();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = DateTime.Now.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/EngenMe");
        }

        private void ChildFormClosed(object sender, EventArgs e)
        {
            pnlTitle.BackColor = pnlMenu.BackColor;
            lblTitle.Text = string.Empty;
            UnselectButton();
        }
        private void OpenChiledForm(Form frmChild, object btnSender)
        {
            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = frmChild;
            ActiveButton(btnSender);
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frmChild);
            pnlMain.Tag = frmChild;
            frmChild.BringToFront();
            frmChild.FormClosed += ChildFormClosed;
            frmChild.Show();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                _oldSize = this.Size;
                _oldLocation = this.Location;

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = _oldSize;
                this.Location = _oldLocation;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
