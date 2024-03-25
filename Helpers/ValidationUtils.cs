using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar.Helpers
{
    internal static class ValidationUtils
    {
        public static bool checkIsEmpty(System.Windows.Forms.TextBox textBox)
        {
            bool isEmpty = textBox.Text.Length < 1;
            return !isEmpty;
        }

        public static bool checkIsNumber(System.Windows.Forms.TextBox textBox)
        {
            int value;
            bool isConverted = Int32.TryParse(textBox.Text.Trim(), out value);
            return isConverted;
        }
    }
}
