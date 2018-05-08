using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            if (IsValidNumber(input))
            {
                PhoneFormat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                MessageBox.Show("That is not a proper number.");
            }
        }

        private bool IsValidNumber(string input)
        {
            const int PROPER_LENGTH = 10;
            bool valid = true;

            if (input.Length == PROPER_LENGTH)
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        valid = false;
                    }

                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void PhoneFormat(ref string input)
        {
            input = input.Insert(0, "(");
            input = input.Insert(4, ")");
            input = input.Insert(8, "-");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
