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
    //A very basic structure to hold two related values together: a person's name and their phone number.
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

        //A list is created that uses the previously created structure.
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        private void ReadFile()
        {       //Method to get all of the names and numbers off of a file.
            try
            {
                //Variables, one to hold a line of into from the file that will be drawn from, one to split a line, and one to hold the values
                //from said split line.
                string line;
                PhoneBookEntry entry = new PhoneBookEntry();
                char[] delimiter = { ',' };

                
                StreamReader input = File.OpenText("PhoneList.txt");

                while (!input.EndOfStream)
                {
                    line = input.ReadLine();

                    //String array to hold the split line that will be put into the PhoneBookEntry structure.
                    string[] tokens = line.Split(delimiter);

                    entry.name = tokens[0];
                    entry.number = tokens[1];

                    //The list created earlier gains the new PhoneBookEntry item that was just created.
                    phoneList.Add(entry);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayNames()
        {       //Method that adds all of the phone book entries in the list to the form's list box.
            foreach (PhoneBookEntry entry in phoneList)
            {
                lbNames.Items.Add(entry.name);
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {       //The form performs both of the methods that were previously created when the form loads.
            
            ReadFile();

            DisplayNames();
        }

        private void lbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Variable to hold the index of what name has been chosen in the list box.
            int index = lbNames.SelectedIndex;

            //Since the names and numbers are in the same order in the List as they are in the list box, getting the index from one will
            //match with the other, so the phone output field displays the retrieved phone number at the index of the name that was clicked
            //in the list box.
            txtPhoneOutput.Text = phoneList[index].number;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {       //Obligatory exit button.
            Close();
        }
    }
}
