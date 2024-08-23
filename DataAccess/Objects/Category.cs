using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class Category
    {
        private int _id;
        private string _name;
        private Image _img;

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
        public Image Img
        {
            get { return _img; }
            set { _img = value; }
        }

        public Category(int id, string name, Image img)
        {
            ID = id;
            Name = name;
            Img = img;
        }
        public Category()
        {
            ID = 0;
            Name = string.Empty;
            Img = new Bitmap(1, 1);
        }
    }
}
