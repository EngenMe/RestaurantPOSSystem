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
    public partial class FrmCategoriesList : Form
    {
        public delegate void CategorySelectedEventHandler(int categoryID);
        public event CategorySelectedEventHandler CategorySelected;

        private DataTable _categoriesListDataTable;
        private int _categoryID;

        public FrmCategoriesList()
        {
            InitializeComponent();
        }

        // Select Row Event
        private void _GetCategoryID(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                int rowIndex = e.RowIndex;
                if (dgv.Columns.Contains("ID"))
                {
                    _categoryID = Convert.ToInt32(dgv.Rows[rowIndex].Cells["ID"].Value);
                }
                else
                {
                    MessageBox.Show("Column 'ID' does not exist.");
                }
            }
        }
        private void DgvRow_DoubleClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            _GetCategoryID(sender, e);
            CategorySelected?.Invoke(_categoryID);
            this.Close();
        }
        private void SelectRow_Event()
        {
            dgvCategoriesList.CellMouseDoubleClick += DgvRow_DoubleClicked;
        }

        // Text Box Filter Visible Event
        private void _SetTbFilterVisible()
        {
            if (cbFilterBy.SelectedIndex != -1)
            {
                tbFilter.Text = string.Empty;
                tbFilter.Visible = true;
            }
        }
        private void _SetKeyPress()
        {
            tbFilter.KeyPress -= clsStaticLibrary.TbMustBeDigit_KeyPress;

            if (cbFilterBy.Text == "ID")
                tbFilter.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
        }
        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SetTbFilterVisible();
            _SetKeyPress();
        }
        private void CbFilterByIndexChangedEvent()
        {
            cbFilterBy.SelectedIndexChanged += CbFilterBy_SelectedIndexChanged;
        }

        // Apply Filter Event
        private void TxtFilter_ValueChanged(object sender, EventArgs e)
        {
            string filterExpression = string.Empty;
            switch (cbFilterBy.Text)
            {
                case "ID":
                    filterExpression = $"Convert([{cbFilterBy.Text}]," +
                        $" 'System.String') LIKE '{tbFilter.Text}%'";
                    break;
                default:
                    filterExpression = $"[{cbFilterBy.Text}] LIKE" +
                        $" '{tbFilter.Text}%'";
                    break;
            }

            _categoriesListDataTable.DefaultView.RowFilter = filterExpression;
        }
        private void ApplyFilterEvent()
        {
            tbFilter.TextChanged += TxtFilter_ValueChanged;
        }

        private void _GetUsersListDataTable()
        {
            _categoriesListDataTable = clsDataAccess.GetCategoriesDataTable();
        }
        private void _LoadDataTableIntoDgv()
        {
            dgvCategoriesList.DataSource = _categoriesListDataTable;
        }

        private void _LoadCbFilterByItems()
        {
            foreach (DataColumn column in _categoriesListDataTable.Columns)
            {
                cbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            _GetUsersListDataTable();
            _LoadDataTableIntoDgv();
            _LoadCbFilterByItems();

            SelectRow_Event();
            CbFilterByIndexChangedEvent();
            ApplyFilterEvent();
        }
    }
}
