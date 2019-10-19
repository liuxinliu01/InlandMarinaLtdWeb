using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Products
{
    class ValidateProduct
    {
        public static bool IsNotEmpty(TextBox tb, string txtBoxLabelName)
        {
            bool isValid = true; 
            if (string.IsNullOrEmpty(tb.Text))
            {
                isValid = false;
                MessageBox.Show($"Add a valid {txtBoxLabelName}", "Data Entry Error");
                tb.Focus();
            }
            return isValid;
        }

        public static bool IsValidInteger(TextBox textBox, string txtBoxLabelName)
        {
            bool isValid;
            int outVal;
            if (Int32.TryParse(textBox.Text, out outVal))
            {
                isValid = true;
                if(outVal < 0)  //if input value is negative
                {
                    isValid = false;
                    MessageBox.Show($"{textBox.Text} has to be positive or zero", "Data Entry Error");
                    textBox.SelectAll(); // select all content for replacement
                    textBox.Focus(); 
                }
            }
            else  //if parse not successful
            {
                isValid = false;
                MessageBox.Show($"{txtBoxLabelName} must be a Numeric Value", "Data Entry Error");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }
        //this method check for valid string 

        public static bool IsValidString(TextBox textBox, string txtBoxLabelName)
        {
            bool isValid = true;
            if(!Regex.Match(textBox.Text, @"^[A-Za-z\s]+$").Success) //if not valid string input
            {
                isValid = false;
                MessageBox.Show($"Please add a valid {txtBoxLabelName}", "Data Entry Error");
                textBox.Focus();

            }
            return isValid;
        }


    }
}
