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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }

        private bool _AnyError()
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                epLogin.SetError(tbUsername, "Mendatory Field!");
                return true;
            }
            
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                epLogin.SetError(tbPassword, "Mendatory Field!");
                return true;
            }

            return false;
        }
        private void _PerformLogin()
        {
            if (clsDataAccess.IsUserExist(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show($"Login success :), Welcome back {tbUsername.Text}", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsLog.username = tbUsername.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed, Invalid login info!", "Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_AnyError())
                return;

            _PerformLogin();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
                epLogin.SetError(tbUsername, "Mendatory Field!");
            else
                epLogin.SetError(tbUsername, string.Empty);
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
                epLogin.SetError(tbUsername, "Mendatory Field!");
            else
                epLogin.SetError(tbUsername, string.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';

        }
    }
}
