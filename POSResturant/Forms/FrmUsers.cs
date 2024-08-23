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
    public partial class FrmUsers : Form
    {
        public delegate void PermissionUpdatedEventHandler();
        public event PermissionUpdatedEventHandler PermissionUpdated;

        private int _userID;
        private User _user;
        private Image _defaultPersonalPicture;

        public FrmUsers(int userID)
        {
            InitializeComponent();
            _userID = userID;
            _defaultPersonalPicture = CtrlUserCard.PbPersonalPicture.Image;
        }

        // Set Personal Picture - Event
        private void LnkLblSetPersonalPicture_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                CtrlUserCard.PbPersonalPicture.Image = Image.FromFile(openFileDialog.FileName);
        }
        private void SetPersonalPicture_Event()
        {
            CtrlUserCard.LnkLblSetPersonalPicture.Click += LnkLblSetPersonalPicture_Clicked;
        }

        // Set Error Provider Event
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
                epUsers.SetError(textBox, "Mendatory Field!");
            else
                epUsers.SetError(textBox, string.Empty);
        }
        private void SetErrorProvider_Event()
        {
            CtrlUserCard.TbUsername.TextChanged += Tb_TextChanged;
            CtrlUserCard.TbPassword.TextChanged += Tb_TextChanged;
            CtrlUserCard.TbPhone.TextChanged += Tb_TextChanged;
            CtrlUserCard.TbEmail.TextChanged += Tb_TextChanged;
            CtrlUserCard.TbAddress.TextChanged += Tb_TextChanged;
            CtrlUserCard.TbJobTitle.TextChanged += Tb_TextChanged;
        }

        // Clear Error Provider Event
        private void Tsb_NewClicked(object sender, EventArgs e)
        {
            foreach (Control control in CtrlUserCard.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    epUsers.SetError(control, string.Empty);
            }
        }
        private void ClearErrorProvider_Event()
        {
            tsbNew.Click += Tsb_NewClicked;
        }

        // Show Password Event
        private void CbShowPassword_Clicked(object sender, EventArgs e)
        {
            if (CtrlUserCard.CbShowPassword.Checked)
                CtrlUserCard.TbPassword.PasswordChar = '\0';
            else
                CtrlUserCard.TbPassword.PasswordChar = '*';
        }
        private void ShowPassword_Event()
        {
            CtrlUserCard.CbShowPassword.Click += CbShowPassword_Clicked;
        }

        // Set Permission Event
        private void UpdatePermission_PermissionUpdated()
        {
            PermissionUpdated?.Invoke();
        }
        private void LnkLblSetPermission_Clicked(object sender, EventArgs e)
        {
            FrmPermission frmPermission = new FrmPermission(clsDataAccess.ReadUser(
                Convert.ToInt32(CtrlUserCard.LblID.Text)));
            frmPermission.PermissionUpdated += UpdatePermission_PermissionUpdated;
            frmPermission.ShowDialog();
        }
        private void SetPermission_Event()
        {
            CtrlUserCard.LnkLblSetPermission.Click += LnkLblSetPermission_Clicked;
        }

        private void _SetKeyPresses()
        {
            CtrlUserCard.TbPhone.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
            CtrlUserCard.TbSalary.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
        }
        private void _GetUserObject()
        {
            _user = clsDataAccess.ReadUser(_userID);
        }
        private void _FillItems()
        {
            if (string.IsNullOrWhiteSpace(_user.Username))
                return;

            CtrlUserCard.LblID.Text = _user.ID.ToString();
            CtrlUserCard.TbUsername.Text = _user.Username;
            CtrlUserCard.TbPassword.Text = _user.Password;
            CtrlUserCard.TbPhone.Text = _user.Phone;
            CtrlUserCard.TbEmail.Text = _user.Email;
            CtrlUserCard.TbAddress.Text = _user.Address;
            CtrlUserCard.TbJobTitle.Text = _user.JobTitle;
            CtrlUserCard.TbSalary.Text = _user.Salary.ToString();
            CtrlUserCard.PbPersonalPicture.Image = _user.PersonalPicture;
        }
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            _SetKeyPresses();
            _GetUserObject();
            _FillItems();

            SetPersonalPicture_Event();
            SetErrorProvider_Event();
            ClearErrorProvider_Event();
            ShowPassword_Event();
            SetPermission_Event();
        }

        private void _RefreshValues()
        {
            _GetUserObject();
            _FillItems();
        }
        private void tsbFirst_Click(object sender, EventArgs e)
        {
            if (_userID != 1)
            {
                _userID = 1;
                _RefreshValues();
            }
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            if (_userID > 1)
            {
                _userID--;
                _RefreshValues();
            }    
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            User lastUser = clsDataAccess.GetLastUser();
            if (_userID < lastUser.ID)
            {
                _userID++;
                _RefreshValues();
            }
        }

        private void tsbLast_Click(object sender, EventArgs e)
        {
            User lastUser = clsDataAccess.GetLastUser();
            if (_userID != lastUser.ID)
            {
                _userID = lastUser.ID;
                _user = lastUser;
                _FillItems();
            }
        }

        private bool _AnyError()
        {
            foreach (Control control in CtrlUserCard.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (((TextBox)control).Name != "Salary" && 
                        string.IsNullOrWhiteSpace(((TextBox)control).Text))
                    {
                        epUsers.SetError(control, "Mendatory Field!");
                        control.Focus();
                        return true;
                    }
                }
            }

            return false;
        }
        private void _CreateUserObject()
        {
            _user = new User();
            _user.ID = Convert.ToInt32(CtrlUserCard.LblID.Text);
            _user.Username = CtrlUserCard.TbUsername.Text;
            _user.Password = CtrlUserCard.TbPassword.Text;
            _user.Phone = CtrlUserCard.TbPhone.Text;
            _user.Email = CtrlUserCard.TbEmail.Text;
            _user.Address = CtrlUserCard.TbAddress.Text;
            _user.JobTitle = CtrlUserCard.TbJobTitle.Text;

            if (string.IsNullOrWhiteSpace(CtrlUserCard.TbSalary.Text))
                _user.Salary = 0;
            else
                _user.Salary = Convert.ToDecimal(CtrlUserCard.TbSalary.Text);

            _user.PersonalPicture = CtrlUserCard.PbPersonalPicture.Image;
        }
        private void _PerformSaving()
        {
            if (CtrlUserCard.LblID.Text == "0")
            {
                if (clsDataAccess.CreateUser(_user))
                {
                    {
                        MessageBox.Show("User Created successfully :)", "Create User", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        _user = clsDataAccess.GetLastUser();
                        _userID = _user.ID;
                        _FillItems();
                    }
                }
                else
                    MessageBox.Show("Failed to Create user!", "Create User", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                if (clsDataAccess.UpdateUser(_user))
                    MessageBox.Show("User updated successfully :)", "Update User", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update user!", "Update User", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (_AnyError()) 
                return;

            _CreateUserObject();
            _PerformSaving();
        }

        private void _ResetAllValues()
        {
            _userID = 0;
            _GetUserObject();
        }
        private void _ResetAllItems()
        {
            CtrlUserCard.LblID.Text = "0";
            CtrlUserCard.TbUsername.Text = string.Empty;
            CtrlUserCard.TbPassword.Text = string.Empty;
            CtrlUserCard.TbPhone.Text = string.Empty;
            CtrlUserCard.TbEmail.Text = string.Empty;
            CtrlUserCard.TbAddress.Text = string.Empty;
            CtrlUserCard.TbJobTitle.Text = string.Empty;
            CtrlUserCard.TbSalary.Text = string.Empty;
            CtrlUserCard.PbPersonalPicture.Image = _defaultPersonalPicture;
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            _ResetAllValues();
            _ResetAllItems();
        }

        private void _FillValuesWithReturnedUser(int userID)
        {
            _userID = userID;
            _RefreshValues();
        }
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            FrmUsersList frmUsersList = new FrmUsersList();
            frmUsersList.UserSelected += _FillValuesWithReturnedUser;
            frmUsersList.ShowDialog();
        }
    }
}
