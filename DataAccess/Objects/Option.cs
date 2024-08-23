using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace DataAccess.Objects
{
    public class Option
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _email;
        private string _address;
        private Image _logo;
        private string _receiptLine1;
        private string _receiptLine2;
        private string _printer;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public Image Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        public string ReceiptLine1
        {
            get { return _receiptLine1; }
            set { _receiptLine1 = value; }
        }
        public string ReceiptLine2
        {
            get { return _receiptLine2; }
            set { _receiptLine2 = value; }
        }
        public string Printer
        {
            get { return _printer; }
            set { _printer = value; }
        }

        public Option(int id, string name, string phone, string email, string address, Image logo,
            string receiptLine1, string receiptLine2, string printer)
        {
            _id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Logo = logo;
            ReceiptLine1 = receiptLine1;
            ReceiptLine2 = receiptLine2;
            Printer = printer;
        }
        public Option()
        {
            ID = 0;
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Logo = new Bitmap(1, 1);
            ReceiptLine1 = string.Empty;
            ReceiptLine2 = string.Empty;
            Printer = string.Empty;
        }
    }
}
