using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.FormsHandle;

namespace ArtifactManager
{
    public partial class Home : Form
    {
        HomeHandle homeHandle = new HomeHandle();
        public string username;
        public Home(string username_)
        {
            InitializeComponent();
            username = username_;
            homeHandle.getHomeForm(this, this.label1, this.label2, 
                this.textBoxOldPassword, this.textBoxNewPassword, this.confirmButton, this.username);
            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if (foundUser != null && foundUser.Role == "admin")
                {
                    this.Users.Visible = true;
                }
            }
        }

        private void showProfileDetails(object sender, EventArgs e)
        {
            this.listBoxUsers.Visible = false;
            this.usersInfo.Visible = false;
            homeHandle.showProfileDetails();
        }

        private void changePassword(object sender, EventArgs e)
        {
            this.listBoxUsers.Visible = false;
            this.usersInfo.Visible = false;
            homeHandle.changePassword();
        }

        private void textBoxOldPasswordCheck(object sender, EventArgs e)
        {
            homeHandle.textBoxOldPasswordCheck();
        }

        private void textBoxNewPasswordCheck(object sender, EventArgs e)
        {
            homeHandle.textBoxNewPasswordCheck();
        }

        private void confirmButtonClick(object sender, EventArgs e)
        {
            homeHandle.confirmButtonClick();
        }

        private void logOut(object sender, EventArgs e)
        {
            homeHandle.logOut();
        }


        private void addNewUser(object sender, EventArgs e)
        {
            homeHandle.addNewUser();
        }

        private void modifyUser(object sender, EventArgs e)
        {
            homeHandle.modifyUser();
        }

        private void seeAllUsers(object sender, EventArgs e)
        {
            this.Info.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.textBoxOldPassword.Visible = false;
            this.confirmButton.Visible = false;
            this.listBoxUsers.Visible = true;
            this.usersInfo.Visible = true;
            
            using(var db = new CodeFirstContext())
            {
                foreach (var user in db.Users)
                {
                    if (user.Name == username)
                    {
                        listBoxUsers.Items.Add(user.Name + (" (you)"));
                    }
                    else
                    {
                        listBoxUsers.Items.Add(user.Name);
                    }
                }
            }

        }
    }
}
