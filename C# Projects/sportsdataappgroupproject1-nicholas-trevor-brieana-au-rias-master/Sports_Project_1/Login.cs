using SportStatLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace Sports_Project_1
{
    public partial class Login : Form
    {
        public static string filePath = Path.Combine(Application.StartupPath, "UserLogins.csv");

        public List<User> savedUsers = new List<User>();

        public Methods m = new Methods();

        public bool namePop = false;

        public Login()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("***** THANK YOU *****");
            this.Close();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            savedUsers = m.FetchUserData(filePath);//method from class library to fill users into a list with data from csv file of saved logins
            string inputUser = txtBoxUser.Text.Trim();
            string inputPass = txtBoxPass.Text.Trim();

            //check if user and pass are same as any in savedUserslist and if they are assign that user
            User foundUser = savedUsers.FirstOrDefault(u => u.Username.Equals(inputUser, StringComparison.OrdinalIgnoreCase) && u.Password == inputPass);

            if (foundUser != null)
            {
                MainForm menu = new MainForm(foundUser, this);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD !! TRY AGAIN");
            }

        }

        private void butCreateAcc_Click(object sender, EventArgs e)
        {
            if (!namePop)
            {
                lblFirstName.Visible = true;
                txtBoxFirstName.Visible = true;
                namePop = true;
                MessageBox.Show("ENTER FIRST NAME TO CREATE ACCOUNT");
            }
            else
            {
                savedUsers = m.FetchUserData(filePath);//method from class library to fill users into a list with data from csv file of saved logins
                string user = txtBoxUser.Text.Trim();
                string pass = txtBoxPass.Text.Trim();
                string firstName = txtBoxFirstName.Text.Trim();

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(firstName))
                {
                    MessageBox.Show("FILL ALL FIELDS !!");
                    return;
                }

                bool userExists = savedUsers.Any(u => u.Username.Equals(user, StringComparison.OrdinalIgnoreCase)); //checks if username is taken

                if (userExists)
                {
                    MessageBox.Show("USERNAME IS TAKEN !!");
                    return;
                }


                int newUserID;

                if (savedUsers.Count > 0)
                {
                    newUserID = savedUsers.Max(u => u.ID) + 1;
                }
                else
                {
                    newUserID = 1;
                }
                User newUser = new User(newUserID, user, pass, firstName);

                m.AddUser(filePath, newUser); //writes to UserLogins csv file in debug folder, original UserLogins file in project does not change.

                MessageBox.Show("ACCOUNT CREATED !!");
                lblFirstName.Visible = false;
                txtBoxFirstName.Visible = false;
                namePop = false;

                MainForm menu = new MainForm(newUser, this);
                menu.Show();
                this.Hide();

            }
        }

        private void cBoxSeePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxSeePass.Checked)
            {
                txtBoxPass.PasswordChar = '\0';
            }

            if (!cBoxSeePass.Checked)
            {
                txtBoxPass.PasswordChar = '*';
            }
        }
    }
}
