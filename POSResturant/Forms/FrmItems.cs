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
    public partial class FrmItems : Form
    {
        private int _itemID;
        private Item _item;
        private Image _defaultItemImage;

        // Set Item Image - Event
        private void LnkLblSetItemImage_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pbItemImage.Image = Image.FromFile(openFileDialog.FileName);
        }
        private void SetItemImage_Event()
        {
            lnkLblSetItemImage.Click += LnkLblSetItemImage_Clicked;
        }

        // Set Error Provider Event
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
                epItems.SetError(textBox, "Mendatory Field!");
            else
                epItems.SetError(textBox, string.Empty);
        }
        private void SetErrorProvider_Event()
        {
            tbName.TextChanged += Tb_TextChanged;
            tbPrice.TextChanged += Tb_TextChanged;
        }

        // Clear Error Provider Event
        private void Tsb_NewClicked(object sender, EventArgs e)
        {
            foreach (Control control in pnlControls.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    epItems.SetError(control, string.Empty);
            }
        }
        private void ClearErrorProvider_Event()
        {
            tsbNew.Click += Tsb_NewClicked;
        }

        public FrmItems()
        {
            InitializeComponent();
            _defaultItemImage = pbItemImage.Image;
        }

        private void _GetItemID()
        {
            List<int> ids = clsDataAccess.GetListOfItemIds();

            if (ids.Count == 0)
                return;

            Random random = new Random();
            int randomIndex = random.Next(0, ids.Count);
            _itemID = ids[randomIndex];
        }

        private void _SetKeyPresses()
        {
            tbName.KeyPress += clsStaticLibrary.TbMustBeLetter_KeyPress;
            tbPrice.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
        }

        private void _FillCategoryCb()
        {
            cbCategory.DataSource = clsDataAccess.GetListOfCategoryNames();
        }
        
        private void _GetItemObject()
        {
            _item = clsDataAccess.ReadItem(_itemID);
        }

        private void _SetCategoryValue()
        {
            clsStaticLibrary.SetComboBoxValue(ref cbCategory, _item.Category.Name);
        }
        private void _FillItems()
        {
            if (string.IsNullOrWhiteSpace(_item.Name))
            {
                cbCategory.SelectedIndex = -1;
                return;
            }

            lblID.Text = _item.ID.ToString();
            tbName.Text = _item.Name;
            tbPrice.Text = _item.Price.ToString();
            tbDescription.Text = _item.Description;
            _SetCategoryValue();
            pbItemImage.Image = _item.Img;
        }

        private void FrmItems_Load(object sender, EventArgs e)
        {
            _GetItemID();
            _SetKeyPresses();
            _FillCategoryCb();
            _GetItemObject();
            _FillItems();

            SetItemImage_Event();
            SetErrorProvider_Event();
            ClearErrorProvider_Event();
        }

        private void _RefreshValues()
        {
            _GetItemObject();
            _FillItems();
        }
        private void tsbFirst_Click(object sender, EventArgs e)
        {
            if (_itemID != 1)
            {
                _itemID = 1;
                _RefreshValues();
            }
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            if (_itemID > 1)
            {
                _itemID--;
                _RefreshValues();
            }
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            Item lastItem = clsDataAccess.GetLastItem();
            if (_itemID < lastItem.ID)
            {
                _itemID++;
                _RefreshValues();
            }
        }

        private void tsbLast_Click(object sender, EventArgs e)
        {
            Item lastItem = clsDataAccess.GetLastItem();
            if (_itemID != lastItem.ID)
            {
                _itemID = lastItem.ID;
                _item = lastItem;
                _FillItems();
            }
        }

        private bool _AnyError()
        {
            foreach (Control control in pnlControls.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (((TextBox)control).Name != "tbDescription" && 
                        string.IsNullOrWhiteSpace(((TextBox)control).Text))
                    {
                        epItems.SetError(control, "Mendatory Field!");
                        control.Focus();
                        return true;
                    }
                }
            }

            return false;
        }
        private void _CreateItemObject()
        {
            _item = new Item();

            _item.ID = Convert.ToInt32(lblID.Text);
            _item.Name = tbName.Text;
            _item.Price = Convert.ToDecimal(tbPrice.Text);
            _item.Description = tbDescription.Text;
            _item.Category = clsDataAccess.ReadCategory(cbCategory.Text);
            _item.Img = pbItemImage.Image;
        }
        private void _PerformSaving()
        {
            if (lblID.Text == "0")
            {
                if (clsDataAccess.CreateItem(_item))
                {
                    {
                        MessageBox.Show("Item Created successfully :)", "Create Item", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        _item = clsDataAccess.GetLastItem();
                        _itemID = _item.ID;
                        _FillItems();
                    }
                }
                else
                    MessageBox.Show("Failed to Create Item!", "Create Item", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                if (clsDataAccess.UpdateItem(_item))
                    MessageBox.Show("Item updated successfully :)", "Update Item", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update Item!", "Update Item", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (_AnyError())
                return;

            _CreateItemObject();
            _PerformSaving();
        }

        private void _ResetAllValues()
        {
            _itemID = 0;
            _GetItemObject();
        }
        private void _ResetAllItems()
        {
            lblID.Text = "0";
            tbName.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbDescription.Text = string.Empty;
            cbCategory.SelectedIndex = -1;
            pbItemImage.Image = _defaultItemImage;
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            _ResetAllValues();
            _ResetAllItems();
        }

        private void _FillValuesWithReturnedItem(int ItemID)
        {
            _itemID = ItemID;
            _RefreshValues();
        }
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            FrmItemsList frmItemsList = new FrmItemsList();
            frmItemsList.ItemSelected += _FillValuesWithReturnedItem;
            frmItemsList.ShowDialog();
        }
    }
}
