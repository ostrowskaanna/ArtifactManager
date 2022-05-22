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
                this.textBoxOldPassword, this.textBoxNewPassword, this.confirmButton, this.username, this.Info,
                this.listBox, this.text);
        }

        private void showProfileDetails(object sender, EventArgs e)
        {
            homeHandle.showProfileDetails();
        }

        private void changePassword(object sender, EventArgs e)
        {
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
            homeHandle.seeAllUsers();
        }

        private void seeAllCategories(object sender, EventArgs e)
        {
            homeHandle.seeAllCategories();
        }
    }
}
