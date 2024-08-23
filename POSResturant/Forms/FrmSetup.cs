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
    public partial class FrmSetup : Form
    {
        public delegate void ChildFormClosedEventHandler();
        public event ChildFormClosedEventHandler ChildFormClosed;

        public delegate void PermissionUpdatedEventHandler();
        public event PermissionUpdatedEventHandler PermissionUpdated;

        private int _userPermission;

        public FrmSetup(int userPermission)
        {
            InitializeComponent();
            _userPermission = userPermission;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            ChildFormClosed?.Invoke();
        }

        private void UpdatePermission_PermissionUpdated()
        {
            _LoadPermissions();
            PermissionUpdated?.Invoke();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers(clsDataAccess.ReadUser(clsLog.username).ID);
            frmUsers.PermissionUpdated += UpdatePermission_PermissionUpdated;
            frmUsers.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            FrmItems frmItems = new FrmItems();
            frmItems.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            FrmPayments frmPayments = new FrmPayments();
            frmPayments.ShowDialog();
        }

        private void _LoadPermissions()
        {
            bool usersEnable = (_userPermission & (int)clsStaticLibrary.enPermission.users) ==
                (int)clsStaticLibrary.enPermission.users;

            bool categoriesEnable = (_userPermission & (int)clsStaticLibrary.enPermission.categories) ==
                (int)clsStaticLibrary.enPermission.categories;

            bool itemsEnable = (_userPermission & (int)clsStaticLibrary.enPermission.items) ==
                (int)clsStaticLibrary.enPermission.items;

            bool paymentsEnable = (_userPermission & (int)clsStaticLibrary.enPermission.payments) ==
                (int)clsStaticLibrary.enPermission.payments;

            if (!usersEnable)
                btnUsers.Enabled = false;
            else
                btnUsers.Enabled = true;

            if (!categoriesEnable)
                btnCategories.Enabled = false;
            else
                btnCategories.Enabled = true;

            if (!itemsEnable)
                btnItems.Enabled = false;
            else
                btnItems.Enabled = true;

            if (!paymentsEnable)
                btnPayments.Enabled = false;
            else
                btnPayments.Enabled = true;
        }
        private void FrmSetup_Load(object sender, EventArgs e)
        {
            _LoadPermissions();
        }
    }
}
