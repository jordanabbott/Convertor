using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
{
    public partial class frm_Main : Form
    {
        string[] readings = new string [5];
        
        public frm_Main()
        {
            InitializeComponent();

        }

        // Global Variables and Constants
        double dbl_unit, dbl_Convert;

        //Exit button
        private void btn_Exit_Click(object sender, EventArgs e)
            //Ends the program when pressed
        {
            Application.Exit();
        }

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
            //1cm = 0.3937 inches
        {
            const double cmtinch = 0.3937;
           
            // If a double is not entered then an error message occurs and the text box is reset

            if (! double.TryParse(txt_UnitOfMeasure.Text, out dbl_unit))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_unit * cmtinch;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";

                // While I is less than the length of the array the for loop is carried out, so it is carried out 5 times

                for (int i = 0; i<readings.Length; i++)
                {
                    readings[i] = txt_Convert.Text;
                }

                //The 5 readings are then outputed in to a text box
                readingstxt.Text = "Reading 1 = " + readings[0] + "Inches " + "\n" +
                    "Reading 2 = " + readings[1] + "Inches " + "\n" +
                    "Reading 3 = " + readings[2] + "Inches " + "\n" +
                    "Reading 4 = " + readings[3] + "Inches " + "\n" +
                    "Reading 5 = " + readings[4] + "Inches " + "\n";                   
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
        }

        private void btn_CM_to_Feet_Click(object sender, EventArgs e)
        {
            const double cmtfeet = 0.0328084;

            // If a double is not entered then an error message occurs and the text box is reset

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_unit))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_unit * cmtfeet;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                lbl_Convert.Text = " Feet.";

                // While I is less than the length of the array the for loop is carried out, so it is carried out 5 times

                for (int i = 0; i < readings.Length; i++)
                {
                    readings[i] = txt_Convert.Text;

                }

                //The 5 readings are then outputed in to a text box

                readingstxt.Text = "Reading 1 = " + readings[0] + "Inches " + "\n" +
                    "Reading 2 = " + readings[1] + "Feet " + "\n" +
                    "Reading 3 = " + readings[2] + "Feet " + "\n" +
                    "Reading 4 = " + readings[3] + "Feet " + "\n" +
                    "Reading 5 = " + readings[4] + "Feet " + "\n";
            }
        }

        private void btn_KM_to_Miles_Click(object sender, EventArgs e)
        {
            const double KmtFeet = 0.621371;

            // If a double is not entered then an error message occurs and the text box is reset

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_unit))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_unit * KmtFeet;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Kilometre is converted to ";
                lbl_Convert.Text = " Miles.";

                // While I is less than the length of the array the for loop is carried out, so it is carried out 5 times

                for (int i = 0; i < readings.Length; i++)
                {
                    readings[i] = txt_Convert.Text;

                }
                //The 5 readings are then outputed in to a text box
                readingstxt.Text = "Reading 1 = " + readings[0] + "Miles " + "\n" +
                    "Reading 2 = " + readings[1] + "Miles " + "\n" +
                    "Reading 3 = " + readings[2] + "Miles " + "\n" +
                    "Reading 4 = " + readings[3] + "Miles " + "\n" +
                    "Reading 5 = " + readings[4] + "Miles " + "\n";

            }

        }

        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double MtFeet = 3.28084;

            // If a double is not entered then an error message occurs and the text box is reset

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_unit))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_unit * MtFeet;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Metre is converted to ";
                lbl_Convert.Text = " Feet.";
            }

            // While I is less than the length of the array the for loop is carried out, so it is carried out 5 times

            for (int i = 0; i < readings.Length; i++)
                {
                readings[i] = txt_Convert.Text;

            }

            //The 5 readings are then outputed in to a text box
            readingstxt.Text = "Reading 1 = " + readings[0] + "Feet " + "\n" +
                "Reading 2 = " + readings[1] + "Feet " + "\n" +
                "Reading 3 = " + readings[2] + "Feet " + "\n" +
                "Reading 4 = " + readings[3] + "Feet " + "\n" +
                "Reading 5 = " + readings[4] + "Feet " + "\n";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Celcius_to_Fahrenheit_Click(object sender, EventArgs e)
        {
            // If a double is not entered then an error message occurs and the text box is reset

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_unit))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = (dbl_unit * 1.8) +32;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Degrees C is converted to ";
                lbl_Convert.Text = " Degrees F.";
            }

            // While I is less than the length of the array the for loop is carried out, so it is carried out 5 times

            for (int i = 0; i < readings.Length; i++)
                {
                readings[i] = txt_Convert.Text;

            }

            readingstxt.Text = "Reading 1 = " + readings[0] + "Degrees F " + "\n" +
                "Reading 2 = " + readings[1] + "Degrees F " + "\n" +
                "Reading 3 = " + readings[2] + "Degrees F " + "\n" +
                "Reading 4 = " + readings[3] + "Degrees F " + "\n" +
                "Reading 5 = " + readings[4] + "Degrees F " + "\n";

        }

    }



    

       
    }

