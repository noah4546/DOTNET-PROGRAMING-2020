﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2___Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listAllCarsBTN_Click(object sender, EventArgs e)
        {
            Car myCar = new Car("Make", "Model", 50, 500);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            string fileName = "";

            if (openCars.ShowDialog() == DialogResult.OK)
                fileName = openCars.FileName;
        }
    }
}
