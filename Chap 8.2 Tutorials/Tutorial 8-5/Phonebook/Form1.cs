using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string number;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        private void ReadFile()
        {
            try
            {
                StreamReader input;
                string line;

                PhoneBookEntry entry = new PhoneBookEntry();

                char[] delimiter = { ',' };

                input = File.OpenText("PhoneList.txt");

                while (!input.EndOfStream)
                {
                    line = input.ReadLine();

                    string[] tokens = line.Split(delimiter);

                    entry.name = tokens[0];
                    entry.number = tokens[1];

                    phoneList.Add(entry);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                lbNames.Items.Add(entry.name);
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();

            DisplayNames();
        }

        private void lbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbNames.SelectedIndex;

            txtPhoneOutput.Text = phoneList[index].number;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
