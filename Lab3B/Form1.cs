/*
 * Noah Tomkins
 * November 1, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Windows.Forms;

namespace Lab3B
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initizlizes all components
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the Form
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            hairdresserCB.SelectedIndex = 0;
            hairdresserCB.Focus();

            calculateBtn.Enabled = false;
            addServiceBtn.Enabled = false;

            //Disables selection of items, but still allows scrolling
            chargedItemsLB.SelectionMode = 0; 
            priceLB.SelectionMode = 0;
        }

        /// <summary>
        /// Gets the price for the selected hairdresser
        /// </summary>
        /// <returns>price</returns>
        private decimal getHairdresserPrice()
        {
            string hairdresser = hairdresserCB.SelectedItem.ToString();

            if (hairdresser == "Jane Samley")
                return 30;
            if (hairdresser == "Pat Johnson")
                return 45;
            if (hairdresser == "Ron Chambers")
                return 40;
            if (hairdresser == "Sue Pallon")
                return 50;
            if (hairdresser == "Laura Renkins")
                return 55;
            else
                return 0;
        }

        /// <summary>
        /// Gets the price for the selected service
        /// </summary>
        /// <returns>price</returns>
        private decimal getServicePrice()
        {
            string service = servicesLB.SelectedItem.ToString();

            if (service == "Cut")
                return 30;
            if (service == "Wash, blow-dry, and style")
                return 20;
            if (service == "Colour")
                return 40;
            if (service == "Highlights")
                return 50;
            if (service == "Extension")
                return 200;
            if (service == "Up-do")
                return 60;
            else
                return 0;
        }

        /// <summary>
        /// Adds Services to the chargedItemsLB and priceLB
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            if (hairdresserCB.Enabled)
            {
                chargedItemsLB.Items.Add(hairdresserCB.SelectedItem.ToString());
                priceLB.Items.Add(getHairdresserPrice().ToString("$0.00"));
                hairdresserCB.Enabled = false;
                calculateBtn.Enabled = true;
            }

            chargedItemsLB.Items.Add(servicesLB.SelectedItem.ToString());
            priceLB.Items.Add(getServicePrice().ToString("$0.00"));

            servicesLB.SelectedItem = null;
            addServiceBtn.Enabled = false;
        }

        /// <summary>
        /// Calculates the total of all the items and outputs total to totalPriceLB
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (string strPrice in priceLB.Items)
                if (decimal.TryParse(strPrice.Remove(0,1), out decimal price) == false)
                    MessageBox.Show("Error converting: " + strPrice + " to decimal");
                else
                    total += price;

            totalPriceTB.Text = total.ToString("$0.00");
        }

        /// <summary>
        /// Resets the interface
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            hairdresserCB.Enabled = true;
            hairdresserCB.SelectedIndex = 0;
            hairdresserCB.Focus();

            calculateBtn.Enabled = false;
            addServiceBtn.Enabled = false;

            chargedItemsLB.Items.Clear();
            priceLB.Items.Clear();
            totalPriceTB.Clear();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Enables the addServicesBtn when a service is selected
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void servicesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            addServiceBtn.Enabled = true;
        }
    }
}
