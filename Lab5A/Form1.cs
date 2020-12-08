using System;
using System.Drawing;
using System.Windows.Forms;

/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * A drop in the bukket.
 * A bukket will fill with a liquid of the users choice, and
 * will fill at a specified flowrate depending on a sliders value
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

namespace Lab5A
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen p;
        private SolidBrush b;
        private SolidBrush bb;
        private Color c = Color.Aqua;

        private int waterMax = 275;
        private int fillPercent = 0;

        Rectangle water;
        Rectangle flow;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the form loads initiate the paiting variables
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">PaintEventArgs</param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.White);
            b = new SolidBrush(c);
            bb = new SolidBrush(Color.Black);

            g = CreateGraphics();

            Reset();
        }

        /// <summary>
        /// When the color button is clicked show pop-up to
        /// change the color of the liquid
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorPicker.Color = c;
            colorPicker.ShowDialog();
            c = colorPicker.Color;
        }

        /// <summary>
        /// When the timer ticks it will fill the bukket
        /// with the liquid, the interval is changed by
        /// the slider
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            fillPercent++;
            water.Y = 100 + waterMax - fillPercent;
            water.Height = fillPercent;
            g.FillRectangle(b, water);
            g.FillRectangle(b, flow);

            if (fillPercent > 100)
            {
                fillPercent = 0;
                trackBar1.Value = 0;
                g.FillRectangle(bb, flow);
                g.FillRectangle(b, water);
                timer.Stop();
            }
                
        }

        /// <summary>
        /// Resets the painted objects
        /// </summary>
        public void Reset()
        {
            g.Clear(Color.Black);

            g.DrawLine(p, 74, 250, 74, 375);
            g.DrawLine(p, 300, 250, 300, 375);
            g.DrawLine(p, 74, 375, 300, 375);

            flow = new Rectangle(108, 150, 20, 225);

            water = new Rectangle(75, 100 + waterMax - fillPercent, 225, fillPercent);
            g.FillRectangle(b, water);
        }

        /// <summary>
        /// When the trackbar changes its value
        /// update the interval. When it is 0 it will
        /// stop the timer and stop the liquid, when it
        /// is greater than 0 it will fill the bukket
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                timer.Stop();
                g.FillRectangle(bb, flow);
                g.FillRectangle(b, water);
            }
            else if (trackBar1.Value >= 1)
            {
                Reset();
                timer.Interval = (11 - trackBar1.Value) * 50;
                timer.Start();
            }
        }

        /// <summary>
        /// When the close button is pressed it will close the application
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
