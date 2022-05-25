using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.Forms;

namespace ArtifactManager.FormsHandle
{
    public class ModifyCategoryHandle : Form
    {
        ModifyCategory modifyCategory;
        TextBox textBoxName;
        TextBox textBoxArea;
        TextBox textBoxHeight;
        Button returnButton;
        Button changeButton;
        Label label;

        string username;
        string toModify;

        string type = null;
        string name = null;
        string area = null;
        string age = null;
        string height = null;
        public void getModifyCategoryForm(ModifyCategory modifyCategory_, TextBox textBoxName_, TextBox textBoxArea_,
            TextBox textBoxheight_, Label label_, Button returnButton_, Button changeButton_, 
            string username_, string toModify_)
        {
            modifyCategory = modifyCategory_;
            textBoxName = textBoxName_;
            textBoxArea = textBoxArea_;
            textBoxHeight = textBoxheight_;
            label = label_;
            returnButton = returnButton_;
            changeButton = changeButton_;
            username = username_;
            toModify = toModify_;
            this.show();
        }

        public void show()
        {
            string[] parts = toModify.Split(',');
            type = parts[0];
            if (type == "Type: Tower")
            {
                name = parts[1];
                age = parts[2];
                height = parts[3];
                parts = type.Split(':');
                type = parts[1];
                parts = name.Split(':');
                name = parts[1];
                parts = age.Split(':');
                age = parts[1];
                parts = height.Split(':');
                height = parts[1];
                textBoxName.Text = name;
                textBoxArea.Text = age;
                textBoxHeight.Text = height;
                textBoxHeight.Visible = true;
                label.Visible = true;
                
            }
            else
            {
                name = parts[1];
                area = parts[2];
                parts = type.Split(':');
                type = parts[1];
                parts = name.Split(':');
                name = parts[1];
                parts = area.Split(':');
                area = parts[1];

                textBoxName.Text = name;
                textBoxArea.Text = area;
            }
        }

        public void nameChanged()
        {
            if (textBoxName.Text != name)
            {
                changeButton.Enabled = true;
            }
            else
            {
                changeButton.Enabled = false;
            }
        }


        public void areaChanged()
        {
            if(textBoxArea.Text != area)
            {
                changeButton.Enabled = true;
            }
            else
            {
                changeButton.Enabled = false;
            }
        }

        public void modify()
        {
            string table;
            if (type == "Cave")
            {
                table = "Caves";
            }
            else if (type == "Forest")
            {
                table = "Forests";
            }
            else
            {
                table = "Towers";
            }

            using (var db = new CodeFirstContext())
            {
                if (table == "Towers")
                {
                    db.Database.ExecuteSqlCommand("UPDATE " + table + " SET Name = '" + textBoxName.Text + "', Age = " + int.Parse(textBoxArea.Text) + 
                        ", Height = " + int.Parse(textBoxHeight.Text) + " WHERE Name = '"  + name + "';");
                }
                else
                {
                    db.Database.ExecuteSqlCommand("UPDATE " + table + " SET Name = '" + textBoxName.Text + "', Area = " + int.Parse(textBoxArea.Text)
                         + " WHERE Name = '" + name + "';");
                }
                db.SaveChanges();
            }
            MessageBox.Show("Category changed.");
            this.returnToHomePanel();
        }

        public void returnToHomePanel()
        {
            this.Hide();
            Home home = new Home(username);
            home.ShowDialog();
            this.Close();
        }
    }
}
