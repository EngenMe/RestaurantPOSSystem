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
    public partial class FrmItemsList : Form
    {
        public delegate void ItemSelectedEventHandler(int itemID);
        public event ItemSelectedEventHandler ItemSelected;

        private DataTable _itemsListDataTable;
        private int _itemID;

        public FrmItemsList()
        {
            InitializeComponent();
        }

        // Change Filter State Event
        private void _SetTbFilterVisible()
        {
            if (cbFilterBy.SelectedIndex == -1)
                return;

            if (cbFilterBy.Text == "Category")
            {
                cbCategoryFilter.SelectedIndex = -1;

                cbCategoryFilter.Visible = true;
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Text = string.Empty;

                cbCategoryFilter.Visible = false;
                tbFilter.Visible = true;
            }
        }
        private void _SetKeyPress()
        {
            tbFilter.KeyPress -= clsStaticLibrary.TbMustBeDigit_KeyPress;
            tbFilter.KeyPress -= clsStaticLibrary.TbMustBeLetter_KeyPress;

            switch (cbFilterBy.Text)
            {
                case "ID":
                case "Price":
                    tbFilter.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
                    break;
                case "Name":
                    tbFilter.KeyPress += clsStaticLibrary.TbMustBeLetter_KeyPress;
                    break;
            }
        }
        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SetTbFilterVisible();
            _SetKeyPress();
        }
        private void ChangeFilterState_Event()
        {
            cbFilterBy.SelectedIndexChanged += CbFilterBy_SelectedIndexChanged;
        }

        // Apply Filter Event
        private void TxtOrCbCategoryFilter_ValueChanged(object sender, EventArgs e)
        {
            string filterExpression = string.Empty;
            switch (cbFilterBy.Text)
            {
                case "ID":
                case "Price":
                    filterExpression = $"Convert([{cbFilterBy.Text}], 'System.String')" +
                        $" LIKE '{tbFilter.Text}%'";
                    break;
                case "Category":
                    filterExpression = $"[{cbFilterBy.Text}] LIKE '{cbCategoryFilter.Text}%'";
                    break;
                default:
                    filterExpression = $"[{cbFilterBy.Text}] LIKE '{tbFilter.Text}%'";
                    break;
            }

            _itemsListDataTable.DefaultView.RowFilter = filterExpression;
        }
        private void ApplyFilterEvent()
        {
            tbFilter.TextChanged += TxtOrCbCategoryFilter_ValueChanged;
            cbCategoryFilter.SelectedIndexChanged += TxtOrCbCategoryFilter_ValueChanged;
        }

        // Select Row Event
        private void _GetItemID(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                int rowIndex = e.RowIndex;
                if (dgv.Columns.Contains("ID"))
                {
                    _itemID = Convert.ToInt32(dgv.Rows[rowIndex].Cells["ID"].Value);
                }
                else
                {
                    MessageBox.Show("Column 'ID' does not exist.");
                }
            }
        }
        private void DgvRow_DoubleClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            _GetItemID(sender, e);
            ItemSelected?.Invoke(_itemID);
            this.Close();
        }
        private void SelectRow_Event()
        {
            dgvItemsList.CellMouseDoubleClick += DgvRow_DoubleClicked;
        }

        private void _FilCbCategories()
        {
            cbCategoryFilter.DataSource = clsDataAccess.GetListOfCategoryNames();
        }

        private void _GetItemsListDataTable()
        {
            _itemsListDataTable = clsDataAccess.GetItemsDataTable();
        }

        private void _LoadDataTableIntoDgv()
        {
            dgvItemsList.DataSource = _itemsListDataTable;
        }

        private void _LoadCbFilterByItems()
        {
            foreach (DataColumn column in _itemsListDataTable.Columns)
            {
                cbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void FrmItemsList_Load(object sender, EventArgs e)
        {
            _FilCbCategories();
            _GetItemsListDataTable();
            _LoadDataTableIntoDgv();
            _LoadCbFilterByItems();

            ChangeFilterState_Event();
            ApplyFilterEvent();
            SelectRow_Event();
        }
    }
}
