using DataAccess;
using DataAccess.Objects;
using POSResturant.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSResturant.Forms
{
    public partial class FrmOptions : Form
    {
        public delegate void ChildFormClosedEventHandler();
        public event ChildFormClosedEventHandler ChildFormClosed;

        private Option _option = new Option();
        private bool _isCreateNewOption = false;

        public FrmOptions()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            ChildFormClosed?.Invoke();
        }

        private void _SetKeyPresses()
        {
            tbName.KeyPress += clsStaticLibrary.TbMustBeLetter_KeyPress;
            tbPhone.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
        }
        private void _FindSystemPrinters()
        {
            cbPrinter.Items.Clear();

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cbPrinter.Items.Add(printer);
            }

            PrinterSettings settings = new PrinterSettings();
            if (settings.IsDefaultPrinter)
                cbPrinter.SelectedItem = settings.PrinterName;
            else if (cbPrinter.Items.Count > 0)
                cbPrinter.SelectedIndex = 0;
        }
        private void _LoadData()
        {
            _option = clsDataAccess.ReadOption(1);

            if (_option.Name == string.Empty)
            {
                _isCreateNewOption = true;
                return;
            }

            tbName.Text = _option.Name;
            tbPhone.Text = _option.Phone;
            tbEmail.Text = _option.Email;
            tbAddress.Text = _option.Address;
            pbLogo.Image = _option.Logo;
            tbReceiptLine1.Text = _option.ReceiptLine1;
            tbReceiptLine2.Text = _option.ReceiptLine2;

            // Set ComboBox Item
            foreach (var item in cbPrinter.Items)
            {
                if (item.ToString() == _option.Printer)
                {
                    cbPrinter.SelectedItem = item;
                    break;
                }
            }
        }
        private void FrmOptions_Load(object sender, EventArgs e)
        {
            _SetKeyPresses();
            _FindSystemPrinters();
            _LoadData();
        }

        private bool _AnyError()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                epOptions.SetError(tbName, "This Field is Mendatory");
                tbName.Focus();
                return true;
            }
            else if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                epOptions.SetError(tbPhone, "This Field is Mendatory");
                tbPhone.Focus();
                return true;
            }
            else if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                epOptions.SetError(tbEmail, "This Field is Mendatory");
                tbEmail.Focus();
                return true;
            }
            else if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                epOptions.SetError(tbAddress, "This Field is Mendatory");
                tbAddress.Focus();
                return true;
            }
            else if (string.IsNullOrWhiteSpace(tbReceiptLine1.Text))
            {
                epOptions.SetError(tbReceiptLine1, "This Field is Mendatory");
                tbReceiptLine1.Focus();
                return true;
            }
            else
                return false;
        }
        private void _CreateOptionObject()
        {
            _option.Name = tbName.Text;
            _option.Phone = tbPhone.Text;
            _option.Email = tbEmail.Text;
            _option.Address = tbAddress.Text;

            if (pbLogo.Image != null)
                _option.Logo = pbLogo.Image;

            _option.ReceiptLine1 = tbReceiptLine1.Text;
            _option.ReceiptLine2 = tbReceiptLine2.Text;
            _option.Printer = cbPrinter.Text;
            }
        private void _PerformSaving()
        {
            if (_isCreateNewOption)
            {
                if (clsDataAccess.CreateOption(_option))
                    MessageBox.Show("Option Created Successfully!", "Create Option", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Option Created Successfully!", "Create Option", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                if (clsDataAccess.UpdateOption(_option))
                    MessageBox.Show("Option Updated Successfully!", "Update Option", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Option Updated Successfully!", "Update Option", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_AnyError())
                return;

            _CreateOptionObject();
            _PerformSaving();
        }

        private void lnkLblLogo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pbLogo.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
