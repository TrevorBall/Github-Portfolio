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
    public partial class NFLStats : Form
    {
        public NFLStats(int TeamID, Image logo)//teamid is here so anytime form is opened we can identify what team it is with this
        {
            InitializeComponent();
            pBoxLogo.Image = logo;

        }

        private void NFLStats_Load(object sender, EventArgs e)
        {
            
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
