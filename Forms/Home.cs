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
                this.listBox, this.text, this.deleteButton, this.editButton);
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

        private void addNewCave(object sender, EventArgs e)
        {
            homeHandle.addNewCave();
        }

        private void addNewForest(object sender, EventArgs e)
        {
            homeHandle.addNewForest();
        }

        private void addNewTower(object sender, EventArgs e)
        {
            homeHandle.addNewTower();
        }

        private void addNewDragon(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(1);
        }

        private void addNewBat(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(2);
        }

        private void addNewSpider(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(3);
        }

        private void addNewEnt(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(4);
        }

        private void addNewWolf(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(5);
        }

        private void addNewGiant(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(6);
        }

        private void addNewKnight(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(7);
        }

        private void addNewMagus(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(8);
        }

        private void addNewWitch(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject(9);
        }

        private void seeAllObjects(object sender, EventArgs e)
        {
            homeHandle.seeAllObjects();
        }

        private void deleteSelectedItem(object sender, EventArgs e)
        {
            homeHandle.deleteSelectedItem();
        }

        private void editSelectedItem(object sender, EventArgs e)
        {
            homeHandle.editSelectedItem();
        }
    }
}
