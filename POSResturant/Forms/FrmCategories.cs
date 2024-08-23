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
    public partial class FrmCategories : Form
    {
        private int _categoryID;
        private Category _category;
        private Image _defaultCategoryImage;

        public FrmCategories()
        {
            InitializeComponent();
        }

        // Set Category Image Event
        private void LnkLblSetCategoryImage_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pbCategoryImage.Image = Image.FromFile(openFileDialog.FileName);
        }
        private void SetCategoryImage_Event()
        {
            lnkLblSetICategoryImage.Click += LnkLblSetCategoryImage_Clicked;
        }

        // Set Error Provider Event
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
                epCategories.SetError(textBox, "Mendatory Field!");
            else
                epCategories.SetError(textBox, string.Empty);
        }
        private void SetErrorProvider_Event()
        {
            tbCategoryName.TextChanged += Tb_TextChanged;
        }

        // Clear Error Provider Event
        private void Tsb_NewClicked(object sender, EventArgs e)
        {
            epCategories.SetError(tbCategoryName, string.Empty);
        }
        private void ClearErrorProvider_Event()
        {
            tsbNew.Click += Tsb_NewClicked;
        }

        private void _GetCategoryID()
        {
            List<int> ids = clsDataAccess.GetListOfCategoryIds();
            if (ids.Count == 0)
                return;

            Random random = new Random();
            int randomIndex = random.Next(0, ids.Count);
            _categoryID = ids[randomIndex];
        }
        private void _GetCategoryObject()
        {
            _category = clsDataAccess.ReadCategory(_categoryID);
        }
        private void _FillItems()
        {
            if (string.IsNullOrWhiteSpace(_category.Name))
                return;

            lblID.Text = _category.ID.ToString();
            tbCategoryName.Text = _category.Name;
            pbCategoryImage.Image = _category.Img;
        }
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            _defaultCategoryImage = pbCategoryImage.Image;

            _GetCategoryID();
            _GetCategoryObject();
            _FillItems();

            SetCategoryImage_Event();
            SetErrorProvider_Event();
            ClearErrorProvider_Event();
        }

        private void _RefreshValues()
        {
            _GetCategoryObject();
            _FillItems();
        }
        private void tsbFirst_Click(object sender, EventArgs e)
        {
            if (_categoryID != 1)
            {
                _categoryID = 1;
                _RefreshValues();
            }
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            if (_categoryID > 1)
            {
                _categoryID--;
                _RefreshValues();
            }    
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            Category lastCategory = clsDataAccess.GetLastCategory();
            if (_categoryID < lastCategory.ID)
            {
                _categoryID++;
                _RefreshValues();
            }
        }

        private void tsbLast_Click(object sender, EventArgs e)
        {
            Category lastCategory = clsDataAccess.GetLastCategory();
            if (_categoryID != lastCategory.ID)
            {
                _categoryID = lastCategory.ID;
                _category = lastCategory;
                _FillItems();
            }
        }

        private bool _AnyError()
        {
            if (string.IsNullOrWhiteSpace(tbCategoryName.Text))
            {
                epCategories.SetError(tbCategoryName, "Mendatory Field!");
                return true;
            }

            return false;
        }
        private void _CreateCategoryObject()
        {
            _category = new Category();

            _category.ID = Convert.ToInt32(lblID.Text);
            _category.Name = tbCategoryName.Text;
            _category.Img = pbCategoryImage.Image;
        }
        private void _PerformSaving()
        {
            if (lblID.Text == "0")
            {
                if (clsDataAccess.CreateCategory(_category))
                {
                    {
                        MessageBox.Show("Category Created successfully :)", "Create Category",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _category = clsDataAccess.GetLastCategory();
                        _categoryID = _category.ID;
                        _FillItems();
                    }
                }
                else
                    MessageBox.Show("Failed to Create Category!", "Create Category", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                if (clsDataAccess.UpdateCategory(_category))
                    MessageBox.Show("Category updated successfully :)", "Update Category", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update Category!", "Update Category", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (_AnyError()) 
                return;

            _CreateCategoryObject();
            _PerformSaving();
        }

        private void _ResetAllValues()
        {
            _categoryID = 0;
            _GetCategoryObject();
        }
        private void _ResetAllItems()
        {
            lblID.Text = "0";
            tbCategoryName.Text = string.Empty;
            pbCategoryImage.Image = _defaultCategoryImage;
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            _ResetAllValues();
            _ResetAllItems();
        }

        private void _FillValuesWithReturnedCategory(int categoryID)
        {
            _categoryID = categoryID;
            _RefreshValues();
        }
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            FrmCategoriesList frmCategoriesList = new FrmCategoriesList();
            frmCategoriesList.CategorySelected += _FillValuesWithReturnedCategory;
            frmCategoriesList.ShowDialog();
        }
    }
}
