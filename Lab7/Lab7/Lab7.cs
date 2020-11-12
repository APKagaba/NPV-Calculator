// Grading ID: A1749
// CIS 199-01
// Lab 7
// Due: 11/11/2018

// This GUI will use a Net Present Value formula from Finance to calculate how much money 
// you need to invest today to earn a certain amount in the future.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        //Calculates for the present value
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            int years; // the number of years 
            double rate; // the interest rate
            double value; // the future value

            //Recognizes the numbers in the textboxes as the number of years, interest rate, and future value
            int.TryParse(yearTxt.Text, out years);
            double.TryParse(rateTxt.Text, out rate);
            double.TryParse(fvalueTxt.Text, out value);
                    
            //Show the present value in currency
            outputVlbl.Text = $"{CalcPresentValue(value, rate, years):C}";

        }
        //Precondition: value > 0, rate > 0, years > 0
        //Postcondition: present value is calculated and returned as a double
        public static double CalcPresentValue(double value, double rate, int years)
        {
            double Pvalue = value / Math.Pow((1 + rate), years); //Net Present Value formula
            return Pvalue; //Returns the value as a double
        }
    }
}
