using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Spectrum
{
    //Enumerator to hold the names of all of the colors.
    enum Spectrum
    {
        Red, Orange, Yellow, Green, Blue, Indigo, Violet
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Method that accepts a value from the enum to display it to the color text box.
        private void DisplayColor(Spectrum color)
        {
            txtColor.Text = color.ToString();
        }

        //All of the labels have click events that use the DisplayColor method to display their related color.
        private void lblRed_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        private void lblOrange_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        private void lblYellow_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        private void lblGreen_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        private void lblBlue_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        private void lblIndigo_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Indigo);
        }

        private void lblViolet_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Violet);
        }
    }
}
