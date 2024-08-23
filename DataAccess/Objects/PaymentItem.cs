using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class PaymentItem
    {
        private int _id;
        private Payment _payment;
        private User _user;
        private Item _item;
        private int _qty;
        private decimal _price;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public Payment Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }
        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public PaymentItem(int id, Payment payment, User user, Item item, int qty, decimal price)
        {
            ID = id;
            Payment = payment;
            User = user;
            Item = item;
            Qty = qty;
            Price = price;
        }
        public PaymentItem()
        {
            ID = 0;
            Payment = new Payment();
            User = new User();
            Item = new Item();
            Qty = 0;
            Price = 0;
        }
    }
}
