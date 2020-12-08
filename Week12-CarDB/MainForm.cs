using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Week12_CarDB
{
    public partial class MainFrom : Form
    {
        public SqlConnection Connection { get; }
        readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=dotnet;Integrated Security=True";

        public MainFrom()
        {
            InitializeComponent();

            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                statusLbl.Text = "Connected to Database Successfully";
            } 
            catch (Exception ex)
            {
                statusLbl.Text = $"Database Connection failed - check Connection String : {ex.Message}";
            }
        }

        private void listCarsBtn_Click(object sender, EventArgs e)
        {
            resultLB.Items.Clear();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Cars", Connection);
                // Create new SqlDataReader object and read data from the command.
                SqlDataReader reader = command.ExecuteReader();
                // while there is another record present
                while (reader.Read())
                {
                    // write the data on to the screen
                    string output = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                        output += String.Format("{0,-10} | ", reader[i]);
                    resultLB.Items.Add(output);
                }
                statusLbl.Text = "Database Select Success";
                reader.Close();
            }
            catch (Exception ex)
            {
                statusLbl.Text = "Database operation failed: " + ex.Message;
            }
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            AddCarForm form = new AddCarForm(this); // Pass Reference to this class for other info
            form.ShowDialog(this);
            listCarsBtn_Click(this, null);
        }

        private void resultLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Mileage WHERE car_id = @carId", Connection);
                SqlParameter param = new SqlParameter("@carId", SqlDbType.Int);
                cmd.Parameters.Add(param);

                string[] carFields = resultLB.SelectedItem.ToString().Split('|');
                bool result = int.TryParse(carFields[0].Trim(), out int carId);
                if (result)
                {
                    // update the parameter value
                    param.Value = carId;
                    int totalDistance = 0;
                    float gasUsed = 0;

                    // run select query to get all mileage entries for the car in question
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        totalDistance += (int)reader["endkm"] - (int)reader["startkm"];
                        gasUsed += (float)reader["gasused"];
                    }
                    reader.Close();

                    // calculate the mileage (L/100km)
                    double avgMilage = gasUsed / (totalDistance / 100);
                    mileageTB.Text = avgMilage.ToString("f2");
                    selectedVehicleTB.Text = $"{carFields[1].Trim()} {carFields[2].Trim()} {carFields[3].Trim()}";
                }

            }
            catch
            {

            }
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
