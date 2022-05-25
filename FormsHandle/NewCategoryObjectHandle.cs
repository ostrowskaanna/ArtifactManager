using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.Forms;
using ArtifactManager.DataModels;

namespace ArtifactManager.FormsHandle
{
    
    public class NewCategoryObjectHandle : Form
    {
        NewCategoryObject newCategoryObject;
        TextBox textBoxName;
        ComboBox comboBoxType;
        TextBox type;
        TextBox catType;
        TextBox textBoxFirstAttribute;
        TextBox textBoxSecondAttribute;
        Button addButton;

        string username;
        string objectType;
        Dictionary<string, string> objAtt;
        List<string> categories;
        List<int> categoryIds;

        bool nameFilled;
        bool typeFilled;
        bool firstAttFilled;
        bool secondAttFilled;

        public void getNewCategoryObjectForm(NewCategoryObject newCategoryObject_, TextBox textBoxName_, ComboBox comboBoxType_,
            TextBox textBoxFirstAttribute_, TextBox textBoxSecondAttribute_, Button addButton_, string username_, string objectType_, 
            Dictionary<string, string> objAtt_, List<string> categories_, List<int> categoryIds_)
        {
            newCategoryObject = newCategoryObject_;
            textBoxName = textBoxName_;
            comboBoxType = comboBoxType_;
            textBoxFirstAttribute = textBoxFirstAttribute_;
            textBoxSecondAttribute = textBoxSecondAttribute_;
            addButton = addButton_;
            username = username_;
            objectType = objectType_;
            objAtt = objAtt_;
            categories = categories_;
            categoryIds = categoryIds_;
            this.showCategoryTypes();
        }

        public void showCategoryTypes()
        {
            comboBoxType.Items.Clear();
            //foreach(string cat in categories)
            //{
            //    comboBoxType.Items.Add(cat);    
            //}

            using (var db = new CodeFirstContext())
            {
                string record;
                if (objectType == "Dragon" || objectType == "Bat" || objectType == "Spider")
                {
                    foreach (var cave in db.Caves)
                    {
                        record = "Type: Cave, Name: " + cave.Name + ", Area: " + cave.Area;
                        comboBoxType.Items.Add(record);
                    }
                }
                else if (objectType == "Ent" || objectType == "Wolf" || objectType == "Giant") {
                    foreach (var forest in db.Forests)
                    {
                        record = "Type: Forest, Name: " + forest.Name + ", Area: " + forest.Area;
                        comboBoxType.Items.Add(record);
                    }
                }
                else {
                    foreach (var tower in db.Towers)
                    {
                        record = "Type: Tower, Name: " + tower.Name + ", Height: " + tower.Height + ", Age: " + tower.Age;
                        comboBoxType.Items.Add(record);
                    }
                }
            }
        }

        public void returnToHomePanel()
        {
            newCategoryObject.Hide();
            Home home = new Home(this.username);
            home.ShowDialog();
            newCategoryObject.Close();
        }

        public void nameChanged()
        {
            nameFilled = false;
            if (textBoxName.Text != "")
            {
                nameFilled = true;
            }
            this.addEnableCheck();
        }

        public void typeChanged()
        {
            typeFilled = false;
            if(comboBoxType.SelectedItem != null)
            {
                typeFilled = true;
            }
            this.addEnableCheck();
        }

        public void firstAttChanged()
        {
            firstAttFilled = false;
            if(textBoxFirstAttribute.Text != "")
            {
                firstAttFilled = true;
            }
            this.addEnableCheck();
        }

        public void secondAttChanged()
        {
            secondAttFilled = false;
            if(textBoxSecondAttribute.Text != "")
            {
                secondAttFilled = true;
            }
            this.addEnableCheck();
        }


        public void addEnableCheck()
        {
            if(nameFilled && typeFilled && firstAttFilled && secondAttFilled)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        public bool checkIfFree()
        {
            using (var db = new CodeFirstContext())
            {
                List<string> taken = db.Database.SqlQuery<string>("SELECT Name FROM " + objectType + "s").ToList();
                foreach (string takenItem in taken)
                {
                    if (takenItem == textBoxName.Text)
                        MessageBox.Show(objectType + " with this name already exists.");
                        return false;
                }
            }
            return true;
        }
        public void addNewObject()
        {
            if (objectType == "Dragon") addNewDragon();
            else if (objectType == "Bat") addNewBat();
            else if (objectType == "Spider") addNewSpider();
            else if (objectType == "Ent") addNewEnt();
            else if (objectType == "Wolf") addNewWolf();
            else if (objectType == "Giant") addNewGiant();
            else if (objectType == "Knight") addNewKnight();
            else if (objectType == "Magus") addNewMagus();
            else addNewWitch();
            MessageBox.Show("Object added.");
            this.returnToHomePanel();
        }

        public string getCatName()
        {
            string category = comboBoxType.SelectedItem.ToString();
            string[] parts = category.Split(',');
            category = parts[1];
            parts = category.Split(':');
            category = parts[1];
            return category;
        }
        public void addNewDragon()
        {
            string catName = this.getCatName();
            
            using (var db = new CodeFirstContext())
            {
                db.Dragons.Add(new Dragon()
                {
                    Cave = db.Caves.FirstOrDefault(c => " " + c.Name  == catName),
                    Name = textBoxName.Text,
                    Power = int.Parse(textBoxFirstAttribute.Text),
                    Size = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }  
        }

        public void addNewBat()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Bats.Add(new Bat()
                {
                    Cave = db.Caves.FirstOrDefault(c => " " + c.Name == catName),
                    Name = textBoxName.Text,
                    Speed = int.Parse(textBoxFirstAttribute.Text),
                    Size = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }

        public void addNewSpider()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Spiders.Add(new Spider()
                {
                    Cave = db.Caves.FirstOrDefault(c => " " + c.Name == catName),
                    Name = textBoxName.Text,
                    Speed = int.Parse(textBoxFirstAttribute.Text),
                    Sight = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }

        public void addNewEnt()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Ents.Add(new Ent()
                {
                    Forest = db.Forests.FirstOrDefault(c => " " + c.Name==catName),
                    Name = textBoxName.Text,
                    Power = int.Parse(textBoxFirstAttribute.Text),
                    Courage = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }

        public void addNewWolf()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Wolfs.Add(new Wolf()
                {
                    Forest = db.Forests.FirstOrDefault(c => " " + c.Name == catName),
                    Name = textBoxName.Text,
                    Power = int.Parse(textBoxFirstAttribute.Text),
                    Speed = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }

        public void addNewGiant()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Giants.Add(new Giant()
                {
                    Forest = db.Forests.FirstOrDefault(c => " " + c.Name == catName),
                    Name = textBoxName.Text,
                    Height = int.Parse(textBoxFirstAttribute.Text),
                    Sight = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }

        public void addNewKnight()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Knights.Add(new Knight()
                {
                    Tower = db.Towers.FirstOrDefault(c => " " + c.Name == catName),
                    Name = textBoxName.Text,
                    Power = int.Parse(textBoxFirstAttribute.Text),
                    Courage = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }

        public void addNewMagus()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Magus.Add(new Magus()
                {
                    Tower = db.Towers.FirstOrDefault(c => " " + c.Name == catName),
                    Name = textBoxName.Text,
                    Power = int.Parse(textBoxFirstAttribute.Text),
                    Smart = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }

        public void addNewWitch()
        {
            string catName = this.getCatName();

            using (var db = new CodeFirstContext())
            {
                db.Witches.Add(new Witch()
                {
                    Tower = db.Towers.FirstOrDefault(c => " " + c.Name == catName),
                    Name = textBoxName.Text,
                    Power = int.Parse(textBoxFirstAttribute.Text),
                    Smart = int.Parse(textBoxSecondAttribute.Text)
                });
                db.SaveChanges();
            }
        }
    }

}
