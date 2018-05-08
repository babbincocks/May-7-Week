using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnformat_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            if (IsValidNumber(input))
            {
                Unformat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                MessageBox.Show("Your input was not in the correct format.");
            }
        }

        private bool IsValidNumber(string input)
        {
            const int PROPER_LENGTH = 13;
            bool valid = true;

            if (input.Length == PROPER_LENGTH && input[0] == '(' && input[4] == ')' && input[8] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void Unformat(ref string input)
        {
            input = input.Remove(0, 1);

            input = input.Remove(3, 1);

            input = input.Remove(6, 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
