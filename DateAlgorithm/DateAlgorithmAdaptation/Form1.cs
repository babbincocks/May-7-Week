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
using DateConversions;


namespace DateAlgorithmAdaptation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //I just declare the StreamReader and Writer at the beginning and a couple of variables to hold the file paths.
        StreamReader newStream = null;
        StreamWriter location = null;
        string fileName = null;
        string saveLocate = null;

        //Checks to make sure paths are generated before any conversion is attempted.
        int check1 = 0;
        int check2 = 0;

        private void btnConvert_Click(object sender, EventArgs e)
        {       //Code for the Convert button.




            if (fileName != null && saveLocate != null)
            {
                try
                {   //StreamReader is set to the filepath that has been chosen, and a List is created to hold the results.
                    newStream = File.OpenText(fileName);
                    List<string> results = new List<string>();


                    while (!newStream.EndOfStream)
                    {   //The entire row is put into a string, and then is split into a series of strings.
                        string row = newStream.ReadLine();
                        string[] split = row.Split(',');

                        //The third and sixth cell is put through the conversion algorithm.
                        split[2] = DateConversion.StandardizeDates(split[2]);
                        split[5] = DateConversion.StandardizeDates(split[5]);

                        //The row is put back together with the new dates, and is added to the array.
                        row = split[0] + "," + split[1] + "," + split[2] + "," + split[3] + "," + split[4] + "," + split[5];
                        results.Add(row);


                    }

                    //The Streamwriter is used with the save filepath, and the append option is set to false.
                    using (location = new StreamWriter(saveLocate, false))
                    {
                        foreach (string result in results)
                        {
                            //Each element in the List is written to the new file.
                            location.Write(result + Environment.NewLine);
                            
                        }
                        location.Close();
                    }

                    //Show that the conversion is done.
                    MessageBox.Show("Conversion finished.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You need to choose a file to draw data from, and a spot to save your conversion.");
            }
        }

        private void btnFileLocation_Click(object sender, EventArgs e)
        {       //Code for the Input File button.

            //Dialog is opened so a file that contains the data can be chosen.
            OpenFileDialog retrievedFile = new OpenFileDialog();
                        //retrievedFile.InitialDirectory = @"C:\Users\Cyberadmin\Downloads";
            retrievedFile.Filter = "csv files (*.csv)|*.csv|.txt Files (*.txt)|*.txt|All files (*.*)|*.*";
            retrievedFile.RestoreDirectory = true;

            //When a file is chosen, the filepath is stored in the variable created earlier, and is displayed in a text box.
            if (retrievedFile.ShowDialog() == DialogResult.OK)
            {
                fileName = retrievedFile.FileName;
                txtInput.Text = fileName;


                check1++;
                //Check to ensure that both buttons have been pressed and have chosen a file before any conversion is attempted.
                if (check1 != 0 && check2 != 0)
                {
                    btnConvert.Enabled = true;
                }

            }


        }

        private void btnOutput_Click(object sender, EventArgs e)
        {       //Code for the Output Location button.


            //Save file dialog is opened.
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = ".csv Files (*.csv)|*.csv|.txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFile.RestoreDirectory = true;

            //When a file is chosen, same thing as the Input File button happens.
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                saveLocate = saveFile.FileName;
                txtOutput.Text = saveLocate;


                check2++;

                if (check1 != 0 && check2 != 0)
                {
                    btnConvert.Enabled = true;
                }
            }


        }
    }
}
