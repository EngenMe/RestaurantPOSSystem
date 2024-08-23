using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class Item
    {
        private int _id;
        private string _name;
        private string _description;
        private decimal _price;
        private Image _img;
        private Category _category;

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
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Image Img
        {
            get { return _img; }
            set { _img = value; }
        }
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public Item(int id, string name, string description, decimal price, Image img, Category category)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            Img = img;
            Category = category;
        }
        public Item()
        {
            ID = 0;
            Name = string.Empty;
            Description = string.Empty;
            Price = 0;
            Img = new Bitmap(1, 1);
            Category = new Category();
        }
    }
}
