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
    public partial class NFLTeams : Form
    {
        public NFLTeams()
        {
            InitializeComponent();
        }


        private void teamButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn.Tag == null) return;
            int teamID = Convert.ToInt32(btn.Tag);

            NFLStats statForm = new NFLStats(teamID, btn.BackgroundImage); //teamid is passed to the statForm
            statForm.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
