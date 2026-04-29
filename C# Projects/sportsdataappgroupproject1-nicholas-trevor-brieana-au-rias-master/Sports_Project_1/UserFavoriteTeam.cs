using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportStatLibrary;

namespace Sports_Project_1
{
    public partial class UserFavoriteTeam : Form
    {
        //Stores the current logged in user so we know which users favorites to update
        private User _currentUser;

        //Gives access to Methods class so we can update CSV file
        private Methods _methods = new Methods();

        //Gets the path of UserLogins.csv inside the Debug folder
        private string _filePath = Path.Combine(Application.StartupPath, "UserLogins.csv");

        public UserFavoriteTeam(User user)
        {
            InitializeComponent();

            //Receives the logged in user from MainForm and allows the program to update their specific favorites
            _currentUser = user;
        }

        private void UserFavoriteTeam_Load(object sender, EventArgs e)
        {
            //Loads NFL and NHL teams into the ComboBoxes
            LoadNFLTeams();
            LoadNHLTeams();

            //selects user's saved favorite teams if they already have them set
            PreselectFavorites();
        }

        private void LoadNFLTeams()
        {
            cmbNFLTeams.Items.Clear();

            cmbNFLTeams.Items.Add(new TeamItem("Arizona Cardinals", 1));
            cmbNFLTeams.Items.Add(new TeamItem("Atlanta Falcons", 2));
            cmbNFLTeams.Items.Add(new TeamItem("Baltimore Ravens", 3));
            cmbNFLTeams.Items.Add(new TeamItem("Buffalo Bills", 4));
            cmbNFLTeams.Items.Add(new TeamItem("Carolina Panthers", 5));
            cmbNFLTeams.Items.Add(new TeamItem("Chicago Bears", 6));
            cmbNFLTeams.Items.Add(new TeamItem("Cincinnati Bengals", 7));
            cmbNFLTeams.Items.Add(new TeamItem("Cleveland Browns", 8));
            cmbNFLTeams.Items.Add(new TeamItem("Dallas Cowboys", 9));
            cmbNFLTeams.Items.Add(new TeamItem("Denver Broncos", 10));
            cmbNFLTeams.Items.Add(new TeamItem("Detroit Lions", 11));
            cmbNFLTeams.Items.Add(new TeamItem("Green Bay Packers", 12));
            cmbNFLTeams.Items.Add(new TeamItem("Houston Texans", 13));
            cmbNFLTeams.Items.Add(new TeamItem("Indianapolis Colts", 14));
            cmbNFLTeams.Items.Add(new TeamItem("Jacksonville Jaguars", 15));
            cmbNFLTeams.Items.Add(new TeamItem("Kansas City Chiefs", 16));
            cmbNFLTeams.Items.Add(new TeamItem("Las Vegas Raiders", 17));
            cmbNFLTeams.Items.Add(new TeamItem("Los Angeles Chargers", 18));
            cmbNFLTeams.Items.Add(new TeamItem("Los Angeles Rams", 19));
            cmbNFLTeams.Items.Add(new TeamItem("Miami Dolphins", 20));
            cmbNFLTeams.Items.Add(new TeamItem("Minnesota Vikings", 21));
            cmbNFLTeams.Items.Add(new TeamItem("New England Patriots", 22));
            cmbNFLTeams.Items.Add(new TeamItem("New Orleans Saints", 23));
            cmbNFLTeams.Items.Add(new TeamItem("New York Giants", 24));
            cmbNFLTeams.Items.Add(new TeamItem("New York Jets", 25));
            cmbNFLTeams.Items.Add(new TeamItem("Philadelphia Eagles", 26));
            cmbNFLTeams.Items.Add(new TeamItem("Pittsburgh Steelers", 27));
            cmbNFLTeams.Items.Add(new TeamItem("San Francisco 49ers", 28));
            cmbNFLTeams.Items.Add(new TeamItem("Seattle Seahawks", 29));
            cmbNFLTeams.Items.Add(new TeamItem("Tampa Bay Buccaneers", 30));
            cmbNFLTeams.Items.Add(new TeamItem("Tennessee Titans", 31));
            cmbNFLTeams.Items.Add(new TeamItem("Washington Commanders", 32));

            cmbNFLTeams.DisplayMember = "Name";
            cmbNFLTeams.ValueMember = "ID";
        }

        private void LoadNHLTeams()
        {
            cmbNHLTeams.Items.Clear();

            cmbNHLTeams.Items.Add(new TeamItem("Anaheim Ducks", 1));
            cmbNHLTeams.Items.Add(new TeamItem("Boston Bruins", 2));
            cmbNHLTeams.Items.Add(new TeamItem("Buffalo Sabres", 3));
            cmbNHLTeams.Items.Add(new TeamItem("Calgary Flames", 4));
            cmbNHLTeams.Items.Add(new TeamItem("Carolina Hurricanes", 5));
            cmbNHLTeams.Items.Add(new TeamItem("Chicago Blackhawks", 6));
            cmbNHLTeams.Items.Add(new TeamItem("Colorado Avalanche", 7));
            cmbNHLTeams.Items.Add(new TeamItem("Columbus Blue Jackets", 8));
            cmbNHLTeams.Items.Add(new TeamItem("Dallas Stars", 9));
            cmbNHLTeams.Items.Add(new TeamItem("Detroit Red Wings", 10));
            cmbNHLTeams.Items.Add(new TeamItem("Edmonton Oilers", 11));
            cmbNHLTeams.Items.Add(new TeamItem("Florida Panthers", 12));
            cmbNHLTeams.Items.Add(new TeamItem("Los Angeles Kings", 13));
            cmbNHLTeams.Items.Add(new TeamItem("Minnesota Wild", 14));
            cmbNHLTeams.Items.Add(new TeamItem("Montreal Canadiens", 15));
            cmbNHLTeams.Items.Add(new TeamItem("Nashville Predators", 16));
            cmbNHLTeams.Items.Add(new TeamItem("New Jersey Devils", 17));
            cmbNHLTeams.Items.Add(new TeamItem("New York Islanders", 18));
            cmbNHLTeams.Items.Add(new TeamItem("New York Rangers", 19));
            cmbNHLTeams.Items.Add(new TeamItem("Ottawa Senators", 20));
            cmbNHLTeams.Items.Add(new TeamItem("Philadelphia Flyers", 21));
            cmbNHLTeams.Items.Add(new TeamItem("Pittsburgh Penguins", 22));
            cmbNHLTeams.Items.Add(new TeamItem("San Jose Sharks", 23));
            cmbNHLTeams.Items.Add(new TeamItem("Seattle Kraken", 24));
            cmbNHLTeams.Items.Add(new TeamItem("St. Louis Blues", 25));
            cmbNHLTeams.Items.Add(new TeamItem("Tampa Bay Lightning", 26));
            cmbNHLTeams.Items.Add(new TeamItem("Toronto Maple Leafs", 27));
            cmbNHLTeams.Items.Add(new TeamItem("Utah Mammoth", 28));
            cmbNHLTeams.Items.Add(new TeamItem("Vancouver Canucks", 29));
            cmbNHLTeams.Items.Add(new TeamItem("Vegas Golden Knights", 30));
            cmbNHLTeams.Items.Add(new TeamItem("Washington Capitals", 31));
            cmbNHLTeams.Items.Add(new TeamItem("Winnipeg Jets", 32));

            cmbNHLTeams.DisplayMember = "Name";
            cmbNHLTeams.ValueMember = "ID";
        }

        private void PreselectFavorites()
        {
            //This loops through NFL the teams and gets the one matching the user's saved favorite ID and same for NHl below
            for (int i = 0; i < cmbNFLTeams.Items.Count; i++)
            {
                TeamItem item = (TeamItem)cmbNFLTeams.Items[i];
                if (item.ID == _currentUser.FavNFLTeamID)
                {
                    cmbNFLTeams.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbNHLTeams.Items.Count; i++)
            {
                TeamItem item = (TeamItem)cmbNHLTeams.Items[i];
                if (item.ID == _currentUser.FavNHLTeamID)
                {
                    cmbNHLTeams.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_filePath);

            if (cmbNFLTeams.SelectedItem == null || cmbNHLTeams.SelectedItem == null)
            {
                MessageBox.Show("Please select an option for both teams.");
                return;
            }

            //Gets selected team objects from ComboBoxes
            TeamItem selectedNFL = (TeamItem)cmbNFLTeams.SelectedItem;
            TeamItem selectedNHL = (TeamItem)cmbNHLTeams.SelectedItem;

            //saves selected teams ID to the users object
            _currentUser.FavNFLTeamID = selectedNFL.ID;
            _currentUser.FavNHLTeamID = selectedNHL.ID;

            //Calls UpdateUser method to update CSV file instead of creating duplicate user
            bool ok = _methods.UpdateUser(_filePath, _currentUser);

            if (ok)
            {

                MessageBox.Show("Favorites updated successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Could not update the user. Make sure the user ID exists in the CSV file!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // ComboBox items
    public class TeamItem
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public TeamItem(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }

}
