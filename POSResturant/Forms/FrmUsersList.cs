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
    public partial class FrmUsersList : Form
    {
        public delegate void UserSelectedEventHandler(int userID);
        public event UserSelectedEventHandler UserSelected;

        private DataTable _usersListDataTable;
        private int _userID;

        public FrmUsersList()
        {
            InitializeComponent();
        }

        // Select Row Event
        private void _GetUserID(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                int rowIndex = e.RowIndex;
                if (dgv.Columns.Contains("ID"))
                {
                    _userID = Convert.ToInt32(dgv.Rows[rowIndex].Cells["ID"].Value);
                }
                else
                {
                    MessageBox.Show("Column 'ID' does not exist.");
                }
            }
        }
        private void DgvRow_DoubleClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            _GetUserID(sender, e);
            UserSelected?.Invoke(_userID);
            this.Close();
        }
        private void SelectRow_Event()
        {
            dgvUsersList.CellMouseDoubleClick += DgvRow_DoubleClicked;
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

            switch (cbFilterBy.Text)
            {
                case "ID":
                case "Phone":
                case "Salary":
                    tbFilter.KeyPress += clsStaticLibrary.TbMustBeDigit_KeyPress;
                    break;
            }
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
                case "Phone":
                case "Salary":
                    filterExpression = $"Convert([{cbFilterBy.Text}]," +
                        $" 'System.String') LIKE '{tbFilter.Text}%'";
                    break;
                default:
                    filterExpression = $"{cbFilterBy.Text} LIKE" +
                        $" '{tbFilter.Text}%'";
                    break;
            }

            _usersListDataTable.DefaultView.RowFilter = filterExpression;
        }
        private void ApplyFilterEvent()
        {
            tbFilter.TextChanged += TxtFilter_ValueChanged;
        }

        private void _GetUsersListDataTable()
        {
            _usersListDataTable = clsDataAccess.GetUsersDataTable();
        }
        private void _LoadDataTableIntoDgv()
        {
            dgvUsersList.DataSource = _usersListDataTable;
        }

        private void _LoadCbFilterByItems()
        {
            foreach (DataColumn column in _usersListDataTable.Columns)
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
