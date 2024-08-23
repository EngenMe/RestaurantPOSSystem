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
    public partial class FrmPOS : Form
    {
        private List<Category> _listOfCategories = new List<Category>();
        private List<Item> _listOfItems = new List<Item>();
        private Image _defaultItemImage;
        private Payment _payment = new Payment();
        private PaymentItem _paymentItem = new PaymentItem();
        private User _user = clsDataAccess.ReadUser(clsLog.username); 
        private bool _isPaymentSuccess = false;

        public FrmPOS()
        {
            InitializeComponent();
        }

        private void _FillCbPaymentMethods()
        {
            List<string> cbPaymentIds = clsDataAccess.GetListOfPaymentMethodNames();

            cbPayment.DataSource = cbPaymentIds;
            clsStaticLibrary.SetComboBoxValue(ref cbPayment, "Cash");
        }
        private void _FillCategoriesBtns()
        {
            _listOfCategories = clsDataAccess.GetListOfCategories();
            int counter = 0;
            foreach (Control control in pnlItems.Controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList())
            {
                if (counter >= _listOfCategories.Count)
                    return;

                if (control.GetType() == typeof(Button))
                {
                    if (((Button)control).Name == "btnBack")
                        continue;

                    Category category = _listOfCategories[counter];
                    Button btn = (Button)control;

                    btn.Text = category.Name;
                    btn.Image = new Bitmap(category.Img, new Size(8 * btn.Width / 10, 7 * btn.Height / 10));

                    btn.Visible = true;

                    counter++;
                }
            }
        }
        private void FrmPOS_Load(object sender, EventArgs e)
        {
            _defaultItemImage = btn11.Image;
            _FillCbPaymentMethods();
            _FillCategoriesBtns();
        }

        // Select Category Event
        private void _ResetPnlItems()
        {
            foreach (Control control in pnlItems.Controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList())
            {
                if (control.GetType() == typeof(Button))
                {
                    if (((Button)control).Name == "btnBack")
                        continue;

                    ((Button)control).Image = _defaultItemImage;
                    ((Button)control).Text = "text";
                    ((Button)control).Visible = false;
                }
            }
        }
        private void _FillItemsBtns(object sender)
        {
            _listOfItems = clsDataAccess.GetListOfItems(((Button)sender).TabIndex);
            int counter = 0;
            foreach (Control control in pnlItems.Controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList())
            {
                if (counter >= _listOfItems.Count)
                    return;

                if (control.GetType() == typeof(Button))
                {
                    Item item = _listOfItems[counter];
                    Button btn = (Button)control;

                    btn.Text = item.Name;
                    btn.Image = new Bitmap(item.Img, new Size(8 * btn.Width / 10, 7 * btn.Height / 10));

                    btn.Visible = true;

                    counter++;
                }
            }
        }
        private void _UnsubscribeBtnCategoryClickedEvent()
        {
            foreach (Control control in pnlItems.Controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList())
            {
                if (control.GetType() == typeof(Button))
                {
                    if (((Button)control).Name == "btnBack")
                        continue;

                    ((Button)control).Click -= BtnCategory_Clicked;
                    ((Button)control).Click += BtnItem_Clicked;
                }
            }
        }
        private void BtnCategory_Clicked(object sender, EventArgs e)
        {
            _ResetPnlItems();
            _FillItemsBtns(sender);
            _UnsubscribeBtnCategoryClickedEvent();
            btnBack.Enabled = true;
        }

        // Select Item Event
        private void BtnItem_Clicked(object sender, EventArgs e)
        {
            Item selectedItem = _listOfItems[((Button)sender).TabIndex - 1];
            int qty = string.IsNullOrWhiteSpace(tbQTY.Text) ? 1 : Convert.ToInt16(tbQTY.Text);

            bool itemFound = false;
            foreach (DataGridViewRow row in dgvPOS.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells["ID"].Value != null && (int)row.Cells["ID"].Value == selectedItem.ID)
                {
                    row.Cells["QTY"].Value = (int)row.Cells["QTY"].Value + qty;
                    row.Cells["Price"].Value = selectedItem.Price;
                    itemFound = true;
                    break;
                }
            }

            if (!itemFound)
            {
                int rowIndex = dgvPOS.Rows.Add();

                dgvPOS.Rows[rowIndex].Cells["ID"].Value = selectedItem.ID;
                dgvPOS.Rows[rowIndex].Cells["Item"].Value = selectedItem.Name;
                dgvPOS.Rows[rowIndex].Cells["QTY"].Value = qty;
                dgvPOS.Rows[rowIndex].Cells["Price"].Value = selectedItem.Price;
            }

            dgvPOS.ClearSelection();
            _UpdateTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _UnsubscribeBtnItemClickedEvent()
        {
            foreach (Control control in pnlItems.Controls.Cast<Control>().OrderBy(c => c.TabIndex).ToList())
            {
                if (control.GetType() == typeof(Button))
                {
                    if (((Button)control).Name == "btnBack")
                        continue;

                    ((Button)control).Click += BtnCategory_Clicked;
                    ((Button)control).Click -= BtnItem_Clicked;
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _ResetPnlItems();
            _FillCategoriesBtns();
            btnBack.Enabled = false;
            _UnsubscribeBtnItemClickedEvent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvPOS.Rows.Clear();
            _UpdateTotal();
        }

        private void dgvPOS_MouseDown(object sender, MouseEventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dgvPOS.Rows.Remove(dgvPOS.CurrentRow);

            if (dgvPOS.CurrentRow == null)
                btnRemove.Enabled = false;

            _UpdateTotal();
        }

        private void _UpdateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvPOS.Rows)
            {
                if (row.Cells["QTY"].Value != null && row.Cells["Price"].Value != null)
                {
                    decimal qty = Convert.ToDecimal(row.Cells["QTY"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    total += qty * price;
                }
            }

            lblTotal.Text = total.ToString();
        }

        private void BtnNumbClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "C")
                tbQTY.Text = string.Empty;
            else
                tbQTY.Text += btn.Text;
        }

        private void _ChangeBtnPrintCheckEnablingStatus()
        {
            if (lblTotal.Text == "0")
                btnPrint.Enabled = false;
            else
                btnPrint.Enabled = true;
        }
        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            _ChangeBtnPrintCheckEnablingStatus();
        }

        private void cbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPayment.Text == "Cash")
            {
                lblChangeValue.Enabled = true;
                lblChange.Enabled = true;
            }
            else
            {
                lblChange.Enabled = false;
                lblChange.Enabled = false;
            }
        }

        private void _FillPaidAndChangeFields()
        {
            try
            {
                lblChangeValue.Text = 
                    (Convert.ToDecimal(lblPaidValue.Text) - Convert.ToDecimal(lblTotal.Text)).ToString();
            }
            catch { }
        }
        private void _CheckBalanceSufficient()
        {
            try
            {
                if (Convert.ToDecimal(lblTotal.Text) > Convert.ToDecimal(lblPaidValue.Text))
                {
                    epPOS.SetError(lblPaidValue, "Insuficient value!");
                    _isPaymentSuccess = false;
                }
                else
                {
                    epPOS.SetError(lblPaidValue, string.Empty);
                    _isPaymentSuccess = true;
                }
            }
            catch { }
        }
        private void _CreatePaymentObject()
        {
            _payment.Method = clsDataAccess.ReadPaymentMethod(cbPayment.Text);
            _payment.DateAndTime = DateTime.Now;
            _payment.AmountToBePaid = Convert.ToDecimal(lblTotal.Text);

            if (cbPayment.Text == "Cash")
            {
                _payment.PaidCash = Convert.ToDecimal(lblPaidValue.Text);
                _payment.Change = Convert.ToDecimal(lblChangeValue.Text);
            }
            else
            {
                _payment.PaidCash = -1;
            }

            _payment.Status = clsDataAccess.ReadPaymentStatus(1);
        }
        private void _CreatePaymentItemObject(DataGridViewRow row)
        {
            _paymentItem.Payment = _payment;
            _paymentItem.User = _user;
            _paymentItem.Item = clsDataAccess.ReadItem((int)row.Cells["ID"].Value);
            _paymentItem.Qty = (int)row.Cells["QTY"].Value;
            _paymentItem.Price = (decimal)row.Cells["price"].Value;
        }
        private void _SaveCheckToDb()
        {
            if (!_isPaymentSuccess)
                return;

            _CreatePaymentObject();
            if (!clsDataAccess.CreatePayment(_payment))
            {
                MessageBox.Show("Failed to Create Payment!", "Create Payment", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _isPaymentSuccess = false;
                return;
            }

            foreach (DataGridViewRow row in dgvPOS.Rows)
            {
                _CreatePaymentItemObject(row);

                if (!clsDataAccess.CreatePaymentItem(_paymentItem))
                {
                    MessageBox.Show("Failed to Create Payment Item!", "Create Payment Item",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isPaymentSuccess = false;
                }
                else
                    _isPaymentSuccess = true;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            lblPaidValue.Text = tbQTY.Text;
            _FillPaidAndChangeFields();
            _CheckBalanceSufficient();
            _SaveCheckToDb();

            if (_isPaymentSuccess)
                MessageBox.Show("Check Created Successfully :)", "Create Check", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void lblPaidValue_TextChanged(object sender, EventArgs e)
        {
            lblPaidValue.Text = lblPaidValue.Text;
            _FillPaidAndChangeFields();
            _CheckBalanceSufficient();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            clsPrintCheck clsPrintCheck = new clsPrintCheck();
            clsPrintCheck.RunPrintCheck(clsDataAccess.GetLastCheckID());
        }
    }
}
