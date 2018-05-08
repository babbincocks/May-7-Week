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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sourceFile = File.OpenText(@"..\..\..\Grades\Grades.csv");
                string studentLine;
                int count = 0;
                int total;
                double average;
                char[] delim = { ',' };

                while (!sourceFile.EndOfStream)
                {
                    count++;

                    studentLine = sourceFile.ReadLine();

                    string[] tokens = studentLine.Split(delim);

                    total = 0;

                    foreach (string item in tokens)
                    {
                        total += int.Parse(item);
                    }

                    average = (double)total / tokens.Length;

                    lbAverages.Items.Add("The average for student " + count + " is " + average.ToString("n1"));
                }

                sourceFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
