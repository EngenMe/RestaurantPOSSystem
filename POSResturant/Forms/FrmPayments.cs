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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSResturant.Forms
{
    public partial class FrmPayments : Form
    {
        private int _paymentID;
        private Payment _payment;

        public FrmPayments()
        {
            InitializeComponent();
        }

        // Set Error Provider Event
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
                epPayments.SetError(textBox, "Mendatory Field!");
            else
                epPayments.SetError(textBox, string.Empty);

            if (((System.Windows.Forms.TextBox)sender).Name == "tbPaidCash" &&
                (Convert.ToDecimal(tbPaidCash.Text) < Convert.ToDecimal(tbAmountToBePaid.Text)))
                epPayments.SetError(textBox, "Paid cash amount must be sufficient for the amount to be paid!");
            else
                epPayments.SetError(textBox, string.Empty);
        }
        private void SetErrorProvider_Event()
        {
            tbAmountToBePaid.TextChanged += Tb_TextChanged;
            tbPaidCash.TextChanged += Tb_TextChanged;
        }

        // Clear Error Provider Event
        private void Tsb_NewClicked(object sender, EventArgs e)
        {
            foreach (Control control in pnlControls.Controls)
            {
                if (control.GetType() == typeof(System.Windows.Forms.TextBox))
                    epPayments.SetError(control, string.Empty);
            }
        }
        private void ClearErrorProvider_Event()
        {
            tsbNew.Click += Tsb_NewClicked;
        }

        private void _SetKeyPresses()
        {
            tbAmountToBePaid.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
            tbPaidCash.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
        }

        private void _GetPaymentObject()
        {
            _payment = clsDataAccess.ReadPayment(_paymentID);
        }

        private void _FillItems()
        {
            if (_payment.Method.Name != "Cash")
            {
                lblPaidCash.Enabled = false;
                tbPaidCash.Enabled = false;
                lblChange.Enabled = false;
                lblChangeValue.Enabled = false;
            }
            else
            {
                lblPaidCash.Enabled = true;
                tbPaidCash.Enabled = true;
                lblChange.Enabled = true;
                lblChangeValue.Enabled = true;
            }

            if (_payment.AmountToBePaid == 0)
            {
                cbMethod.SelectedIndex = -1;
                cbStatus.SelectedIndex = -1;
                return;
            }

            lblID.Text = _payment.ID.ToString();
            clsStaticLibrary.SetComboBoxValue(ref cbMethod, _payment.Method.Name);
            dtpDateAndTime.Value = _payment.DateAndTime;
            tbAmountToBePaid.Text = _payment.AmountToBePaid.ToString();
            clsStaticLibrary.SetComboBoxValue(ref cbStatus, _payment.Status.Name);

            if (lblPaidCash.Enabled)
            {
                tbPaidCash.Text = _payment.PaidCash.ToString();
                lblChangeValue.Text = (Convert.ToDecimal(_payment.PaidCash) -
                    Convert.ToDecimal(_payment.AmountToBePaid)).ToString();
            }
        }

        private void _FillCbs()
        {
            cbMethod.DataSource = clsDataAccess.GetListOfPaymentMethodNames();
            cbStatus.DataSource = clsDataAccess.GetListOfPaymentStatusNames();
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            _paymentID = clsDataAccess.GetLastPayment().ID;
            _SetKeyPresses();
            _GetPaymentObject();
            _FillCbs();
            _FillItems();

            SetErrorProvider_Event();
            ClearErrorProvider_Event();
        }

        private void _RefreshValues()
        {
            _GetPaymentObject();
            _FillItems();
        }
        private void tsbFirst_Click(object sender, EventArgs e)
        {
            if (_paymentID != 1)
            {
                _paymentID = 1;
                _RefreshValues();
            }
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            if (_paymentID > 1)
            {
                _paymentID--;
                _RefreshValues();
            }
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            Payment lastPayment = clsDataAccess.GetLastPayment();
            if (_paymentID < lastPayment.ID)
            {
                _paymentID++;
                _RefreshValues();
            }
        }

        private void tsbLast_Click(object sender, EventArgs e)
        {
            Payment lastPayment = clsDataAccess.GetLastPayment();
            if (_paymentID != lastPayment.ID)
            {
                _paymentID = lastPayment.ID;
                _payment = lastPayment;
                _FillItems();
            }
        }

        private bool _AnyError()
        {
            foreach (Control control in pnlControls.Controls)
            {
                if (control.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    if (string.IsNullOrWhiteSpace(((System.Windows.Forms.TextBox)control).Text))
                    {
                        epPayments.SetError(control, "Mendatory Field!");
                        control.Focus();
                        return true;
                    }
                    if (((System.Windows.Forms.TextBox)control).Name == "tbPaidCash" && 
                        (Convert.ToDecimal(tbPaidCash.Text) < Convert.ToDecimal(tbAmountToBePaid.Text)))
                        epPayments.SetError((System.Windows.Forms.TextBox)control,
                            "Paid cash amount must be sufficient for the amount to be paid!");
                }
            }

            return false;
        }
        private void _CreatePaymentObject()
        {
            _payment = new Payment();

            _payment.ID = Convert.ToInt32(lblID.Text);
            _payment.Method = clsDataAccess.ReadPaymentMethod(cbMethod.Text);
            _payment.DateAndTime = dtpDateAndTime.Value;
            _payment.AmountToBePaid = Convert.ToDecimal(tbAmountToBePaid.Text);
            
            if (lblPaidCash.Enabled)
            {
                _payment.PaidCash = Convert.ToDecimal(tbPaidCash.Text);
                _payment.Change = Convert.ToDecimal(lblChangeValue.Text);
            }

            _payment.Status = clsDataAccess.ReadPaymentStatus(cbStatus.Text);
        }
        private void _PerformSaving()
        {
            if (lblID.Text == "0")
            {
                if (clsDataAccess.CreatePayment(_payment))
                {
                    {
                        MessageBox.Show("Payment Created successfully :)", "Create Payment", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        _payment = clsDataAccess.GetLastPayment();
                        _paymentID = _payment.ID;
                        _FillItems();
                    }
                }
                else
                    MessageBox.Show("Failed to Create Payment!", "Create Payment", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                if (clsDataAccess.UpdatePayment(_payment))
                    MessageBox.Show("Payment updated successfully :)", "Update Payment", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update Payment!", "Update Payment", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (_AnyError())
                return;

            _CreatePaymentObject();
            _PerformSaving();
        }

        private void _ResetAllValues()
        {
            _paymentID = 0;
            _GetPaymentObject();
        }
        private void _ResetAllItems()
        {
            lblID.Text = "0";
            cbMethod.SelectedIndex = -1;
            dtpDateAndTime.Value = DateTime.Now;
            tbAmountToBePaid.Text = string.Empty;
            cbStatus.SelectedIndex = -1;

            if (lblPaidCash.Enabled)
            {
                tbPaidCash.Text = string.Empty;
                lblChangeValue.Text = "0";
            }
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            _ResetAllValues();
            _ResetAllItems();
        }

        private void _FillValuesWithReturnedPayment(int paymentID)
        {
            _paymentID = paymentID;
            _RefreshValues();
        }
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            FrmPaymentsList frmPaymentsList = new FrmPaymentsList();
            frmPaymentsList.PaymentSelected += _FillValuesWithReturnedPayment;
            frmPaymentsList.ShowDialog();
        }

        private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMethod.Text != "Cash")
            {
                lblPaidCash.Enabled = false;
                tbPaidCash.Enabled = false;
                lblChange.Enabled = false;
                lblChangeValue.Enabled = false;
            }
            else
            {
                lblPaidCash.Enabled = true;
                tbPaidCash.Enabled = true;
                lblChange.Enabled = true;
                lblChangeValue.Enabled = true;
            }
        }

        private void tbPaidCash_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(tbPaidCash.Text) >= Convert.ToDecimal(tbAmountToBePaid.Text))
                lblChangeValue.Text = (Convert.ToDecimal(tbPaidCash.Text) - 
                    Convert.ToDecimal(tbAmountToBePaid.Text)).ToString();
        }
    }
}
