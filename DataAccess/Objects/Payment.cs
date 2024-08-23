using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class Payment
    {
        private int _id;
        private PaymentMethod _method;
        private DateTime _dateAndTime;
        private decimal _amountToBePaid;
        private decimal _paidCash;
        private decimal _change;
        private PaymentStatus _status;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public PaymentMethod Method
        {
            get { return _method; }
            set { _method = value; }
        }
        public DateTime DateAndTime
        {
            get { return _dateAndTime; }
            set { _dateAndTime = value; }
        }
        public decimal AmountToBePaid
        {
            get { return _amountToBePaid; }
            set { _amountToBePaid = value; }
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
        public PaymentStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Payment(int id, PaymentMethod method, DateTime dateAndTime, decimal amountToBePaid, 
            decimal paidCash, decimal change, PaymentStatus status)
        {
            ID = id;
            Method = method;
            DateAndTime = dateAndTime;
            AmountToBePaid = amountToBePaid;
            PaidCash = paidCash;
            Change = change;
            Status = status;
        }
        public Payment()
        {
            ID = 0;
            Method = new PaymentMethod();
            DateAndTime = DateTime.MinValue;
            AmountToBePaid = 0;
            PaidCash = 0;
            Change = 0;
            Status = new PaymentStatus();
        }
    }
}
