using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Project_1
{
    public partial class NHLPlayersForm : Form
    {
        private readonly int _teamId;
        private Image _teamLogo;
        private string _teamName;

        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\sportsDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public NHLPlayersForm(int teamId, Image teamLogo, string teamName)
        {
            InitializeComponent();

            _teamId = teamId;
            _teamLogo = teamLogo;
            _teamName = teamName;

            //Load the players into the combo box
            LoadPlayersForTeam();

            //When user changes player, load details + stats
            cmbPlayers.SelectedIndexChanged += cmbPlayers_SelectedIndexChanged;

            ApplyTeamTheme(teamId);
            tbTeamName.Text = _teamName;
        }

        private void NHLPlayersForm_Load(object sender, EventArgs e)
        {
            //this line causes issues, so i commented it out.
            //It's only needed if we're using the dataset bindings.
            //this._NHL_Players__TableAdapter.Fill(this.sportsDBDataSet.@__NHL_Players__);

            PictureBoxTeamLogo.Image = _teamLogo;
            PictureBoxTeamLogo.SizeMode = PictureBoxSizeMode.Zoom;

            LoadPlayersForTeam();
        }

        private void _NHL_Players__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._NHL_Players__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsDBDataSet);
        }

        private void cmbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlayers.SelectedValue == null) return;

            int playerId;
            if (!int.TryParse(cmbPlayers.SelectedValue.ToString(), out playerId))
                return;

            LoadPlayerDetailsAndStats(playerId);
        }

        private void LoadPlayersForTeam()
        {
            cmbPlayers.DataSource = null;
            cmbPlayers.Items.Clear();

            string query =
            "SELECT PlayerID, [First Name], [Last Name] " +
            "FROM [dbo].['NHL Players$'] " +
            "WHERE TeamID = @TeamID " +
            "ORDER BY [Last Name], [First Name];";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@TeamID", SqlDbType.Int).Value = _teamId;

                DataTable dt = new DataTable();
                connection.Open();
                dt.Load(cmd.ExecuteReader());

                //Create a FullName column for displaying in combo box
                dt.Columns.Add("FullName", typeof(string), "[First Name] + ' ' + [Last Name]");

                cmbPlayers.DisplayMember = "FullName";
                cmbPlayers.ValueMember = "PlayerID";
                cmbPlayers.DataSource = dt;
            }

            //Auto-select first player so it loads right away
            if (cmbPlayers.Items.Count > 0)
                cmbPlayers.SelectedIndex = 0;
        }

        private void LoadPlayerDetailsAndStats(int playerId)
        {
            string sql = @"
                SELECT 
                    p.[First Name],
                    p.[Last Name],
                    p.[Position],
                    p.[Jersey Number],

                    s.[Games Played (GP)]      AS GP,
                    s.[Goals (G)]              AS G,
                    s.[Assists (A)]            AS A,
                    s.[Points (PTS)]           AS PTS,
                    s.[PlusMinus (+/-)]        AS PlusMinus,
                    s.[Penalty Minutes (PIM)]  AS PIM
                FROM [dbo].['NHL Players$'] p
                LEFT JOIN [dbo].['NHL Player Stats$'] 
                s ON p.PlayerID = s.PlayerID
                WHERE p.PlayerID = @PlayerID
            ";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@PlayerID", SqlDbType.Int).Value = playerId;

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (!r.Read())
                    {
                        ClearAllBoxes();
                        return;
                    }

                    // Player info
                    tbFirstName.Text = r["First Name"] == DBNull.Value ? "" : r["First Name"].ToString();
                    tbLastName.Text = r["Last Name"] == DBNull.Value ? "" : r["Last Name"].ToString();
                    tbPosition.Text = r["Position"] == DBNull.Value ? "" : r["Position"].ToString();
                    tbJerseyNumber.Text = r["Jersey Number"] == DBNull.Value ? "" : r["Jersey Number"].ToString();

                    // Stats -- defaults to 0 if NULL / missing --
                    tbGP.Text = r["GP"] == DBNull.Value ? "0" : r["GP"].ToString();
                    tbG.Text = r["G"] == DBNull.Value ? "0" : r["G"].ToString();
                    tbA.Text = r["A"] == DBNull.Value ? "0" : r["A"].ToString();
                    tbPTS.Text = r["PTS"] == DBNull.Value ? "0" : r["PTS"].ToString();
                    tbPlusMinus.Text = r["PlusMinus"] == DBNull.Value ? "0" : r["PlusMinus"].ToString();
                    tbPIM.Text = r["PIM"] == DBNull.Value ? "0" : r["PIM"].ToString();
                }
            }
        }

        private void ClearAllBoxes()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPosition.Text = "";
            tbJerseyNumber.Text = "";

            tbGP.Text = "0";
            tbG.Text = "0";
            tbA.Text = "0";
            tbPTS.Text = "0";
            tbPlusMinus.Text = "0";
            tbPIM.Text = "0";
        }

        private void ApplyTeamTheme(int teamId)
        {
            Color teamColor;

            switch (teamId)
            {
                case 1: // Anaheim Ducks
                    teamColor = Color.FromArgb(252, 76, 2);
                    break;

                case 2: // Boston Bruins
                    teamColor = Color.FromArgb(255, 184, 28);
                    break;

                case 3: // Buffalo Sabres
                    teamColor = Color.FromArgb(0, 38, 84);
                    break;

                case 4: // Calgary Flames
                    teamColor = Color.FromArgb(200, 16, 46);
                    break;

                case 5: // Carolina Hurricanes
                    teamColor = Color.FromArgb(206, 17, 38);
                    break;

                case 6: // Chicago Blackhawks
                    teamColor = Color.FromArgb(207, 10, 44);
                    break;

                case 7: // Colorado Avalanche
                    teamColor = Color.FromArgb(111, 38, 61);
                    break;

                case 8: // Columbus Blue Jackets
                    teamColor = Color.FromArgb(0, 38, 84);
                    break;

                case 9: // Dallas Stars
                    teamColor = Color.FromArgb(0, 104, 71);
                    break;

                case 10: // Detroit Red Wings
                    teamColor = Color.FromArgb(206, 17, 38);
                    break;

                case 11: // Edmonton Oilers
                    teamColor = Color.FromArgb(4, 30, 66);
                    break;

                case 12: // Florida Panthers
                    teamColor = Color.FromArgb(200, 16, 46);
                    break;

                case 13: // Los Angeles Kings
                    teamColor = Color.FromArgb(17, 17, 17);
                    break;

                case 14: // Minnesota Wild
                    teamColor = Color.FromArgb(21, 71, 52);
                    break;

                case 15: // Montreal Canadiens
                    teamColor = Color.FromArgb(175, 30, 45);
                    break;

                case 16: // Nashville Predators
                    teamColor = Color.FromArgb(255, 184, 28);
                    break;

                case 17: // New Jersey Devils
                    teamColor = Color.FromArgb(200, 16, 46);
                    break;

                case 18: // New York Islanders
                    teamColor = Color.FromArgb(0, 83, 155);
                    break;

                case 19: // New York Rangers
                    teamColor = Color.FromArgb(0, 56, 168);
                    break;

                case 20: // Ottawa Senators
                    teamColor = Color.FromArgb(200, 16, 46);
                    break;

                case 21: // Philadelphia Flyers
                    teamColor = Color.FromArgb(247, 73, 2);
                    break;

                case 22: // Pittsburgh Penguins
                    teamColor = Color.FromArgb(255, 184, 28);
                    break;

                case 23: // San Jose Sharks
                    teamColor = Color.FromArgb(0, 109, 117);
                    break;

                case 24: // Seattle Kraken
                    teamColor = Color.FromArgb(0, 22, 40);
                    break;

                case 25: // St. Louis Blues
                    teamColor = Color.FromArgb(0, 47, 135);
                    break;

                case 26: // Tampa Bay Lightning
                    teamColor = Color.FromArgb(0, 32, 91);
                    break;

                case 27: // Toronto Maple Leafs
                    teamColor = Color.FromArgb(0, 32, 91);
                    break;

                case 28: // Utah Mammoth
                    teamColor = Color.FromArgb(140, 38, 51);
                    break;

                case 29: // Vancouver Canucks
                    teamColor = Color.FromArgb(0, 32, 91);
                    break;

                case 30: // Vegas Golden Knights
                    teamColor = Color.FromArgb(185, 151, 91);
                    break;

                case 31: // Washington Capitals
                    teamColor = Color.FromArgb(200, 16, 46);
                    break;

                case 32: // Winnipeg Jets
                    teamColor = Color.FromArgb(4, 30, 66);
                    break;

                default:
                    teamColor = SystemColors.Control;
                    break;
            }

            // Apply to form
            this.BackColor = teamColor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
