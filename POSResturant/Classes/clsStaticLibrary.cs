using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSResturant.Classes
{
    public class clsStaticLibrary
    {
        public static void TbMustBeDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void TbMustBeLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void SetComboBoxValue(ref ComboBox comboBox, string value)
        {
            int counter = 0;
            foreach (string item in comboBox.Items)
            {
                if (item == value)
                {
                    comboBox.SelectedIndex = counter;
                    return;
                }
                counter++;
            }
        }

        public enum enPermission
        {
            pos = 2,
            users = 4,
            categories = 8,
            items = 16,
            payments = 32,
            salesReport = 64,
            options = 128
        }
    }
}
