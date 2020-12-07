using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11B_DB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cARSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cARSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dN20_CarsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dN20_CarsDataSet.CARS' table. You can move, or remove it, as needed.
            this.cARSTableAdapter.Fill(this.dN20_CarsDataSet.CARS);

        }
    }
}
