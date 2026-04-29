using System;
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
    public partial class MainForm : Form
    {

        private Form loginForm;
        private User _currentUser;

        public MainForm(User person, Login login)
        {
            InitializeComponent();

            //Stores logged in user so it can be passed to other forms
            _currentUser = person;
            lblName.Text = "Welcome Back " + person.FirstName;
            this.loginForm = login;

        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out ... returning to Login screen");
            this.Close();
            loginForm.Show();
        }

        private void butNFL_Click(object sender, EventArgs e)
        {
            NFLTeams NFLteams = new NFLTeams();
            NFLteams.Show();
        }

        private void butNHL_Click(object sender, EventArgs e)
        {
            Form1 NHLteams = new Form1();
            NHLteams.Show();
        }

        private void butFavTeams_Click(object sender, EventArgs e)
        {
            //Opens UserFavoriteTeam form and passes the current user object
            UserFavoriteTeam fav = new UserFavoriteTeam(_currentUser);
            fav.ShowDialog();
        }
    }
}
