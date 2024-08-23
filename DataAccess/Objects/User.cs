using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Objects
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private string _email;
        private string _phone;
        private string _address;
        private string _jobTitle;
        private decimal _salary;
        private Image _personalPicture;
        private int _permission;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Image PersonalPicture
        {
            get { return _personalPicture; }
            set { _personalPicture = value; }
        }
        public int Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }

        public User(int id, string username, string password, string email, string phone, string address,
            string jobTitle, decimal salary, Image personalPicture, int permission)
        {
            ID = id;
            Username = username;
            Password = password;
            Email = email;
            Phone = phone;
            Address = address;
            JobTitle = jobTitle;
            Salary = salary;
            PersonalPicture = personalPicture;
            Permission = permission;
        }
        public User()
        {
            ID = 0;
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            JobTitle = string.Empty;
            Salary = 0;
            PersonalPicture = new Bitmap(1, 1);
            Permission = 0;
        }
    }
}
