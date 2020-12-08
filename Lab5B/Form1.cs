using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * Doctor Who: Doctors and Companions
 * Lists all the doctors and their companions
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

namespace Lab5B
{
    public partial class Form1 : Form
    {
        public SqlConnection Connection { get; }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True";
        List<Doctor> doctors = new List<Doctor>();
        List<Companion> companions = new List<Companion>();
        List<Episode> episodes = new List<Episode>();

        public Form1()
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

        /// <summary>
        /// This is ran when the form is loaded for the first time
        /// it will query the sql database and populate: doctors,
        /// companions, and episodes lists. Then it displays the
        /// doctor to the screen
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Get all episodes
            SqlCommand command = new SqlCommand("SELECT * FROM EPISODE", Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string storyId = (string)reader["STORYID"];
                int season = (int)reader["SEASON"];
                int seansonYear = (int)reader["SEASONYEAR"];
                string title = (string)reader["TITLE"];

                episodes.Add(new Episode(storyId, season, seansonYear, title));
            }
            reader.Close();

            // Get all doctors
            command = new SqlCommand("SELECT * FROM DOCTOR", Connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int doctorId = (int)reader["DOCTORID"];
                string actor = (string)reader["ACTOR"];
                int series = (int)reader["SERIES"];
                int age = (int)reader["AGE"];
                string debut = (string)reader["DEBUT"];
                byte[] photo = (byte[])reader["PICTURE"];

                MemoryStream stream = new MemoryStream(photo);
                Image image = Image.FromStream(stream);

                doctors.Add(new Doctor(doctorId, actor, series, age, debut, image));
            }
            reader.Close();

            // Get all compainions
            command = new SqlCommand("SELECT * FROM COMPANION", Connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["NAME"];
                string actor = (string)reader["ACTOR"];
                int doctorId = (int)reader["DOCTORID"];
                string storyId = (string)reader["STORYID"];

                companions.Add(new Companion(name, actor, doctorId, storyId));
            }
            reader.Close();

            foreach (Doctor doctor in doctors)
                doctorCB.Items.Add(doctor.Id);

            doctorCB.SelectedIndex = 0;

            if (querySqlRB.Checked)
                LoadUsingSQL();
            else
                LoadUsingLINQ();        
        }

        /// <summary>
        /// Loads the doctors using SQL queries
        /// </summary>
        private void LoadUsingSQL()
        {
            int doctorId = doctorCB.SelectedIndex + 1;

            SqlCommand command = new SqlCommand(@"
            SELECT *
            FROM DOCTOR d
            JOIN EPISODE e
            ON d.DEBUT = e.STORYID
            WHERE d.DOCTORID = @doctorId
            ", Connection);
            SqlParameter param = new SqlParameter("@doctorId", SqlDbType.Int);
            command.Parameters.Add(param);
            param.Value = doctorId;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                playedByTB.Text = (string)reader["ACTOR"];
                yearTB.Text = ((int)reader["SEASONYEAR"]).ToString();
                seriesTB.Text = ((int)reader["SERIES"]).ToString();
                startAgeTB.Text = ((int)reader["AGE"]).ToString();
                firstEpTB.Text = (string)reader["TITLE"];

                byte[] photo = (byte[])reader["PICTURE"];
                MemoryStream stream = new MemoryStream(photo);
                imagePB.Image = Image.FromStream(stream);
            } 
            else
            {
                playedByTB.Clear();
                yearTB.Clear();
                seriesTB.Clear();
                startAgeTB.Clear();
                firstEpTB.Clear();
                imagePB.Image = null;
                statusLbl.Text = "Failed to load doctor";
            }
            reader.Close();

            SqlCommand command2 = new SqlCommand(@"
            SELECT *
            FROM COMPANION c
            JOIN EPISODE e
            ON c.STORYID = e.STORYID
            WHERE c.DOCTORID = @doctorId
            ORDER BY e.SEASONYEAR
            ", Connection);
            SqlParameter param2 = new SqlParameter("@doctorId", SqlDbType.Int);
            command2.Parameters.Add(param2);
            param2.Value = doctorId;
            reader = command2.ExecuteReader();

            companionsLB.Items.Clear();
            if (reader.HasRows)
                while (reader.Read())
                {
                    string name = (string)reader["NAME"];
                    string actor = (string)reader["ACTOR"];
                    string title = (string)reader["TITLE"];
                    int year = (int)reader["SEASONYEAR"];

                    companionsLB.Items.Add($"{name} ({actor})");
                    companionsLB.Items.Add($"\"{title}\" ({year})");
                    companionsLB.Items.Add("");
                }
            else
                statusLbl.Text = "Failed Loading Companions";
            reader.Close();
        }

        /// <summary>
        /// Loads the doctors using linq
        /// </summary>
        private void LoadUsingLINQ()
        {
            int doctorId = doctorCB.SelectedIndex + 1;

            var resultsDoctor =
                from doctor in doctors
                join episode in episodes on doctor.Debut equals episode.StoryId
                where doctor.Id == doctorId
                select new { doctor, episode };

            var result = resultsDoctor.First();

            if (resultsDoctor.Count() > 0)
            {
                playedByTB.Text = result.doctor.Actor;
                yearTB.Text = result.episode.SeasonYear.ToString();
                seriesTB.Text = result.doctor.Series.ToString();
                startAgeTB.Text = result.doctor.Age.ToString();
                firstEpTB.Text = result.episode.Title;
                imagePB.Image = result.doctor.Picture;
            }
            else
            {
                playedByTB.Clear();
                yearTB.Clear();
                seriesTB.Clear();
                startAgeTB.Clear();
                firstEpTB.Clear();
                imagePB.Image = null;
                statusLbl.Text = "Failed to load doctor";
            }

            companionsLB.Items.Clear();
            var resultsCompanions =
                from companion in companions
                join episode in episodes on companion.StoryId equals episode.StoryId
                where companion.DoctorId == doctorId
                orderby episode.StoryId
                select new { companion, episode };

            if (resultsCompanions.Count() >= 1)
                foreach (var c in resultsCompanions)
                {
                    companionsLB.Items.Add($"{c.companion.Name} ({c.companion.Actor})");
                    companionsLB.Items.Add($"\"{c.episode.Title}\" ({c.episode.SeasonYear})");
                    companionsLB.Items.Add("");
                }
        }

        /// <summary>
        /// When the doctor combobox is changed it will
        /// either load with sql or linq depending on the
        /// query radio buttons
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void doctorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (querySqlRB.Checked)
                LoadUsingSQL();
            else
                LoadUsingLINQ();
        }

        /// <summary>
        /// Ctr-Q or pressing exit will quit the application
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
