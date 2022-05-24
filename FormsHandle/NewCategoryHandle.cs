using ArtifactManager.Forms;
using ArtifactManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class NewCategoryHandle : Form
    {
        NewCategory newCategory;
        TextBox textBoxName;
        TextBox textBoxAreaAge;
        TextBox textBoxHeight;
        Button addButton;

        int categoryType;
        string username;

        bool nameFilled;
        bool areaAgeFilled;
        bool heightFilled;
        public void getNewCategoryForm(NewCategory newCategory_, int categoryType_, TextBox textBoxName_,
            TextBox textBoxAreaAge_, TextBox textBoxHeight_, Button addButton_, string username_)
        {
            newCategory = newCategory_;
            categoryType = categoryType_;
            textBoxName = textBoxName_;
            textBoxAreaAge = textBoxAreaAge_;
            textBoxHeight = textBoxHeight_;
            addButton = addButton_;
            username = username_;
        }

        public void nameChanged()
        {
            nameFilled = false;
            if(textBoxName.Text != "")
            {
                nameFilled = true;
            }
            this.addEnableCheck();
        }

        public void areaAgeChanged()
        {            
            areaAgeFilled = false;
            if(textBoxAreaAge.Text != "")
            {
                areaAgeFilled = true;
            }
        }

        public void heightChanged()
        {            
            heightFilled = false;
            if(textBoxHeight.Text != "")
            {
                heightFilled = true;
            }
        }

        public void addEnableCheck()
        {
            if (nameFilled)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        public void addNewCategory()
        {
            if (this.checkIfFree())
            {
                if (categoryType == 1) addNewCave();
                else if (categoryType == 2) addNewForest();
                else addNewTower();
                MessageBox.Show("Category added.");
                this.returnToHomePanel();
            }
        }

        public bool checkIfFree()
        {
            MessageBox.Show("checkIfFree()");
            using (var db = new CodeFirstContext())
            {
                if (categoryType == 1)
                {
                    foreach (var cave in db.Caves)
                    {
                        if (cave.Name == textBoxName.Text)
                            MessageBox.Show("Cave with this name already exists.");
                            return false;
                    }
                }
                else if (categoryType == 2)
                {
                    foreach (var forest in db.Forests)
                    {
                        if (forest.Name == textBoxName.Text)
                            MessageBox.Show("Forest with this name already exists.");
                            return false;
                    }
                }
                else
                {
                    foreach(var tower in db.Towers)
                    {
                        if(tower.Name == textBoxName.Text)
                            MessageBox.Show("Tower with this name already exists.");
                            return false;
                    }
                }
            }
            return true;
        }

        public void addNewCave()
        { 
            int area = 0;
            if (areaAgeFilled) area = int.Parse(textBoxAreaAge.Text);

            using(var db = new CodeFirstContext())
            {
                db.Caves.Add(new Cave()
                {
                    Category = db.Categories.FirstOrDefault(c => c.Id == 1),
                    User = db.Users.FirstOrDefault(c => c.Name == this.username),
                    Name = textBoxName.Text,
                    Area = area
                });
                db.SaveChanges();
            }
        }

        public void addNewForest()
        {
            int area = 0;
            if(areaAgeFilled) area = int.Parse(textBoxAreaAge.Text);
            using (var db = new CodeFirstContext())
            {
                db.Forests.Add(new Forest()
                {
                    Category = db.Categories.FirstOrDefault(c => c.Id == 2),
                    User = db.Users.FirstOrDefault(c => c.Name == this.username),
                    Name = textBoxName.Text,
                    Area = area
                });
                db.SaveChanges();
            }
        }

        public void addNewTower()
        {
            int height = 0;
            if(heightFilled) height = int.Parse(textBoxHeight.Text);
            int age = 0;
            if(areaAgeFilled) age = int.Parse(textBoxAreaAge.Text); 

            using (var db = new CodeFirstContext())
            {
                db.Towers.Add(new Tower()
                {
                    Category = db.Categories.FirstOrDefault(c => c.Id == 3),
                    User = db.Users.FirstOrDefault(c => c.Name == this.username),
                    Name = textBoxName.Text,
                    Height = height,
                    Age = age
                });
                db.SaveChanges();
            }
        }

        public void returnToHomePanel()
        {
            newCategory.Hide();
            Home home = new Home(this.username);
            home.ShowDialog();
            newCategory.Close();
        }
    }
}
