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
        }

      }



    

       
    }

