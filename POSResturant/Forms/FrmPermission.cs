using DataAccess;
using DataAccess.Objects;
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
    public partial class FrmPermission : Form
    {
        public delegate void PermissionUpdatedEventHandler();
        public event PermissionUpdatedEventHandler PermissionUpdated;

        private User _user;
        private int _userPermission;

        public FrmPermission(User user)
        {
            InitializeComponent();
            _user = user;
            _userPermission = user.Permission;
        }

        private void _CheckCbsUsingUserPermission()
        {
            if (_userPermission == -1)
            {
                _CheckAllCbs();
                return;
            }

            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach(Control subControl in  control.Controls)
                    {
                        if (subControl is CheckBox)
                        {
                            if ((_userPermission & Convert.ToInt32(((CheckBox)subControl).Tag)) ==
                                Convert.ToInt32(((CheckBox)subControl).Tag))
                                ((CheckBox)subControl).Checked = true;
                        }
                    }
                }
            }
        }
        private void FrmPermission_Load(object sender, EventArgs e)
        {
            _CheckCbsUsingUserPermission();
        }

        private void _CheckAllCbs()
        {
            cbAll.Checked = true;
            cbPOS.Checked = true;
            cbAllSetup.Checked = true;
            cbUsers.Checked = true;
            cbCategories.Checked = true;
            cbItems.Checked = true;
            cbPayments.Checked = true;
            cbSalesReport.Checked = true;
            cbOptions.Checked = true;
        }
        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
                _CheckAllCbs();
            else
                _CheckCbsUsingUserPermission();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _UpdatePermissions()
        {
            _userPermission = 0;

            if (cbPOS.Checked)
                _userPermission += Convert.ToInt32(cbPOS.Tag);
            if (cbUsers.Checked)
                _userPermission += Convert.ToInt32(cbUsers.Tag);
            if (cbCategories.Checked)
                _userPermission += Convert.ToInt32(cbCategories.Tag);
            if (cbItems.Checked)
                _userPermission += Convert.ToInt32(cbItems.Tag);
            if (cbPayments.Checked)
                _userPermission += Convert.ToInt32(cbPayments.Tag);
            if (cbSalesReport.Checked)
                _userPermission += Convert.ToInt32(cbSalesReport.Tag);
            if (cbOptions.Checked)
                _userPermission += Convert.ToInt32(cbOptions.Tag);

            _user.Permission = _userPermission;

            if (clsDataAccess.UpdateUser(_user))
            {
                MessageBox.Show("Permission updated successfully :)", "Update User", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                PermissionUpdated?.Invoke();
            }
            else
                MessageBox.Show("Failed to update user", "Update User", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _UpdatePermissions();
        }

        private void cbAllSetup_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllSetup.Checked)
            {
                cbUsers.Checked = true;
                cbCategories.Checked = true;
                cbItems.Checked = true;
                cbPayments.Checked = true;
            }
        }
    }
}
