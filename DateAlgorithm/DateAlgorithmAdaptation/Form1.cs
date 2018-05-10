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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Stream newStream = null;
            OpenFileDialog retrievedFile = new OpenFileDialog();

            retrievedFile.InitialDirectory = @"C:\Users\Cyberadmin\Downloads";
            retrievedFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            retrievedFile.FilterIndex = 2;
            retrievedFile.RestoreDirectory = true;

            if (retrievedFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (retrievedFile.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File not found.");
                }
            }
        }
    }
}
