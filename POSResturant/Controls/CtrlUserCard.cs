using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSResturant.Controls
{
    public partial class CtrlUserCard : UserControl
    {
        public Label LblID
        {
            get { return lblID; }
            set { lblID = value; }
        }
        public TextBox TbUsername
        {
            get { return tbUsername; }
            set { tbUsername = value; }
        }
        public TextBox TbPassword
        {
            get { return tbPassword; }
            set { tbPassword = value; }
        }
        public TextBox TbPhone
        {
            get { return tbPhone; }
            set { tbPhone = value; }
        }
        public TextBox TbEmail
        {
            get { return tbEmail; }
            set { tbEmail = value; }
        }
        public TextBox TbAddress
        {
            get { return tbJobTitle; }
            set { tbJobTitle = value; }
        }
        public TextBox TbJobTitle
        {
            get { return tbAddress; }
            set { tbAddress = value; }
        }
        public TextBox TbSalary
        {
            get { return tbSalary; }
            set { tbSalary = value; }
        }
        public PictureBox PbPersonalPicture
        {
            get { return pbPersonalPicture; }
            set { pbPersonalPicture = value; }
        }
        public LinkLabel LnkLblSetPersonalPicture
        {
            get { return lnkLblSetPersonalPicture; }
            set { lnkLblSetPersonalPicture = value; }
        }
        public CheckBox CbShowPassword
        {
            get { return cbShowPassword; }
            set { cbShowPassword = value; }
        }
        public LinkLabel LnkLblSetPermission
        {
            get { return lnkLblSetPermission; }
            set { lnkLblSetPermission = value; }
        }

        public CtrlUserCard()
        {
            InitializeComponent();
        }
    }
}
