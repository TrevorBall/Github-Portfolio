using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NHL_Class_Library;

namespace Sports_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Bruins Stats
        private void pbxBruins_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxBruins.Tag);
                Image logo = pbxBruins.Image ?? pbxBruins.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Ducks
        private void pbxDucks_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxDucks.Tag);
                Image logo = pbxDucks.Image ?? pbxDucks.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Sabres
        private void pbxSabres_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxSabres.Tag);
                Image logo = pbxSabres.Image ?? pbxSabres.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Flsames
        private void pbxFlames_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxFlames.Tag);
                Image logo = pbxFlames.Image ?? pbxFlames.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hurricanes
        private void pbxHurricanes_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxHurricanes.Tag);
                Image logo = pbxHurricanes.Image ?? pbxHurricanes.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Blackhawks
        private void pbxBlackhawks_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxBlackhawks.Tag);
                Image logo = pbxBlackhawks.Image ?? pbxBlackhawks.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Avalanche
        private void pbxAvalanche_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxAvalanche.Tag);
                Image logo = pbxAvalanche.Image ?? pbxAvalanche.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Blue Jackets
        private void pbxBlueJackets_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxBlueJackets.Tag);
                Image logo = pbxBlueJackets.Image ?? pbxBlueJackets.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Stars
        private void pbxStars_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxStars.Tag);
                Image logo = pbxStars.Image ?? pbxStars.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Red Wings
        private void pbxWings_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxWings.Tag);
                Image logo = pbxWings.Image ?? pbxWings.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Oilers
        private void pbxOilers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxOilers.Tag);
                Image logo = pbxOilers.Image ?? pbxOilers.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Panthers
        private void pbxPanthers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxPanthers.Tag);
                Image logo = pbxPanthers.Image ?? pbxPanthers.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Kings
        private void pbxKings_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxKings.Tag);
                Image logo = pbxKings.Image ?? pbxKings.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Wilds
        private void pbxWild_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxWild.Tag);
                Image logo = pbxWild.Image ?? pbxWild.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Canadiens
        private void pbxCanadiens_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxCanadiens.Tag);
                Image logo = pbxCanadiens.Image ?? pbxCanadiens.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Predators
        private void pbxPredators_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxPredators.Tag);
                Image logo = pbxPredators.Image ?? pbxPredators.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxDevils_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxDevils.Tag);
                Image logo = pbxDevils.Image ?? pbxDevils.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxIslanders_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxIslanders.Tag);
                Image logo = pbxIslanders.Image ?? pbxIslanders.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxRangers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxRangers.Tag);
                Image logo = pbxRangers.Image ?? pbxRangers.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxSenators_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxSenators.Tag);
                Image logo = pbxSenators.Image ?? pbxSenators.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxFlyers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxFlyers.Tag);
                Image logo = pbxFlyers.Image ?? pbxFlyers.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxPenguins_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxPenguins.Tag);
                Image logo = pbxPenguins.Image ?? pbxPenguins.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxSharks_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxSharks.Tag);
                Image logo = pbxSharks.Image ?? pbxSharks.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxKraken_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxKraken.Tag);
                Image logo = pbxKraken.Image ?? pbxKraken.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxBlues_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxBlues.Tag);
                Image logo = pbxBlues.Image ?? pbxBlues.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxLightning_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxLightning.Tag);
                Image logo = pbxLightning.Image ?? pbxLightning.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxLeafs_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxLeafs.Tag);
                Image logo = pbxLeafs.Image ?? pbxLeafs.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxMammoths_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxMammoths.Tag);
                Image logo = pbxMammoths.Image ?? pbxMammoths.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxCanucks_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxCanucks.Tag);
                Image logo = pbxCanucks.Image ?? pbxCanucks.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxKnights_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxKnights.Tag);
                Image logo = pbxKnights.Image ?? pbxKnights.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxCapitals_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxCapitals.Tag);
                Image logo = pbxCapitals.Image ?? pbxCapitals.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxWinnipeg_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT * FROM ['NHL Team$'] WHERE TeamID = @TeamID";


            try
            {
                int teamId = Convert.ToInt32(pbxWinnipeg.Tag);
                Image logo = pbxWinnipeg.Image ?? pbxWinnipeg.BackgroundImage; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TeamID", SqlDbType.Int).Value = teamId;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var team = new NHL_Class_Library.Team(
                                reader["Team"].ToString(),
                                reader["Conference"].ToString(),
                                Convert.ToInt32(reader["Wins"]),
                                Convert.ToInt32(reader["Losses"]),
                                Convert.ToInt32(reader["Tie"]),
                                Convert.ToInt32(reader["OT Losses"]),
                                Convert.ToInt32(reader["Points"])
                            );

                            var form = new NHLStats(team, logo, teamId);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("No team found for that TeamID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


