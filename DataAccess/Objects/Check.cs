using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class Check
    {
        private string _name;
        private decimal _price;
        private int _qty;
        private DateTime _dateAndTime;
        private decimal _paidCash;
        private decimal _change;
        private decimal _amountToBePaid;
        private int _itemID;
        private string _username;
        private int _id;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        public DateTime DateAndTime
        {
            get { return _dateAndTime; }
            set { _dateAndTime = value; }
        }
        public decimal PaidCash
        {
            get { return _paidCash; }
            set { _paidCash = value; }
        }
        public decimal Change
        {
            get { return _change; }
            set { _change = value; }
        }
        public decimal AmountToBePaid
        {
            get { return _amountToBePaid; }
            set { _amountToBePaid = value; }
        }
        public int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Check(string name, decimal price, int qty, DateTime dateAndTime,
            decimal paidCash, decimal change, decimal amountToBePaid, int itemID, string username, int id)
        {
            Name = name;
            Price = price;
            Qty = qty;
            DateAndTime = dateAndTime;
            PaidCash = paidCash;
            Change = change;
            AmountToBePaid = amountToBePaid;
            ItemID = itemID;
            Username = _username;
            ID = id;
        }
        public Check()
        {
            Name = string.Empty;
            Price = 0;
            Qty = 0;
            DateAndTime = DateTime.MinValue;
            PaidCash = 0;
            Change = 0;
            AmountToBePaid = 0;
            ItemID = 0;
            Username = string.Empty;
            ID = 0;
        }
    }
}
