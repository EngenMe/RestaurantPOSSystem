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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace POSResturant.Forms
{
    public partial class FrmPaymentsList : Form
    {
        public delegate void PaymentSelectedEventHandler(int PaymentID);
        public event PaymentSelectedEventHandler PaymentSelected;

        private DataTable _paymentsListDataTable;
        private int _paymentID;

        public FrmPaymentsList()
        {
            InitializeComponent();
        }

        // Select Row Event
        private void _GetPaymentID(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                int rowIndex = e.RowIndex;
                if (dgv.Columns.Contains("ID"))
                {
                    _paymentID = Convert.ToInt32(dgv.Rows[rowIndex].Cells["ID"].Value);
                }
                else
                {
                    MessageBox.Show("Column 'ID' does not exist.");
                }
            }
        }
        private void DgvRow_DoubleClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            _GetPaymentID(sender, e);
            PaymentSelected?.Invoke(_paymentID);
            this.Close();
        }
        private void SelectRow_Event()
        {
            dgvPaymentsList.CellMouseDoubleClick += DgvRow_DoubleClicked;
        }

        // Text Box Filter Visible Event
        private void _ChangeFilterDateVisibilityStatus(bool status)
        {
            lblYear.Visible = status;
            lblMonth.Visible = status;
            lblDay.Visible = status;
            lblHour.Visible = status;

            cbYear.Visible = status;
            cbMonth.Visible = status;
            cbDay.Visible = status;
            cbHour.Visible = status;
        }
        private void _EmptyFilterDate()
        {
            cbYear.SelectedIndex = -1;
            cbMonth.SelectedIndex = -1;
            cbDay.SelectedIndex = -1;
            cbHour.SelectedIndex =-1;
        }
        private void _SetTbFilterVisible()
        {
            if (cbFilterBy.SelectedIndex == -1)
                return;

            if (cbFilterBy.Text == "Method")
            {
                cbFilterMethod.SelectedIndex = -1;

                cbFilterMethod.Visible = true;
                cbFilterStatus.Visible = false;
                _ChangeFilterDateVisibilityStatus(false);
                tbFilter.Visible = false;
            }
            else if (cbFilterBy.Text == "Status")
            {
                cbFilterStatus.SelectedIndex = -1;

                cbFilterMethod.Visible = false;
                cbFilterStatus.Visible = true;
                _ChangeFilterDateVisibilityStatus(false);
                tbFilter.Visible = false;
            }
            else if (cbFilterBy.Text == "Date And Time")
            {
                _EmptyFilterDate();

                cbFilterMethod.Visible = false;
                cbFilterStatus.Visible = false;
                _ChangeFilterDateVisibilityStatus(true);
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Text = string.Empty;

                cbFilterMethod.Visible = false;
                cbFilterStatus.Visible = false;
                _ChangeFilterDateVisibilityStatus(false);
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
        private int? _GetSelectedValue(System.Windows.Forms.ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(comboBox.SelectedItem.ToString()))
            {
                return Convert.ToInt32(comboBox.SelectedItem);
            }
            return null;
        }
        private void _ApplyDateAndTimeFilter()
        {
            int? selectedMonth = _GetSelectedValue(cbMonth);
            int? selectedDay = _GetSelectedValue(cbDay);
            int? selectedYear = _GetSelectedValue(cbYear);
            int? selectedHour = _GetSelectedValue(cbHour);

            List<string> filterParts = new List<string>();
            if (selectedYear.HasValue)
            {
                DateTime startYear = new DateTime(selectedYear.Value, 1, 1);
                DateTime endYear = new DateTime(selectedYear.Value + 1, 1, 1).AddSeconds(-1);
                filterParts.Add($"[Date And Time] >= #{startYear:yyyy-MM-dd HH:mm:ss}# AND" +
                    $" [Date And Time] <= #{endYear:yyyy-MM-dd HH:mm:ss}#");
            }

            if (selectedMonth.HasValue)
            {
                DateTime startMonth = new DateTime(selectedYear.GetValueOrDefault(DateTime.Now.Year),
                    selectedMonth.Value, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddSeconds(-1);
                filterParts.Add($"[Date And Time] >= #{startMonth:yyyy-MM-dd HH:mm:ss}# AND" +
                    $" [Date And Time] <= #{endMonth:yyyy-MM-dd HH:mm:ss}#");
            }

            if (selectedDay.HasValue)
            {
                DateTime startDay = new DateTime(selectedYear.GetValueOrDefault(DateTime.Now.Year),
                    selectedMonth.GetValueOrDefault(DateTime.Now.Month), selectedDay.Value);
                DateTime endDay = startDay.AddDays(1).AddSeconds(-1);
                filterParts.Add($"[Date And Time] >= #{startDay:yyyy-MM-dd HH:mm:ss}# AND" +
                    $" [Date And Time] <= #{endDay:yyyy-MM-dd HH:mm:ss}#");
            }

            if (selectedHour.HasValue)
            {
                DateTime startHour = new DateTime(selectedYear.GetValueOrDefault(DateTime.Now.Year),
                    selectedMonth.GetValueOrDefault(DateTime.Now.Month),
                    selectedDay.GetValueOrDefault(DateTime.Now.Day), selectedHour.Value, 0, 0);
                DateTime endHour = startHour.AddHours(1).AddSeconds(-1);
                filterParts.Add($"[Date And Time] >= #{startHour:yyyy-MM-dd HH:mm:ss}# AND" +
                    $" [Date And Time] <= #{endHour:yyyy-MM-dd HH:mm:ss}#");
            }

            string filterExpression = string.Join(" AND ", filterParts);

            _paymentsListDataTable.DefaultView.RowFilter = filterExpression;
        }
        private void _ApplyMoneyFilter()
        {
            string filterExpression = string.Empty;
            if (!string.IsNullOrWhiteSpace(tbFilter.Text))
                filterExpression = $"Convert([{cbFilterBy.Text}], 'System.String') LIKE '{tbFilter.Text}%'";

            _paymentsListDataTable.DefaultView.RowFilter = filterExpression;
        }
        private void TxtFilter_ValueChanged(object sender, EventArgs e)
        {
            string filterExpression = string.Empty;
            switch (cbFilterBy.Text)
            {
                case "ID":
                    filterExpression = $"Convert([{cbFilterBy.Text}]," +
                        $" 'System.String') LIKE '{tbFilter.Text}%'";
                    break;
                case "Method":
                    filterExpression = $"[{cbFilterBy.Text}] LIKE '{cbFilterMethod.Text}%'";
                    break;
                case "Status":
                    filterExpression = $"[{cbFilterBy.Text}] LIKE '{cbFilterStatus.Text}%'";
                    break;
                case "Date And Time":
                    _ApplyDateAndTimeFilter();
                    return;
                case "Amount":
                case "Paid":
                case "Change":
                    _ApplyMoneyFilter();
                    return;
                default:
                    filterExpression = $"[{cbFilterBy.Text}] LIKE '{tbFilter.Text}%'";
                    break;
            }

            _paymentsListDataTable.DefaultView.RowFilter = filterExpression;
        }
        private void ApplyFilterEvent()
        {
            tbFilter.TextChanged += TxtFilter_ValueChanged;
            cbFilterMethod.SelectedIndexChanged += TxtFilter_ValueChanged;
            cbFilterStatus.SelectedIndexChanged += TxtFilter_ValueChanged;

            cbYear.SelectedIndexChanged += TxtFilter_ValueChanged;
            cbMonth.SelectedIndexChanged += TxtFilter_ValueChanged;
            cbDay.SelectedIndexChanged += TxtFilter_ValueChanged;
            cbHour.SelectedIndexChanged += TxtFilter_ValueChanged;
        }

        private void _GetPaymentsListDataTable()
        {
            _paymentsListDataTable = clsDataAccess.GetPaymentsDataTable();
        }
        private void _LoadDataTableIntoDgv()
        {
            dgvPaymentsList.DataSource = _paymentsListDataTable;
        }

        private void _LoadCbFilterByItems()
        {
            foreach (DataColumn column in _paymentsListDataTable.Columns)
            {
                cbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void _LoadCbFilterItems()
        {
            List<string>listOfPaymentMethodNames = clsDataAccess.GetListOfPaymentMethodNames();
            List<string>listOfPaymentStatusNames = clsDataAccess.GetListOfPaymentStatusNames();

            listOfPaymentMethodNames.Insert(listOfPaymentMethodNames.Count, string.Empty);
            listOfPaymentStatusNames.Insert(listOfPaymentStatusNames.Count, string.Empty);

            cbFilterMethod.DataSource = listOfPaymentMethodNames;
            cbFilterStatus.DataSource = listOfPaymentStatusNames;
        }

        private void _LoadFilterDateItems()
        {
            cbYear.Items.AddRange(new object[] { string.Empty }.Concat(
                Enumerable.Range(2000, 3000).Cast<object>()).ToArray());

            cbMonth.Items.AddRange(new object[] { string.Empty }.Concat(
                Enumerable.Range(1, 12).Cast<object>()).ToArray());

            cbDay.Items.AddRange(new object[] { string.Empty }.Concat(
                Enumerable.Range(1, 31).Cast<object>()).ToArray());

            cbHour.Items.AddRange(new object[] { string.Empty }.Concat(
                Enumerable.Range(0, 23).Cast<object>()).ToArray());

            cbMonth.SelectedIndex = -1;
            cbMonth.SelectedIndex = -1;
            cbMonth.SelectedIndex = -1;
            cbMonth.SelectedIndex = -1;
        }

        private void FrmPaymentsList_Load(object sender, EventArgs e)
        {
            _GetPaymentsListDataTable();
            _LoadDataTableIntoDgv();
            _LoadCbFilterByItems();
            _LoadCbFilterItems();
            _LoadFilterDateItems();

            SelectRow_Event();
            CbFilterByIndexChangedEvent();
            ApplyFilterEvent();
        }
    }
}
