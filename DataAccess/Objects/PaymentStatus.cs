using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class PaymentStatus
    {
        private int _id;
        private string _name;

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

        public PaymentStatus(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public PaymentStatus()
        {
            ID = 0;
            Name = string.Empty;
        }
    }
}
