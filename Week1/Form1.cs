using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            decimal hoursWorked, hourlyPay;

            if (!decimal.TryParse(hoursWorkedTB.Text, out hoursWorked) || hoursWorked < 0 || hoursWorked > 100)
            {
                errorLbl.Text = "Invalid hours worked entry! Please try again";
                return;
            }
            else if (!decimal.TryParse(hourlyPayTB.Text, out hourlyPay) || hourlyPay < 14 || hourlyPay > 250)
            {
                errorLbl.Text = "Invalid hourly pay entry! Please try again";
                return;
            }
            else
            {
                errorLbl.Text = "";
                decimal grossPay = hoursWorked * hourlyPay;
                grossPayTB.Text = grossPay.ToString();
            }
        }

        private void calculateBtn2_Click(object sender, EventArgs e)
        {
            decimal hoursWorked = hoursWorkedNUD.Value;
            decimal hourlyPay = hourlyPayNUD.Value;

            decimal grossPay = hoursWorked * hourlyPay;
            grossPayTB2.Text = grossPay.ToString("C"); //C means currency
        }
    }
}
