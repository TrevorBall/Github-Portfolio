using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Class_Library
{
    public class Team
    {
        public string TeamName { get; set; }
        public string Conference { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public int OTLosses { get; set; }
        public int Points { get; set; }

        public Team() { }

        public Team(string teamName, string conference, int wins, int losses, int ties, int otlosses, int points)
        {
            TeamName = teamName;
            Conference = conference;
            Wins = wins;
            Losses = losses;
            Ties = ties;
            OTLosses = otlosses;
            Points = points;
        }
    }

}

