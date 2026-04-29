using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO; //added micorosoft visual basic reference for textfield parser

namespace SportStatLibrary
{
    public class Methods
    {
        public List<User> FetchUserData(string filePath)
        {
            List<User> users = new List<User>();
            string[] columns = new string[6];

            //this parses through csv file and puts each catagory in columns array then assigns those values to a user object then adds to users list
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;  

                //get rid of headings
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    columns = parser.ReadFields();

                    if (columns.Length < 6) { continue; }

                    int iD = 0;
                    int favNHLID = 0;
                    int favNFLID = 0;


                    int.TryParse(columns[0].Trim(), out iD);
                    int.TryParse(columns[4].Trim(), out favNFLID);
                    int.TryParse(columns[5].Trim(), out favNHLID);



                    User user = new User(iD, columns[1], columns[2], columns[3], favNFLID, favNHLID);
                    users.Add(user);

                }
                return users;
            }
        }

        public void AddUser(string filePath, User newUser) //converts user object to string and adds to debug csv file
        {
            string row = $"{newUser.ID},{newUser.Username},{newUser.Password},{newUser.FirstName},{newUser.FavNFLTeamID},{newUser.FavNHLTeamID}";
            
            File.AppendAllText(filePath, Environment.NewLine + row);
        }

        public bool UpdateUser(string filePath, User updatedUser)
        {
            if (!File.Exists(filePath)) return false; 
            
            var lines = File.ReadAllLines(filePath).ToList(); 
            if (lines.Count == 0) return false; 
            
            bool updated = false; 
            
            for (int i = 1; i < lines.Count; i++) // start at 1 to skip header
            { 
                if (string.IsNullOrWhiteSpace(lines[i])) continue; 
                
                string[] cols = lines[i].Split(','); 
                if (cols.Length < 6) continue; 
                
                if (int.TryParse(cols[0].Trim(), out int id) && id == updatedUser.ID) 
                { 
                    lines[i] = $"{updatedUser.ID},{updatedUser.Username},{updatedUser.Password},{updatedUser.FirstName},{updatedUser.FavNFLTeamID},{updatedUser.FavNHLTeamID}"; 
                    updated = true; 
                    break;
                } 
            } 
            
            if (!updated) return false; 
            
            File.WriteAllLines(filePath, lines); 
            return true;
        }

    }
}