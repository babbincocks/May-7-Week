using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPassCheck_Click(object sender, EventArgs e)
        {
            const int MINIMUM = 8;

            string password = txtInput.Text;

            if(password.Length >= MINIMUM && UpperCaseTotal(password) >= 1 && LowerCaseTotal(password) >= 1 && DigitTotal(password) >= 1)
            {
                MessageBox.Show("Yeah, that'll fly, my dude.");
            }
            else
            {
                MessageBox.Show("Up your game, that password is terrible.");
            }
        }

        private int UpperCaseTotal(string input)
        {
            int upperCase = 0;

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    upperCase++;
                }
            }

            return upperCase;
        }

        private int LowerCaseTotal(string input)
        {
            int lowerCase = 0;

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    lowerCase++;
                }
            }

            return lowerCase;
        }

        private int DigitTotal(string input)
        {
            int digit = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digit++;
                }
            }

            return digit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
