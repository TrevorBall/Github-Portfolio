using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Project_1
{
    public partial class NFLTeamStats : Form
    {
        public int teamID;

        public NFLTeamStats(int TeamID, Image logo)//teamid is here so anytime form is opened we can identify what team it is with this
        {
            InitializeComponent();
            pBoxLogo.Image = logo;
            teamID = TeamID;

        }

        private void NFLStats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDBDataSet.__NFL_Players__' table. You can move, or remove it, as needed.
            this._NFL_Players__TableAdapter.FillByTeam(this.sportsDBDataSet.@__NFL_Players__, teamID);  //used teamID passed from button as parameter for filling the table of players

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _NFL_Players__BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._NFL_Players__BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportsDBDataSet);

        }
    }
}
