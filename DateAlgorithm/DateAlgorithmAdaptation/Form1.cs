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

        StreamReader newStream = null;
        StreamWriter location = null;
        string fileName = null;
        string saveLocate = null;

        private void btnConvert_Click(object sender, EventArgs e)
        {




            if (fileName != null && saveLocate != null)
            {
                try
                {
                    newStream = File.OpenText(fileName);
                    List<string> results = new List<string>();
                    while (!newStream.EndOfStream)
                    {
                        string row = newStream.ReadLine();

                        string[] split = row.Split(',');

                        split[2] = DateConversion.StandardizeDates(split[2]).ToString();
                        split[5] = DateConversion.StandardizeDates(split[5]).ToString();

                        row = split[0] + "," + split[1] + "," + split[2] + "," + split[3] + "," + split[4] + "," + split[5];

                        results.Add(row);


                    }

                    using (location = new StreamWriter(saveLocate, false))
                    {
                        foreach (string result in results)
                        {
                            location.Write(result + Environment.NewLine);
                            
                        }
                        location.Close();
                    }


                    MessageBox.Show("Conversion finished.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnFileLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog retrievedFile = new OpenFileDialog();
            retrievedFile.InitialDirectory = @"C:\Users\Cyberadmin\Downloads";
            retrievedFile.Filter = "csv files (*.csv)|*.csv|.txt Files (*.txt)|*.txt|All files (*.*)|*.*";
            retrievedFile.RestoreDirectory = true;

            if (retrievedFile.ShowDialog() == DialogResult.OK)
            {
                fileName = retrievedFile.FileName;
                txtInput.Text = fileName;

                btnOutput.Enabled = true;
            }



        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = ".csv Files (*.csv)|*.csv|.txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                saveLocate = saveFile.FileName;
                txtOutput.Text = saveLocate;
                btnConvert.Enabled = true;
            }
        }
    }
}
