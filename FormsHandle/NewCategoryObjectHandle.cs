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
        TextBox textBoxFirstAttribute;
        TextBox textBoxSecondAttribute;
        Button addButton;

        string username;
        int objectType;

        bool nameFilled;
        bool typeFilled;
        bool firstAttFilled;
        bool secondAttFilled;

        public void getNewCategoryObjectForm(NewCategoryObject newCategoryObject_, TextBox textBoxName_, ComboBox comboBoxType_,
            TextBox textBoxFirstAttribute_, TextBox textBoxSecondAttribute_, Button addButton_, string username_, int objectType_)
        {
            newCategoryObject = newCategoryObject_;
            textBoxName = textBoxName_;
            comboBoxType = comboBoxType_;
            textBoxFirstAttribute = textBoxFirstAttribute_;
            textBoxSecondAttribute = textBoxSecondAttribute_;
            addButton = addButton_;
            username = username_;
            objectType = objectType_;
            this.showCategoryTypes();
        }

        public void showCategoryTypes()
        {
            comboBoxType.Items.Clear();
            using(var db = new CodeFirstContext())
            {
                if(objectType == 1 || objectType == 2 || objectType == 3)
                {
                    foreach(var cave in db.Caves)
                    {
                        comboBoxType.Items.Add("Name: " + cave.Name + ", Area: " + cave.Area.ToString());
                    }
                }
                else if (objectType == 4 || objectType == 5 || objectType == 6)
                {
                    foreach (var forest in db.Forests)
                    {
                        comboBoxType.Items.Add("Name: " + forest.Name + ", Area: " + forest.Area.ToString());
                    }
                }
                else if (objectType == 7 || objectType == 8 || objectType == 9)
                {
                    foreach (var tower in db.Towers)
                    {
                        comboBoxType.Items.Add("Name: " + tower.Name + ", Height: " + tower.Height.ToString() + ", Age: " + tower.Age.ToString());
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
        }

        public void secondAttChanged()
        {
            secondAttFilled = false;
            if(textBoxSecondAttribute.Text != "")
            {
                secondAttFilled = true;
            }
        }


        public void addEnableCheck()
        {
            if(nameFilled && typeFilled)
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
            return true;
        }
        public void addNewObject()
        {
            /* objectType defines what character is being created
             * 1 - Dragon
             * 2 - Bat
             * 3 - Spider
             * 4 - Ent
             * 5 - Wolf
             * 6 - Giant 
             * 7 - Knight
             * 8 - Magus 
             * 9 - Witch
             * */
            if (this.checkIfFree())
            {
                
            }
        }

        public void addNewDragon()
        {

        }

        public void addNewBat()
        {

        }

        public void addNewSpider()
        {

        }

        public void addNewEnt()
        {

        }

        public void addNewWolf()
        {

        }

        public void addNewGiant()
        {

        }

        public void addNewKnight()
        {

        }

        public void addMagus()
        {

        }

        public void addNewWitch()
        {

        }
    }

}
