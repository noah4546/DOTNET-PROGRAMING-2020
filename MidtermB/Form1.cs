/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MidtermB
{
    public partial class Form1 : Form
    {
        private List<Weather> weather;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load form
        /// Reads the Weather.txt and updates the list box
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            addMonthCB.SelectedIndex = 0;

            weather = Read();

            weatherLB.Items.AddRange(weather.ToArray());
            UpdateMaxAvgTemps();
        }

        /// <summary>
        /// Updates the Max and Avg temp text boxes
        /// </summary>
        private void UpdateMaxAvgTemps()
        {
            double max = 0;
            double avg = 0;
            foreach (Weather item in weather)
            {
                if (item.Temperature > max)
                    max = item.Temperature;
                avg += item.Temperature;
            }
            avg = avg / weather.Count();

            highestTB.Text = max.ToString("0.00") + "°c";
            averageTB.Text = avg.ToString("0.0") + "°c";
        }

        /// <summary>
        /// Reads the weather data from Weather.txt
        /// </summary>
        /// <returns>List of weather objects</returns>
        private List<Weather> Read()
        {
            List<Weather> tempWeather = new List<Weather>();

            // Release Location (In same directory)
            string filePath = "Weather.txt"; 

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // Debug Location (In MidtermB directory)
                if (File.Exists("../../Weather.txt"))
                    filePath = "../../Weather.txt";

                fs = new FileStream(filePath, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    // Read next line
                    string input = sr.ReadLine();

                    // Check if line is not empty
                    if (input != "")
                    {

                        string[] values = input.Split(' ');

                        // Check to see if there is the right ammount of data in the file per line
                        if (values.Length < 4)
                        {
                            MessageBox.Show($"Error: {values[0]} does not contain the right arguments in file Weather.txt");
                            continue;
                        }

                        string month = values[0];

                        if (int.TryParse(values[1], out int year) == false)
                        {
                            MessageBox.Show($"Error Year: {values[1]} is not a valid number");
                            continue;
                        }

                        if (double.TryParse(values[2], out double rainFall) == false)
                        {
                            MessageBox.Show($"Error RainFall: {values[2]} is not a valid number");
                            continue;
                        }

                        if (double.TryParse(values[3], out double temp) == false)
                        {
                            MessageBox.Show($"Error Temperature: {values[3]} is not a valid number");
                            continue;
                        }

                        tempWeather.Add(new Weather(month, year, rainFall, temp));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Weather.txt due to:\n{ex}", "Error Loading Weather.txt");
                return null;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
                if (sr != null)
                    sr.Close();
            }


            return tempWeather;
        }

        /// <summary>
        /// Click add new weather object button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void addNewBtn_Click(object sender, EventArgs e)
        {
            bool allowed = true;

            foreach (Weather item in weather)
                if (item.Month == addMonthCB.Text && item.Year == addYearNUD.Value)
                    allowed = false;

            if (allowed)
            {
                Weather temp = new Weather(addMonthCB.Text, (int)addYearNUD.Value, (double)addRainNUD.Value, (double)addTempNUD.Value);

                weather.Add(temp);
                UpdateMaxAvgTemps();
                weatherLB.Items.Add(temp);
            }
            else
            {
                MessageBox.Show("Unable to create new data point because Month and Year already exists", "Unable to create data point");
            }

        }

        /// <summary>
        /// Click sort by rainfall button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void sortRainFall_Click(object sender, EventArgs e)
        {
            weather.Sort();
            weatherLB.Items.Clear();
            weatherLB.Items.AddRange(weather.ToArray());
        }
    }
}
