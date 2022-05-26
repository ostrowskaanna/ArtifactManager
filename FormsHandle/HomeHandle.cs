using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.Forms;

namespace ArtifactManager.FormsHandle
{
    public class HomeHandle : Form
    {
        Home home;
        Label label1;
        Label label2;
        TextBox textBoxOldPassword;
        TextBox textBoxNewPassword;
        Button confirmButton;
        Label Info;
        ListBox listBox;
        Label text;
        Button deleteButton;
        Button editButton;
        Button filterButton;
        CheckedListBox filters;

        string username;

        bool oldPasswordFiled = false;
        bool newPasswordFilled = false;

        int whatIsShown;
        /* defines what is shown in listBox:
         * 1 - categories
         * 2 - objects
         * 3 - users
         * */

        Dictionary<string, string> objAtt = new Dictionary<string, string>();
        List<string> categories = new List<string>();
        List<int> categoryIds = new List<int>();
        public HomeHandle()
        {
            objAtt.Add("Dragon", "Cave,Power,Size");
            objAtt.Add("Bat", "Cave,Speed,Size");
            objAtt.Add("Spider", "Cave,Speed,Sight");
            objAtt.Add("Ent", "Forest,Power,Courage");
            objAtt.Add("Wolf", "Forest,Power,Speed");
            objAtt.Add("Giant", "Forest,Height,Sight");
            objAtt.Add("Knight", "Tower,Power,Courage");
            objAtt.Add("Magus", "Tower,Power,Smart");
            objAtt.Add("Witch", "Tower,Power,Smart");
        }
        
        public void getHomeForm(Home home_, Label label1_, Label label2_,
            TextBox textBoxOldPassword_, TextBox textBoxNewPasword_, Button confirmButton_, string username_,
            Label Info_, ListBox listBox_, Label text_, Button deleteButton_, Button editButton_, Button filterButton_, 
            CheckedListBox filters_)
        {
            home = home_;
            label1 = label1_;
            label2 = label2_;
            textBoxOldPassword = textBoxOldPassword_;
            textBoxNewPassword = textBoxNewPasword_;
            confirmButton = confirmButton_;
            username = username_;
            textBoxOldPassword.PasswordChar = '*';
            textBoxNewPassword.PasswordChar = '*';
            Info = Info_;
            listBox = listBox_;
            text = text_;
            deleteButton = deleteButton_;
            editButton = editButton_;
            filterButton = filterButton_;
            filters = filters_;
            this.getCategories();
        }


        public void getCategories()
        {
            categories.Clear();
            using (var db = new CodeFirstContext())
            {
                string record;
                foreach (var cave in db.Caves)
                {
                    record = "Type:Cave, Name:" + cave.Name + ", Area:" + cave.Area;
                    categories.Add(record);
                    categoryIds.Add(cave.Id);
                }
                foreach (var forest in db.Forests)
                {
                    record = "Type:Forest, Name:" + forest.Name + ", Area:" + forest.Area;
                    categories.Add(record);
                    categoryIds.Add(forest.Id);
                }
                foreach (var tower in db.Towers)
                {
                    record = "Type:Tower, Name:" + tower.Name + ", Height:" + tower.Height + ", Age:" + tower.Age;
                    categories.Add(record);
                    categoryIds.Add(tower.Id);
                }
            }

        }


        public void showProfileDetails()
        {
            this.listBox.Visible = false;
            this.text.Visible = false;
            this.Info.Visible = true;
            this.textBoxOldPassword.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.deleteButton.Visible = false;
            this.editButton.Visible = false;
            this.filterButton.Visible = false;
            this.filters.Visible = false;

            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if (foundUser != null)
                {
                    this.label2.Text = "Email: " + foundUser.Email;
                }
            }
            this.label1.Text = "Username: " + username;
            this.label1.Visible = true;
            this.label2.Visible = true;
        }

        public void changePassword()
        {
            this.listBox.Visible = false;
            this.text.Visible = false;
            this.Info.Visible = true;
            this.label1.Text = "Enter old password:";
            this.label2.Text = "Enter new password";
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.textBoxOldPassword.Visible = true;
            this.textBoxNewPassword.Visible = true;
            this.confirmButton.Visible = true;
            this.deleteButton.Visible = false;
            this.editButton.Visible = false;
            this.filterButton.Visible = false;
            this.filters.Visible = false;
        }

        public void textBoxOldPasswordCheck()
        {
            if (textBoxOldPassword.Text != "")
            {
                oldPasswordFiled = true;
                if (newPasswordFilled == true)
                {
                    confirmButton.Enabled = true;
                }
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }

        public void textBoxNewPasswordCheck()
        {
            if (textBoxNewPassword.Text != "")
            {
                newPasswordFilled = true;
                if (oldPasswordFiled == true)
                {
                    confirmButton.Enabled = true;
                }
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }

        public void confirmButtonClick()
        {
            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if (foundUser.Password == textBoxOldPassword.Text)
                {
                    foundUser.Password = textBoxNewPassword.Text;
                    MessageBox.Show("Password changed.");
                    textBoxNewPassword.Text = "";
                    textBoxOldPassword.Text = "";
                    confirmButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You entered wrong old password. Please try again.");
                }
                db.SaveChanges();
            }
        }

        public void logOut()
        {
            home.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            home.Close();
        }

        public void modifyUser()
        {
            home.Hide();
            EditUser editUserForm = new EditUser(this.username);
            editUserForm.ShowDialog();
            home.Close();
        }

        public void addNewUser()
        {
            home.Hide();
            NewUserForm newUserForm = new NewUserForm(this.username);
            newUserForm.ShowDialog();
            home.Close();
        }

        public void seeAllUsers()
        {
            this.Info.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.textBoxOldPassword.Visible = false;
            this.confirmButton.Visible = false;
            this.listBox.Visible = true;
            this.text.Visible = true;
            this.text.Text = "Here are all the users:";
            this.deleteButton.Visible = true;
            this.editButton.Visible = true;
            this.deleteButton.Enabled = false;
            this.editButton.Enabled = false;
            this.filters.Visible = false;

            whatIsShown = 3;

            listBox.Items.Clear();

            using (var db = new CodeFirstContext())
            {
                foreach (var user in db.Users)
                {
                    if (user.Name == username)
                    {
                        listBox.Items.Add(user.Name + (" (you)"));
                    }
                    else
                    {
                        listBox.Items.Add(user.Name);
                    }
                }
            }
        }
        public void seeAllCategories()
        {
            this.Info.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.textBoxOldPassword.Visible = false;
            this.confirmButton.Visible = false;
            this.listBox.Visible = true;
            this.text.Visible = true;
            this.text.Text = "Here are all the categories:";
            this.deleteButton.Visible = true;
            this.editButton.Visible = true;
            this.filterButton.Visible = true;
            this.deleteButton.Enabled = false;
            this.editButton.Enabled = false;
            this.filters.Visible = true;
            whatIsShown = 1;

            this.setFilters();

            listBox.Items.Clear();
            foreach (string cat in this.categories)
            {
                listBox.Items.Add(cat);
            }
        }


        public void seeAllObjects()
        {
            this.Info.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.textBoxOldPassword.Visible = false;
            this.confirmButton.Visible = false;
            this.listBox.Visible = true;
            this.text.Visible = true;
            this.text.Text = "Here are all the objects:";
            this.deleteButton.Visible = true;
            this.editButton.Visible = true;
            this.filterButton.Visible= true;
            this.deleteButton.Enabled = false;
            this.editButton.Enabled = false;
            this.filters.Visible = true;
            whatIsShown = 2;
            
            this.setFilters();
            listBox.Items.Clear();
            string[] objects = { "Dragon", "Bat", "Spider", "Ent", "Wolf", "Giant", "Knight", "Magus", "Witch" };
            foreach(string obj in objects)
            {
                this.showObjects(obj);
            }
        }

       
        public void setFilters()
        {
            filters.Items.Clear();
            if(whatIsShown == 1)
            {
                filters.Items.Add("Cave");
                filters.Items.Add("Forest");
                filters.Items.Add("Tower");
            }
            else if(whatIsShown == 2)
            {
                filters.Items.Add("Dragon");
                filters.Items.Add("Bat");
                filters.Items.Add("Spider");
                filters.Items.Add("Ent");
                filters.Items.Add("Wolf");
                filters.Items.Add("Giant");
                filters.Items.Add("Knight");
                filters.Items.Add("Magus");
                filters.Items.Add("Witch");
            }
            for (int i = 0; i < filters.Items.Count; i++)
            {
                filters.SetItemChecked(i, true);
            }

        }

        public void showCategories(string catName)
        {
            using (var db = new CodeFirstContext())
            {

                    if (catName == "Cave")
                    {
                        string[] names = db.Database.SqlQuery<string>("SELECT Name FROM Caves").ToArray();
                        int[] area = db.Database.SqlQuery<int>("SELECT Area FROM Caves").ToArray();
                        for (int i = 0; i < names.Length; i++)
                        {
                            string record = "Type:Cave, Name:" + names[i] + ", Area:" + area[i].ToString();
                            listBox.Items.Add(record);
                        }
                    }
                    else if (catName == "Forest")
                    {
                        string[] names = db.Database.SqlQuery<string>("SELECT Name FROM Forests").ToArray();
                        int[] area = db.Database.SqlQuery<int>("SELECT Area FROM Forests").ToArray();
                        for (int i = 0; i < names.Length; i++)
                        {
                            string record = "Type:Forest, Name:" + names[i] + ", Area:" + area[i].ToString();
                            listBox.Items.Add(record);
                        }
                    }
                    else if (catName == "Tower")
                    {
                        string[] names = db.Database.SqlQuery<string>("SELECT Name FROM Towers").ToArray();
                        int[] height = db.Database.SqlQuery<int>("SELECT Height FROM Towers").ToArray();
                        int[] age = db.Database.SqlQuery<int>("SELECT Age FROM Towers").ToArray();
                        
                        for (int i = 0; i < names.Length; i++)
                        {
                            string record = "Type:Tower, Name:" + names[i] +  ", Height:" + height[i]  + ", Age:" + age[i];
                            listBox.Items.Add(record);
                        }
                    }
                
            }
        }

        public void showObjects(string catName)
        {
            string baseName;
            if (catName == "Witch")  baseName = "Witches";
            else if (catName == "Wolf") baseName = "Wolves";
            else if (catName == "Magus") baseName = "Magus";
            else baseName = catName + "s";
            string att = objAtt[catName];
            string[] parts = att.Split(',');
            string type = parts[0];
            string firstAtt = parts[1];
            string secondAtt = parts[2];

            using(var db = new CodeFirstContext())
            {
                string[] names = db.Database.SqlQuery<string>("SELECT Name FROM " + baseName).ToArray();
                int[] firstAtts = db.Database.SqlQuery<int>("SELECT " + firstAtt + " FROM " + baseName).ToArray();
                int[] secondAtts = db.Database.SqlQuery<int>("SELECT " + secondAtt + " FROM " + baseName).ToArray();
                for(int i=0; i < names.Length; i++)
                {
                    string record = "Type:" + catName + ", Name:" + names[i] + ", " + firstAtt + ":" + firstAtts[i] +
                        ", " + secondAtt + ":" + secondAtts[i];
                    listBox.Items.Add(record);
                }
            }
        }

        public void filterClick()
        {
            listBox.Items.Clear();
            if (whatIsShown == 1)
            {
                foreach (var item in filters.CheckedItems)
                {
                    this.showCategories(item.ToString());
                }
            }
            else
            {
                foreach (var item in filters.CheckedItems)
                {
                    this.showObjects(item.ToString());
                }
            }
        }

        public void itemSelected()
        {
            if(listBox.SelectedIndex >= 0)
                deleteButton.Enabled = true;
                editButton.Enabled = true;
        }

        public void deleteSelectedItem()
        {
            if (whatIsShown == 1) this.deleteCategory();
            else if (whatIsShown == 2) this.deleteObject();
            else if(whatIsShown == 3) this.deleteUser();
        }

        public void deleteCategory()
        {
            var catToDelete = listBox.SelectedItem;
            string [] parts = catToDelete.ToString().Split(',');
            string type = parts[0];
            string name = parts[1];
            parts = type.Split(':');
            type = parts[1];
            parts = name.Split(':');
            name = parts[1];

            using(var db = new CodeFirstContext())
            {
                if(type == "Cave")
                {
                    db.Caves.Remove(db.Caves.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Forest")
                {
                    db.Forests.Remove(db.Forests.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Tower")
                {
                    db.Towers.Remove(db.Towers.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                db.SaveChanges();
            }
            MessageBox.Show("Category deleted.");
            this.getCategories();
            this.seeAllCategories();
        }

        public void deleteObject()
        {
            var objToDelete = listBox.SelectedItem;
            string [] parts = objToDelete.ToString().Split(',');
            string type = parts[0];
            string name = parts[1];
            parts = type.Split(':');
            type = parts[1];
            parts = name.Split(':');
            name = parts[1];
            using(var db = new CodeFirstContext())
            {
                if (type == "Dragon")
                {
                    db.Dragons.Remove(db.Dragons.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Bat")
                {
                    db.Bats.Remove(db.Bats.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Spider")
                {
                    db.Spiders.Remove(db.Spiders.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Ent")
                {
                    db.Ents.Remove(db.Ents.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Wolf")
                {
                    db.Wolfs.Remove(db.Wolfs.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Giant")
                {
                    db.Giants.Remove(db.Giants.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Knight")
                {
                    db.Knights.Remove(db.Knights.Where(c => c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Magus")
                {
                    db.Magus.Remove(db.Magus.Where(c =>  c.Name == name.ToString()).FirstOrDefault());
                }
                else if (type == "Witch")
                {
                    db.Witches.Remove(db.Witches.Where(c =>  c.Name == name.ToString()).FirstOrDefault());
                }
                db.SaveChanges();
            }
            MessageBox.Show("Object deleted.");
            this.seeAllObjects();
        }

        public void deleteUser()
        {
            var userToDelete = listBox.SelectedItem;
            using (var db = new CodeFirstContext())
            {
                db.Users.Remove(db.Users.Where(u => u.Name == userToDelete.ToString()).FirstOrDefault());
                db.SaveChanges();
            }
            MessageBox.Show("User deleted.");
            this.seeAllUsers();
        }

        public void editSelectedItem()
        {
            if(whatIsShown == 1) this.editCategory();
            else if (whatIsShown == 2) this.editObject();
            else if(whatIsShown == 3) this.editUser();
        }

        public void editCategory()
        {
            string toModify = listBox.SelectedItem.ToString();
            this.home.Hide();
            ModifyCategory modifyCategory = new ModifyCategory(this.username, toModify);
            modifyCategory.ShowDialog();
            this.home.Close();
            
        }

        public void editObject()
        {
            string toModify = listBox.SelectedItem.ToString();
            this.home.Hide();
            ModifyObject modifyObject = new ModifyObject(this.username, toModify);
            modifyObject.ShowDialog();
            this.home.Close();
        }

        public void editUser()
        {
            User userToModify;
            string user = listBox.SelectedItem.ToString();
            using (var db = new CodeFirstContext())
            {
                userToModify = db.Users.FirstOrDefault(u => u.Name == user);
            }

            this.Hide();
            ModifyUser modifyUserForm = new ModifyUser(userToModify, this.username);
            modifyUserForm.ShowDialog();
            this.Close();
        }

        public void openNewCategoryForm(int categoryType)
        {
            home.Hide();
            NewCategory newCategory = new NewCategory(this.username, categoryType);
            newCategory.ShowDialog();
            home.Close();
            
        }

        public void addNewCave()
        {
            this.openNewCategoryForm(1);
        }

        public void addNewForest()
        {
            this.openNewCategoryForm(2);
        }

        public void addNewTower()
        {
            this.openNewCategoryForm(3);
        }

        public void addNewCategoryObject(string objectType)
        {
            home.Hide();
            NewCategoryObject newObject = new NewCategoryObject(this.username, objectType,this.objAtt, this.categories, this.categoryIds);
            newObject.ShowDialog();
            home.Close();
        }
    }
}
