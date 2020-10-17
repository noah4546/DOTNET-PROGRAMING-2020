/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Form1, Main Form of the program
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            // Check to see if at least one service is checked
            if (!cutCB.Checked && !colorCB.Checked && !highlightsCB.Checked && !extentionsCB.Checked)
            {
                totalPriceLbl.Text = "Total Price: ";
                MessageBox.Show("You must select at least one service", "Missing Service(s)");
                cutCB.Focus();
                return;
            }

            int visits = 0;
            if (!int.TryParse(visitsTB.Text, out visits) || visits < 0)
            {
                totalPriceLbl.Text = "Total Price: ";
                MessageBox.Show("Number of Visits must be an integer greater than 0", "Incorect Value");
                return;
            }

            decimal baseRate = 0;
            if (janeRB.Checked)
                baseRate = 30;
            else if (patRB.Checked)
                baseRate = 45;
            else if (ronRB.Checked)
                baseRate = 40;
            else if (sueRB.Checked)
                baseRate = 50;
            else if (lauraRB.Checked)
                baseRate = 55;

            decimal servies = 0;
            if (cutCB.Checked)
                servies += 30;
            if (colorCB.Checked)
                servies += 40;
            if (highlightsCB.Checked)
                servies += 50;
            if (extentionsCB.Checked)
                servies += 200;

            double typeDiscount = 0.00;
            if (adultRB.Checked)
                typeDiscount = 0.00;
            else if (childRB.Checked)
                typeDiscount = 0.10;
            else if (studentRB.Checked)
                typeDiscount = 0.05;
            else if (seniorRB.Checked)
                typeDiscount = 0.15;

            double visitsDiscount = 0.00;
            if (visits >= 1 && visits <= 3)
                visitsDiscount = 0.00;
            else if (visits >= 4 && visits <= 8)
                visitsDiscount = 0.05;
            else if (visits >= 9 && visits <= 13)
                visitsDiscount = 0.10;
            else if (visits >= 14)
                visitsDiscount = 0.15;

            decimal totalPrice = (baseRate + servies) *
                                 (1 - (decimal)typeDiscount) * 
                                 (1 - (decimal)visitsDiscount);

            totalPriceLbl.Text = "Total Price: " + totalPrice.ToString("$00.00");
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            janeRB.Checked = true;
            janeRB.Focus();
            cutCB.Checked = false;
            colorCB.Checked = false;
            highlightsCB.Checked = false;
            extentionsCB.Checked = false;
            adultRB.Checked = true;
            visitsTB.Clear();
            totalPriceLbl.Text = "Total Price:";
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
