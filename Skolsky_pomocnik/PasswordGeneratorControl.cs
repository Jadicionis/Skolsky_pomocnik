using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skolsky_pomocnik
{
    public partial class PasswordGeneratorControl : UserControl
    {

        string lastGeneratedPassword = "";

        private string GeneratePassword(int length, bool useUpper, bool useLower, bool useNumbers, bool useSymbols, bool easyRead)
        {
            if (!useUpper && !useLower && !useNumbers && !useSymbols)
                return ""; // Nothing selected

            // Full sets
            string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            string numberChars = "0123456789";
            string symbolChars = "!@#$%^&*()-_=+[]{};:,.<>?";

            if (easyRead)
            {
                // Remove ambiguous characters
                upperChars = "ABCDEFGHJKLMNPQRSTUVWXYZ";
                lowerChars = "abcdefghjkmnpqrstuvwxyz";
                numberChars = "23456789";
            }

            StringBuilder charPool = new StringBuilder();

            if (useUpper) charPool.Append(upperChars);
            if (useLower) charPool.Append(lowerChars);
            if (useNumbers) charPool.Append(numberChars);
            if (useSymbols) charPool.Append(symbolChars);

            Random rnd = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = charPool[rnd.Next(charPool.Length)];
            }

            return new string(password);
        }


        public PasswordGeneratorControl()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            bool easyRead = checkBox_Ambiguous.Checked;

            string password = GeneratePassword(
                trackBar_Password_Length.Value,
                checkBox_Uppercase.Checked,
                checkBox_Lowercase.Checked,
                checkBox_Numbers.Checked,
                checkBox_Symbols.Checked,
                easyRead
            );

            lastGeneratedPassword = password;
            textBox_Password.Text = password;

            if (checkBox_AutoCopy.Checked && !string.IsNullOrEmpty(password))
            {
                Clipboard.SetText(password);
            }

        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastGeneratedPassword))
                Clipboard.SetText(lastGeneratedPassword);
        }

        private void trackBar_Password_Length_ValueChanged(object sender, EventArgs e)
        {
            label_LengthofPassword.Text = trackBar_Password_Length.Value.ToString();
        }
    }
}
