using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStatLibrary
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public int FavNHLTeamID { get; set; }
        public int FavNFLTeamID { get; set; }

        public User(int iD, string username, string password, string firstName)
        {
            ID = iD;
            Username = username;
            Password = password;
            FirstName = firstName;
            FavNFLTeamID = -1;
            FavNHLTeamID = -1;

        }

        public User(int iD, string username, string password, string firstName, int favNFLTeamID, int favNHLTeamID)
        {
            ID = iD;
            Username = username;
            Password = password;
            FirstName = firstName;
            FavNFLTeamID = favNFLTeamID;
            FavNHLTeamID = favNHLTeamID;

        }


        public User() { }
    }

}

