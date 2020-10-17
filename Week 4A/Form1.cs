using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_4A
{
    public partial class membershipFeeCalculator : Form
    {

        public membershipFeeCalculator()
        {
            InitializeComponent();
        }


        private void calculateBTN_Click(object sender, EventArgs e)
        {
            decimal monthlyFee = getBaseFee() + getAdditionalFees();

            monthlyFeeTB.Text = monthlyFee.ToString("C");
            totalTB.Text = (monthlyFee * monthsNUD.Value).ToString("C");
        }

        /// <summary>
        /// Gets the base fee depending on membership type
        /// </summary>
        /// <returns>Base fee</returns>
        public decimal getBaseFee()
        {
            decimal baseFee = 0;

            if (membershipAdultRB.Checked)
                baseFee = 40;
            else if (membershipChildRB.Checked)
                baseFee = 20;
            else if (membershipStudentRB.Checked)
                baseFee = 25;
            else if (membershipSeniorRB.Checked)
                baseFee = 30;

            return baseFee;
        }

        /// <summary>
        /// Gets additional fees
        /// </summary>
        /// <returns>Additional Fees</returns>
        public decimal getAdditionalFees()
        {
            decimal additonalFees = 0;

            if (yogaCB.Checked)
                additonalFees += 10;
            if (karateCB.Checked)
                additonalFees += 30;
            if (trainerCB.Checked)
                additonalFees += 50;

            return additonalFees;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            membershipAdultRB.Select();
            yogaCB.Checked = false;
            karateCB.Checked = false;
            trainerCB.Checked = false;
            monthsNUD.Value = monthsNUD.Minimum;
            monthlyFeeTB.Clear();
            totalTB.Clear();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
