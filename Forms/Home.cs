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
using ArtifactManager.DataModels;

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
                this.listBox, this.text, this.deleteButton, this.editButton, this.filterButton, this.filtersListBox);
            /*
            using(var db = new CodeFirstContext())
            {
                foreach (var d in db.Dragons)
                    db.Dragons.Remove(d);
                db.SaveChanges();
                foreach(var d in db.Bats)
                    db.Bats.Remove(d);
                db.SaveChanges();
                foreach(var d in db.Spiders)
                    db.Spiders.Remove(d);
                db.SaveChanges();
                foreach(var d in db.Ents)
                    db.Ents.Remove(d);
                db.SaveChanges();
                foreach(var d in db.Wolfs)
                    db.Wolfs.Remove(d);
                db.SaveChanges();
                foreach(var d in db.Giants)
                    db.Giants.Remove(d);
                db.SaveChanges();
                foreach(var d in db.Knights)
                    db.Knights.Remove(d);
                db.SaveChanges();
            }
            */
        }

        private void addObjects()
        {
            using(var db = new CodeFirstContext())
            {
                db.Dragons.Add(new Dragon()
                {
                    Cave = db.Caves.FirstOrDefault(c => c.Id == 1),
                    Name = "Fireball Dragon",
                    Power = 100,
                    Size = 100
                });
                db.Dragons.Add(new Dragon()
                {
                    Cave = db.Caves.FirstOrDefault(c => c.Id == 1),
                    Name = "Ice Dragon",
                    Power = 50,
                    Size = 150
                });
                db.SaveChanges();
                db.Bats.Add(new Bat()
                {
                    Cave = db.Caves.FirstOrDefault(c => c.Id == 1),
                    Name = "Invisible Bat",
                    Speed = 100,
                    Size = 5
                });
                db.SaveChanges();
                db.Spiders.Add(new Spider()
                {
                    Cave = db.Caves.FirstOrDefault(c => c.Id == 1),
                    Name = "Multi Spider",
                    Speed = 50,
                    Sight = 10
                });
                db.SaveChanges();
                db.Ents.Add(new Ent()
                {
                    Forest = db.Forests.FirstOrDefault(f => f.Id == 1),
                    Name = "Twin Ent",
                    Power = 200,
                    Courage = 70,
                });
                db.Ents.Add(new Ent()
                {
                    Forest = db.Forests.FirstOrDefault(f => f.Id == 2),
                    Name = "Classic Ent",
                    Power = 100,
                    Courage = 100,
                });
                db.SaveChanges();
                db.Wolfs.Add(new Wolf()
                {
                    Forest = db.Forests.FirstOrDefault(f => f.Id == 1),
                    Name = "Winter Wolf",
                    Power = 50,
                    Speed = 70,
                });
                db.Wolfs.Add(new Wolf()
                {
                    Forest = db.Forests.FirstOrDefault(f => f.Id == 2),
                    Name = "WereWolf",
                    Power = 150,
                    Speed = 150,
                });
                db.SaveChanges();
                db.Giants.Add(new Giant()
                {
                    Forest = db.Forests.FirstOrDefault(f => f.Id == 2),
                    Name = "Green Giant",
                    Height = 50,
                    Sight = 3
                });
                db.SaveChanges();
                db.Knights.Add(new Knight()
                {
                    Tower = db.Towers.FirstOrDefault(t => t.Id == 1),
                    Name = "Half-Dead Knight",
                    Power = 100,
                    Courage = 40
                });
                db.SaveChanges();
                db.Magus.Add(new Magus()
                {
                    Tower = db.Towers.FirstOrDefault(t => t.Id == 1),
                    Name = "Dark-Magic Magus",
                    Power = 200,
                    Smart = 100
                });
                db.SaveChanges();
                db.Witches.Add(new Witch()
                {
                    Tower = db.Towers.FirstOrDefault(t => t.Id == 1),
                    Name = "Bad Witch",
                    Power = 100,
                    Smart = 50
                });
                db.Witches.Add(new Witch()
                {
                    Tower = db.Towers.FirstOrDefault(t => t.Id == 3),
                    Name = "Good Witch",
                    Power = 50,
                    Smart = 100
                });
                db.SaveChanges();
            }
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
            homeHandle.addNewCategoryObject("Dragon");
        }

        private void addNewBat(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Bat");
        }

        private void addNewSpider(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Spider");
        }

        private void addNewEnt(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Ent");
        }

        private void addNewWolf(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Wolf");
        }

        private void addNewGiant(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Giant");
        }

        private void addNewKnight(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Knight");
        }

        private void addNewMagus(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Magus");
        }

        private void addNewWitch(object sender, EventArgs e)
        {
            homeHandle.addNewCategoryObject("Witch");
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

        private void itemSelected(object sender, EventArgs e)
        {
            homeHandle.itemSelected();
        }


        private void filterClick(object sender, EventArgs e)
        {
            homeHandle.filterClick();
        }
    }
}
